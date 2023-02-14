﻿//  2006-2008 (c) Viva64.com Team
//  2008-2020 (c) OOO "Program Verification Systems"
//  2020-2023 (c) PVS-Studio LLC
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProgramVerificationSystems.PVSStudio
{
    static class CppAnalyzerDecoder
    {
        public readonly static string EncodeMarker = "d99cf3ba-6fcd-43f9-9260-1179fa3a9bed";

        private readonly static char[] DecodeMap = {
            '\x00', '\x01', '\x02', '\x03', '\x04', '\x05', '\x06', '\x07', '\x08', '\x09', '\x0a', '\x0b', '\x0c', '\x0d', '\x0e', '\x0f',
            '\x10', '\x11', '\x12', '\x13', '\x14', '\x15', '\x16', '\x17', '\x18', '\x19', '\x1a', '\x1b', '\x1c', '\x1d', '\x1e', '\x1f',
            'f',    '[',    ']',    '^',    'A',    ':',    '!',    'c',    '/', '\x5c',    '3',    '*',    'T',    'i',    'S',    'x',
            'Q',    'I',    'l',    '>',    'W',    'j',    'M',    '@',    'o',    'b',    'z',    '(',    'E',    's',    'n',    'O',
            'L',    'J',    '}',    'R',    '~', '\x2c',    'D',    '7',    'G',    'H',    '2',    '_',    'h',    'X', '\x27',    'B',
            'm',    'N',    '"',    '0',    'F',    'a',    '6',    'Z',    '8',    '%',    '&',    '5',    'P',    'w',    ')',    'd',
            'K',    'r',    '4',    ' ',    '{',    'Y',    'y',    'U',    'u',    '9',    'g',    'p',    '`',    '=',    ';',    't',
            '|',    '$',    'V',    'k',    '+',    'e',    'v',    '-',    '1',    '<',    '?',    'C',    '#',    '.',    'q', '\x7f',
            '\x80', '\x81', '\x82', '\x83', '\x84', '\x85', '\x86', '\x87', '\x88', '\x89', '\x8a', '\x8b', '\x8c', '\x8d', '\x8e', '\x8f',
            '\x90', '\x91', '\x92', '\x93', '\x94', '\x95', '\x96', '\x97', '\x98', '\x99', '\x9a', '\x9b', '\x9c', '\x9d', '\x9e', '\x9f',
            '\xa0', '\xa1', '\xa2', '\xa3', '\xa4', '\xa5', '\xa6', '\xa7', '\xa8', '\xa9', '\xaa', '\xab', '\xac', '\xad', '\xae', '\xaf',
            '\xb0', '\xb1', '\xb2', '\xb3', '\xb4', '\xb5', '\xb6', '\xb7', '\xb8', '\xb9', '\xba', '\xbb', '\xbc', '\xbd', '\xbe', '\xbf',
            '\xc0', '\xc1', '\xc2', '\xc3', '\xc4', '\xc5', '\xc6', '\xc7', '\xc8', '\xc9', '\xca', '\xcb', '\xcc', '\xcd', '\xce', '\xcf',
            '\xd0', '\xd1', '\xd2', '\xd3', '\xd4', '\xd5', '\xd6', '\xd7', '\xd8', '\xd9', '\xda', '\xdb', '\xdc', '\xdd', '\xde', '\xdf',
            '\xe0', '\xe1', '\xe2', '\xe3', '\xe4', '\xe5', '\xe6', '\xe7', '\xe8', '\xe9', '\xea', '\xeb', '\xec', '\xed', '\xee', '\xef',
            '\xf0', '\xf1', '\xf2', '\xf3', '\xf4', '\xf5', '\xf6', '\xf7', '\xf8', '\xf9', '\xfa', '\xfb', '\xfc', '\xfd', '\xfe', '\xff'
        };

        public static string DecodeString(string str, Encoding encoding)
        {
            byte[] buffer = encoding.GetBytes(str);
            StringBuilder sb = new StringBuilder(buffer.Length);
            for (int i = 0; i < buffer.Length; i++)
                sb.Append(DecodeMap[buffer[i]]);
            return sb.ToString();
        }
    }
}
