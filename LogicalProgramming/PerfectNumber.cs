using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class PerfectNumber
    {
        public static void FindPerfectNumber()
        {
            try
            {
                int num, rem, sum = 0, i;
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i < num; i++)
                {
                    rem = num % i;
                    if (rem == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (sum == num)
                    Console.WriteLine(sum + " is a Perfect Number");
                else
                    Console.WriteLine(sum + " is not a Perfect Number");
            }
            catch(Exception e)
            {
                Console.WriteLine("Please Enter Only number");
            }
        }
    }
}
