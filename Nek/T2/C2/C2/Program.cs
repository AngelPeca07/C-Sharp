using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos d = new Datos("Angel Peña", 24); //Aquí se está instanciando a la clase sino lo hacemos el programa lo pondrá (estará implicitamente))

            // Console.WriteLine("Escribe tu nombre");
            // setNombre (String readline)
            // d.setNombre(Console.ReadLine());

            Console.WriteLine("El nombre es: " + d.getNombre()); //se hace referencia al objeto en nombre y edad, objeto: d
            Console.WriteLine("La edad es: " + d.getEdad());
            Console.ReadKey();
        }
    }
}
