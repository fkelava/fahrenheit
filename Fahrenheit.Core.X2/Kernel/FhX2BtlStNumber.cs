using System.Runtime.InteropServices;

namespace Fahrenheit.Core.X2.Kernel;

/* [fkelava 13/9/22 08:11]
 * source: MS Store ver.
 * header: header_btl_st_number
 *
 * /ffx_ps2/ffx2/master/jppc/battle/kernel/st_number.h
 */

[StructLayout(LayoutKind.Sequential)]
internal struct FhX2BtlStNumber
{
    public readonly byte   Category;
    public readonly byte   Type;
    public readonly ushort CommandName;
}