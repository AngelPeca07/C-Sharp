using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddcharToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hola";

            //Console.WriteLine("Input a string: ");
            //str = Console.ReadLine();
            

            if (str.Length >=1){
                var s = str.Substring(2, 2);
                Console.WriteLine(s);
                Console.WriteLine(s + str + s);
            }

            Console.ReadKey();
        }
    }
}
