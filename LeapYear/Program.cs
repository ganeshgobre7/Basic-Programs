using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the Year:");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0) && (year % 100 != 0 || (year % 400 == 0)))
            {
                Console.WriteLine("leap Year", +year);
            }
            else
            {
                Console.WriteLine("Not Leap Year", +year);
            }
        }
    }
}
