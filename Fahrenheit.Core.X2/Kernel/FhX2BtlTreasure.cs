using System.Runtime.InteropServices;

namespace Fahrenheit.Core.X2.Kernel;

/* [fkelava 13/9/22 08:11]
 * source: MS Store ver.
 * header: header_btl_takara
 *
 * /ffx_ps2/ffx2/master/jppc/battle/kernel/takara.h
 */

[StructLayout(LayoutKind.Sequential)]
internal struct FhX2BtlTreasure
{
    public readonly byte   Type;
    public readonly byte   Number;
    public readonly ushort ItemName;
}