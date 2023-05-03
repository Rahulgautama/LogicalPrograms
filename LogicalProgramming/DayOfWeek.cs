using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class DayOfWeek
    {
        public static void FindDayOfWeek() {           

            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("Month");
                int m = Convert.ToInt32(Console.ReadLine());
                if (m < 1 || m > 12)
                {
                    Console.WriteLine("Months are between 1 and 12");
                    continue;
                }

                Console.WriteLine("Day");
                int d = Convert.ToInt32(Console.ReadLine());
                if (d < 1 || d > 31)
                {
                    Console.WriteLine("Days are between 1 and 31");
                    continue;
                }

                Console.WriteLine("Year");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y < -10000 || y > 10000)
                {
                    Console.WriteLine("Years are between -10000 and 10000");
                    continue;
                }
                string b="";
                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + 31 * m0 / 12) % 7;
                bool c = 0 <= d0 && d0 <= 6;
                
                if (c)
                {
                    b = "Sunday";
                }
                else
                {
                    if (c)
                    {
                         b = "Monday";
                    }
                    else
                    {
                        if (c)
                        {
                             b = "Tuesday";
                        }
                        else
                        {
                            if (c)
                            {
                                 b = "Wednesday";
                            }
                            else
                            {
                                if (c)
                                {
                                     b = "Thursday";
                                }
                                else
                                {
                                    if (c)
                                    {
                                         b = "Friday";
                                    }
                                    else
                                    {
                                        if (c)
                                        {
                                             b = "Saturday";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                Console.WriteLine("The day of the week is "+ b);
            }



        }
    }
}
