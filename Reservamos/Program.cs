using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservamos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a String formed only by parenthesis check if they are 
            //well balanced(Every parenthesis that opens closes).
            //char[] exp = {'(',')'};
            exp("(",")",")",")");
            Console.ReadKey();

        }

        static void exp(string character1, string character2, string character3, string character4)
        {
            if (character1[0] == '(' && character2[1] == '(' && character3[2] == ')' && character4[3] == ')')
            {
                Console.WriteLine("The characters are balanced");
            }
            else
            {
                Console.WriteLine("The characters mismatch");
            }
        } 
    }
}
