using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program remove specified a character from 
            //a non-empty string using index of a character.
            Console.WriteLine("W3Solution");
            Console.WriteLine(w3Funct("Python", 1));
            Console.WriteLine(w3Funct("Python", 0));

            Console.WriteLine("\nMy solution");
            Console.WriteLine("Input a string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str.Remove(0,1));
            Console.ReadKey();
        }
        //W3 Solution
        public static string w3Funct(string w3Funct, int n)
        {
            
            return w3Funct.Remove(n,1);
        }
    }
}
