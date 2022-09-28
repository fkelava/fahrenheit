// System imports
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

// External imports
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Fahrenheit.SGen.DEdit;

public enum FhEncodingLocale
{
    In,
    Us,
    Jp,
    NewCh,
    NewDe,
    NewFr,
    NewIt,
    NewJp,
    NewKr,
    NewSp,
    NewUs,
    FH_NUM_ENCODINGS
}

[Generator]
public class FhEncodingGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        IncrementalValuesProvider<AdditionalText> encodingTableCsv = context.AdditionalTextsProvider.Where(s => s.Path.Contains("FhEncodingTable.csv"));
        context.RegisterSourceOutput(encodingTableCsv, Execute);
    }

    private bool LoadEncodingTable(AdditionalText text, out List<string[]> encodingLines)
    {
        encodingLines = new List<string[]>();

        using StreamReader sr = new StreamReader(text.Path);

        if (sr.ReadLine() is not { } headerLine)
            return false;

        string[] columnHeaders = headerLine.Split(',');
        string[] expectedHeaders = Enum.GetNames(typeof(FhEncodingLocale));

        for (int i = 1; i < columnHeaders.Length; i++)
        {
            if (!columnHeaders[i].Equals(expectedHeaders[i - 1]))
                return false;
        }

        while (sr.ReadLine() is { } dataLine)
            encodingLines.Add(dataLine.Split(','));

        return true;
    }

    // Converts ex. U+0000 or \u0000 to a escaped character literal suitable for C# source.
    private bool UnicodeCodePointToCharLiteral(string unicodePoint, out string charLiteral)
    {
        charLiteral = SymbolDisplay.FormatLiteral('\0', true);

        if (!int.TryParse(unicodePoint.Substring(2), NumberStyles.HexNumber, null, out int codePoint))
            return false;

        string baseChar = char.ConvertFromUtf32(codePoint);

        // FFX code points cannot be surrogate pairs, so immediately weed them out
        if (baseChar.Length != 1)
            return false;

        charLiteral = SymbolDisplay.FormatLiteral(baseChar[0], true);
        return true;
    }

    private void EmitEncodingBaseClass(SourceProductionContext context)
    {
        StringBuilder locales = new StringBuilder();

        for (FhEncodingLocale locale = 0; locale < FhEncodingLocale.FH_NUM_ENCODINGS; locale++)
        {
            locales.AppendLine($"    public static readonly FhEncoding {locale} = new FhEncoding{locale}();");
        }

        string source = $@"using System;

namespace Fahrenheit.Common.DEdit;

public enum FhEncodingLocale
{{
    In,
    Us,
    Jp,
    NewCh,
    NewDe,
    NewFr,
    NewIt,
    NewJp,
    NewKr,
    NewSp,
    NewUs,
    FH_NUM_ENCODINGS
}}

public abstract class FhEncoding
{{
    protected const int InvalidChar = '\0'; // The null terminator is handled by the DialogueFile
    protected const int InvalidByte = 0xFF; // Not used by the game.

    internal abstract char GetChar(in byte b);
    internal abstract byte GetByte(in char c);

    public Span<char> GetChars(in ReadOnlySpan<byte> bytes)
    {{
        char[] cs = new char[bytes.Length];

        for (int i = 0; i < bytes.Length; i++)
        {{
            char c;
            if ((c = GetChar(bytes[i])) != InvalidChar)
                cs[i] = c;
        }}

        return cs;
    }}

    public Span<byte> GetBytes(in ReadOnlySpan<char> chars)
    {{
        byte[] bs = new byte[chars.Length + 1];

        for (int i = 0; i < chars.Length; i++)
        {{
            byte b;
            if ((b = GetByte(chars[i])) != InvalidByte)
                bs[i] = b;
        }}

        bs[^1] = 0;

        return bs;
    }}

{locales}}}";
        context.AddSource("FhEncoding.g.cs", source);
    }

    private void EmitEncodingFile(SourceProductionContext context, string localeName, string byteToChar, string charToByte)
    {
        string source = $@"namespace Fahrenheit.Common.DEdit;

internal sealed class FhEncoding{localeName} : FhEncoding
{{
    internal override char GetChar(in byte b)
    {{
        return b switch
        {{
{byteToChar}
            _ => '\0'
        }};
    }}

    internal override byte GetByte(in char c)
    {{
        return c switch
        {{
{charToByte}
            _ => 0xFF
        }};
    }}
}}";

        context.AddSource($"FhEncoding{localeName}.g.cs", source);
    }

    public void Execute(SourceProductionContext context, AdditionalText encodingTable)
    {
        /* [fkelava 23/9/22 17:49]
         * Uncomment the below block to debug the source generator.
         * UNLOAD FAHRENHEIT.COMMON BEFORE YOU DO THIS, OR IN GENERAL BEFORE YOU EDIT THE SOURCE GENERATOR.
         */

        //#if DEBUG
        //        if (!Debugger.IsAttached)
        //        {
        //            Debugger.Launch();
        //        }
        //#endif

        EmitEncodingBaseClass(context);

        if (!LoadEncodingTable(encodingTable, out List<string[]> encodingLines))
            return;

        for (FhEncodingLocale locale = 0; locale < FhEncodingLocale.FH_NUM_ENCODINGS; locale++)
        {
            StringBuilder byteToChar = new StringBuilder();
            StringBuilder charToByte = new StringBuilder();

            foreach (string[] splitLine in encodingLines)
            {
                byte val = byte.TryParse(splitLine[0], NumberStyles.HexNumber, null, out byte b) ? b : throw new InvalidDataException();

                if (UnicodeCodePointToCharLiteral(splitLine[(int)locale + 1], out string charLiteral) && charLiteral != SymbolDisplay.FormatLiteral('\0', true))
                {
                    byteToChar.AppendLine($"            0x{val:X2} => {charLiteral},");
                    charToByte.AppendLine($"            {charLiteral} => 0x{val:X2},");
                }
            }

            EmitEncodingFile(context, locale.ToString(), byteToChar.ToString(), charToByte.ToString());
        }
    }
}