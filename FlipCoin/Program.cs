using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int count_head = 0;
            int count_tail = 0;

            Console.WriteLine("Flip the Coin");
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                double coin = random.NextDouble();
                if (coin < 0.5)
                {
                    Console.WriteLine(coin + " Head");
                    count_head = +1;
                }
                else
                {
                    Console.WriteLine(coin + " Tail");
                    count_tail += 1;
                }

            }
            Console.WriteLine("Percentage of Head is: {0}%", count_head * 10);
            Console.WriteLine("Percentage of Tail is: {0}%", count_tail * 10);



        }
    }
}
