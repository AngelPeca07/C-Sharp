using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosMultidi
{
    class Program
    {
        static void Main(string[] args)
        {
            // matriz
            int[] matriz = { }; // matriz unidimensional 

            // Forma incorrecta
            int[,] matriz1 = { {2,4},{6,8} }; // matriz inicializada  

            int[,] matriz2 = new int[2, 2]; // van a estar inicializados en 0 

            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++){
                    Console.WriteLine(matriz1[i,j]);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matriz2[i, j]);
                }
            }

            // agregar valores a una matriz 
            matriz2[0, 0] = 1;
            matriz2[0, 1] = 3;
            matriz2[1, 0] = 5;
            matriz2[1, 1] = 7;

            // Suma de matrices 
            // Sumar matriz 1 con matriz 2 

            int[,] matriz3 = new int[2,2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++){
                    matriz3[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matriz3[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
