using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e32_40
{
    class Program
    {
        static void Main(string[] args)
        {
            //e32();
            //Console.WriteLine(e33(25));
            //e33W3Sol();
            //e34();
            //e34W3Sol();
            //e37();
            //e38();
            //e38W3Sol();
            //e39();
            //e39W3Sol();
            e40();
            Console.ReadKey();
        }

        public static void e32()
        {
            //Write a C# program to create a new string of four copies, 
            //taking last four characters from a given string. 
            //If the length of the given string is less than 4 return the original one.

            //This example is taking the last 2 characters
            Console.WriteLine("Input a sentence: ");
            string str = Console.ReadLine();
            //string str = "Python";
            int line = str.Length-2;
            string copies = str.Substring(line,2);
            Console.WriteLine(copies+ copies+ copies + copies);

            //This example is taking the last 4 characters
            Console.WriteLine("Input a sentence: ");
            string str1 = Console.ReadLine();

            if (str1.Length > 4) {
                Console.WriteLine(str1.Substring(str1.Length - 4) + str1.Substring(str1.Length - 4) + str1.Substring(str1.Length - 4) + str1.Substring(str1.Length - 4));
            }
            else
            {
                Console.WriteLine(str1);
            }
        }
        public static bool e33(int num)
        {
            //Write a C# program to check if a given positive number 
            //is a multiple of 3 or a multiple of 7.
            //Console.WriteLine("Input a (+) number: ");
            //int num = int.Parse(Console.ReadLine());
            Console.WriteLine("My solution is:");
            if (num % 3 == 0 || num % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static void e33W3Sol()
        {
            Console.WriteLine("Input the integer: ");
            int x = int.Parse(Console.ReadLine());

            if (x>0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0);
            }
        }

        public static void e34()
        {
            //Write a C# program to check if a string starts with a specified word.
            string str = "Hello my niggas";

            string[] box = str.Split(new[] { " " }, StringSplitOptions.None);

            if (str.Length > 0)
            {
                Console.WriteLine(box[0] == "Hello");
            }
        }

        public static void e34W3Sol()
        {
            string str;
            Console.WriteLine("Input a string: ");
            str = Console.ReadLine();
            Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
        }

        public static void e37()
        {
            //Write a C# program to check if "HP" appears at second position in a 
            //string and returns the string without "HP".

            string str = "PHP Tutorial";

            if (str.Substring(1, 2).Equals("HP"))
            {
                Console.WriteLine(str.Remove(1,2));
            }
                       
        }
        public static void e38()
        {
            //Write a C# program to get a new string of two characters 
            //from a given string. The first and second character of the 
            //given string must be "P" and "H", so PHP will be "PH".

            string str = "PHP Tutorial";

            if (str.StartsWith("PH"))
            {
                Console.WriteLine(str.Substring(0,2));
            }
        }

        public static void e38W3Sol()
        {
            string str1 = "PHP Tutorial";
            var result = "";

            if(str1.Length >= 1 && str1[0] == 'P')
            {
                result += str1[0];
                Console.WriteLine(result);
            }
            if (str1.Length >= 2 && str1[1] == 'H')
            {
                result += str1[1];
                Console.WriteLine(result);
            }
        }

        public static void e39()
        {
            Console.WriteLine("Input first integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third integer: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2){
                if(num1 > num3)
                {
                    Console.WriteLine("The first value is greatest: " + num1);
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The second value is greatest: " + num2);
            }
            else
            {
                Console.WriteLine("The third value is greatest: " + num3);
            }
        }

        public static void e39W3Sol()
        {
            Console.WriteLine("Input first integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third integer: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Largest of three: " +Math.Max(num1,Math.Max(num2,num3)));
            Console.WriteLine("Lowest of three: " + Math.Min(num1, Math.Min(num2, num3)));
        }
        public static void e40()
        {
            //Write a C# program to check the nearest value of 20 of two given integers 
            //and return 0 if two numbers are same.
            Console.WriteLine("Input first integer: ");
            int n1 = int.Parse(Console.ReadLine()); //15
            Console.WriteLine("Input second integer: ");
            int n2 = int.Parse(Console.ReadLine()); //10

            int r = Math.Abs(20 - n1); //5
            int r1 = Math.Abs(20 - n2);//10 // 5 > 10

            if (r < r1)
            {
                Console.WriteLine("The nearest value of 20 is: " + n1);
            }
            else
            {
                Console.WriteLine("The nearest value of 20 is: " + n2);
            }
        }
    }
}
