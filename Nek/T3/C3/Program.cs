using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de dato

            //enteros, valore sin punto flotante o décimal

            byte bt = 255;
            short sh = 32767;
            int entero = 213124123;
            long l = 1231231237;

            //con punto flotante 

            float f1 = 3.1416F;
            double d1 = 45.124231; //más precisión que el float

            Console.WriteLine("byte " + byte.MinValue + " " + byte.MaxValue); //alcance del tipo de dato byte 
            Console.WriteLine("float " + float.MinValue + " " + float.MaxValue);

            // la variable a la que se le asignará el valor = tipo de dato . Parse ( String );
            entero = byte.Parse("154");//Para convertir valores 

            Console.WriteLine("El valor capturado de consola es = " + entero);

            f1 = float.Parse("3.1212");

            Console.WriteLine("El valor capturado de consola para un float es = " + f1);

            Console.ReadKey();


        }
    }
}
