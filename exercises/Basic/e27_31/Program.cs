using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e27_31
{
    class Program
    {
        static void Main(string[] args)
        {
            //e27();
            //e28();
            //e30();
            e31();
            Console.ReadKey();
        }

        public static void e27()
        {
            //Write a C# program and compute the sum of the digits of an integer.
            Console.WriteLine("Input an integer.");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0; // sum = 4, 123 
            while (num != 0)
            {
                sum = sum + num % 10; // num % 10 siempre nos dará el núm después del punto.
                num = num / 10; // Quita el último dígito
            }
            Console.WriteLine("La suma es: " + sum);
        }

        public static void e28()
        {
            //Write a C# program to reverse the words of a sentence. 
            string s1 = "", s2 = "";
            Console.WriteLine("Input a sentence: ");
            s2 = Console.ReadLine();

            for (int i = s2.Length - 1; i>=0; i--)
            {
                s1 = s1 + s2[i];
            }

            Console.WriteLine("The sentence reversed is: " + s1);
            
        }

        public static void e30()
        {
            //Write a C# program to convert a hexadecimal number to decimal number.
            string hexString = "8E2";
            int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(num);
        }

        public static void e31()
        {
            //Write a C# program to multiply corresponding elements of two arrays of integers.
            int[] array1 = {1,3,-5,4};
            int[] array2 = {1,4,-5,-2};

            Console.WriteLine("Array 1: [{0}]", string.Join(", ", array1));
            Console.WriteLine("Array 2: [{0}]", string.Join(", ", array2));

            for (int i=0; i<array1.Length; i++)
            {
                Console.WriteLine(array1[i] * array2[i]);
            }
            Console.WriteLine();
        }
    }
}
