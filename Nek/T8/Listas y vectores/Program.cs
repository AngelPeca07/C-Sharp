using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_y_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estamos haciendo un constructor
            List<String> nombres = new List<String>();

            // método llamado .Add
            nombres.Add("Daniel");
            nombres.Add("María");
            nombres.Add("Gerardo");
            nombres.Add("Juanita");

            for (int i = nombres.Count/2; i<nombres.Count; i++){
                Console.WriteLine(nombres[i]);
            }
            Console.ReadKey();
        }
    }
}


