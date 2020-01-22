using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2_Array
{
    class Arreglo
    {
        public void Array(){

            // Array declarado
            int[] arr = new int[10];
            

            Console.WriteLine("\n\nRead and print elements of an array:\n");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Input 10 elements in the array: \n");
            for (int i=0; i<10; i++){
                Console.WriteLine("Element - {0} : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nElements in array are: ");
            for (int i=0; i<10; i++){
                Console.WriteLine("{0} ", arr[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
