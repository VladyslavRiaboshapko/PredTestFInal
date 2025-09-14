// See https://aka.ms/new-console-template for more information
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num_s = Console.ReadLine();
            bool num = int.TryParse(num_s, out int number);

            if (num == true)
            {
                if (number % 10 == 0)
                {
                    Console.WriteLine("Multiple of 10");
                }
                else
                {
                    Console.WriteLine("Not a multiple of 10");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}