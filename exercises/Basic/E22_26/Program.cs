using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(e22(80));
            //e23();
            e24();
            //e25();
            //e26();
            Console.ReadKey();
        }

        public static bool e22(int n)
        {
            //Write a C# program to check if an given integer is 
            //within 20 of 100 or 200.

            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void e23()
        {
            Console.WriteLine("Input a sentence in capital letters.");
            string str = Console.ReadLine();
            Console.WriteLine(str.ToLower());
        }
            
        public static void e24()
        {
            //Write a C# program to find the longest word in a string.

            Console.WriteLine("Input a sentence to check the longest word.");
            //string str = Console.ReadLine();//Esto es una prueba
            string str = "1234";

            string[] array = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = null;
            int ctr = 0;

            foreach (string s in array)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word + " The length of the word is: " + ctr);
        }
        
        public static void e25()
        {
            //Write a C# program to print the odd numbers from 1 to 99

            for (int i = 1; i<100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void e26()
        {
            //Write a C# program to compute the sum of the first 500 prime numbers.
            //Sum of the first 500 prime numbers: 3682913

            Console.WriteLine("w3 answer");

            
        }
    }
}
