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
            Console.WriteLine("Please enter 1 to 100");
            string str = Console.ReadLine();
            int num = Int32.Parse(str);
            StringBuilder result = new StringBuilder("");

            Console.WriteLine("\n");
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
        }
    }
}
