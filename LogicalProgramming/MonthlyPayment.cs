using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class MonthlyPayment
    {
        public static void MonthPay()
        {
            double monthlyPayment, loanAmount, monthlyRate, numberOfYears, totalPayment, rate = 0;          
            

            Console.Write("Enter the annual interest rate \n(Eg: 4.9% =0.049 : ");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the loan in years\n(Eg: 4): ");
            numberOfYears = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the loan amount ($)\n(Eg: 1000): ");
            loanAmount = Convert.ToDouble(Console.ReadLine());

            monthlyRate = rate / 12;
            // Monthly interest rate 
            // is the yearly rate divided by 12

            monthlyPayment = loanAmount * monthlyRate / (1 - 1 / Math.Pow(1 + monthlyRate, numberOfYears * 12));
            totalPayment = monthlyPayment * numberOfYears * 12;

                       

            // Display details of the loan

            Console.WriteLine("Loan Amount: " + loanAmount);
            Console.WriteLine("The annual interest rate : " + rate);
            Console.WriteLine("Monthly Payment: " + monthlyPayment);
            Console.WriteLine("Total Payment: " + totalPayment);
        }
    }
}
