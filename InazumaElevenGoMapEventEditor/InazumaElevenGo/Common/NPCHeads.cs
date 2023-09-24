﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InazumaElevenGoMapEventEditor.InazumaElevenGo.Games.Common
{
    public static class NPCHeads
    {
        public static Dictionary<int, string> IEGO = new Dictionary<int, string>
        {
            {0x00000001, "Mark Evans" },
            {0x00000002, "Arion Sherwind (Young)" },
            {0x00000003, "Spotter (Young)" },
            {0x00000004, "Celia Hills" },
            {0x00000005, "Nelly Evans" },
            {0x00000006, "Silvia Woods" },
            {0x00000007, "Camellia Travis" },
            {0x0000000C, "Percival Travis" },
            {0x0000000D, "Henry Goldwin" },
            {0x0000000E, "Frank Wintersea" },
            {0x0000000F, "Seymour Hillman" },
            {0x00000010, "George Firewill" },
            {0x00000011, "Alex Zabel" },
            {0x00000012, "Julia Blaze" },
            {0x00000013, "Vladimir Blade" },
            {0x00000014, "Vladimir Blade (Young)" },
            {0x00000015, "Victor Blade (Young)" },
            {0x00000016, "Jude Sharp" },
            {0x00000017, "Sonny Raimon" },
            {0x00000018, "Saber Sabel" },
            {0x00000019, "Stewart Vanguard" },
            {0x0000001A, "Victoria Vanguard" },
            {0x0000001B, "Aquilina Schiller" },
            {0x00000021, "Wilder Bigfoot" },
            {0x00000025, "Gyan Cinquedea" },
            {0x00000026, "Priest" },
            {0x00000027, "Mrs Sherwind" },
            {0x0000002A, "Mr Veteran" },
            {0x0000002C, "Charley Horse" },
            {0x0000002D, "Chester Horse Sr" },
            {0x0000002E, "Othello Go" },
            {0x0000002F, "Suit" },
            {0x00000031, "Mrs Han" },
            {0x00000035, "Nathan Swift" },
            {0x00000036, "Jack Wallside" },
            {0x00000037, "Steve Grim" },
            {0x00000038, "Kevin Dragonfly" },
            {0x00000039, "William Glass" },
            {0x0000003A, "David Samford" },
            {0x0000003B, "Millie Moonlight" },
            {0x0000003C, "Byron Love" },
            {0x0000003D, "Austin Hobbes" },
            {0x0000003E, "Archer Hawkins" },
            {0x0000003F, "Xavier Schiller" },
            {0x00000040, "Caleb Stonewall" },
            {0x00000041, "Jordan Greenway" },
            {0x00000042, "Dave Quagmire" },
            {0x00000043, "Shawn Froste" },
            {0x00000044, "Darren LaChance" },
            {0x00000045, "Hurley Kane" },
            {0x00000047, "Mark Gambling" },
            {0x0000004A, "Gus Gamer" },
            {0x0000004B, "Faythe Heeler" },
            {0x0000004C, "Erik Eagle" },
            {0x0000004D, "Bobby Shearer" },
            {0x0000004E, "Doctor" },
            {0x0000004F, "Camellia Travis" },
            {0x00000050, "Nelly Raimon" },
            {0x00000051, "Harrold Houdini" },
            {0x00000052, "Wanli Changcheng" },
            {0x00000053, "Tezcat's Sister" },
            {0x00000054, "Kevin Dragonfly" },

            {0x000003E9, "Raimon Boy (Uniform) 1" },
            {0x000003EA, "Raimon Boy (Uniform) 2" },
            {0x000003EB, "Raimon Boy (Uniform) 3" },
            {0x000003EC, "Raimon Boy (Uniform) 4" },
            {0x000003ED, "Raimon Boy (Uniform) 5" },
            {0x000003EE, "Raimon Girl (Uniform) 1" },
            {0x000003EF, "Raimon Girl (Uniform) 2" },
            {0x000003F0, "Raimon Girl (Uniform) 3" },
            {0x000003F1, "Raimon Girl (Uniform) 4" },
            {0x000003F2, "Raimon Girl (Uniform) 5" },
            {0x000003F3, "Raimon Boy (PE Kit) 1" },
            {0x000003F4, "Raimon Boy (PE Kit) 2" },
            {0x000003F5, "Raimon boy (PE Kit) 3" },
            {0x000003F6, "Raimon Girl (PE Kit) 1" },
            {0x000003F7, "Raimon girl (PE Kit) 2" },
            {0x000003F8, "Raimon Girl (PE Kit) 3" },
            {0x000003F9, "Teacher (Male) 1" },
            {0x000003FA, "Teacher (Male) 2" },
            {0x000003FB, "Teacher (Male) 3" },
            {0x000003FC, "Teacher (Female) 1" },
            {0x000003FD, "Teacher (Female) 2" },
            {0x000003FE, "Teacher (Female) 3" },
            {0x000003FF, "Youth (Male) 1" },
            {0x00000400, "Youth (Male) 2" },
            {0x00000401, "Youth (Male) 3" },
            {0x00000402, "Youth (Male) 4" },
            {0x00000403, "Youth (Female) 1" },
            {0x00000404, "Youth (Female) 2" },
            {0x00000405, "Youth (Female) 3" },
            {0x00000406, "Youth (Female) 4" },
            {0x00000407, "Young Boy 1" },
            {0x00000408, "Young Boy 2" },
            {0x00000409, "Young Boy 3" },
            {0x0000040A, "Young Girl 1" },
            {0x0000040B, "Young Girl 2" },
            {0x0000040C, "Young Girl 3" },
            {0x0000040D, "Old Man 1" },
            {0x0000040E, "Old Man 2" },
            {0x0000040F, "Old Man 3" },
            {0x00000410, "Old Woman 1" },
            {0x00000411, "Old Woman 2" },
            {0x00000412, "Old Woman 3" },
            {0x00000413, "Middle-Aged Man 1" },
            {0x00000414, "Middle-Aged Man 2" },
            {0x00000415, "Middle-Aged Man 3" },
            {0x00000416, "Middle-Aged Man 4" },
            {0x00000417, "Middle-Aged Woman 1" },
            {0x00000418, "Middle-Aged Woman 2" },
            {0x00000419, "Middle-Aged Woman 3" },
            {0x0000041A, "Middle-Aged Woman 4" },
            {0x0000041B, "Shop Worker (Male) 1" },
            {0x0000041C, "Shop Worker (Male) 2" },
            {0x0000041D, "Shop Worker (Female) 1" },
            {0x0000041E, "Shop Worker (Female) 2" },
            {0x0000041F, "Doctor (Male) 1" },
            {0x00000420, "Nurse (Female) 1" },
            {0x00000421, "Nurse (Female) 2" },
            {0x00000422, "Prodigy Boy (Uniform) 1" },
            {0x00000423, "M. Way Girl (Uniform) 1" },
            {0x00000424, "A. Faith Boy (Uniform) 1" },
            {0x00000425, "A. Faith Boy (Uniform) 2" },
            {0x00000426, "A. Faith Girl (Uniform) 1" },
            {0x00000427, "A. Faith Girl (Uniform) 2" },
            {0x00000428, "Royal Boy (Uniform) 1" },
            {0x00000429, "Royal Boy (Uniform) 2" },
            {0x0000042A, "Royal Boy (Uniform) 3" },
            {0x0000042B, "SW Receptionist (Male)" },
            {0x0000042C, "SW Receptionist (Fem.)" },
            {0x0000042F, "Station Worker (Male) 1" },
            {0x00000430, "Battle Rt. Receptionist" },
            {0x00000431, "School Nurse (Female) 1" },
            {0x00000432, "School Store Lady 1" },
            {0x00000433, "Butler (Male) 1" },
            {0x00000434, "Butler (Male) 2" },
            {0x00000435, "Maid (Female) 1" },
            {0x00000436, "Maid (Female) 2" },
            {0x00000437, "Explorer (Male) 1" },
            {0x00000438, "Zabel's Aide (Male) 1" },
            {0x00000439, "Zabel's Aide (Male) 2" },
            {0x0000043A, "Zabel's Aide (Male) 3" },
            {0x0000043B, "Mysterious Old Guru" },
            {0x0000043C, "ZS Receptionist (Male) 1" },
            {0x0000043D, "ZS Receptionist (Male) 2" },
            {0x0000043E, "Sanctum Player A" },
            {0x0000043F, "Sanctum Player B" },
            {0x00000440, "Sanctum Player C" },
            {0x00000441, "Sanctum Player D" },
            {0x00000442, "Sanctum Player E" },
            {0x00000443, "Mysterious Old Sage" },
            {0x0000044D, "Mysterious Wise Man" },
            {0x00002329, "" },
            {0x0000232A, "" },
            {0x0000232B, "" },
            {0x0000232C, "" },
            {0x0000232D, "" },
        };
    }
}
