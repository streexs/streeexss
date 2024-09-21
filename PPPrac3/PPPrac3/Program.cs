using System;

namespace PS_03_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckLeapYear(2025);
        }

        static void CheckLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} qualifies as a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} does not qualify as a leap year.");
            }
        }
    }
}