using System.Runtime.InteropServices;

namespace Fahrenheit.Core.X2.Kernel;

/* [fkelava 13/9/22 08:11]
 * source: MS Store ver.
 * header: header_btl_accessory
 *
 * /ffx_ps2/ffx2/master/jppc/battle/kernel/accessory.h
 */

[StructLayout(LayoutKind.Sequential)]
internal struct FhX2BtlAccessory
{
    public readonly uint Name;
    public readonly uint Help;
    public readonly byte ExtData;
    public readonly byte Equip;
    public readonly byte User;
    public readonly byte Icon;
    public readonly byte Seq;
    public readonly byte Reserved1;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = 10)]
    public readonly sbyte[] UpStatus;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U2, SizeConst = 4)]
    public readonly ushort[] Ability;

    public readonly uint Price;
}