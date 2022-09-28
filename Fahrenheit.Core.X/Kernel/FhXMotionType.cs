using System;

namespace Fahrenheit.Core.X.Kernel;

/* [fkelava 26/9/22 02:07]
 * Obtained from decompilation.
 */

[Flags]
public enum FhXMotionType
{
    MOTION_TYPE_ATTACK_RUN_00_01   = 0x01,
    MOTION_TYPE_ATTACK_RUN_01      = 0x02,
    MOTION_TYPE_ATTACK_MISS        = 0x04,
    MOTION_TYPE_ATTACK_RETURN      = 0x08,
    MOTION_TYPE_ATTACK_POS_CHECK   = 0x10,
    MOTION_TYPE_AVOID_MOVE         = 0x20,
    MOTION_TYPE_HOKAN_WAIT_TO_RUN  = 0x40,
    MOTION_TYPE_MOVE_BACK_JUMP     = 0x100,
    MOTION_TYPE_MOVE_AVOID         = 0x200,
    MOTION_TYPE_TURN_STAY          = 0x400,
    MOTION_TYPE_TURN_RUN           = 0x800,
    MOTION_TYPE_ATTACK_STAY        = 0x1000,
    MOTION_TYPE_WAIT_RETURN        = 0x2000,
    MOTION_TYPE_DISABLE_AVOID      = 0x4000,
    MOTION_TYPE_DISABLE_CHEST_MOVE = 0x8000,
    MOTION_TYPE_ATTACK_WEIGHT_MAX  = 0x10000,
}