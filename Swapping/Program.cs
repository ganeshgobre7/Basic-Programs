using System;

namespace Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            int Temp, Num1, Num2;
            Console.WriteLine("Enter the First the Number:");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Temp = Num1;
            Num1 = Num2;
            Num2 = Temp;

            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number is:" + Num1);
            Console.WriteLine("Second Number is:" + Num2);
        }
    }
}
