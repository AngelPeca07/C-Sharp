using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Get
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();

            a.Raza = "Labrador"; // Uso del método set
            Console.WriteLine(a.Raza); // accediendo al método get 
            // Labrador y es un perro 

            Console.ReadKey();
        }
    }
}
