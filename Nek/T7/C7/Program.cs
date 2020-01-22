using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Arreglo es como una colección de datos

            // array inicializado (esta forma no es tan practica)
             int[] array = {5,9,2,1,7,3,8,6,4,0};
            //int[] array = {1,2,3,4,5,6,7,8,9,10};

            // array declarado 
            int[] array2 = new int[10];

            //
            int[] array3 = new int[10] { 5, 9, 2, 1, 7, 3, 8, 6, 4, 0};

            int[] array4 = new int[] { 5, 9, 2, 1, 7, 3, 8, 6, 4, 0};

            //Se puede usar este for para copiar los datos 
            /*for(int i = 0; i < array.Length; i++){
                array2[i] = array[i];
            }*/

            // o este 
            array.CopyTo(array2, 0);

            for (int i = 0; i < 9; i++){
                Console.WriteLine("" + array[i]);
            }

            Console.WriteLine("Ahora vamos a recorrer un arreglo con el foreach (se creó una clase para más orden) y nos dá lo siguiente: ");
            ClassA A = new ClassA();
            A.arrayN();

            Console.ReadKey();
        }
    }
}
