using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Input a string: ");
            str = Console.ReadLine();

            if (str.Length % 2 == 0)
            {
                Console.WriteLine("Verify if the parenthesis closes");
            }
            else
            {
                Console.WriteLine("The string is odd");
            }

            Console.ReadKey();

        }
    }
}
