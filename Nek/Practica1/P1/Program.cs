using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En este programa vamos a practicar el manejo de clases");

            Calculo Objeto = new Calculo();

            Objeto.Calculos();

            Console.ReadKey();
        }
    }
}
