using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter 1 to 100");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            string str = Console.ReadLine();
            Console.WriteLine("\n");
            Console.ResetColor();

            int num = Int32.Parse(str);
            StringBuilder result = new StringBuilder("");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" " + "Results");
            Console.WriteLine("---------------------------------------- \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" " + "Multiples of 3 = Fizz \n");
            Console.WriteLine(" " + "Multiples of 5 = Buzz \n");
            Console.WriteLine(" " + "Multiples of 3 and 5 = FizzBuzz \n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Append(" FizzBuzz \n");
                } else if (i % 3 == 0)
                {
                    result.Append(" Buzz \n");
                } else
                {
                    result.Append(" " + i.ToString() + " \n");
                }
            }
            Console.WriteLine(result);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
