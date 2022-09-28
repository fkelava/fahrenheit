using System.Runtime.InteropServices;

namespace Fahrenheit.Core.X.Structs;

[StructLayout(LayoutKind.Explicit, Size = 0xF90, Pack = 0)]
internal struct FhXBtlChr
{
    [FieldOffset(0x40C)] public readonly byte   StatAttackNormalFrame;
    [FieldOffset(0x40D)] public readonly byte   StatAttackNearFrame;
    [FieldOffset(0x40E)] public readonly byte   StatAttackMotionFrame;
    [FieldOffset(0x41B)] public readonly byte   StatDirectionFixFlag;
    [FieldOffset(0x41D)] public readonly byte   StatDirectionChangeEffect;
    [FieldOffset(0x4AC)] public readonly uint   StatMotionType;
    [FieldOffset(0x4B0)] public readonly ushort StatRound;
    [FieldOffset(0x4B2)] public readonly ushort StatRoundReturn;
    [FieldOffset(0x4B8)] public readonly byte   StatIdle2Prob;
    [FieldOffset(0x4B9)] public readonly byte   StatAttackIncSpeed;
    [FieldOffset(0x4BA)] public readonly byte   StatAttackDecSpeed;
    [FieldOffset(0x4BB)] public readonly byte   StatMotionNum;
    [FieldOffset(0x4BC)] public readonly float  MotionAttackStartDist;
    [FieldOffset(0x4C0)] public readonly float  MotionAttackOffset;
    [FieldOffset(0x4C4)] public readonly float  MotionAttackHeight;
    [FieldOffset(0x4C8)] public readonly float  MotionMoveBackjumpDist;
    [FieldOffset(0x4CC)] public readonly float  MotionRunSpeedV0;
    [FieldOffset(0x4D0)] public readonly float  MotionRunSpeedAcc;
    [FieldOffset(0x4D4)] public readonly float  MotionRunSpeed;
    [FieldOffset(0x4D8)] public readonly float  MotionRunSpeedReturn;
    [FieldOffset(0x594)] public readonly uint   MaxHP;
    [FieldOffset(0x598)] public readonly uint   MaxMP;
    [FieldOffset(0x59C)] public readonly uint   MaxHP2;
    [FieldOffset(0x5A0)] public readonly uint   MaxMP2;
}