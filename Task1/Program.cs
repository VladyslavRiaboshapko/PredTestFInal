// See https://aka.ms/new-console-template for more information
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string minutes_s = Console.ReadLine();
            bool minutes_b = int.TryParse(minutes_s, out int minutes_int);

            if (minutes_b == true && minutes_int >= 0)
            {
                if (minutes_int >= 60)
                {
                    int hours = minutes_int / 60;
                    int minutes = minutes_int % 60;
                    Console.WriteLine($"{hours} hours {minutes} minutes");
                }
                else
                {
                    Console.WriteLine($"0 hours {minutes_int} minutes");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}