using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string cont = null;
                string hexv;
                int decn;
                int answ;
                int dec2;
            do
            {

                Console.WriteLine("Hex to Dec: 1 | Dec to Hex: 2");
                answ = Convert.ToInt32(Console.ReadLine());

                if (answ == 1)
                {
                    Console.WriteLine("Enter the hexadecimal number: ");
                    hexv = Convert.ToString(Console.ReadLine());

                    decn = int.Parse(hexv, System.Globalization.NumberStyles.HexNumber);
                    Console.WriteLine("\nThe decimal value is {0} ", decn);
                }
                else
                {
                    Console.WriteLine("Enter a decimal number: ");
                    dec2 = Convert.ToInt32(Console.ReadLine());
                    string hex2 = dec2.ToString("X");
                    Console.WriteLine("\nThe hex value is: {0} ", hex2);
                }

                //https://stackoverflow.com/questions/74148/how-to-convert-numbers-between-hexadecimal-and-decimal

                Console.WriteLine("\nDesea continuar ejecutando la aplicación (S/N)");

                cont = Console.ReadLine();
            } while (cont == "S" || cont == "s");
        }
    }
}
