using System.Runtime.InteropServices;

namespace Fahrenheit.Core.X2.Kernel;

/* [fkelava 13/9/22 08:11]
 * source: MS Store ver.
 * header: header_btl_a_ability
 *
 * /ffx_ps2/ffx2/master/jppc/battle/kernel/a_ability.h
 */

[StructLayout(LayoutKind.Sequential)]
internal struct FhX2BtlAAbility
{
    public readonly uint Name;
    public readonly uint Help;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U2, SizeConst = 4)]
    public readonly ushort[] RESERVED_1;

    public readonly ushort CountDownType;
    public readonly sbyte  CountDown;
    public readonly byte   RESERVED_2;
    public readonly byte   SpecialData;
    public readonly byte   AttackElement;
    public readonly byte   AbsorbElement;
    public readonly byte   ImmuneElement;
    public readonly byte   HalfElement;
    public readonly byte   WeakElement;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = 10)]
    public readonly sbyte[] UpStatus;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 24)]
    public readonly byte[] AttackStatus;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = 24)]
    public readonly sbyte[] AttackStatus2;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 24)]
    public readonly byte[] ImmunitiesArray;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 24)]
    public readonly byte[] ImmunitiesArray2;

    public readonly int AutoStatus;
    public readonly int AutoStatus2;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = 24)]
    public readonly sbyte[] StatusTime;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U2, SizeConst = 3)]
    public readonly ushort[] AbilityType;

    public readonly byte   Icon;
    public readonly byte   RESERVED_3;
    public readonly ushort RESERVED_4;
    public readonly ushort Ap;
}