using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Calculo
    {
        string nombre;
        float Calificacion1, Calificacion2, op;

        public Calculo(){
            Console.WriteLine("\nEste es un objeto llamado cálculo");
        }

        public void Calculos(){
            Console.WriteLine("\nEn este método haremos las operaciones");

            Console.WriteLine("Ingresa nombre de alumno: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa calificación 1 ");
            Calificacion1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa calificación 2 ");
            Calificacion2 = float.Parse(Console.ReadLine());

            op = (Calificacion1+Calificacion2)/2;
            Console.WriteLine("Tu calificación es: " + op);

            if (op >= 60){
                Console.WriteLine("Pass");
            }
            else{
                Console.WriteLine("Fail");
            }
        }
    }
}
