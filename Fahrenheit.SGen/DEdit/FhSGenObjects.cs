namespace Fahrenheit.SGen.DEdit;

public record FhEncodingTable(FhEncodingTableEntry[] Entries);

public record FhEncodingTableEntry(
    byte Val,
    char In    = '\0',
    char Us    = '\0',
    char Jp    = '\0',
    char NewCh = '\0',
    char NewDe = '\0',
    char NewFr = '\0',
    char NewIt = '\0',
    char NewSp = '\0',
    char NewUs = '\0',
    char NewKr = '\0',
    char NewJp = '\0'
);