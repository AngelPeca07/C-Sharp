using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E17_E21
{
    class Program
    {
        static void Main(string[] args)
        {
            //e17();
            //e18();
            //e19();
            //w3SolE19();
            //e20();
            e21();
            //Console.WriteLine(w3SolE20(5,2));

            Console.ReadKey();
        }

        public static void e17()
        {
            //Write a C# program to create a new string from a given string (length 1 or more ) 
            //with the first character added at the front and back.
            Console.WriteLine("My solution");
            Console.WriteLine("\nInput a string: ");
            string line = Console.ReadLine();
            Console.WriteLine("The new string is: " + line[0] + line + line[0]);
        }

        public static void w3SolE17()
        {
            Console.WriteLine("w3Solution");
            string str;
            Console.WriteLine("Input a string: ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
        }

        public static void e18()
        {
            //Write a C# program to check two given integers and return true 
            //if one is negative and one is positive.
            Console.WriteLine("Input the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0));
        }

        public static void e19()
        {
            //Write a C# program to compute the sum of two given integers, 
            //if two values are equal then return the triple of their sum.
            Console.WriteLine("My solution");

            int sum, reslt;

            Console.WriteLine("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                sum = num1 + num2;
                reslt = sum * 3;
                Console.WriteLine("The triple of their sum is: " + reslt);
            }
            else
            {
                sum = num1 + num2;
                Console.WriteLine(sum);
            }
        }

        public static void w3SolE19()
        {
            Console.WriteLine("w3 solution");

            Console.WriteLine("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 == num2 ? (num1 + num2)*3 : num1 + num2);

        }

        public static void e20()
        {
            //Write a C# program to get the absolute value of the difference between 
            //two given numbers. Return double the absolute value of the difference if 
            //the first number is greater than second number.
            Console.WriteLine("My solution");

            int reslt;

            Console.WriteLine("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            reslt = num1 - num2;
            Console.WriteLine(Math.Abs(reslt));

            if (num1 > num2)
            {
                Console.WriteLine("The dobule of the Abs is: " + reslt * 2);
            }
            
        }
        public static int w3SolE20(int a, int b)
        {
            if(a > b)
            {
                return (a - b) * 2;
            }
            return (b - a);
        }
        public static void e21()
        {
            //Write a C# program to check the sum of the two given integers 
            //and return true if one of the integer is 20 or if their sum is 20.
            Console.WriteLine("My solution and the w3's solution is the same.");
            Console.WriteLine("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 == 20 || num2 == 20 ||  (num1 + num2 == 20));  ;
        }
    }
}
