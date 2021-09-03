using System;

namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {


                if ((input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U'))
                {
                    Console.WriteLine($"{input[i]} is Vowels");
                }
                else
                {
                    Console.WriteLine($"{input[i]} is Consonant");
                }
            }
        }
    }
}
