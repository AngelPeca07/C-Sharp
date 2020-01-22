using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    class ClassA
    {
        public void arrayN()
        {
            int[] a = new int[5];

            // ingresan valores en un arreglo

            a[0] = 7;
            a[1] = 8;
            a[2] = 2;
            a[3] = 1;
            a[4] = 0;

            // recorre un arreglo
            foreach(int x in a){
                Console.WriteLine(x);
            }
        }
    }
}
