/* [fkelava 20/9/22 14:50]
 * A dirty workaround to permit the usage of records in .NET Standard.
 * v. https://stackoverflow.com/a/67687186
 */

using System.ComponentModel;

namespace System.Runtime.CompilerServices;

/// <summary>
/// Reserved to be used by the compiler for tracking metadata.
/// This class should not be used by developers in source code.
/// This dummy class is required to compile records when targeting .NET Standard.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
internal static class IsExternalInit
{
}