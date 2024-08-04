﻿namespace Fahrenheit.CoreLib.FFX;

[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 0x2150)]
public unsafe struct Btl
{
    [FieldOffset(0x10)]   public       byte   battle_state;
    [FieldOffset(0x12)]   public       byte   battle_trigger;
    [FieldOffset(0x28)]   public       bool   flag_invincible_mon;
    [FieldOffset(0x29)]   public       bool   flag_invincible_ply;
    [FieldOffset(0x2A)]   public       bool   flag_ply_controls_mon;
    [FieldOffset(0x2C)]   public       bool   flag_free_camera;
    [FieldOffset(0x38)]   public       bool   flag_no_variance;
    [FieldOffset(0x39)]   public       bool   flag_never_crit;
    [FieldOffset(0x3A)]   public       bool   flag_always_hit;
    [FieldOffset(0x3D)]   public       bool   flag_always_crit;
    [FieldOffset(0x3E)]   public       bool   flag_always_1_dmg;
    [FieldOffset(0x3F)]   public       bool   flag_always_9999_dmg;
    [FieldOffset(0x40)]   public       bool   flag_always_99999_dmg;
    [FieldOffset(0x4F)]   public       bool   flag_never_hit;
    [FieldOffset(0x5C)]   public       nint   ptr_command_bin;
    [FieldOffset(0x60)]   public       nint   ptr_monmagic1_bin;
    [FieldOffset(0x64)]   public       nint   ptr_monmagic2_bin;
    [FieldOffset(0x68)]   public       nint   ptr_ply_rom_bin;
    [FieldOffset(0x70)]   public       nint   ptr_item_bin;
    [FieldOffset(0x74)]   public       nint   ptr_a_ability_bin;
    [FieldOffset(0x78)]   public       nint   ptr_sum_assure_bin;
    [FieldOffset(0x7C)]   public       nint   ptr_ctb_base_bin;
    [FieldOffset(0x80)]   public       nint   ptr_magic_bin;
    [FieldOffset(0x84)]   public       nint   ptr_mot_bin;
    [FieldOffset(0x88)]   public       nint   ptr_st_number_bin;
    [FieldOffset(0x90)]   public       nint   ptr_sum_grow_bin;
    [FieldOffset(0x94)]   public       nint   ptr_kaizou_bin;
    [FieldOffset(0x98)]   public       ushort size_command_bin;
    [FieldOffset(0x9A)]   public       ushort size_ply_rom_bin;
    [FieldOffset(0x9E)]   public       ushort size_item_bin;
    [FieldOffset(0xA0)]   public       ushort size_a_ability_bin;
    [FieldOffset(0xA2)]   public       ushort size_sum_assure_bin;
    [FieldOffset(0xA4)]   public       ushort size_ctb_base_bin;
    [FieldOffset(0xA6)]   public       ushort size_magic_bin;
    [FieldOffset(0xA8)]   public       ushort size_st_number_bin;
    [FieldOffset(0xAA)]   public       ushort size_mot_bin;
    [FieldOffset(0xAE)]   public       ushort size_sum_grow_bin;
    [FieldOffset(0xB0)]   public       ushort size_kaizou_bin;
    [FieldOffset(0xF4)]   public       uint   ptr_btl_bin;
    [FieldOffset(0xF8)]   public       uint   ptr_btl_bin_fields;
    [FieldOffset(0xFC)]   public       uint   ptr_btl_bin_encounters;
    [FieldOffset(0x100)]  public       ushort btl_bin_field_count;
    [FieldOffset(0x102)]  public       ushort size_btl_bin;
    [FieldOffset(0x120)]  public       uint   ptr_btl_bin_cur_field;
    [FieldOffset(0x124)]  public       uint   ptr_btl_bin_cur_encounter;
    [FieldOffset(0x128)]  public       uint   ptr_btl_bin_cur_group;
    [FieldOffset(0x12C)]  public       uint   ptr_btl_bin_cur_formation;
    [FieldOffset(0x15C0)] public       uint   chosen_gil;
    [FieldOffset(0x1984)] public       ushort battlefield_id;
    [FieldOffset(0x1986)] public       ushort field_idx;
    [FieldOffset(0x198A)] public fixed byte   field_name[8];
    [FieldOffset(0x2008)] public       uint   last_com;
    [FieldOffset(0x210C)] public       byte   ambush_state;
    [FieldOffset(0x2121)] public       byte   battle_end_type;
}