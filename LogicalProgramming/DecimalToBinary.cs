using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class DecimalToBinary
    {
        public static void DecimalToBinaryConversion()
        {
                int dec_num, quot, i = 1, j;
                int[] bin_num = new int[100];                

                Console.Write("Input a Decimal Number : ");
            dec_num = Convert.ToInt32(Console.ReadLine());

                quot = dec_num;

                while (quot != 0)
                {
                    bin_num[i++] = quot % 2;
                    quot = quot / 2;
                }

                Console.Write("Binary number is: ");
                for (j = i - 1; j > 0; j--)
                {
                    Console.Write(bin_num[j]);
                }
                Console.Write("\n");
            
        }
    }
}
