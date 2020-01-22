using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28
{
    class Program
    {
        static void Main(string[] args)
        {
            //easiest();
            myFunct();
            // Write a C# program to reverse the words of a sentence.
            
            Console.WriteLine("Input a sentence: ");
            string line = Console.ReadLine();

            Console.WriteLine("\nOriginal string: " + line);
            string result = null;

            List<string> wordsList = new List<string>();

            string[] words = line.Split(new[] {" "}, StringSplitOptions.None);
            for (int i = words.Length-1; i >= 0; i--) {
                result = result + words[i] + " ";
            }
            wordsList.Add(result);
            foreach(string s in wordsList)
            {
                Console.WriteLine("\nReverse String: " + s);
            }

            Console.ReadKey();
            
        }

        public static void myFunct()
        {
            Console.WriteLine("Ingresa cadena: ");
            string line = Console.ReadLine();
            //string line = "Hola soy yoda";
            string results = null;

            List<string> container = new List<string>();

            string[] cadena = line.Split(new[] {" "}, StringSplitOptions.None);
            for (int i = cadena.Length - 1; i >= 0; i--) {
                results = results + cadena[i] + " ";
            }
            container.Add(results);
            foreach (string c in container)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }

        public static void easiest()
        {
            string f1 = "", f2 = "";// Variables string, cadena de caracteres

            Console.WriteLine("Escriba frase a invertir: ");
            f1 = Console.ReadLine();
            
            for (int i = f1.Length-1; i>=0; i--)//Ciclo for que recorre la cadena 1
            {
                f2 = f2 + f1[i]; // Agrega caracter por caracter a la segunda cadena iniciando desde el último

            }
            Console.WriteLine("Frase invertida: " + f2);

            Console.ReadKey();
        } 
    }
}
