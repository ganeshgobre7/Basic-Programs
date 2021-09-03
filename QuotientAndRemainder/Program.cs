using System;

namespace QuotientAndRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, q, r;
            Console.WriteLine("Enter First Number:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            y = Convert.ToInt32(Console.ReadLine());

            q = x / y;
            r = x % y;

            Console.WriteLine("Quatient is:" + q);
            Console.WriteLine("Remainder is:" + r);
        }
    }
    
}
