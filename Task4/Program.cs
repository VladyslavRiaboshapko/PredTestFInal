// See https://aka.ms/new-console-template for more information
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            bool num_a = int.TryParse(a, out int a_int);
            bool num_b = int.TryParse(b, out int b_int);
            bool num_c = int.TryParse(c, out int c_int);

            if (num_a == true && num_b == true && num_c == true)
            {
                if (a_int == 0)
                {
                    Console.WriteLine("Not a quadratic");
                }
                else
                {
                    double D = Math.Pow(b_int, 2) - 4 * a_int * c_int;

                    if (D > 0)
                    {
                        Console.WriteLine("Two Roots");
                    }
                    else if (D == 0)
                    {
                        Console.WriteLine("One Roots");
                    }
                    else
                    {
                        Console.WriteLine("No real roots");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}