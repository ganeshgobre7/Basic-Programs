using System;

namespace LargestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, large;
            Console.WriteLine("Enter First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                large = num1;
            else if (num2 > num1 && num2 > num3)
                large = num2;
            else
                large = num3;

            Console.WriteLine("Largest Number among {0}, {1} and {2} is {3}", num1, num2, num3, large);

        }
    }
}
