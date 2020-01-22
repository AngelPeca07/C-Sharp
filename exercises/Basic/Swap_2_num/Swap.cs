using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_2_num
{
    class Swap
    {
        public void swap()
        {
            int num1, num2, temp;

            Console.WriteLine("Input the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nAfter swapping: ");
            Console.WriteLine("\nFirst number: " + num1);
            Console.WriteLine("\nSecond number:" + num2);
        }
    }
}
