using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Boolean isMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static Boolean areParenthesisBalanced(char[] exp)
        {
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < exp.Length; i++)
            {

                if (exp[i] == '(')
                {
                    st.Push(exp[i]);
                }

                if (exp[i] == ')')
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }

                    else if (!isMatchingPair(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                }

            }

            if (st.Count == 0)
            {
                return true; /*balanced*/
            }
            else
            { /*not balanced*/
                return false;
            }
        }
        public static void Main(string[] args)
        {
            char[] exp = {'(','(',')',')'};
            if (areParenthesisBalanced(exp))
                Console.WriteLine("Balanced " );
            else
                Console.WriteLine("Not Balanced ");
            Console.ReadKey();
        }
    }

}
