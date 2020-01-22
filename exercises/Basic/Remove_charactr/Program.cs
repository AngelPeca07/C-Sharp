using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_charactr
{
    class Program
    {
        static void Main(string[] args)
        {
            String n = new String();
            n.remove_char("Elefante", 1);
            n.remove_char("Elefante", 0);
            n.remove_char("Elefante", 7);

            Console.ReadKey();
        }
    }
}
