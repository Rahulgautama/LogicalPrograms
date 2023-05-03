using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class Binary
    {
        static int SwapNibbles(int x)
        {
            return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
        }

        // Driver code
        public static void BinaryConversion()
        {
            int x = 100;
            Console.Write(SwapNibbles(x));
        }
    }
}

