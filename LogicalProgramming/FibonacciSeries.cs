using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class FibonacciSeries
    {
        public static void FibonacciSeriesSum()
        {
            int num1 = 0, num2 = 1, num3, i, number,sum=1;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");
            for (i = 2; i < number; ++i)
            {
                num3 = num1 + num2;
                sum = sum+num3;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
            Console.WriteLine("\nSum of All fibonacci Series "+sum);
        }
    }
}
