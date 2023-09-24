﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InazumaElevenGoMapEventEditor.InazumaElevenGo.Games.Common
{
    internal class PlayablePhase
    {
        public static Dictionary<int, int> IEGO = new Dictionary<int, int>
        {
            {0x00000000, 10010010 },
            {0x0000000A, 10010020 },
            {0x00000014, 10010030 },
            {0x0000001E, 10010040 },
            {0x00000028, 10020010 },
            {0x00000032, 10020020 },
            {0x0000003C, 10020025 },
            {0x00000046, 10020030 },
            {0x00000050, 10020040 },
            {0x0000005A, 10020050 },
            {0x00000064, 10030010 },
            {0x0000006E, 10030020 },
            {0x00000078, 10030030 },
            {0x00000082, 10030040 },
            {0x0000008C, 10030050 },
            {0x00000096, 10040010 },
            {0x000000A0, 10040020 },
            {0x000000AA, 10040030 },
            {0x000000B4, 10040040 },
            {0x000000BE, 10040050 },
            {0x000000C8, 10040055 },
            {0x000000D2, 10040060 },
            {0x000000DC, 10040070 },
            {0x000000E6, 10050010 },
            {0x000000F0, 10050020 },
            {0x000000FA, 10050030 },
            {0x00000104, 20010010 },
            {0x0000010E, 20010020 },
            {0x00000118, 20010030 },
            {0x00000122, 20010040 },
            {0x0000012C, 20020010 },
            {0x00000136, 20020015 },
            {0x00000140, 20020020 },
            {0x0000014A, 20020030 },
            {0x00000154, 20020040 },
            {0x0000015E, 20020050 },
            {0x00000168, 20020060 },
            {0x00000172, 20020070 },
            {0x0000017C, 20030010 },
            {0x00000186, 20030020 },
            {0x00000190, 20040010 },
            {0x0000019A, 20040020 },
            {0x000001A4, 20040030 },
            {0x000001AE, 20040040 },
            {0x000001B8, 30010010 },
            {0x000001C2, 30010020 },
            {0x000001CC, 30010030 },
            {0x000001D6, 30010040 },
            {0x000001E0, 30020010 },
            {0x000001EA, 30020020 },
            {0x000001F4, 30020030 },
            {0x000001FE, 30020040 },
            {0x00000208, 30030010 },
            {0x00000212, 30030020 },
            {0x0000021C, 30030030 },
            {0x00000226, 30030040 },
            {0x00000230, 30030050 },
            {0x0000023A, 30030060 },
            {0x00000244, 30030070 },
            {0x0000024E, 30030080 },
            {0x00000258, 30030090 },
            {0x00000262, 30030100 },
            {0x0000026C, 30030110 },
            {0x00000276, 30030120 },
            {0x00000280, 30040010 },
            {0x0000028A, 30040020 },
            {0x00000294, 30040030 },
            {0x0000029E, 30040040 },
            {0x000002A8, 30040050 },
            {0x000002B2, 30040060 },
            {0x000002BC, 30040070 },
            {0x000002C6, 40010010 },
            {0x000002D0, 40010020 },
            {0x000002DA, 40010030 },
            {0x000002E4, 40010040 },
            {0x000002EE, 40010050 },
            {0x000002F8, 40020010 },
            {0x00000302, 40020020 },
            {0x0000030C, 40020030 },
            {0x00000316, 40020040 },
            {0x00000320, 40020050 },
            {0x0000032A, 40020060 },
            {0x00000334, 40020070 },
            {0x0000033E, 40030010 },
            {0x00000348, 40030020 },
            {0x00000352, 40040010 },
            {0x0000035C, 40040020 },
            {0x00000366, 40040030 },
            {0x00000370, 40040040 },
            {0x0000037A, 40040050 },
            {0x00000384, 50010010 },
            {0x0000038E, 50010020 },
            {0x00000398, 50020010 },
            {0x000003A2, 50020020 },
            {0x000003AC, 50020030 },
            {0x000003B6, 50020040 },
            {0x000003C0, 50020050 },
            {0x000003CA, 50030010 },
            {0x000003D4, 50030020 },
            {0x000003DE, 50030030 },
            {0x000003E8, 50030040 },
            {0x000003F2, 50030050 },
            {0x000003FC, 50030060 },
            {0x00000406, 50030070 },
            {0x00000410, 50040010 },
            {0x0000041A, 50040020 },
            {0x00000424, 50040030 },
            {0x0000042E, 50050010 },
            {0x00000438, 50050020 },
            {0x00000442, 50050030 },
            {0x0000044C, 50050040 },
            {0x00000456, 60010010 },
            {0x00000460, 60010020 },
            {0x0000046A, 60010030 },
            {0x00000474, 60010040 },
            {0x0000047E, 60010050 },
            {0x00000488, 60020010 },
            {0x00000492, 60020020 },
            {0x0000049C, 60020030 },
            {0x000004A6, 60020040 },
            {0x000004B0, 60030010 },
            {0x000004BA, 60030020 },
            {0x000004C4, 60030030 },
            {0x000004CE, 60040010 },
            {0x000004D8, 60040020 },
            {0x000004E2, 60040030 },
            {0x000004EC, 60040040 },
            {0x000004F6, 60040050 },
            {0x00000500, 70010010 },
            {0x0000050A, 70010020 },
            {0x00000514, 70010030 },
            {0x0000051E, 70020010 },
            {0x00000528, 70020020 },
            {0x00000532, 70020030 },
            {0x0000053C, 70030010 },
            {0x00000546, 70030020 },
            {0x00000550, 70030030 },
            {0x0000055A, 70030040 },
            {0x00000564, 70040010 },
            {0x0000056E, 70040020 },
            {0x00000578, 70040030 },
            {0x00000582, 70040040 },
            {0x0000058C, 70040050 },
            {0x00000596, 70050010 },
            {0x000005A0, 70050020 },
            {0x000005AA, 70050030 },
            {0x000005B4, 70050040 },
            {0x000005BE, 70050050 },
            {0x000005C8, 80010010 },
            {0x000005D2, 80010020 },
            {0x000005DC, 80010030 },
            {0x000005E6, 80010040 },
            {0x000005F0, 80010050 },
            {0x000005FA, 80020010 },
            {0x00000604, 80020020 },
            {0x0000060E, 80020030 },
            {0x00000618, 80020040 },
            {0x00000622, 80030010 },
            {0x0000062C, 80030020 },
            {0x00000636, 80030030 },
            {0x00000640, 80040010 },
            {0x0000064A, 80040020 },
            {0x00000654, 80040030 },
            {0x0000065E, 80040040 },
            {0x00000668, 80040050 },
            {0x00000672, 80040060 },
            {0x0000067C, 80040070 },
            {0x00000686, 80040080 },
            {0x00000690, 90010010 },
            {0x0000069A, 90010030 },
            {0x000006A4, 90010040 },
            {0x000006AE, 90020010 },
            {0x000006B8, 90020020 },
            {0x000006C2, 90020030 },
            {0x000006CC, 90020040 },
            {0x000006D6, 90030010 },
            {0x000006E0, 90030020 },
            {0x000006EA, 90030030 },
            {0x000006F4, 90030040 },
            {0x000006FE, 90040010 },
            {0x00000708, 90040020 },
            {0x00000712, 90050010 },
            {0x0000071C, 90050020 },
            {0x00000726, 90050030 },
            {0x00000730, 90050040 },
            {0x0000073A, 90050050 },
            {0x00000744, 90050060 },
            {0x0000074E, 100010010 },
            {0x00000759, 100010020 },
            {0x00000764, 100010030 },
            {0x0000076F, 100020010 },
            {0x0000077A, 100020020 },
            {0x00000785, 100030010 },
            {0x00000790, 100030020 },
            {0x0000079B, 100040010 },
            {0x000007A6, 100040020 },
            {0x000007B1, 100040030 },
            {0x000007BC, 100050010 },
            {0x000007C7, 100050020 },
            {0x000007D2, 100050030 },
            {0x000007DD, 100050040 },
            {0x000007E8, 100050050 },
            {0x000007F3, 100050060 },
            {0x000007FE, 110010010 },
            {0x00000809, 110010020 },
            {0x00000814, 110020010 },
            {0x0000081F, 110020020 },
            {0x0000082A, 110020030 },
            {0x00000835, 110020040 },
            {0x00000840, 110030010 },
            {0x0000084B, 110030020 },
            {0x00000856, 110040010 },
            {0x00000861, 110040020 },
            {0x0000086C, 110040030 },
            {0x00000877, 110040040 },
            {0x00000882, 110050010 },
            {0x0000088D, 110050020 },
            {0x00000898, 110050030 },
            {0x000008A3, 110050040 },
            {0x000008AE, 110050050 },
            {0x000008B9, 110050060 },
            {0x000008C4, 110050070 },
            {0x000008CF, 120010005 },
            {0x000008DA, 120010010 },
            {0x000008E5, 120010020 },
            {0x000008F0, 120020010 },
            {0x000008FB, 120020020 },
            {0x00000906, 120020030 },
            {0x00000911, 120020040 },
            {0x0000091C, 120030010 },
            {0x00000927, 120030020 },
            {0x00000932, 120030030 },
            {0x0000093D, 120040010 },
            {0x00000948, 120040020 },
            {0x00000953, 120040030 },
            {0x0000095E, 120050010 },
            {0x00000969, 120050020 },
            {0x00000974, 120050030 },
            {0x0000097F, 120050040 },
            {0x0000098A, 120050050 },
            {0x00000995, 130010010 },
            {0x000009A0, 130010020 },
            {0x000009AB, 130020010 },
            {0x000009B6, 130020020 },
            {0x000009C1, 130030010 },
            {0x000009CC, 130040010 },
            {0x000009D7, 130040020 },
            {0x000009E2, 130050010 },
            {0x000009ED, 130050020 },
            {0x000009F8, 130050030 },
            {0x00000A03, 130050040 },
            {0x00000A0E, 130050050 },
            {0x00000A19, 10900000 },
        };
    }
}
