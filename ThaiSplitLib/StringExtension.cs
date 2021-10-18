using System;

namespace ThaiSplitLib
{
    public static class StringExtension
    {
        public static int LengthTH(this String str)
        {
            int count = 0;
            foreach (char c in str.ToCharArray())
            {
                int asciiNo = (int)c;
                //ไม่นับวรรณยุกต์และสระบนล่าง
                if (!(asciiNo == 3633 || (asciiNo >= 3636 && asciiNo <= 3641) || (asciiNo >= 3656 && asciiNo <= 3660)))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
