using System.Runtime.InteropServices;

namespace Fahrenheit.Core.X;

/* [fkelava 13/9/22 08:11]
 * source: MS Store ver.
 * header: __ATEL_FUNCTION_LIST_6__
 *
 * /ffx_ps2/ffx/proj2/chr/ath/battle/atelcam.ath
 */

internal unsafe class FhAtelCamExtern
{
#pragma warning disable 0626 // no DllImport attribute on extern definition - true, because we have no idea where these are in FFX.exe yet
    //[DllImport()]	
    public extern int ATEL6_camSleep(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camWakeUp(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camSetPos(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_camGetPos(float* arg1, float* arg2, float* arg3);

    //[DllImport()]	
    public extern int ATEL6_camSetPolar(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_camSetPolarOffset(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_camSetHypot(float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_camSetHypot2(float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_camSetHypot3(float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_camSetAct(int arg1, int arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_camSetFilter(float arg1, float arg2, float arg3, float arg4, float arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetFilter2(float arg1, float arg2, float arg3, float arg4, float arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetFilterY(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_camSetFilterY2(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_camSleepFilter(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camResetFilter();

    //[DllImport()]	
    public extern int ATEL6_camMove(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camMovePolar(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camMoveCos(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camMovePolarCos(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camMoveAcc(int arg1, int arg2, int arg3, int arg4);

    //[DllImport()]	
    public extern int ATEL6_camMovePolarAcc(int arg1, int arg2, int arg3, int arg4);

    //[DllImport()]	
    public extern int ATEL6_camResetMove();

    //[DllImport()]	
    public extern int ATEL6_camSetInertia(float arg1, float arg2, float arg3, float arg4);

    //[DllImport()]	
    public extern int ATEL6_camSetDirVector(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_camResetDirVector();

    //[DllImport()]	
    public extern int ATEL6_camWait();

    //[DllImport()]	
    public extern int ATEL6_camCheck();

    //[DllImport()]	
    public extern int ATEL6_camSetDataPoint(int* arg1, float arg2);

    //[DllImport()]	
    public extern int ATEL6_camSetDataPointHypot(int* arg1, float arg2, float arg3, float arg4);

    //[DllImport()]	
    public extern int ATEL6_camSetDataPoint2(int* arg1, float arg2);

    //[DllImport()]	
    public extern int ATEL6_camSetDataPointHypot2(int* arg1, float arg2, float arg3, float arg4);

    //[DllImport()]	
    public extern int ATEL6_refSetPos(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_refGetPos(float* arg1, float* arg2, float* arg3);

    //[DllImport()]	
    public extern int ATEL6_refSetPolar(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_refSetPolarOffset(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_refSetHypot(float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_refSetHypot2(float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_refSetHypot3(float arg1, float arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_refSetAct(int arg1, int arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_refSetFilter(float arg1, float arg2, float arg3, float arg4, float arg5);

    //[DllImport()]	
    public extern int ATEL6_refSetFilter2(float arg1, float arg2, float arg3, float arg4, float arg5);

    //[DllImport()]	
    public extern int ATEL6_refSetFilterY(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_refSetFilterY2(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_refSleepFilter(int arg1);

    //[DllImport()]	
    public extern int ATEL6_refResetFilter();

    //[DllImport()]	
    public extern int ATEL6_refMove(int arg1);

    //[DllImport()]	
    public extern int ATEL6_refMovePolar(int arg1);

    //[DllImport()]	
    public extern int ATEL6_refMoveCos(int arg1);

    //[DllImport()]	
    public extern int ATEL6_refMovePolarCos(int arg1);

    //[DllImport()]	
    public extern int ATEL6_refMoveAcc(int arg1, int arg2, int arg3, int arg4);

    //[DllImport()]	
    public extern int ATEL6_refMovePolarAcc(int arg1, int arg2, int arg3, int arg4);

    //[DllImport()]	
    public extern int ATEL6_refResetMove();

    //[DllImport()]	
    public extern int ATEL6_refSetInertia(float arg1, float arg2, float arg3, float arg4);

    //[DllImport()]	
    public extern int ATEL6_refSetDirVector(float arg1, float arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_refResetDirVector();

    //[DllImport()]	
    public extern int ATEL6_refWait();

    //[DllImport()]	
    public extern int ATEL6_refCheck();

    //[DllImport()]	
    public extern int ATEL6_camSetRoll(float arg1);

    //[DllImport()]	
    public extern int ATEL6_camSetScrDpt(float arg1);

    //[DllImport()]	
    public extern int ATEL6_camSetAct2(float arg1, float arg2, float arg3, float arg4);

    //[DllImport()]	
    public extern int ATEL6_refSetAct2(float arg1, float arg2, float arg3, float arg4);

    //[DllImport()]	
    public extern int ATEL6_camSetBtl(int arg1, int arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_refSetBtl(int arg1, int arg2, float arg3);

    //[DllImport()]	
    public extern int ATEL6_camSetBtlPolar(int arg1, int arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_refSetBtlPolar(int arg1, int arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_refMoveStat(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camMoveStat(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camSetBtlPolar2(int arg1, int arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_refSetBtlPolar2(int arg1, int arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_camSetSpline(int arg1, float arg2, float arg3, int arg4);

    //[DllImport()]	
    public extern int ATEL6_refSetSpline(int arg1, float arg2, float arg3, int arg4);

    //[DllImport()]	
    public extern int ATEL6_camStartSpline();

    //[DllImport()]	
    public extern int ATEL6_camRegSpline();

    //[DllImport()]	
    public extern int ATEL6_refStartSpline();

    //[DllImport()]	
    public extern int ATEL6_refRegSpline();

    //[DllImport()]	
    public extern int ATEL6_camSetChrPolar(int arg1, int arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_camSetChrPolar2(int arg1, int arg2, float arg3, float arg4, float arg5, float arg6);

    //[DllImport()]	
    public extern int ATEL6_camScrSet(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6);

    //[DllImport()]	
    public extern int ATEL6_camScrOff(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camDrawSet(int arg1, int arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camDrawLink(int arg1, int arg2);

    //[DllImport()]	
    public extern int ATEL6_camScrLink(int arg1, int arg2);

    //[DllImport()]	
    public extern int ATEL6_camScrMove(int arg1, int arg2);

    //[DllImport()]	
    public extern int ATEL6_camScrMoveCos(int arg1, int arg2);

    //[DllImport()]	
    public extern int ATEL6_camScrMoveAcc(int arg1, int arg2, int arg3, int arg4);

    //[DllImport()]	
    public extern int ATEL6_camDrawMove(int arg1, int arg2);

    //[DllImport()]	
    public extern int ATEL6_camDrawMoveCos(int arg1, int arg2);

    //[DllImport()]	
    public extern int ATEL6_camDrawMoveAcc(int arg1, int arg2, int arg3, int arg4);

    //[DllImport()]	
    public extern int ATEL6_refSetSplineFilter(int* arg1, int arg2);

    //[DllImport()]	
    public extern int ATEL6_refSetSplineFilter2(int* arg1, float arg2, int arg3);

    //[DllImport()]	
    public extern int ATEL6_camSetSpline2(int* arg1, int arg2);

    //[DllImport()]	
    public extern int ATEL6_refSetShake(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetShake(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetScreenShake(int arg1, int arg2, float arg3, int arg4, int arg5, int arg6);

    //[DllImport()]	
    public extern int ATEL6_refResetShake();

    //[DllImport()]	
    public extern int ATEL6_camResetShake();

    //[DllImport()]	
    public extern int ATEL6_camResetScreenShake(int arg1);

    //[DllImport()]	
    public extern int ATEL6_refWaitShake();

    //[DllImport()]	
    public extern int ATEL6_camWaitShake();

    //[DllImport()]	
    public extern int ATEL6_camWaitScreenShake(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camPriority(int arg1);

    //[DllImport()]	
    public extern int ATEL6_refSetShakeB(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetShakeB(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetScreenShakeB(int arg1, int arg2, float arg3, int arg4, int arg5, int arg6);

    //[DllImport()]	
    public extern int ATEL6_refSetShake2(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetShake2(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetScreenShake2(int arg1, int arg2, float arg3, int arg4, int arg5, int arg6);

    //[DllImport()]	
    public extern int ATEL6_refSetShake2B(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetShake2B(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetScreenShake2B(int arg1, int arg2, float arg3, int arg4, int arg5, int arg6);

    //[DllImport()]	
    public extern int ATEL6_refSetShake3(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetShake3(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetScreenShake3(int arg1, int arg2, float arg3, int arg4, int arg5, int arg6);

    //[DllImport()]	
    public extern int ATEL6_refSetShake3B(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetShake3B(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetScreenShake3B(int arg1, int arg2, float arg3, int arg4, int arg5, int arg6);

    //[DllImport()]	
    public extern int ATEL6_camScrSetCam(int arg1, int arg2);

    //[DllImport()]	
    public extern int ATEL6_camFreeBattle();

    //[DllImport()]	
    public extern float ATEL6_camGetRoll();

    //[DllImport()]	
    public extern float ATEL6_camGetScrDpt();

    //[DllImport()]	
    public extern int ATEL6_camScrResetMove(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camDrawResetMove(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camScrWait(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camDrawWait(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camBlur(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camFocus(int arg1);

    //[DllImport()]	
    public extern int ATEL6_camSetFocus(int arg1, int arg2);

    //[DllImport()]	
    public extern int ATEL6_camRand(int arg1);

    //[DllImport()]	
    public extern int ATEL6_refSetShake4(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetShake4(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_refSetShake5(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camSetShake5(int arg1, float arg2, int arg3, int arg4, int arg5);

    //[DllImport()]	
    public extern int ATEL6_camGetRealPos(float* arg1, float* arg2, float* arg3);

    //[DllImport()]	
    public extern int ATEL6_refGetRealPos(float* arg1, float* arg2, float* arg3);

    //[DllImport()]	
    public extern int ATEL6_refReset();

    //[DllImport()]	
    public extern int ATEL6_camReset();
#pragma warning restore 0626
}