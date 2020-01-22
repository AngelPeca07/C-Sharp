using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_2_num
{
    class Program
    {
        // Write a C# Sharp program to swap two numbers.
        // Test Data:
        //Input the First Number : 5
        // Input the Second Number : 6
        // Expected Output After Swapping :
        // First Number : 6
        // Second Number : 5

        
        static void Main(string[] args)
        {
            Swap s = new Swap();

            s.swap();
            /*
            int num1;
            int num2;

            Console.WriteLine("Input the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("************ SWAPPING ************");

            Console.WriteLine("The first number is: " + num2);
            Console.WriteLine("The second number is: " + num1);*/



            Console.ReadKey();
        }
    }
}
