/* [ct2cs 21/5/23 00:09]
 * This file was generated by Fahrenheit.CT2CS (https://github.com/fkelava/fahrenheit/).
 * 
 * Source file: x_btlactor.ct
 */

namespace Fahrenheit.CoreLib;

[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 0xF90)]
public struct FhXChr 
{
    [FieldOffset(0x5D0)] public uint stat_hp;
    [FieldOffset(0x5D4)] public uint stat_mp;
    [FieldOffset(0x594)] public uint stat_maxhp;
    [FieldOffset(0x598)] public uint stat_maxmp;
    [FieldOffset(0xDCC)] public byte stat_death;
    [FieldOffset(0x606)] public byte __0x606;
    public int stat_poison { get { return (__0x606 >> 3) & 1; } }
    [FieldOffset(0xDCE)] public byte stat_stone;
    public int stat_zombie { get { return (__0x606 >> 1) & 1; } }
    [FieldOffset(0x63D)] public byte stat_weak;
    [FieldOffset(0x5A8)] public byte stat_str;
    [FieldOffset(0x5A9)] public byte stat_vit;
    [FieldOffset(0x5AA)] public byte stat_mag;
    [FieldOffset(0x5AB)] public byte stat_spirit;
    [FieldOffset(0x5AC)] public byte stat_dex;
    [FieldOffset(0x5AD)] public byte stat_luck;
    [FieldOffset(0x5AE)] public byte stat_avoid;
    [FieldOffset(0x5AF)] public byte stat_hit;
    [FieldOffset(0x5BA)] public byte stat_poison_per;
    [FieldOffset(0x5BB)] public byte stat_limit_type;
    [FieldOffset(0x5BC)] public byte stat_limit_gauge;
    [FieldOffset(0x5BD)] public byte stat_limit_gauge_max;
    [FieldOffset(0xDC8)] public byte stat_inbattle;
    [FieldOffset(0x590)] public byte __0x590;
    public int stat_man { get { return (__0x590) & 1; } }
    public int stat_female { get { return (__0x590 >> 1) & 1; } }
    public int stat_summon { get { return (__0x590 >> 2) & 1; } }
    [FieldOffset(0x505)] public byte stat_fly;
    [FieldOffset(0xDEC)] public byte stat_will_die;
    [FieldOffset(0x4FC)] public ushort stat_area;
    [FieldOffset(0x4FE)] public byte stat_pos;
    [FieldOffset(0x4FF)] public byte stat_far;
    [FieldOffset(0x504)] public byte stat_group;
    public int stat_power_break { get { return (__0x606 >> 4) & 1; } }
    public int stat_magic_break { get { return (__0x606 >> 5) & 1; } }
    public int stat_armor_break { get { return (__0x606 >> 6) & 1; } }
    public int stat_mental_break { get { return (__0x606 >> 7) & 1; } }
    [FieldOffset(0x607)] public byte __0x607;
    public int stat_confuse { get { return (__0x607) & 1; } }
    public int stat_berserk { get { return (__0x607 >> 1) & 1; } }
    public int stat_prov { get { return (__0x607 >> 2) & 1; } }
    public int stat_threat { get { return (__0x607 >> 3) & 1; } }
    [FieldOffset(0x608)] public byte stat_sleep;
    [FieldOffset(0x609)] public byte stat_silence;
    [FieldOffset(0x60A)] public byte stat_dark;
    [FieldOffset(0x60B)] public byte stat_shell;
    [FieldOffset(0x60C)] public byte stat_protess;
    [FieldOffset(0x60D)] public byte stat_reflect;
    [FieldOffset(0x60E)] public byte stat_bawater;
    [FieldOffset(0x60F)] public byte stat_bafire;
    [FieldOffset(0x610)] public byte stat_bathunder;
    [FieldOffset(0x611)] public byte stat_bacold;
    [FieldOffset(0x612)] public byte stat_regen;
    [FieldOffset(0x613)] public byte stat_haste;
    [FieldOffset(0x614)] public byte stat_slow;
    [FieldOffset(0x3F5)] public byte stat_death_pattern;
    [FieldOffset(0xDDD)] public byte stat_event_chr;
    [FieldOffset(0xDD6)] public byte stat_action;
    [FieldOffset(0xDD9)] public byte stat_cursor;
    [FieldOffset(0xDD7)] public byte stat_ctb_list;
    [FieldOffset(0x16)] public byte stat_visible;
    [FieldOffset(0x509)] public byte stat_move_area;
    [FieldOffset(0x50B)] public byte stat_move_pos;
    [FieldOffset(0x408)] public uint stat_efflv;
    [FieldOffset(0x24)] public byte stat_model;
    [FieldOffset(0x422)] public byte stat_damage_chr;
    [FieldOffset(0x416)] public byte stat_move_target;
    [FieldOffset(0x420)] public byte stat_motionlv;
    [FieldOffset(0x412)] public byte stat_move_flag;
    [FieldOffset(0x43E)] public byte stat_live_motion;
    [FieldOffset(0x508)] public byte stat_adjust_pos;
    [FieldOffset(0x50D)] public byte stat_height_on;
    [FieldOffset(0x50E)] public byte stat_sleep_recover_flag;
    [FieldOffset(0x5DA)] public byte __0x5DA;
    public int stat_abs_fire { get { return (__0x5DA) & 1; } }
    public int stat_abs_cold { get { return (__0x5DA >> 1) & 1; } }
    public int stat_abs_thunder { get { return (__0x5DA >> 2) & 1; } }
    public int stat_abs_water { get { return (__0x5DA >> 3) & 1; } }
    public int stat_abs_holy { get { return (__0x5DA >> 4) & 1; } }
    [FieldOffset(0x5DB)] public byte __0x5DB;
    public int stat_inv_fire { get { return (__0x5DB) & 1; } }
    public int stat_inv_cold { get { return (__0x5DB >> 1) & 1; } }
    public int stat_inv_thunder { get { return (__0x5DB >> 2) & 1; } }
    public int stat_inv_water { get { return (__0x5DB >> 3) & 1; } }
    public int stat_inv_holy { get { return (__0x5DB >> 4) & 1; } }
    [FieldOffset(0x5DC)] public byte __0x5DC;
    public int stat_half_fire { get { return (__0x5DC) & 1; } }
    public int stat_half_cold { get { return (__0x5DC >> 1) & 1; } }
    public int stat_half_thunder { get { return (__0x5DC >> 2) & 1; } }
    public int stat_half_water { get { return (__0x5DC >> 3) & 1; } }
    public int stat_half_holy { get { return (__0x5DC >> 4) & 1; } }
    public int stat_weak_fire { get { return (__0x5DC) & 1; } }
    public int stat_weak_cold { get { return (__0x5DC >> 1) & 1; } }
    public int stat_weak_thunder { get { return (__0x5DC >> 2) & 1; } }
    public int stat_weak_water { get { return (__0x5DC >> 3) & 1; } }
    public int stat_weak_holy { get { return (__0x5DC >> 4) & 1; } }
    [FieldOffset(0x426)] public byte stat_adjust_pos_flag;
    [FieldOffset(0x447)] public byte __0x447;
    public int stat_inv_physic_motion { get { return (__0x447) & 1; } }
    public int stat_inv_magic_motion { get { return (__0x447 >> 1) & 1; } }
    [FieldOffset(0xDEB)] public byte stat_steal_count;
    [FieldOffset(0x448)] public byte stat_wait_motion_flag;
    [FieldOffset(0x40A)] public byte stat_attack_return_flag;
    [FieldOffset(0x40C)] public byte stat_attack_normal_frame;
    [FieldOffset(0x41E)] public byte stat_disable_move_flag;
    [FieldOffset(0x41F)] public byte stat_disable_jump_flag;
    [FieldOffset(0x2D)] public byte stat_bodyhit_flag;
    [FieldOffset(0xE0C)] public byte stat_effvar;
    [FieldOffset(0xF88)] public FhXItemMem __FhXItemMem_0xF88;
    [FieldOffset(0x451)] public byte stat_magiclv;
    [FieldOffset(0x43D)] public byte stat_appear_motion_flag;
    [FieldOffset(0xDF9)] public byte stat_cursor_element;
    [FieldOffset(0x719)] public byte stat_limit_bar_flag_cam;
    [FieldOffset(0x718)] public byte stat_limit_bar_flag;
    [FieldOffset(0xDD2)] public byte stat_exist_flag;
    [FieldOffset(0x616)] public byte __0x616;
    public int stat_live { get { return (__0x616) & 1; } }
    public int stat_str_memory { get { return (__0x616 >> 1) & 1; } }
    public int stat_mag_memory { get { return (__0x616 >> 2) & 1; } }
    public int stat_dex_memory { get { return (__0x616 >> 3) & 1; } }
    public int stat_move_memory { get { return (__0x616 >> 4) & 1; } }
    public int stat_ability_memory { get { return (__0x616 >> 5) & 1; } }
    public int stat_dodge { get { return (__0x616 >> 6) & 1; } }
    public int stat_defend { get { return (__0x616 >> 7) & 1; } }
    [FieldOffset(0x617)] public byte __0x617;
    public int stat_blow { get { return (__0x617) & 1; } }
    public int stat_relife { get { return (__0x617 >> 1) & 1; } }
    public int stat_curse { get { return (__0x617 >> 2) & 1; } }
    public int stat_defense { get { return (__0x617 >> 3) & 1; } }
    public int stat_protect { get { return (__0x617 >> 4) & 1; } }
    public int stat_iron { get { return (__0x617 >> 5) & 1; } }
    public int stat_death_sentence { get { return (__0x617 >> 6) & 1; } }
    [FieldOffset(0x5C9)] public byte stat_death_sentence_start;
    [FieldOffset(0x5C8)] public byte stat_death_sentence_count;
    [FieldOffset(0x44E)] public byte stat_dmg_dir;
    [FieldOffset(0x41C)] public byte stat_direction_change_flag;
    [FieldOffset(0x41D)] public byte stat_direction_change_effect;
    [FieldOffset(0x41B)] public byte stat_direction_fix_flag;
    [FieldOffset(0x433)] public byte stat_hit_terminate_flag;
    [FieldOffset(0xD34)] public uint stat_damage_hp;
    [FieldOffset(0xD38)] public uint stat_damage_mp;
    [FieldOffset(0xD3C)] public uint stat_damage_ctb;
    [FieldOffset(0x423)] public byte stat_appear_invisible_flag;
    [FieldOffset(0xE0E)] public byte stat_effect_hit_num;
    [FieldOffset(0x425)] public byte stat_avoid_flag;
    [FieldOffset(0xDDE)] public sbyte stat_blow_exist_flag;
    [FieldOffset(0xDCD)] public sbyte stat_escape_flag;
    [FieldOffset(0x17)] public byte stat_hide;
    [FieldOffset(0x641)] public byte stat_def_death;
    [FieldOffset(0x642)] public byte stat_def_zombie;
    [FieldOffset(0x643)] public byte stat_def_stone;
    [FieldOffset(0x644)] public byte stat_def_poison;
    [FieldOffset(0x645)] public byte stat_def_power_break;
    [FieldOffset(0x646)] public byte stat_def_magic_break;
    [FieldOffset(0x647)] public byte stat_def_armor_break;
    [FieldOffset(0x648)] public byte stat_def_mental_break;
    [FieldOffset(0x649)] public byte stat_def_confuse;
    [FieldOffset(0x64A)] public byte stat_def_berserk;
    [FieldOffset(0x64B)] public byte stat_def_prov;
    [FieldOffset(0x64C)] public byte stat_def_threat;
    [FieldOffset(0x64D)] public byte stat_def_sleep;
    [FieldOffset(0x64E)] public byte stat_def_silence;
    [FieldOffset(0x64F)] public byte stat_def_dark;
    [FieldOffset(0x650)] public byte stat_def_shell;
    [FieldOffset(0x651)] public byte stat_def_protess;
    [FieldOffset(0x652)] public byte stat_def_reflect;
    [FieldOffset(0x653)] public byte stat_def_bawater;
    [FieldOffset(0x654)] public byte stat_def_bafire;
    [FieldOffset(0x655)] public byte stat_def_bathunder;
    [FieldOffset(0x656)] public byte stat_def_bacold;
    [FieldOffset(0x657)] public byte stat_def_regen;
    [FieldOffset(0x658)] public byte stat_def_haste;
    [FieldOffset(0x659)] public byte stat_def_slow;
    [FieldOffset(0x65A)] public byte __0x65A;
    public int stat_def_live { get { return (__0x65A) & 1; } }
    public int stat_def_str_memory { get { return (__0x65A >> 1) & 1; } }
    public int stat_def_mag_memory { get { return (__0x65A >> 2) & 1; } }
    public int stat_def_dex_memory { get { return (__0x65A >> 3) & 1; } }
    public int stat_def_move_memory { get { return (__0x65A >> 4) & 1; } }
    public int stat_def_ability_memory { get { return (__0x65A >> 5) & 1; } }
    public int stat_def_dodge { get { return (__0x65A >> 6) & 1; } }
    public int stat_def_defend { get { return (__0x65A >> 7) & 1; } }
    [FieldOffset(0x65B)] public byte __0x65B;
    public int stat_def_relife { get { return (__0x65B >> 1) & 1; } }
    public int stat_def_blow { get { return (__0x65B) & 1; } }
    public int stat_def_curse { get { return (__0x65B >> 2) & 1; } }
    public int stat_def_defense { get { return (__0x65B >> 3) & 1; } }
    public int stat_def_protect { get { return (__0x65B >> 4) & 1; } }
    public int stat_def_iron { get { return (__0x65B >> 5) & 1; } }
    public int stat_def_death_sentence { get { return (__0x65B >> 6) & 1; } }
    [FieldOffset(0xDD8)] public byte stat_hp_list;
    [FieldOffset(0x19)] public byte stat_visible_cam;
    [FieldOffset(0x1B)] public byte stat_visible_out;
    [FieldOffset(0x43B)] public byte stat_win_pose;
    [FieldOffset(0x23)] public byte stat_fast_model_flag;
    [FieldOffset(0x446)] public byte stat_command_type;
    [FieldOffset(0xDDA)] public byte stat_effect_target_flag;
    [FieldOffset(0xE10)] public byte stat_magic_effect_ground;
    [FieldOffset(0xE11)] public byte stat_magic_effect_water;
    [FieldOffset(0x4B8)] public byte stat_idle2_prob;
    [FieldOffset(0x408)] public byte stat_attack_motion_type;
    [FieldOffset(0x4B9)] public byte stat_attack_inc_speed;
    [FieldOffset(0x4BA)] public byte stat_attack_dec_speed;
    [FieldOffset(0x65C)] public byte stat_ctb;
    [FieldOffset(0x424)] public byte stat_appear_count;
    [FieldOffset(0x4BB)] public byte stat_motion_num;
    [FieldOffset(0xF74)] public byte stat_info_mes_id;
    [FieldOffset(0xF75)] public byte stat_live_mes_id;
    [FieldOffset(0x18)] public sbyte stat_visible_eff;
    [FieldOffset(0x21)] public sbyte stat_motion_dispose_flag;
    [FieldOffset(0x22)] public sbyte stat_model_dispose_flag;
    [FieldOffset(0x5B9)] public byte __0x5B9;
    public int stat_def_ctb { get { return (__0x5B9) & 1; } }
    [FieldOffset(0x26)] public sbyte stat_shadow;
    [FieldOffset(0x43C)] public sbyte stat_win_se;
    [FieldOffset(0x6DB)] public byte stat_attack_num;
    [FieldOffset(0x44A)] public sbyte stat_near_motion;
    [FieldOffset(0x44B)] public sbyte stat_near_motion_set;
    [FieldOffset(0x400)] public byte stat_motion_speed_normal;
    [FieldOffset(0x405)] public byte stat_motion_speed_normal_start;
    [FieldOffset(0x4B4)] public byte stat_own_attack_near;
    [FieldOffset(0x5CB)] public byte stat_prov_command_flag;
    [FieldOffset(0x5C4)] public byte stat_prov_chr;
    [FieldOffset(0x6CE)] public byte stat_use_mp0;
    [FieldOffset(0x5C3)] public byte stat_icon_number;
    [FieldOffset(0xE1A)] public short stat_sound_hit_num;
    [FieldOffset(0x6D1)] public byte stat_summoner;
    [FieldOffset(0x5B8)] public byte __0x5B8;
    public int stat_sp_invincible { get { return (__0x5B8 >> 7) & 1; } }
    public int stat_sp_inv_magic { get { return (__0x5B8 >> 6) & 1; } }
    public int stat_sp_inv_physic { get { return (__0x5B8 >> 5) & 1; } }
    public int stat_sp_disable_zan { get { return (__0x5B9 >> 1) & 1; } }
    [FieldOffset(0x5A4)] public uint stat_over_kill_hp;
    [FieldOffset(0x409)] public byte stat_return_motion_type;
    [FieldOffset(0x6DF)] public byte stat_command_exe_count;
    [FieldOffset(0x6E0)] public byte stat_consent;
    [FieldOffset(0x40D)] public byte stat_attack_near_frame;
    [FieldOffset(0x6E1)] public byte stat_energy;
    [FieldOffset(0x44F)] public byte stat_weak_motion;
    public int stat_sp_wairo { get { return (__0x5B9 >> 2) & 1; } }
    [FieldOffset(0x40E)] public byte stat_attack_motion_frame;
    [FieldOffset(0x700)] public sbyte stat_death_status;
    [FieldOffset(0xDCA)] public byte stat_target_list;
    [FieldOffset(0x3F8)] public byte stat_center_chr_flag;
    [FieldOffset(0x3F9)] public byte stat_death_return;
    [FieldOffset(0x3B)] public byte stat_eternal_relife;
    [FieldOffset(0x437)] public byte stat_neck_target_flag;
    [FieldOffset(0x1C)] public sbyte stat_visible_out_on;
    [FieldOffset(0xDDB)] public sbyte stat_regen_damage_flag;
    [FieldOffset(0x442)] public byte stat_num_print_element;
}

