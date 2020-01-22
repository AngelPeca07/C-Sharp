using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibona1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Secuencia Fibonacci
            // 0,1,1,2,3,5,8,13,21,34,55,89,144...
            //fibonacci(3);

            // Creamos el objeto de la clase
             Recursivo r = new Recursivo();

            /* int numero = 1;

             while(numero < 10)
             {
                 Console.WriteLine(r.fibonacci(numero));
                 numero++;
             }*/

            Console.WriteLine(r.factorial(3));

            //Console.WriteLine(factorial(3));
            Console.ReadKey();
        }
        public static void fibonacci(int fin)
        {
            int numero = 1;
            int temporal = 0;
            int resultado;

            while (numero < fin) {
                Console.WriteLine(numero);
                resultado = numero + temporal;
                temporal = numero;
                numero = resultado;
            }
        }

        public static int factorial(int numero)
        {
            int temporal = 1;

            if (numero == 0) {
                return 1;
            }
            else{
                while (numero > 0)
                {
                    temporal = temporal * numero;
                    numero--;
                }
                return temporal;
            }
        }
    }
}
