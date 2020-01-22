using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangecharFrom
{
    class Class1
    {
        public void String(string c){
            int len = c.Length;
            Console.WriteLine(c.Substring(1, len - 2));
            Console.WriteLine(c[5]);
            Console.WriteLine(c[len-1] + c.Substring(1,len-2) + c[0]);
        }
    }
}
