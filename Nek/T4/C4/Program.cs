using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            float Calificacion1, Calificacion2, promedio;

            Console.WriteLine("Ingresa nombre de alumno: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa calificación 1 ");
            Calificacion1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa calificación 2 ");
            Calificacion2 = float.Parse(Console.ReadLine());

            promedio = (Calificacion1 + Calificacion2) / 2;

            Console.WriteLine(nombre +  " tu calificación es: " + promedio);

            if(promedio > 6) {
                Console.WriteLine("Pasaste");
            }
            else {
                Console.WriteLine("Reprobaste");
            }

            Console.ReadKey();
        }
    }
}
