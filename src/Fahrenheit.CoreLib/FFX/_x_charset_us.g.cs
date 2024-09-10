// Deprecated until further notice.

/* [dedit 21/5/23 14:35]
 * This file was generated by Fahrenheit.DEdit (https://github.com/fkelava/fahrenheit/).
 *
 * Source file: ffxsjistbl_us.bin
 */

namespace Fahrenheit.CoreLib;

public abstract partial class FhCharset {
    public static FhCharsetUs Us = new FhCharsetUs();
}

public sealed class FhCharsetUs : FhCharset {
    public override byte ToByte(char c) {
        return c switch {
            '0' => 0x30, // 30
            '1' => 0x31, // 31
            '2' => 0x32, // 32
            '3' => 0x33, // 33
            '4' => 0x34, // 34
            '5' => 0x35, // 35
            '6' => 0x36, // 36
            '7' => 0x37, // 37
            '8' => 0x38, // 38
            '9' => 0x39, // 39
            ' ' => 0x3A, // 20
            '!' => 0x3B, // 21
            '”' => 0x3C, // E2809D
            '#' => 0x3D, // 23
            '$' => 0x3E, // 24
            '%' => 0x3F, // 25
            '&' => 0x40, // 26
            '’' => 0x41, // E28099
            '(' => 0x42, // 28
            ')' => 0x43, // 29
            '*' => 0x44, // 2A
            '+' => 0x45, // 2B
            ',' => 0x46, // 2C
            '-' => 0x47, // 2D
            '.' => 0x48, // 2E
            '/' => 0x49, // 2F
            ':' => 0x4A, // 3A
            ';' => 0x4B, // 3B
            '<' => 0x4C, // 3C
            '=' => 0x4D, // 3D
            '>' => 0x4E, // 3E
            '?' => 0x4F, // 3F
            'A' => 0x50, // 41
            'B' => 0x51, // 42
            'C' => 0x52, // 43
            'D' => 0x53, // 44
            'E' => 0x54, // 45
            'F' => 0x55, // 46
            'G' => 0x56, // 47
            'H' => 0x57, // 48
            'I' => 0x58, // 49
            'J' => 0x59, // 4A
            'K' => 0x5A, // 4B
            'L' => 0x5B, // 4C
            'M' => 0x5C, // 4D
            'N' => 0x5D, // 4E
            'O' => 0x5E, // 4F
            'P' => 0x5F, // 50
            'Q' => 0x60, // 51
            'R' => 0x61, // 52
            'S' => 0x62, // 53
            'T' => 0x63, // 54
            'U' => 0x64, // 55
            'V' => 0x65, // 56
            'W' => 0x66, // 57
            'X' => 0x67, // 58
            'Y' => 0x68, // 59
            'Z' => 0x69, // 5A
            '[' => 0x6A, // 5B
            '\\' => 0x6B, // 5C
            ']' => 0x6C, // 5D
            '^' => 0x6D, // 5E
            '_' => 0x6E, // 5F
            '‘' => 0x6F, // E28098
            'a' => 0x70, // 61
            'b' => 0x71, // 62
            'c' => 0x72, // 63
            'd' => 0x73, // 64
            'e' => 0x74, // 65
            'f' => 0x75, // 66
            'g' => 0x76, // 67
            'h' => 0x77, // 68
            'i' => 0x78, // 69
            'j' => 0x79, // 6A
            'k' => 0x7A, // 6B
            'l' => 0x7B, // 6C
            'm' => 0x7C, // 6D
            'n' => 0x7D, // 6E
            'o' => 0x7E, // 6F
            'p' => 0x7F, // 70
            'q' => 0x80, // 71
            'r' => 0x81, // 72
            's' => 0x82, // 73
            't' => 0x83, // 74
            'u' => 0x84, // 75
            'v' => 0x85, // 76
            'w' => 0x86, // 77
            'x' => 0x87, // 78
            'y' => 0x88, // 79
            'z' => 0x89, // 7A
            '{' => 0x8A, // 7B
            '|' => 0x8B, // 7C
            '}' => 0x8C, // 7D
            '~' => 0x8D, // 7E
            '·' => 0x8E, // C2B7
            '【' => 0x8F, // E38090
            '】' => 0x90, // E38091
            '♪' => 0x91, // E299AA
            '♥' => 0x92, // E299A5
            // ' ' => 0x93, // duplicate of 0x3A
            '“' => 0x94, // E2809C
            // '”' => 0x95, // duplicate of 0x3C
            '—' => 0x96, // E28094
            // ' ' => 0x97, // duplicate of 0x3A
            '¡' => 0x98, // C2A1
            '↑' => 0x99, // E28691
            '↓' => 0x9A, // E28693
            '←' => 0x9B, // E28690
            '→' => 0x9C, // E28692
            '¨' => 0x9D, // C2A8
            '«' => 0x9E, // C2AB
            'º' => 0x9F, // C2BA
            // ' ' => 0xA0, // duplicate of 0x3A
            '»' => 0xA1, // C2BB
            '¿' => 0xA2, // C2BF
            'À' => 0xA3, // C380
            'Á' => 0xA4, // C381
            'Â' => 0xA5, // C382
            'Ä' => 0xA6, // C384
            'ç' => 0xA7, // C3A7
            'È' => 0xA8, // C388
            'É' => 0xA9, // C389
            'Ê' => 0xAA, // C38A
            'Ë' => 0xAB, // C38B
            'Ì' => 0xAC, // C38C
            'Í' => 0xAD, // C38D
            'Î' => 0xAE, // C38E
            'Ï' => 0xAF, // C38F
            'Ñ' => 0xB0, // C391
            'Ò' => 0xB1, // C392
            'Ó' => 0xB2, // C393
            'Ô' => 0xB3, // C394
            'Ö' => 0xB4, // C396
            'Ù' => 0xB5, // C399
            'Ú' => 0xB6, // C39A
            'Û' => 0xB7, // C39B
            'Ü' => 0xB8, // C39C
            'ß' => 0xB9, // C39F
            'à' => 0xBA, // C3A0
            'á' => 0xBB, // C3A1
            'â' => 0xBC, // C3A2
            'ä' => 0xBD, // C3A4
            // 'ç' => 0xBE, // duplicate of 0xA7
            'è' => 0xBF, // C3A8
            'é' => 0xC0, // C3A9
            'ê' => 0xC1, // C3AA
            'ë' => 0xC2, // C3AB
            'ì' => 0xC3, // C3AC
            'í' => 0xC4, // C3AD
            'î' => 0xC5, // C3AE
            'ï' => 0xC6, // C3AF
            'ñ' => 0xC7, // C3B1
            'ò' => 0xC8, // C3B2
            'ó' => 0xC9, // C3B3
            'ô' => 0xCA, // C3B4
            'ö' => 0xCB, // C3B6
            'ù' => 0xCC, // C3B9
            'ú' => 0xCD, // C3BA
            'û' => 0xCE, // C3BB
            'ü' => 0xCF, // C3BC
            // ',' => 0xD0, // duplicate of 0x46
            'ƒ' => 0xD1, // C692
            '„' => 0xD2, // E2809E
            '…' => 0xD3, // E280A6
            '\'' => 0xD4, // 27
            // '’' => 0xD5, // duplicate of 0x41
            '•' => 0xD6, // E280A2
            // '-' => 0xD7, // duplicate of 0x47
            // '~' => 0xD8, // duplicate of 0x8D
            '™' => 0xD9, // E284A2
            // ' ' => 0xDA, // duplicate of 0x3A
            '›' => 0xDB, // E280BA
            '§' => 0xDC, // C2A7
            '©' => 0xDD, // C2A9
            'ª' => 0xDE, // C2AA
            '®' => 0xDF, // C2AE
            '±' => 0xE0, // C2B1
            '²' => 0xE1, // C2B2
            '³' => 0xE2, // C2B3
            '¼' => 0xE3, // C2BC
            '½' => 0xE4, // C2BD
            '¾' => 0xE5, // C2BE
            '×' => 0xE6, // C397
            '÷' => 0xE7, // C3B7
            '‹' => 0xE8, // E280B9
            // '…' => 0xE9, // duplicate of 0xD3
            // ' ' => 0xEA, // duplicate of 0x3A
            'ǎ' => 0xEB, // C78E
            '★' => 0xEC, // E29885
            '☆' => 0xED, // E29886
            '■' => 0xEE, // E296A0
            '∞' => 0xEF, // E2889E
            _ => InvalidByte,

        };
    }

    public override char ToChar(byte b) {
        return b switch {
            0x30 => '0', // 30
            0x31 => '1', // 31
            0x32 => '2', // 32
            0x33 => '3', // 33
            0x34 => '4', // 34
            0x35 => '5', // 35
            0x36 => '6', // 36
            0x37 => '7', // 37
            0x38 => '8', // 38
            0x39 => '9', // 39
            0x3A => ' ', // 20
            0x3B => '!', // 21
            0x3C => '”', // E2809D
            0x3D => '#', // 23
            0x3E => '$', // 24
            0x3F => '%', // 25
            0x40 => '&', // 26
            0x41 => '’', // E28099
            0x42 => '(', // 28
            0x43 => ')', // 29
            0x44 => '*', // 2A
            0x45 => '+', // 2B
            0x46 => ',', // 2C
            0x47 => '-', // 2D
            0x48 => '.', // 2E
            0x49 => '/', // 2F
            0x4A => ':', // 3A
            0x4B => ';', // 3B
            0x4C => '<', // 3C
            0x4D => '=', // 3D
            0x4E => '>', // 3E
            0x4F => '?', // 3F
            0x50 => 'A', // 41
            0x51 => 'B', // 42
            0x52 => 'C', // 43
            0x53 => 'D', // 44
            0x54 => 'E', // 45
            0x55 => 'F', // 46
            0x56 => 'G', // 47
            0x57 => 'H', // 48
            0x58 => 'I', // 49
            0x59 => 'J', // 4A
            0x5A => 'K', // 4B
            0x5B => 'L', // 4C
            0x5C => 'M', // 4D
            0x5D => 'N', // 4E
            0x5E => 'O', // 4F
            0x5F => 'P', // 50
            0x60 => 'Q', // 51
            0x61 => 'R', // 52
            0x62 => 'S', // 53
            0x63 => 'T', // 54
            0x64 => 'U', // 55
            0x65 => 'V', // 56
            0x66 => 'W', // 57
            0x67 => 'X', // 58
            0x68 => 'Y', // 59
            0x69 => 'Z', // 5A
            0x6A => '[', // 5B
            0x6B => '\\', // 5C
            0x6C => ']', // 5D
            0x6D => '^', // 5E
            0x6E => '_', // 5F
            0x6F => '‘', // E28098
            0x70 => 'a', // 61
            0x71 => 'b', // 62
            0x72 => 'c', // 63
            0x73 => 'd', // 64
            0x74 => 'e', // 65
            0x75 => 'f', // 66
            0x76 => 'g', // 67
            0x77 => 'h', // 68
            0x78 => 'i', // 69
            0x79 => 'j', // 6A
            0x7A => 'k', // 6B
            0x7B => 'l', // 6C
            0x7C => 'm', // 6D
            0x7D => 'n', // 6E
            0x7E => 'o', // 6F
            0x7F => 'p', // 70
            0x80 => 'q', // 71
            0x81 => 'r', // 72
            0x82 => 's', // 73
            0x83 => 't', // 74
            0x84 => 'u', // 75
            0x85 => 'v', // 76
            0x86 => 'w', // 77
            0x87 => 'x', // 78
            0x88 => 'y', // 79
            0x89 => 'z', // 7A
            0x8A => '{', // 7B
            0x8B => '|', // 7C
            0x8C => '}', // 7D
            0x8D => '~', // 7E
            0x8E => '·', // C2B7
            0x8F => '【', // E38090
            0x90 => '】', // E38091
            0x91 => '♪', // E299AA
            0x92 => '♥', // E299A5
            // 0x93 => ' ', // duplicate of 0x3A
            0x94 => '“', // E2809C
            // 0x95 => '”', // duplicate of 0x3C
            0x96 => '—', // E28094
            // 0x97 => ' ', // duplicate of 0x3A
            0x98 => '¡', // C2A1
            0x99 => '↑', // E28691
            0x9A => '↓', // E28693
            0x9B => '←', // E28690
            0x9C => '→', // E28692
            0x9D => '¨', // C2A8
            0x9E => '«', // C2AB
            0x9F => 'º', // C2BA
            // 0xA0 => ' ', // duplicate of 0x3A
            0xA1 => '»', // C2BB
            0xA2 => '¿', // C2BF
            0xA3 => 'À', // C380
            0xA4 => 'Á', // C381
            0xA5 => 'Â', // C382
            0xA6 => 'Ä', // C384
            0xA7 => 'ç', // C3A7
            0xA8 => 'È', // C388
            0xA9 => 'É', // C389
            0xAA => 'Ê', // C38A
            0xAB => 'Ë', // C38B
            0xAC => 'Ì', // C38C
            0xAD => 'Í', // C38D
            0xAE => 'Î', // C38E
            0xAF => 'Ï', // C38F
            0xB0 => 'Ñ', // C391
            0xB1 => 'Ò', // C392
            0xB2 => 'Ó', // C393
            0xB3 => 'Ô', // C394
            0xB4 => 'Ö', // C396
            0xB5 => 'Ù', // C399
            0xB6 => 'Ú', // C39A
            0xB7 => 'Û', // C39B
            0xB8 => 'Ü', // C39C
            0xB9 => 'ß', // C39F
            0xBA => 'à', // C3A0
            0xBB => 'á', // C3A1
            0xBC => 'â', // C3A2
            0xBD => 'ä', // C3A4
            // 0xBE => 'ç', // duplicate of 0xA7
            0xBF => 'è', // C3A8
            0xC0 => 'é', // C3A9
            0xC1 => 'ê', // C3AA
            0xC2 => 'ë', // C3AB
            0xC3 => 'ì', // C3AC
            0xC4 => 'í', // C3AD
            0xC5 => 'î', // C3AE
            0xC6 => 'ï', // C3AF
            0xC7 => 'ñ', // C3B1
            0xC8 => 'ò', // C3B2
            0xC9 => 'ó', // C3B3
            0xCA => 'ô', // C3B4
            0xCB => 'ö', // C3B6
            0xCC => 'ù', // C3B9
            0xCD => 'ú', // C3BA
            0xCE => 'û', // C3BB
            0xCF => 'ü', // C3BC
            // 0xD0 => ',', // duplicate of 0x46
            0xD1 => 'ƒ', // C692
            0xD2 => '„', // E2809E
            0xD3 => '…', // E280A6
            0xD4 => '\'', // 27
            // 0xD5 => '’', // duplicate of 0x41
            0xD6 => '•', // E280A2
            // 0xD7 => '-', // duplicate of 0x47
            // 0xD8 => '~', // duplicate of 0x8D
            0xD9 => '™', // E284A2
            // 0xDA => ' ', // duplicate of 0x3A
            0xDB => '›', // E280BA
            0xDC => '§', // C2A7
            0xDD => '©', // C2A9
            0xDE => 'ª', // C2AA
            0xDF => '®', // C2AE
            0xE0 => '±', // C2B1
            0xE1 => '²', // C2B2
            0xE2 => '³', // C2B3
            0xE3 => '¼', // C2BC
            0xE4 => '½', // C2BD
            0xE5 => '¾', // C2BE
            0xE6 => '×', // C397
            0xE7 => '÷', // C3B7
            0xE8 => '‹', // E280B9
            // 0xE9 => '…', // duplicate of 0xD3
            // 0xEA => ' ', // duplicate of 0x3A
            0xEB => 'ǎ', // C78E
            0xEC => '★', // E29885
            0xED => '☆', // E29886
            0xEE => '■', // E296A0
            0xEF => '∞', // E2889E
            _ => InvalidChar,

        };
    }
}