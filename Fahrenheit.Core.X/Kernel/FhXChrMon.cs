namespace Fahrenheit.Core.X.Kernel;

/* [fkelava 13/9/22 08:16]
 * source: MS Store ver.
 * header: __chr_mon_h, header_btl_monster, header_btl_monster2, header_btl_monster3
 *
 * /ffx_ps2/ffx/proj2/chr/ath/battle/monster1.ath
 * /ffx_ps2/ffx/proj2/chr/ath/battle/monster2.ath
 * /ffx_ps2/ffx/proj2/chr/ath/battle/monster3.ath
 * /ffx_ps2/ffx/proj2/chr/ath/mon.ath [combination of 3 above and a few more]
 *
 * Mind you that monster[1-3] have different define names (e.g. chr_koura_01 vs. m_甲羅モンスター１, but these are not important to us
 * because the actual values align between the headers- I picked the more legible names for posterity.
 */

public enum FhXChrMonId : ushort
{
    M000            = 0x1000, //ダミー
    CHR_DUMMY       = 0x1000,
    M001            = 0x1001, //甲羅モンスター１
    CHR_KOURA_01    = 0x1001,
    M002            = 0x1002, //甲羅モンスター２
    CHR_KOURA_02    = 0x1002,
    M003            = 0x1003, //甲羅モンスター３
    CHR_KOURA_03    = 0x1003,
    M004            = 0x1004, //甲羅モンスター４
    CHR_KOURA_04    = 0x1004,
    M005            = 0x1005, //甲羅モンスター５
    CHR_KOURA_05    = 0x1005,
    M006            = 0x1006, //ガルキマセラ１
    CHR_GARUKI_01   = 0x1006,
    M007            = 0x1007, //ガルキマセラ２
    CHR_GARUKI_02   = 0x1007,
    M008            = 0x1008, //ガルキマセラ３
    CHR_GARUKI_03   = 0x1008,
    M009            = 0x1009, //狼１
    CHR_WOLF_01     = 0x1009,
    M010            = 0x100A, //狼２
    CHR_WOLF_02     = 0x100A,
    M011            = 0x100B, //狼３
    CHR_WOLF_03     = 0x100B,
    M012            = 0x100C, //狼４
    CHR_WOLF_04     = 0x100C,
    M013            = 0x100D, //狼５
    CHR_WOLF_05     = 0x100D,
    M014            = 0x100E, //狼６
    CHR_WOLF_06     = 0x100E,
    M015            = 0x100F, //狼７
    CHR_WOLF_07     = 0x100F,
    M016            = 0x1010, //プリン1,
    CHR_PUDDING_01  = 0x1010,
    M017            = 0x1011, //プリン２
    CHR_PUDDING_02  = 0x1011,
    M018            = 0x1012, //プリン３
    CHR_PUDDING_03  = 0x1012,
    M019            = 0x1013, //プリン４
    CHR_PUDDING_04  = 0x1013,
    M020            = 0x1014, //プリン５
    CHR_PUDDING_05  = 0x1014,
    M021            = 0x1015, //プリン６
    CHR_PUDDING_06  = 0x1015,
    M022            = 0x1016, //トカゲ１
    CHR_LIZARD_01   = 0x1016,
    M023            = 0x1017, //トカゲ２
    CHR_LIZARD_02   = 0x1017,
    M024            = 0x1018, //トカゲ３
    CHR_LIZARD_03   = 0x1018,
    M025            = 0x1019, //トカゲ４
    CHR_LIZARD_04   = 0x1019,
    M026            = 0x101A, //トカゲ５
    CHR_LIZARD_05   = 0x101A,
    M027            = 0x101B, //トカゲ６
    CHR_LIZARD_06   = 0x101B,
    M028            = 0x101C, //鳥１
    CHR_BIRD_01     = 0x101C,
    M029            = 0x101D, //鳥２
    CHR_BIRD_02     = 0x101D,
    M030            = 0x101E, //鳥３
    CHR_BIRD_03     = 0x101E,
    M031            = 0x101F, //虫１
    CHR_INSECT_01   = 0x101F,
    M032            = 0x1020, //虫２
    CHR_INSECT_02   = 0x1020,
    M033            = 0x1021, //虫３
    CHR_INSECT_03   = 0x1021,
    M034            = 0x1022, //虫４
    CHR_INSECT_04   = 0x1022,
    M035            = 0x1023, //アーリマン１
    CHR_ARIMAN_01   = 0x1023,
    M036            = 0x1024, //アーリマン２
    CHR_ARIMAN_02   = 0x1024,
    M037            = 0x1025, //アーリマン３
    CHR_ARIMAN_03   = 0x1025,
    M038            = 0x1026, //アーリマン４
    CHR_ARIMAN_04   = 0x1026,
    M039            = 0x1027, //植物系ザコ１
    CHR_PLANT_01    = 0x1027,
    M040            = 0x1028, //植物系ザコ２
    CHR_PLANT_02    = 0x1028,
    M041            = 0x1029, //サハギン１（水中）
    CHR_SAHAGIN_01  = 0x1029,
    M042            = 0x102A, //サハギン２（水中）
    CHR_M042        = 0x102A,
    M043            = 0x102B, //サハギン２改（陸上）
    CHR_SAHAGIN_02N = 0x102B,
    M044            = 0x102C, //ズー１
    CHR_ZOO_01      = 0x102C,
    M045            = 0x102D, //ズー２
    CHR_ZOO_02      = 0x102D,
    M046            = 0x102E, //サンドウォーム１
    CHR_SAND_01     = 0x102E,
    M047            = 0x102F, //サンドウォーム２
    CHR_SAND_02     = 0x102F,
    M048            = 0x1030, //ゴーレム１
    CHR_GOLEM_01    = 0x1030,
    M049            = 0x1031, //ゴーレム２
    CHR_GOLEM_02    = 0x1031,
    M050            = 0x1032, //ゴースト１
    CHR_GHOST_01    = 0x1032,
    M051            = 0x1033, //フレジアス１
    CHR_FLESIUS_01  = 0x1033,
    M052            = 0x1034, //フレジアス２
    CHR_FLESIUS_02  = 0x1034,
    M053            = 0x1035, //レイジングスパイク１
    CHR_RISING_01   = 0x1035,
    M054            = 0x1036, //レイジングスパイク２
    CHR_RISING_02   = 0x1036,
    M055            = 0x1037, //４本ツノ獣１
    CHR_4SPIKE_01   = 0x1037,
    M056            = 0x1038, //４本ツノ獣２
    CHR_4SPIKE_02   = 0x1038,
    M057            = 0x1039, //４本ツノ獣３
    CHR_4SPIKE_03   = 0x1039,
    M058            = 0x103A, //タコ１
    CHR_TAKO_01     = 0x103A,
    M059            = 0x103B, //中ドラゴン１
    CHR_DRAGON_01   = 0x103B,
    M060            = 0x103C, //中ドラゴン２
    CHR_DRAGON_02   = 0x103C,
    M061            = 0x103D, //中ドラゴン３
    CHR_DRAGON_03   = 0x103D,
    M062            = 0x103E, //中ドラゴン４
    CHR_DRAGON_04   = 0x103E,
    M063            = 0x103F, //中ドラゴン５
    CHR_DRAGON_05   = 0x103F,
    M064            = 0x1040, //モルボル１
    CHR_MORBOL_01   = 0x1040,
    M065            = 0x1041, //モルボル２
    CHR_MORBOL_02   = 0x1041,
    M066            = 0x1042, //４ツ腕格闘家１
    CHR_FIGHTER_01  = 0x1042,
    M067            = 0x1043, //４ツ腕格闘家２
    CHR_FIGHTER_02  = 0x1043,
    M068            = 0x1044, //ピラニア１（１匹）
    CHR_PIRANIA_11  = 0x1044,
    M069            = 0x1045, //ピラニア１（２匹）
    CHR_PIRANIA_12  = 0x1045,
    M070            = 0x1046, //ピラニア１（３匹）
    CHR_PIRANIA_13  = 0x1046,
    M071            = 0x1047, //ピラニア２（１匹）
    CHR_PIRANIA_21  = 0x1047,
    M072            = 0x1048, //ピラニア２（２匹）
    CHR_PIRANIA_22  = 0x1048,
    M073            = 0x1049, //ピラニア２（３匹）
    CHR_PIRANIA_23  = 0x1049,
    M074            = 0x104A, //ピラニア３（１匹）
    CHR_PIRANIA_31  = 0x104A,
    M075            = 0x104B, //ピラニア３（２匹）
    CHR_PIRANIA_32  = 0x104B,
    M076            = 0x104C, //ピラニア３（３匹）
    CHR_PIRANIA_33  = 0x104C,
    M077            = 0x104D, //エレメンタル１ （雷）
    CHR_ELEMENT_01  = 0x104D,
    M078            = 0x104E, //エレメンタル２ （氷）
    CHR_ELEMENT_02  = 0x104E,
    M079            = 0x104F, //エレメンタル３ （炎）
    CHR_ELEMENT_03  = 0x104F,
    M080            = 0x1050, //エレメンタル４ （雷２）
    CHR_ELEMENT_04  = 0x1050,
    M081            = 0x1051, //エレメンタル５ （水）
    CHR_ELEMENT_05  = 0x1051,
    M082            = 0x1052, //エレメンタル６ （闇）
    CHR_ELEMENT_06  = 0x1052,
    M083            = 0x1053, //エレメンタル７ （未定）
    CHR_ELEMENT_07  = 0x1053,
    M084            = 0x1054, //爪モンスター１
    CHR_BLADE_01    = 0x1054,
    M085            = 0x1055, //ベヒーモス
    CHR_BEHI_01     = 0x1055,
    M086            = 0x1056, //キングベヒーモス
    CHR_BEHI_02     = 0x1056,
    M087            = 0x1057, //キマイラ
    CHR_CHIMERA_01  = 0x1057,
    M088            = 0x1058, //キマイラブレイン
    CHR_CHIMERA_02  = 0x1058,
    M089            = 0x1059, //クァール
    CHR_QUAL_01     = 0x1059,
    M090            = 0x105A, //マスタークァール
    CHR_QUAL_02     = 0x105A,
    M091            = 0x105B, //二足歩行メカ１
    CHR_2LEG_01     = 0x105B,
    M092            = 0x105C, //二足歩行メカ２
    CHR_2LEG_02     = 0x105C,
    M093            = 0x105D, //二足歩行メカ２ （燃えてるver.）
    CHR_2LEG_02F    = 0x105D,
    M094            = 0x105E, //二足歩行メカ３
    CHR_2LEG_03     = 0x105E,
    M095            = 0x105F, //デビルモノリス
    CHR_MONOLITH_01 = 0x105F,
    M096            = 0x1060, //四足歩行メカ１
    CHR_4LEG_01     = 0x1060,
    M097            = 0x1061, //四足歩行メカ２
    CHR_4LEG_02     = 0x1061,
    M098            = 0x1062, //四足歩行メカ３
    CHR_4LEG_03     = 0x1062,
    M099            = 0x1063, //アルテマウェポン
    CHR_ULTIMA_01   = 0x1063,
    M100            = 0x1064, //オメガウェポン
    CHR_OMEGA_01    = 0x1064,

    // END   monster1.ath
    // BEGIN monster2.ath

    M101              = 0x1065, //タコ型ボス
    CHR_TAKOBOSS      = 0x1065,
    M102              = 0x1066, //シンから生まれたもの２
    CHR_SHIN2         = 0x1066,
    M103              = 0x1067, //シンから生まれたもの２・触手
    CHR_SHIN2_ARM     = 0x1067,
    M104              = 0x1068, //チョコボイーター
    CHR_EATER         = 0x1068,
    M105              = 0x1069, //カタツムリボス
    CHR_DENDEN        = 0x1069,
    M106              = 0x106A, //魔方陣１
    CHR_MAGICSQ_01    = 0x106A,
    M107              = 0x106B, //シンザコ陸１
    CHR_SHINZ_L1      = 0x106B,
    M108              = 0x106C, //シンザコ陸２
    CHR_SHINZ_L2      = 0x106C,
    M109              = 0x106D, //バージ見張り番
    CHR_BAJIBOSS      = 0x106D,
    M110              = 0x106E, //甲板ボス
    CHR_KIKAI1        = 0x106E,
    M111              = 0x106F, //幻光河ボス
    CHR_KIKAI2        = 0x106F,
    M112              = 0x1070, //キマリ
    CHR_KIMARI_B      = 0x1070,
    M113              = 0x1071, //シン背ビレ
    CHR_SHIN_SE       = 0x1071,
    M114              = 0x1072, //シンからうまれたもの１
    CHR_SHIN1         = 0x1072,
    M115              = 0x1073, //シンザコ水１
    CHR_SHINZ_W1      = 0x1073,
    M116              = 0x1074, //こま犬２
    CHR_INU_02        = 0x1074,
    M117              = 0x1075, //シンから生まれたもの３
    CHR_SHIN3         = 0x1075,
    M118              = 0x1076, //魔方陣２
    CHR_MAGICSQ_02    = 0x1076,
    M119              = 0x1077, //エフレイエ空
    CHR_EF1           = 0x1077,
    M120              = 0x1078, //エフレイエ水
    CHR_EF2           = 0x1078,
    M121              = 0x1079, //マカラーニャ森ボス
    CHR_MAKABOSS      = 0x1079,
    M122              = 0x107A, //カウントダウンボス
    CHR_COUNTDOWN     = 0x107A,
    M123              = 0x107B, //カウントダウンボスビット
    CHR_COUNTDOWNB    = 0x107B,
    M124              = 0x107C, //シーモア
    CHR_SIMOA         = 0x107C,
    M125              = 0x107D, //アニマ
    CHR_ANIMA_B       = 0x107D,
    M126              = 0x107E, //シーモアモンスター１
    CHR_SIMOA01       = 0x107E,
    M127              = 0x107F, //シーモアモンスター１武器
    CHR_SIMOA01_W     = 0x107F,
    M128              = 0x1080, //エボン守護獣１
    CHR_EBON1         = 0x1080,
    M129              = 0x1081, //エボン守護獣３
    CHR_EBON3         = 0x1081,
    M130              = 0x1082, //ユウナレスカ
    CHR_YUNARESKA     = 0x1082,
    M131              = 0x1083, //シン融合シーモア
    CHR_SIMOA03       = 0x1083,
    M132              = 0x1084, //ジェクト
    CHR_JECHT         = 0x1084,
    M133              = 0x1085, //クレーン
    CHR_CRANE         = 0x1085,
    M134              = 0x1086, //ビラン＝ロンゾ
    CHR_BIRAN         = 0x1086,
    M135              = 0x1087, //エンケ＝ロンゾ
    CHR_ENCHE         = 0x1087,
    M136              = 0x1088, //シンの腕１
    CHR_SHIN_ARML     = 0x1088,
    M137              = 0x1089, //シンの腕２
    CHR_SHIN_ARMR     = 0x1089,
    M138              = 0x108A, //シンの背中コア
    CHR_SHIN_BACK     = 0x108A,
    M139              = 0x108B, //シン生２改
    CHR_SHIN2_KAI     = 0x108B,
    M140              = 0x108C, //シン頭
    CHR_SHIN_HEAD     = 0x108C,
    M141              = 0x108D, //グアド族Ｅ
    CHR_GUAD_E        = 0x108D,
    M142              = 0x108E, //シーモアモンスター２
    CHR_SIMOA02       = 0x108E,
    M143              = 0x108F, //シーモアモンスター２武器
    CHR_SIMOA2_W      = 0x108F,
    M144              = 0x1090, //キマリ武器
    CHR_KIMARI_W      = 0x1090,
    M145              = 0x1091, //シンザコ（陸ＬＯＷ）
    CHR_SHINZ_L3      = 0x1091,
    M146              = 0x1092, //移動用ターゲット
    CHR_IDO           = 0x1092,
    M147              = 0x1093, //シンザコ（陸超Ｌ単）
    CHR_SHINZ_L4      = 0x1093,
    M148              = 0x1094, //シンザコ（陸超Ｌ複）
    CHR_SHINZ_L5      = 0x1094,
    M149              = 0x1095, //シド
    CHR_SYD           = 0x1095,
    M150              = 0x1096, //魔方陣３
    CHR_MAGICSQ_03    = 0x1096,
    M151              = 0x1097, //中ドラゴンＥ１
    CHR_DRAGON_E01    = 0x1097,
    M152              = 0x1098, //二足歩行メカＥ１
    CHR_ROBOT_E01     = 0x1098,
    M153              = 0x1099, //オチューＥ１
    CHR_OTYU_E01      = 0x1099,
    M154              = 0x109A, //魔方陣４
    CHR_MAGICSQ_04    = 0x109A,
    M155              = 0x109B, //サハギンＥ１
    CHR_SAHAGIN_E01   = 0x109B,
    M156              = 0x109C, //サハギンＥ２
    CHR_SAHAGIN_E02   = 0x109C,
    M157              = 0x109D, //ズーＥ（小）
    CHR_ZOO_E01       = 0x109D,
    M158              = 0x109E, //爪モンスターe,
    CHR_BLADE_E01     = 0x109E,
    M159              = 0x109F, //コケラミサイル
    CHR_SHIN4         = 0x109F,
    M160              = 0x10A0, //シン生３の頭
    CHR_SHIN3_HEAD    = 0x10A0,
    M161              = 0x10A1, //シン生３の腕
    CHR_SHIN3_ARM     = 0x10A1,
    M162              = 0x10A2, //くさび
    CHR_KUSABI        = 0x10A2,
    M163              = 0x10A3, //ヴァルファーレＥ
    CHR_VALFARE_E     = 0x10A3,
    M164              = 0x10A4, //イフリートＥ
    CHR_IFRIT_E       = 0x10A4,
    M165              = 0x10A5, //イクシオンＥ
    CHR_IXION_E       = 0x10A5,
    M166              = 0x10A6, //シヴァＥ
    CHR_SHIVA_E       = 0x10A6,
    M167              = 0x10A7, //バハムートＥ
    CHR_BAHAMOT_E     = 0x10A7,
    M168              = 0x10A8, //アニマＥ
    CHR_ANIMA_E       = 0x10A8,
    M169              = 0x10A9, //ようじんぼうＥ
    CHR_YOJINBOU_E    = 0x10A9,
    M170              = 0x10AA, //タンクローリー
    CHR_TANK          = 0x10AA,
    M171              = 0x10AB, //くさび２
    CHR_KUSABI2       = 0x10AB,
    M172              = 0x10AC, //ジェクト剣
    CHR_JECHTKEN      = 0x10AC,
    M173              = 0x10AD, //オプション左
    CHR_OPTION_L      = 0x10AD,
    M174              = 0x10AE, //オプション右
    CHR_OPTION_R      = 0x10AE,
    M175              = 0x10AF, //ユウナレスカ触手
    CHR_YUNARESKA_ARM = 0x10AF,
    M176              = 0x10B0, //エボンジュ
    CHR_YEVONJU       = 0x10B0,
    M177              = 0x10B1, //魔方陣５
    CHR_MAGICSQ_05    = 0x10B1,
    M178              = 0x10B2, //マグＥ
    CHR_MAG_E         = 0x10B2,
    M179              = 0x10B3, //ドグＥ
    CHR_DOG_E         = 0x10B3,
    M180              = 0x10B4, //ラグＥ
    CHR_RAG_E         = 0x10B4,

    // END   monster2.ath
    // BEGIN monster3.ath

    M181              = 0x10B5, //鉄巨人１１
    CHR_IRON_11       = 0x10B5,
    M182              = 0x10B6, //鉄巨人１２
    CHR_IRON_12       = 0x10B6,
    M183              = 0x10B7, //鉄巨人２１
    CHR_IRON_21       = 0x10B7,
    M184              = 0x10B8, //鉄巨人２２
    CHR_IRON_22       = 0x10B8,
    M185              = 0x10B9, //バジリスク１
    CHR_BASIL_01      = 0x10B9,
    M186              = 0x10BA, //バジリスク２
    CHR_BASIL_02      = 0x10BA,
    M187              = 0x10BB, //アダマンタイマイ
    CHR_ADMAN_01      = 0x10BB,
    M188              = 0x10BC, //ベリアル１
    CHR_BELIAL_01     = 0x10BC,
    M189              = 0x10BD, //オチュー１
    CHR_OTYUGH_01     = 0x10BD,
    M190              = 0x10BE, //オチュー２
    CHR_OTYUGH_02     = 0x10BE,
    M191              = 0x10BF, //射撃型エボン兵器１
    CHR_F_EBON_01     = 0x10BF,
    M192              = 0x10C0, //射撃型エボン兵器２
    CHR_F_EBON_02     = 0x10C0,
    M193              = 0x10C1, //ボム１
    CHR_BOMB_01       = 0x10C1,
    M194              = 0x10C2, //ボム２
    CHR_BOMB_02       = 0x10C2,
    M195              = 0x10C3, //格闘型エボン兵器１
    CHR_G_EBON_01     = 0x10C3,
    M196              = 0x10C4, //格闘型エボン兵器２
    CHR_G_EBON_02     = 0x10C4,
    M197              = 0x10C5, //エボン僧兵１１
    CHR_S_EBON_11     = 0x10C5,
    M198              = 0x10C6, //エボン僧兵１２
    CHR_S_EBON_12     = 0x10C6,
    M199              = 0x10C7, //エボン僧兵２１
    CHR_S_EBON_21     = 0x10C7,
    M200              = 0x10C8, //エボン僧兵２２
    CHR_S_EBON_22     = 0x10C8,
    M201              = 0x10C9, //コヨコヨ１
    CHR_KOYOKOYO_01   = 0x10C9,
    M202              = 0x10CA, //マジックポットDX
    CHR_MAGICP_01     = 0x10CA,
    M203              = 0x10CB, //マジックポット2（目：ターゲット）
    CHR_MAGICP_02     = 0x10CB,
    M204              = 0x10CC, //マジックポット3（目：ターゲット）
    CHR_MAGICP_03     = 0x10CC,
    M205              = 0x10CD, //マジックポット4（目：ターゲット）
    CHR_MAGICP_04     = 0x10CD,
    M206              = 0x10CE, //マジックポット5（目：ターゲット）
    CHR_MAGICP_05     = 0x10CE,
    M207              = 0x10CF, //サボテンダー？
    CHR_SABO_01       = 0x10CF,
    M208              = 0x10D0, //サボテンダー
    CHR_SABO_02       = 0x10D0,
    M209              = 0x10D1, //ミスト１
    CHR_MIST_01       = 0x10D1,
    M210              = 0x10D2, //ラスダンアーマー１
    CHR_LAST2_01      = 0x10D2,
    M211              = 0x10D3, //宝箱１
    CHR_TREASURE_01   = 0x10D3,
    M212              = 0x10D4, //４ツ腕格闘家３
    CHR_FIGHTER_03    = 0x10D4,
    M213              = 0x10D5, //グアド兵１
    CHR_GUAD_01       = 0x10D5,
    M214              = 0x10D6, //フンゴオンゴ１
    CHR_KINOKO_01     = 0x10D6,
    M215              = 0x10D7, //フンゴオンゴ２
    CHR_KINOKO_02     = 0x10D7,
    M216              = 0x10D8, //フンゴオンゴ３
    CHR_KINOKO_03     = 0x10D8,
    M217              = 0x10D9, //爪モンスター２
    CHR_BLADE_02      = 0x10D9,
    M218              = 0x10DA, //ボム３
    CHR_BOMB_03       = 0x10DA,
    M219              = 0x10DB, //ミスト２
    CHR_MIST_02       = 0x10DB,
    M220              = 0x10DC, //ゴースト２
    CHR_GHOST_02      = 0x10DC,
    M221              = 0x10DD, //植物系ザコ３
    CHR_PLANT_03      = 0x10DD,
    M222              = 0x10DE, //グアド兵２
    CHR_GUAD_02       = 0x10DE,
    M223              = 0x10DF, //トンベリ１
    CHR_TONBERI_01    = 0x10DF,
    M224              = 0x10E0, //トンベリ２
    CHR_TONBERI_02    = 0x10E0,
    M225              = 0x10E1, //アーリマン５
    CHR_ARIMAN_05     = 0x10E1,
    M226              = 0x10E2, //ボム４
    CHR_BOMB_04       = 0x10E2,
    M227              = 0x10E3, //キマイラ３
    CHR_CHIMERA_03    = 0x10E3,
    M228              = 0x10E4, //４本ツノ獣４
    CHR_4SPIKE_04     = 0x10E4,
    M229              = 0x10E5, //ゴーレム３
    CHR_GOLEM_03      = 0x10E5,
    M230              = 0x10E6, //Ｔ_ズー１
    CHR_ZOO_01T       = 0x10E6,
    M231              = 0x10E7, //Ｔ_狼１
    CHR_WOLF_01T      = 0x10E7,
    M232              = 0x10E8, //Ｔ_プリン１
    CHR_PUDDING_01T   = 0x10E8,
    M233              = 0x10E9, //Ｔ_鳥１
    CHR_BIRD_01T      = 0x10E9,
    M234              = 0x10EA, //Ｔ_植物系ザコ１
    CHR_PLANT_01T     = 0x10EA,
    M235              = 0x10EB, //Ｔ_甲羅モンスター１
    CHR_KOURA_01T     = 0x10EB,
    M236              = 0x10EC, //Ｔ_甲羅モンスター２
    CHR_KOURA_02T     = 0x10EC,
    M237              = 0x10ED, //Ｔ_宝箱１
    CHR_TREASURE_01T  = 0x10ED,
    M238              = 0x10EE, //Ｅ_ズー２
    CHR_ZOO_02E       = 0x10EE,
    M239              = 0x10EF, //トカゲ７
    CHR_LIZARD_07     = 0x10EF,
    M240              = 0x10F0, //甲羅モンスター６
    CHR_KOURA_06      = 0x10F0,
    M241              = 0x10F1, //プリン７
    CHR_PUDDING_07    = 0x10F1,
    M242              = 0x10F2, //アーリマン７
    CHR_ARIMAN_07     = 0x10F2,
    M243              = 0x10F3, //ミスト３
    CHR_MIST_03       = 0x10F3,
    M244              = 0x10F4, //爪モンスター３
    CHR_BLADE_03      = 0x10F4,
    M245              = 0x10F5, //トカゲ８
    CHR_LIZARD_08     = 0x10F5,
    M246              = 0x10F6, //甲羅モンスター７
    CHR_KOURA_07      = 0x10F6,
    M247              = 0x10F7, //アーリマン６
    CHR_ARIMAN_06     = 0x10F7,
    M248              = 0x10F8, //イサール１
    CHR_ISAL_01       = 0x10F8,
    M249              = 0x10F9, //ギンネム１
    CHR_GINNEM_01     = 0x10F9,
    M250              = 0x10FA, //ベルゲミーネ１
    CHR_VELGEMINE_01  = 0x10FA,
    M251              = 0x10FB, //ミミック１
    CHR_MIMIX_01      = 0x10FB,
    M252              = 0x10FC, //ミミック２
    CHR_MIMIX_02      = 0x10FC,
    M253              = 0x10FD, //ミミック３
    CHR_MIMIX_03      = 0x10FD,
    M254              = 0x10FE, //ヴァルファーレ１
    CHR_VALFARE_01    = 0x10FE,
    M255              = 0x10FF, //透明ダミー
    CHR_INVI_00       = 0x10FF,
    M256              = 0x1100, //ミミック４
    CHR_MIMIX_04      = 0x1100,
    M257              = 0x1101, //ミミックパーツ０１
    CHR_MPARTS_01     = 0x1101,
    M258              = 0x1102, //ヴァルファーレ２
    CHR_VALFARE_02    = 0x1102,
    M259              = 0x1103, //イフリート２
    CHR_EFREET_02     = 0x1103,
    M260              = 0x1104, //ミミックパーツ０２
    CHR_MPARTS_02     = 0x1104,
    M261              = 0x1105, //ミミックパーツ０３
    CHR_MPARTS_03     = 0x1105,
    M262              = 0x1106, //ミミックパーツ０４
    CHR_MPARTS_04     = 0x1106,
    M263              = 0x1107, //ライフル１
    CHR_RIFLE_01      = 0x1107,
    M264              = 0x1108, //火炎放射器１
    CHR_FLAMEGUN_01   = 0x1108,
    M265              = 0x1109, //アニマ１
    CHR_ANIMA_01      = 0x1109,
    M266              = 0x110A, //こま犬１
    CHR_INU_01        = 0x110A,
    M267              = 0x110B, //アニマ下１
    CHR_ANIMA_DOWN_01 = 0x110B,
    M268              = 0x110C, //アニマ下ＵＰ１
    CHR_ANIMA_UP_01   = 0x110C,
    M269              = 0x110D, //刀１
    CHR_KATANA_01     = 0x110D,
    M270              = 0x110E, //小柄１
    CHR_KODUKA_01     = 0x110E,
    M271              = 0x110F, //手裏剣１
    CHR_SYURIKEN_01   = 0x110F,
    M272              = 0x1110, //牧_シン生３あたま
    M273              = 0x1111, //牧_シン生３うで
    M274              = 0x1112, //ミミックパーツ１８
    CHR_MPARTS_18     = 0x1112,
    M275              = 0x1113, //ミミックパーツ１９
    CHR_MPARTS_19     = 0x1113,
    M276              = 0x1114, //牧_アルテマウェポン
    CHR_B_ULTIMA_01   = 0x1114,
    M277              = 0x1115, //牧_シンから生まれたもの２
    CHR_B_SHIN2       = 0x1115,
    M278              = 0x1116, //牧_シンから生まれたもの２・触手
    CHR_B_SHIN2_ARM   = 0x1116,
    M279              = 0x1117, //牧_チョコボイーター
    CHR_B_EATER       = 0x1117,
    M280              = 0x1118, //牧_シンから生まれたもの３
    CHR_B_SHIN3       = 0x1118,
    M281              = 0x1119, //牧_マカラーニャ森ボス
    CHR_B_MAKABOSS    = 0x1119,
    M282              = 0x111A, //牧_エボン守護獣１
    CHR_B_EBON1       = 0x111A,
    M283              = 0x111B, //牧_エフレイエ（水中）
    CHR_B_EF2         = 0x111B,
    M284              = 0x111C, //イフリート１
    CHR_EFREET_01     = 0x111C,
    M285              = 0x111D, //イクシオン１
    M286              = 0x111E, //シヴァ１
    M287              = 0x111F, //バハムート１
    M288              = 0x1120, //用心棒１
    M289              = 0x1121, //ドグ１
    M290              = 0x1122, //マグ１
    M291              = 0x1123, //ラグ１
    M292              = 0x1124, //牧_甲羅モンスター３
    CHR_B_KOURA_03    = 0x1124,
    M293              = 0x1125, //牧_ガルキマセラ３
    CHR_B_GARUKI_03   = 0x1125,
    M294              = 0x1126, //牧_狼７
    CHR_B_WOLF_07     = 0x1126,
    M295              = 0x1127, //牧_プリン６
    CHR_B_PUDDING_06  = 0x1127,
    M296              = 0x1128, //牧_トカゲ６
    CHR_B_LIZARD_06   = 0x1128,
    M297              = 0x1129, //牧_鳥２
    CHR_B_BIRD_02     = 0x1129,
    M298              = 0x112A, //牧_虫３
    CHR_B_INSECT_03   = 0x112A,
    M299              = 0x112B, //牧_アーリマン３
    CHR_B_ARIMAN_03   = 0x112B,
    M300              = 0x112C, //牧_ズー２
    CHR_B_ZOO_02      = 0x112C,
    M301              = 0x112D, //牧_サンドウォーム２
    CHR_B_SAND_02     = 0x112D,
    M302              = 0x112E, //牧_４本ツノ獣３
    CHR_B_4SPIKE_03   = 0x112E,
    M303              = 0x112F, //牧_中ドラゴン５
    CHR_B_DRAGON_05   = 0x112F,
    M304              = 0x1130, //牧_モルボル２
    CHR_B_MORBOL_01   = 0x1130,
    M305              = 0x1131, //牧_４ツ腕格闘家２
    CHR_B_FIGHTER_02  = 0x1131,
    M306              = 0x1132, //牧_エレメンタル６
    CHR_B_ELEMENT_06  = 0x1132,
    M307              = 0x1133, //牧_ベヒーモス１
    CHR_B_BEHI_01     = 0x1133,
    M308              = 0x1134, //牧_キマイラ２
    CHR_B_CHIMERA_02  = 0x1134,
    M309              = 0x1135, //牧_クァール２
    CHR_B_QUAL_02     = 0x1135,
    M310              = 0x1136, //牧_鉄巨人１２
    CHR_B_IRON_12     = 0x1136,
    M311              = 0x1137, //牧_バジリスク２
    CHR_B_BASIL_02    = 0x1137,
    M312              = 0x1138, //牧_ベリアル１
    CHR_B_BELIAL_01   = 0x1138,
    M313              = 0x1139, //牧_ボム１
    CHR_B_BOMB_01     = 0x1139,
    M314              = 0x113A, //牧_サポテンダー
    CHR_B_SABO_01     = 0x113A,
    M315              = 0x113B, //牧_ラスダンアーマー
    CHR_B_LAST2_01    = 0x113B,
    M316              = 0x113C, //牧_フンゴオンゴ３
    CHR_B_KINOKO_03   = 0x113C,
    M317              = 0x113D, //牧_トンベリ２
    CHR_B_TONBERI_02  = 0x113D,
    M318              = 0x113E, //牧_爪モンスターＥ
    CHR_B_BLADE_E01   = 0x113E,
    M319              = 0x113F, //Ｓ_ボム１
    M320              = 0x1140, //Ｓ_４本ツノ獣１
    M321              = 0x1141, //Ｓ_ズー１
    M322              = 0x1142, //Ｓ_バジリスク１
    M323              = 0x1143, //Ｓ_オチュー１
    M324              = 0x1144, //Ｓ_ミスト１
    M325              = 0x1145, //Ｓ_鉄巨人１１
    M326              = 0x1146, //Ｓ_キマイラ１
    M327              = 0x1147, //Ｓ_爪モンスター１
    M328              = 0x1148, //Ｓ_サボテンダー１
    M329              = 0x1149, //Ｓ_ズー２
    M330              = 0x114A, //Ｓ_サンドウォーム１
    M331              = 0x114B, //Ｓ_ゴースト１
    M332              = 0x114C, //Ｓ_モルボル１
    M333              = 0x114D, //Ｓ_４ツ腕格闘家２
    M334              = 0x114E, //悪ヴァルファーレ
    M335              = 0x114F, //悪イフリート
    M336              = 0x1150, //悪イクシオン
    M337              = 0x1151, //悪シヴァ
    M338              = 0x1152, //悪バハムート
    M339              = 0x1153, //悪アニマ
    M340              = 0x1154, //悪ヨウジンボウ
    M341              = 0x1155, //悪マグ
    M342              = 0x1156, //悪ドグ
    M343              = 0x1157, //悪ラグ

    // END   monster3.ath
    // BEGIN mon.ath

    M344        = 0x1158, //天使本体
    CHR_ANGEL_B = 0x1158,
    M345        = 0x1159, //天使右手
    CHR_ANGEL_R = 0x1159,
    M346        = 0x115A, //天使左手
    CHR_ANGEL_L = 0x115A,
    M999        = 0x13E7, //無
    CHR_ZERO    = 0x13E7
}