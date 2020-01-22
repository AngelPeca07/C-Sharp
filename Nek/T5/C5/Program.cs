using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 0;
            String s1 = null;

            do {

                Console.WriteLine("Elige una opción\n" +
                "\n1.- Suma" +
                "\n2.- Resta" +
                "\n3.- Multiplicación" +
                "\n4.- División" +
                "\n5.- Módulo(%)\n");
            

                s1 = Console.ReadLine();

                switch (i1) {
                    case 1:
                        Console.WriteLine("Opción Suma");
                        break;
                    case 2:
                        Console.WriteLine("Opción Resta");
                        break;
                    case 3:
                        Console.WriteLine("Opción Multiplicación");
                        break;
                    case 4:
                        Console.WriteLine("Opción División");
                        break;
                    case 5:
                        Console.WriteLine("Opción Módulo");
                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado una opción");
                        break;
                }

                Console.WriteLine("Desea continuar ejecutando la aplicación (S/N)");

                s1 = Console.ReadLine();
            } while (s1 == "S" || s1 == "s"); // "S" o "s" son válidas
        }
    }
}
