// bibliotecas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//proyecto 
namespace C1
{
    //Clase 
    class Program
    {
        // Método
        // static = global
        // void = sin regreso de valores
        // Main = Nombre del método 
        // (Argumentos que hará uso el método)
        static void Main(string[] args)
        {
            // Vamos a instanciar la clase métodos

            metodos m = new metodos(); //Construyendo objeto 

            m.mensaje();

            Console.ReadKey();

        }
    }
}
