// System imports
using System;
using System.Runtime.CompilerServices;

namespace Fahrenheit.Common.Utilities;

// forward-only whatever-parsing
public ref struct FhTokenizer<T> where T : struct, IEquatable<T>
{
    private readonly ReadOnlySpan<T> _line;
    private readonly ReadOnlySpan<T> _seps;
    private          int             _idx;

    public FhTokenizer(ReadOnlySpan<T> line,
                       ReadOnlySpan<T> seps,
                       int             startpos = 0)
    {
        _line = line;
        _seps = seps;
        _idx  = startpos;
    }

    public ReadOnlySpan<T> GetNextToken(out int startpos)
    {
        startpos = _idx;

        if (_idx == _line.Length)
            return ReadOnlySpan<T>.Empty;

        startpos = _idx;
        int endpos = _line[_idx.._line.Length].IndexOfAny(_seps) + _idx;

        while (endpos == startpos)
        {
            _idx++;
            startpos++;
            endpos = _line[_idx.._line.Length].IndexOfAny(_seps) + _idx;
        }

        if (endpos == startpos - 1)
        {
            _idx = _line.Length;
            return _line[startpos.._line.Length];
        }

        _idx = endpos + 1;
        return _line[startpos..endpos];
    }

    public void DiscardToken()
    {
        ReadOnlySpan<T> _ = GetNextToken(out int _);
    }
}

public static class FhTextUtil
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<T> SliceBetween<T>(this ReadOnlySpan<T> span, int i1, int i2)
    {
        return span.Slice(i1 + 1, i2 - i1 - 1);
    }

    /* [fkelava 13/8/22 17:19]
     * I simply find line.AsT(out T t) to be a more legible alias for T.TryParse(line, out T t).
     */

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsBoolean(this ReadOnlySpan<char> line, out bool b)
    {
        return bool.TryParse(line, out b);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsSByte(this ReadOnlySpan<char> line, out sbyte i8)
    {
        return sbyte.TryParse(line, out i8);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsByte(this ReadOnlySpan<char> line, out byte u8)
    {
        return byte.TryParse(line, out u8);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsInt16(this ReadOnlySpan<char> line, out short i16)
    {
        return short.TryParse(line, out i16);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsUInt16(this ReadOnlySpan<char> line, out ushort u16)
    {
        return ushort.TryParse(line, out u16);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsInt32(this ReadOnlySpan<char> line, out int i32)
    {
        return int.TryParse(line, out i32);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsUInt32(this ReadOnlySpan<char> line, out uint u32)
    {
        return uint.TryParse(line, out u32);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsInt64(this ReadOnlySpan<char> line, out long i64)
    {
        return long.TryParse(line, out i64);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsUInt64(this ReadOnlySpan<char> line, out ulong u64)
    {
        return ulong.TryParse(line, out u64);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsFloat(this ReadOnlySpan<char> line, out float fp32)
    {
        return float.TryParse(line, out fp32);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsDouble(this ReadOnlySpan<char> line, out double fp64)
    {
        return double.TryParse(line, out fp64);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool AsDecimal(this ReadOnlySpan<char> line, out decimal fp80)
    {
        return decimal.TryParse(line, out fp80);
    }
}