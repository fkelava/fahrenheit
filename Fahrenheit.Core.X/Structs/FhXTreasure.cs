namespace Fahrenheit.Core.X.Structs;

/* e.g. takara.bin entry 0
 * type      - 00
 * number    - 04
 * item_name - 00 20
 */
internal struct FhXTreasure
{
    public byte   Type;
    public byte   Number;
    public ushort ItemName;
}