using System.Runtime.InteropServices;

namespace Fahrenheit.Core.X2.Kernel;

[StructLayout(LayoutKind.Sequential)]
internal struct FhX2BtlItem
{
    public readonly uint Name;
    public readonly uint Help;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I2, SizeConst = 2)]
    public readonly short[] Effect;

    public readonly byte   Process;
    public readonly byte   SubCommand;
    public readonly byte   System;
    public readonly byte   FlowSystem;
    public readonly uint   Cursor;
    public readonly uint   ExpData;
    public readonly uint   DmgData;
    public readonly ushort SubWindow;
    public readonly ushort AtbCost;
    public readonly ushort ChantCost;
    public readonly byte   Mp;
    public readonly byte   Target;
    public readonly byte   CalcPs;
    public readonly byte   Critical;
    public readonly byte   Hit;
    public readonly byte   Power;
    public readonly byte   AtcNum;
    public readonly byte   AtcStone;
    public readonly byte   AtcElement;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 24)]
    public readonly byte[] AtcStatus;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 24)]
    public readonly byte[] AtcStatus2;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = 24)]
    public readonly sbyte[] StatusTime;

    public readonly byte   Icon;
    public readonly ushort MonsterKiller;
    public readonly byte   MagicCancel;
    public readonly byte   Reserve1;
    public readonly ushort BlueMagic;
    public readonly ushort Reserve2;
    public readonly byte   Seq;
    public readonly byte   GetAp;
    public readonly byte   ItemElement;
    public readonly byte   ItemLevel;
    public readonly uint   Price;
}