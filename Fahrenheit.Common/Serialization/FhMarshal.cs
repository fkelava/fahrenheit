// System imports
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;

namespace Fahrenheit.Common.Serialization;

/* [fkelava 16/8/22 00:50]
 * FhMarshal is a fallback in case source-generated fast deserialization is not available.
 */
public static class FhMarshal
{
    public static bool MarshalToStruct<T>(this BinaryReader br, [NotNullWhen(true)] out T? tval) where T : struct
    {
        tval = default;

        int    size = Marshal.SizeOf(typeof(T));
        byte[] arr  = br.ReadBytes(size);
        IntPtr ptr  = IntPtr.Zero;

        try
        {
            ptr = Marshal.AllocHGlobal(size);
            Marshal.Copy(arr, 0, ptr, size);
            tval = Marshal.PtrToStructure<T>(ptr);
        }
        finally
        {
            Marshal.FreeHGlobal(ptr);
        }

        return tval.HasValue;
    }

    public static bool MarshalToStructMulti<T>(this BinaryReader br, int n, out T[] tlist) where T : struct
    {
        tlist = new T[n];

        for (int i = 0; i < n; i++)
        {
            if (!MarshalToStruct(br, out T? tval))
                return false;

            tlist[i] = tval.Value;
        }

        return true;
    }

    public static bool MarshalToBytes<T>(this BinaryWriter bw, T tval) where T : struct
    {
        long   bspos = bw.BaseStream.Position;
        int    size  = Marshal.SizeOf(typeof(T));
        byte[] arr   = new byte[size];

        IntPtr ptr = IntPtr.Zero;
        try
        {
            ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(tval, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
        }
        finally
        {
            Marshal.FreeHGlobal(ptr);
        }

        bw.Write(arr);
        bw.Flush();

        return bw.BaseStream.Position == bspos + size;
    }

    public static bool MarshalToBytesMulti<T>(this BinaryWriter bw, int n, Span<T> tval) where T : struct
    {
        for (int i = 0; i < n; i++)
        {
            if (!bw.MarshalToBytes(tval[i]))
                return false;
        }

        return true;
    }
}