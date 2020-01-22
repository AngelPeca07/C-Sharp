using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            myFunct();
            //int[] array1 = { 1, 2, 5 };
            //Console.WriteLine("Array1: [{0}]", string.Join(",", array1));
            //int[] array2 = { 0, 3, 8 };
            //Console.WriteLine("Array2: [{0}]", string.Join(",", array2));
            //int[] array3 = { -1, 0, 2 };
            //Console.WriteLine("Array2: [{0}]", string.Join(",", array3));
            //int[] new_array = { array1[1], array2[1], array3[1] };
            //Console.WriteLine("\nNew array: [{0}]", string.Join(",", new_array));
            //Console.ReadKey();
        }
        static void myFunct()
        {
            Console.WriteLine("Input a sentence: ");
            string str = Console.ReadLine();

            int line = str.Length; //Python -> 6
                                   //hesdrujula -> 10
                                   //holi -> 4

            Console.WriteLine(str[(line-1)] + str.Substring(1,line-2) + str[0]);

            Console.ReadKey();
        }
    }
}
