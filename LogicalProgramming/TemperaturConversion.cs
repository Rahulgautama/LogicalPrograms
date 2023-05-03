using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class TemperaturConversion
    {
		public static bool IsNumber(string val)
		{
			double value=0;
			try
			{
				 value = Convert.ToInt32(val);
				
			}
			catch (Exception)
			{
				Console.WriteLine("Please Enter only Number");
			}
			return value > 0 ? true : false;
		}
        public static void TemperaturConversionFunc()
        {
			
			bool flag = true;
			string input="";
			Console.WriteLine("Enter the tempareture which do you want to convert into celsius to fahrenheit");
			input = Console.ReadLine();
			
			while (flag)
			{
				if (IsNumber(input))
				{
					flag = false;
				}
				else
				{
					Console.WriteLine("Enter the Correct type of tempareture");
					input= Console.ReadLine();
				}
			}
			double temp = Convert.ToDouble(input);
			Console.WriteLine("Fahrenheit Temp:" + (temp * 9 / 5) + 32);

			bool flag1 = true;
			string in1;
			Console.WriteLine("Enter the tempareture which do you want to convert into fahrenheit to celsius");
			in1 = Console.ReadLine();
			while (flag1)
			{
				if (IsNumber(in1))
				{
					flag1 = false;
				}
				else
				{
					Console.WriteLine("Enter the Correct type of tempareture");
					in1 = Console.ReadLine();
				}
			}
			double temp1 = Convert.ToDouble(in1);
			Console.WriteLine("ceslsius Temp:" + (temp1 - 32) * (5 / 9.0));
		}
    }
}
