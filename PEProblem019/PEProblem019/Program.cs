using System;
/*
 * You are given the following information, but you may prefer to do some research for yourself.
 * 1 Jan 1900 was a Monday.
 * Thirty days has September,
 * April, June and November.
 * All the rest have thirty-one,
 * Saving February alone,
 * Which has twenty-eight, rain or shine.
 * And on leap years, twenty-nine.
 * A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
 * How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
 */
namespace PEProblem019
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            int day = 1;
            int month = 1;
            int year = 1900;
            int Dday = 1;
            int count = 0;

            while (year < 2001)
            {
                switch (month)
                {
                    case 1:
                        day += 31;
                        Dday += 3;
                        break;
                    case 2:
                        day += 28;
                        if (year % 4 == 0)
                        {
                            if (year != 2000)
                            {
                                day++;
                                Dday += 1;
                            }
                        }
                        break;
                    case 3:
                        day += 31;
                        Dday += 3;
                        break;
                    case 4:
                        day += 30;
                        Dday += 2;
                        break;
                    case 5:
                        day += 31;
                        Dday += 3;
                        break;
                    case 6:
                        day += 30;
                        Dday += 2;
                        break;
                    case 7:
                        day += 31;
                        Dday += 3;
                        break;
                    case 8:
                        day += 31;
                        Dday += 3;
                        break;
                    case 9:
                        day += 30;
                        Dday += 2;
                        break;
                    case 10:
                        day += 31;
                        Dday += 3;
                        break;
                    case 11:
                        day += 30;
                        Dday += 2;
                        break;
                    case 12:
                        day = 1;
                        Dday += 3;
                        month = 0;
                        year++;
                        break;
                }
                month++;

                if (Dday > 7)
                {
                    Dday -= 7;
                }

                if (year > 1900 || month > 11)
                {
                    if (Dday == 7)
                    {
                        count++;
                    }
                }
            }

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + count.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }

        /* alternative counter */
        private static string generatedatecount()
        {
            DateTime StartTimed = new DateTime(1901, 1, 1);
            int count = 0;
            while (StartTimed.Year < 2001)
            {
                if (StartTimed.DayOfWeek == DayOfWeek.Sunday)
                {
                    count++;
                }
                StartTimed = StartTimed.AddMonths(1);
            }
            return count.ToString();
        }

    }
}
