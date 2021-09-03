using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Remainder;
            Console.WriteLine("Enter the Number:");
            Num = Convert.ToInt32(Console.ReadLine());

            Remainder = Num % 2;

            if (Remainder == 0)
                Console.WriteLine("Number is Even", Num);
            else
                Console.WriteLine("Number is Odd", Num);
        }
    }
}
