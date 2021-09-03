using System;

namespace HarmonicNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            double sum = 0.0;

            Console.WriteLine("Enter the Harmonic Number");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                sum += 1 / (float)i;
            }
            Console.WriteLine("Sum of Series upto {0} terms : {1}", num, sum);

        }
    }
}
