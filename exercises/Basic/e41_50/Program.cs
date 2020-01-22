using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e41_50
{
    class Program
    {
        static void Main(string[] args)
        {
            e41();
            Console.ReadKey();
        }
        public static void e41()
        {
            //Write a C# program to check if a given string contains ‘w’ 
            //character between 1 and 3 times.
            string s1 = "w3Resoursew";
            string s2 = "";

            string[] line = s1.Split(new[] { "" } , StringSplitOptions.None);
            for (int i = s1.Length; i>=0; i++)
            {
                s2 = s2 + s1[i];
            }

            Console.WriteLine(s2);
        }
    }
}
