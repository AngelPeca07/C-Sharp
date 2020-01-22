using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla;

            Console.WriteLine("Ingrese tabla a calcular");
            tabla = int.Parse(Console.ReadLine());

            /*int i = 1; // Parte 1
            while (i <= 10 /*Parte 2) {
                Console.WriteLine("" + tabla * i);
                i++; // Parte 3
            }*/
            for (int i=0; i<=10; i++){
                Console.WriteLine("" + tabla * i);
            }


            Console.ReadKey();
        }
    }
}
