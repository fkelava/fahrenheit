using System.Runtime.InteropServices;

namespace Fahrenheit.Core.X;

/* [fkelava 13/9/22 08:11]
 * source: MS Store ver.
 * header: __BATTLE_ATEL__
 *
 * /ffx_ps2/ffx/proj2/chr/ath/battle/btlhead.src
 *
 * Not very useful yet. No signatures exist; only names. And this is _definitely_ not a complete list.
 */

internal class FhAtelBtlExtern
{
#pragma warning disable 0626 // no DllImport attribute on extern definition - true, because we have no idea where these are in FFX.exe yet

    /* [fkelava 15/9/22 01:55]
     * We don't know the actual return types are. I assumed _int_ based on other ATEL functions.
     */

    //[DllImport()]	
    public extern int ATEL_btlOn();

    //[DllImport()]	
    public extern int ATEL_btlOff();

    //[DllImport()]	
    public extern int ATEL_btlOff2();

    //[DllImport()]	
    public extern int ATEL_btlWait();

    //[DllImport()]	
    public extern int ATEL_btlWaitExe();

    //[DllImport()]	
    public extern int ATEL_btlSetSpecialBattle();

    //[DllImport()]	
    public extern int ATEL_btlSetUpVectorFlag();

    //[DllImport()]	
    public extern int ATEL_btlSetCursorType();

    //[DllImport()]	
    public extern int ATEL_btlSetSkipMode();

    //[DllImport()]	
    public extern int ATEL_camReq();

    //[DllImport()]	
    public extern int ATEL_btlReqMotion();

    //[DllImport()]	
    public extern int ATEL_btlReqWeaponMotion();

    //[DllImport()]	
    public extern int ATEL_btlWaitReqMotion();

    //[DllImport()]	
    public extern int ATEL_btlCheckReqMotion();

    //[DllImport()]	
    public extern int ATEL_btlSetMapCenter();

    //[DllImport()]	
    public extern int ATEL_btlSetRandPosFlag();

    //[DllImport()]	
    public extern int ATEL_btlExe();

    //[DllImport()]	
    public extern int ATEL_btlComplete();

    //[DllImport()]	
    public extern int ATEL_btlGetWater();

    //[DllImport()]	
    public extern int ATEL_btlSetDirRate();

    //[DllImport()]	
    public extern int ATEL_btlSetBtlPosDir();

    //[DllImport()]	
    public extern int ATEL_btlDistTarget();

    //[DllImport()]	
    public extern int ATEL_btlDistTarget2();

    //[DllImport()]	
    public extern int ATEL_btlDistTargetFrame();

    //[DllImport()]	
    public extern int ATEL_btlDistTargetFrame2();

    //[DllImport()]	
    public extern int ATEL_btlDistTargetFrameSpd();

    //[DllImport()]	
    public extern int ATEL_btlDistTargetFrameBall();

    //[DllImport()]	
    public extern int ATEL_btlSetMotion();

    //[DllImport()]	
    public extern int ATEL_btlSetMotion2();

    //[DllImport()]	
    public extern int ATEL_btlSetMotionAbs();

    //[DllImport()]	
    public extern int ATEL_btlSetDamageMotion();

    //[DllImport()]	
    public extern int ATEL_btlWaitMotion();

    //[DllImport()]	
    public extern int ATEL_btlWaitMotion_avoid();

    //[DllImport()]	
    public extern int ATEL_btlCheckMotion();

    //[DllImport()]	
    public extern int ATEL_btlStartMotion();

    //[DllImport()]	
    public extern int ATEL_btlCheckMotionNum();

    //[DllImport()]	
    public extern int ATEL_btlCheckDefenseMotion();

    //[DllImport()]	
    public extern int ATEL_btlResetMotionSpeed();

    //[DllImport()]	
    public extern int ATEL_btlFaseTarget();

    //[DllImport()]	
    public extern int ATEL_btlFaseTargetXYZ();

    //[DllImport()]	
    public extern int ATEL_btlSetShadowHeight();

    //[DllImport()]	
    public extern int ATEL_btlSetMotionSignal();

    //[DllImport()]	
    public extern int ATEL_btlSetTexAnime();

    //[DllImport()]	
    public extern int ATEL_btlTerminateAction();

    //[DllImport()]	
    public extern int ATEL_btlTerminateEffect();

    //[DllImport()]	
    public extern int ATEL_btlTerminateDeath();

    //[DllImport()]	
    public extern int ATEL_btlTerminateStone();

    //[DllImport()]	
    public extern int ATEL_btlTerminateMotion();

    //[DllImport()]	
    public extern int ATEL_btlGetStat();

    //[DllImport()]	
    public extern int ATEL_btlGetStat2();

    //[DllImport()]	
    public extern int ATEL_btlSetStat();

    //[DllImport()]	
    public extern int ATEL_btlSetStat2();

    //[DllImport()]	
    public extern int ATEL_btlGetMotionData();

    //[DllImport()]	
    public extern int ATEL_btlGetMotionData2();

    //[DllImport()]	
    public extern int ATEL_btlSetMotionData();

    //[DllImport()]	
    public extern int ATEL_btlSetMotionData2();

    //[DllImport()]	
    public extern int ATEL_btlResetParam();

    //[DllImport()]	
    public extern int ATEL_btlSetDirectCommand();

    //[DllImport()]	
    public extern int ATEL_btlSetAbsCommand();

    //[DllImport()]	
    public extern int ATEL_btlSetDeathCommand();

    //[DllImport()]	
    public extern int ATEL_btlSetSummonGameOver();

    //[DllImport()]	
    public extern int ATEL_btlSetCounterFlag();

    //[DllImport()]	
    public extern int ATEL_btlSetRandomTarget();

    //[DllImport()]	
    public extern int ATEL_btlGetCommandTarget();

    //[DllImport()]	
    public extern int ATEL_btlGetCommandTargetSearch();

    //[DllImport()]	
    public extern int ATEL_btlCheckUseCommand();

    //[DllImport()]	
    public extern int ATEL_btlCheckGetCommand();

    //[DllImport()]	
    public extern int ATEL_btlInitCommandBuffer();

    //[DllImport()]	
    public extern int ATEL_btlSetCommandBuffer();

    //[DllImport()]	
    public extern int ATEL_btlGetCommandBuffer();

    //[DllImport()]	
    public extern int ATEL_btlCameraMode();

    //[DllImport()]	
    public extern int ATEL_btlSetCameraSelectMode();

    //[DllImport()]	
    public extern int ATEL_btlPrint();

    //[DllImport()]	
    public extern int ATEL_btlPrintSp();

    //[DllImport()]	
    public extern int ATEL_btlPrintF();

    //[DllImport()]	
    public extern int ATEL_btlGetReaction();

    //[DllImport()]	
    public extern int ATEL_btlGetNormalAttack();

    //[DllImport()]	
    public extern int ATEL_btlGetReCom();

    //[DllImport()]	
    public extern int ATEL_btlGetComInfo();

    //[DllImport()]	
    public extern int ATEL_btlGetComInfo2();

    //[DllImport()]	
    public extern int ATEL_btlSetCommandUse();

    //[DllImport()]	
    public extern int ATEL_btlGetAssumeDamage();

    //[DllImport()]	
    public extern int ATEL_btlChangeReCom();

    //[DllImport()]	
    public extern int ATEL_btlCountChr();

    //[DllImport()]	
    public extern int ATEL_btlGetChrNum();

    //[DllImport()]	
    public extern int ATEL_btlGetChrNum2();

    //[DllImport()]	
    public extern int ATEL_btlChangeChrName();

    //[DllImport()]	
    public extern int ATEL_btlChangeChrNameID();

    //[DllImport()]	
    public extern int ATEL_btlGetReflect();

    //[DllImport()]	
    public extern int ATEL_btlSetEscape();

    //[DllImport()]	
    public extern int ATEL_btlCheckWakkaWeapon();

    //[DllImport()]	
    public extern int ATEL_btlEquipWakkaWeapon();

    //[DllImport()]	
    public extern int ATEL_btlSetSummoner();

    //[DllImport()]	
    public extern int ATEL_btlSetAnimaChainOff();

    //[DllImport()]	
    public extern int ATEL_btlGetAnimaChainOff();

    //[DllImport()]	
    public extern int ATEL_btlExeAnimaChainOff();

    //[DllImport()]	
    public extern int ATEL_btlSetDebugCount();

    //[DllImport()]	
    public extern int ATEL_btlGetCameraCount();

    //[DllImport()]	
    public extern int ATEL_btlGetEffectMemory();

    //[DllImport()]	
    public extern int ATEL_btlGetWakkaLimitSkill();

    //[DllImport()]	
    public extern int ATEL_btlGetWakkaLimitNum();

    //[DllImport()]	
    public extern int ATEL_btlSetFirstAttack();

    //[DllImport()]	
    public extern int ATEL_btlGetFirstAttack();

    //[DllImport()]	
    public extern int ATEL_btlGetComNum();

    //[DllImport()]	
    public extern int ATEL_btlSetDamage();

    //[DllImport()]	
    public extern int ATEL_btlGetBtlScene();

    //[DllImport()]	
    public extern int ATEL_btlCheckBtlScene();

    //[DllImport()]	
    public extern int ATEL_btlAddCom();

    //[DllImport()]	
    public extern int ATEL_btlDelCom();

    //[DllImport()]	
    public extern int ATEL_btlMouseOn();

    //[DllImport()]	
    public extern int ATEL_btlMouseOff();

    //[DllImport()]	
    public extern int ATEL_btlSetMotionLevel();

    //[DllImport()]	
    public extern int ATEL_btlGetMotionLevel();

    //[DllImport()]	
    public extern int ATEL_btlSetDeathLevel();

    //[DllImport()]	
    public extern int ATEL_btlSetHeight();

    //[DllImport()]	
    public extern int ATEL_btlSetGravity();

    //[DllImport()]	
    public extern int ATEL_btlSetFly();

    //[DllImport()]	
    public extern int ATEL_btlSetScale();

    //[DllImport()]	
    public extern int ATEL_btlSetBindScale();

    //[DllImport()]	
    public extern int ATEL_btlSetEnMapID();

    //[DllImport()]	
    public extern int ATEL_btlSetBodyHit();

    //[DllImport()]	
    public extern int ATEL_btlSetModelHide();

    //[DllImport()]	
    public extern int ATEL_btlSetAppear();

    //[DllImport()]	
    public extern int ATEL_btlGetGold();

    //[DllImport()]	
    public extern int ATEL_btlGetYoujinboType();

    //[DllImport()]	
    public extern int ATEL_btlSetYoujinboType();

    //[DllImport()]	
    public extern int ATEL_btlGetYoujinboRandom();

    //[DllImport()]	
    public extern int ATEL_btlGetYoujinboCommand();

    //[DllImport()]	
    public extern int ATEL_btlCheckMegasRandom();

    //[DllImport()]	
    public extern int ATEL_btlSetMegasRandomCommand();

    //[DllImport()]	
    public extern int ATEL_btlGetMegasRandomCommand();

    //[DllImport()]	
    public extern int ATEL_btlOut();

    //[DllImport()]	
    public extern int ATEL_btlSetHoming();

    //[DllImport()]	
    public extern int ATEL_btlMoveTargetDist();

    //[DllImport()]	
    public extern int ATEL_btlMoveTargetDist2D();

    //[DllImport()]	
    public extern int ATEL_btlGetGroundDist();

    //[DllImport()]	
    public extern int ATEL_btlResetMove();

    //[DllImport()]	
    public extern int ATEL_btlMove();

    //[DllImport()]	
    public extern int ATEL_btlMoveAttack();

    //[DllImport()]	
    public extern int ATEL_btlMoveJump();

    //[DllImport()]	
    public extern int ATEL_btlMoveLeave();

    //[DllImport()]	
    public extern int ATEL_btlDirTarget();

    //[DllImport()]	
    public extern int ATEL_btlDirBasic();

    //[DllImport()]	
    public extern int ATEL_btlDirBasic2();

    //[DllImport()]	
    public extern int ATEL_btlDirMove();

    //[DllImport()]	
    public extern int ATEL_btlDirMove2();

    //[DllImport()]	
    public extern int ATEL_btlDirResetLeave();

    //[DllImport()]	
    public extern int ATEL_btlCheckDirFlag();

    //[DllImport()]	
    public extern int ATEL_btlDirPos();

    //[DllImport()]	
    public extern int ATEL_btlDirPosBasic();

    //[DllImport()]	
    public extern int ATEL_btlDirPosBasic2();

    //[DllImport()]	
    public extern int ATEL_btlGetTargetDir();

    //[DllImport()]	
    public extern int ATEL_btlGetTargetDirH();

    //[DllImport()]	
    public extern int ATEL_btlGetChrTargetDir();

    //[DllImport()]	
    public extern int ATEL_btlGetChrTargetDir2();

    //[DllImport()]	
    public extern int ATEL_btlGetChrDir();

    //[DllImport()]	
    public extern int ATEL_btlSetWeak();

    //[DllImport()]	
    public extern int ATEL_btlGetWeak();

    //[DllImport()]	
    public extern int ATEL_btlCheckMove();

    //[DllImport()]	
    public extern int ATEL_btlChrLink();

    //[DllImport()]	
    public extern int ATEL_btlSetChrPosElem();

    //[DllImport()]	
    public extern int ATEL_btlSetBtlPos();

    //[DllImport()]	
    public extern int ATEL_btlGetMoveFlag();

    //[DllImport()]	
    public extern int ATEL_btlCheckBtlPos();

    //[DllImport()]	
    public extern int ATEL_btlCheckBtlPos2();

    //[DllImport()]	
    public extern int ATEL_btlCheckRetBtlPos();

    //[DllImport()]	
    public extern int ATEL_btlCheckTargetOwn();

    //[DllImport()]	
    public extern int ATEL_btlSetOwnTarget();

    //[DllImport()]	
    public extern int ATEL_btlAddOwnTarget();

    //[DllImport()]	
    public extern int ATEL_btlSubOwnTarget();

    //[DllImport()]	
    public extern int ATEL_btlSetTrans();

    //[DllImport()]	
    public extern int ATEL_btlSetTransVisible();

    //[DllImport()]	
    public extern int ATEL_btlGetMoveFrameRest();

    //[DllImport()]	
    public extern int ATEL_btlCheckPoison();

    //[DllImport()]	
    public extern int ATEL_btlGetChrPosY();

    //[DllImport()]	
    public extern int ATEL_btlGetHeight();

    //[DllImport()]	
    public extern int ATEL_btlGetItemNum();

    //[DllImport()]	
    public extern int ATEL_btlGetItem();

    //[DllImport()]	
    public extern int ATEL_btlSplineStart();

    //[DllImport()]	
    public extern int ATEL_btlSplineRegist();

    //[DllImport()]	
    public extern int ATEL_btlSplineRegistPos();

    //[DllImport()]	
    public extern int ATEL_btlSplineMove();

    //[DllImport()]	
    public extern int ATEL_btlBallSplineMove();

    //[DllImport()]	
    public extern int ATEL_btlGetCameraBuffer();

    //[DllImport()]	
    public extern int ATEL_btlGetCameraBufferFloat();

    //[DllImport()]	
    public extern int ATEL_btlSetCriticalEffect();

    //[DllImport()]	
    public extern int ATEL_btlSetHitEffect();

    //[DllImport()]	
    public extern int ATEL_btlSetNormalEffect();

    //[DllImport()]	
    public extern int ATEL_btlSetFreeEffect();

    //[DllImport()]	
    public extern int ATEL_btlSetAfterImage();

    //[DllImport()]	
    public extern int ATEL_btlWaitHitEffect();

    //[DllImport()]	
    public extern int ATEL_btlWaitNormalEffect();

    //[DllImport()]	
    public extern int ATEL_btlSetHitEff();

    //[DllImport()]	
    public extern int ATEL_btlSetNomEff();

    //[DllImport()]	
    public extern int ATEL_btlSetNomEffReg();

    //[DllImport()]	
    public extern int ATEL_btlSetHitEffReg();

    //[DllImport()]	
    public extern int ATEL_btlWaitHitEff();

    //[DllImport()]	
    public extern int ATEL_btlWaitNomEff();

    //[DllImport()]	
    public extern int ATEL_btlGetHitEff();

    //[DllImport()]	
    public extern int ATEL_btlGetNomEff();

    //[DllImport()]	
    public extern int ATEL_btlSendEffSignal();

    //[DllImport()]	
    public extern int ATEL_btlSetCommandEffect();

    //[DllImport()]	
    public extern int ATEL_btlWaitStone();

    //[DllImport()]	
    public extern int ATEL_btlSetSummonDefenseEffect();

    //[DllImport()]	
    public extern int ATEL_btlSetBindEffect();

    //[DllImport()]	
    public extern int ATEL_btlResetBindEffect();

    //[DllImport()]	
    public extern int ATEL_btlResetAfterImage();

    //[DllImport()]	
    public extern int ATEL_btlSetStatEff();

    //[DllImport()]	
    public extern int ATEL_btlClearStatEff();

    //[DllImport()]	
    public extern int ATEL_btlSetCameraStandard();

    //[DllImport()]	
    public extern int ATEL_btlSetWind();

    //[DllImport()]	
    public extern int ATEL_btlGetCamWidth();

    //[DllImport()]	
    public extern int ATEL_btlGetCamHeight();

    //[DllImport()]	
    public extern int ATEL_btlGetCamWidth2();

    //[DllImport()]	
    public extern int ATEL_btlGetCamHeight2();

    //[DllImport()]	
    public extern int ATEL_btlSetUpLimit();

    //[DllImport()]	
    public extern int ATEL_btlSetUpLimit2();

    //[DllImport()]	
    public extern int ATEL_btlGetReverbe();

    //[DllImport()]	
    public extern int ATEL_btlVoiceStandby();

    //[DllImport()]	
    public extern int ATEL_btlVoiceStart();

    //[DllImport()]	
    public extern int ATEL_btlVoiceStop();

    //[DllImport()]	
    public extern int ATEL_btlGetVoiceStatus();

    //[DllImport()]	
    public extern int ATEL_btlVoiceSync();

    //[DllImport()]	
    public extern int ATEL_btlReqVoice();

    //[DllImport()]	
    public extern int ATEL_btlVoiceSet();

    //[DllImport()]	
    public extern int ATEL_btlSoundStreamNormal();

    //[DllImport()]	
    public extern int ATEL_btlSoundEffectNormal();

    //[DllImport()]	
    public extern int ATEL_btlSoundEffect();

    //[DllImport()]	
    public extern int ATEL_btlSoundEffect2();

    //[DllImport()]	
    public extern int ATEL_btlSoundEffect3();

    //[DllImport()]	
    public extern int ATEL_btlSoundEffectFade();

    //[DllImport()]	
    public extern int ATEL_btlRegSoundEffect();

    //[DllImport()]	
    public extern int ATEL_btlRegSoundEffect2();

    //[DllImport()]	
    public extern int ATEL_btlRegSoundEffect3();

    //[DllImport()]	
    public extern int ATEL_btlRegSoundEffectFade();

    //[DllImport()]	
    public extern int ATEL_btlWaitSound();

    //[DllImport()]	
    public extern int ATEL_btlStatusOn();

    //[DllImport()]	
    public extern int ATEL_btlStatusOff();

    //[DllImport()]	
    public extern int ATEL_btlGetCalcResult();

    //[DllImport()]	
    public extern int ATEL_btlGetCalcResultLimit();

    //[DllImport()]	
    public extern int ATEL_btlGetLastActionChr();

    //[DllImport()]	
    public extern int ATEL_btlGetLastDeathChr();

    //[DllImport()]	
    public extern int ATEL_btlGetVoiceFlag();
#pragma warning restore 0626
}