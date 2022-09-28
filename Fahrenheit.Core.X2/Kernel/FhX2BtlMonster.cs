using System.Runtime.InteropServices;

namespace Fahrenheit.Core.X2.Kernel;

/* FhX2BtlMonster
 * e.g. /ffx2/master/jppc/battle/mon/_m164/m164.bin, at offset at 10h size C8h
 *
 * name        - 00 00 5A 00 => unsure what internal identifier this is
 * help        - 08 00 0B 01 => unsure what internal identifier this is
 * hpmax       - EE 20 00 00 => 8430
 * mpmax       - 0F 27 00 00 => 9999
 * lv          - 16          => 22
 * str         - 61          => 97
 * def         - 4C          => 76
 * mag         - 0B          => 11
 * mdef        - 14          => 20
 * agi         - 7D          => 125
 * acc         - 5F          => 95
 * eva         - 19          => 25
 * lck         - 03          => 3
 * thinktime   - 00          
 * special     - C3 03
 * abselem     - 00
 * invelem     - 10          => can't remember what element this is
 * hlfelem     - 00
 * weakelem    - 00
 * defstatus   - FF FF FF FF FF FF FF FF FF 00 FF 00 00 00 00 00 00 FF FF 00 00 00 00 00
 * defstatus2  - 00 00 00 00 00 00 FF 00 00 00 00 00 00 00 FF 00 00 00 00 00 00 00 00 00
 * autostatus  - 00 00 00 00
 * autostatus2 - 00 00 00 00
 * statustime  - 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00
 * ability     - DA 41 91 40 92 40 93 40 AD 40 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00
 * basaku      - 00 00
 * monmodel    - A4 10                   => unsure what internal identifier this is
 * monmotion   - A4 10                   => unsure what internal identifier this is
 * monsound    - A4 10                   => unsure what internal identifier this is
 * oversoul    - 00 00                   => cannot oversoul
 * montype     - 00 00                   => species: unspecified
 * exp         - DC 05 00 00             => 1500
 * gil         - B0 04 00 00             => 1200
 * stealgil    - DC 05 00 00             => 1500
 * ap          - 0F 00                   => 15
 * droprate    - FF                      => guaranteed
 * stealrate   - 80                      => 128 - not sure what odds this maps to
 * dropitem    - 5C 90 01 00 5C 90 01 00 => common: 1x 905C, rare: 1x 905C
 * stealitem   - 34 20 04 00 34 20 06 00 => common: 4x 2034, rare: 6x 2034
 * bribeitem   - 00 00 00 00 00 00 00 00 => cannot be bribed
 * zantetsu    - 50
 * res1        - 00
 * res2        - 00 00
 */
[StructLayout(LayoutKind.Sequential)]
internal struct FhX2BtlMonster
{
    public readonly uint   Name;
    public readonly uint   Help;
    public readonly uint   HpMax;
    public readonly uint   MpMax;
    public readonly byte   Level;
    public readonly byte   Strength;
    public readonly byte   Defense;
    public readonly byte   Magic;
    public readonly byte   MagicDef;
    public readonly byte   Agility;
    public readonly byte   Accuracy;
    public readonly byte   Evasion;
    public readonly byte   Luck;
    public readonly byte   ThinkingTime;
    public readonly ushort Special;
    public readonly byte   AbsorbElement;
    public readonly byte   InvulnElement;
    public readonly byte   HalfElement;
    public readonly byte   WeakElement;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 24)]
    public readonly byte[] ImmunitiesArray;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 24)]
    public readonly byte[] ImmunitiesArray2;

    public readonly int AutoStatus;
    public readonly int AutoStatus2;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = 24)]
    public readonly sbyte[] StatusTimeArray;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U2, SizeConst = 16)]
    public readonly ushort[] AbilityMap;

    public readonly ushort Berserk; // ???
    public readonly ushort MonsterModel;
    public readonly ushort MonsterMotion;
    public readonly ushort MonsterSound;
    public readonly ushort Oversoul;
    public readonly ushort MonsterType;
    public readonly int    Exp;
    public readonly int    Gil;
    public readonly int    StealGil;
    public readonly ushort Ap;
    public readonly byte   DropChance;
    public readonly byte   StealChance;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U2, SizeConst = 4)]
    public readonly ushort[] DropItem;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U2, SizeConst = 4)]
    public readonly ushort[] StealItem;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U2, SizeConst = 4)]
    public readonly ushort[] BribeItem;

    public readonly byte   ZantetsuResist;
    public readonly byte   Reserved1;
    public readonly ushort Reserved2;
}