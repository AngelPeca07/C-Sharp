using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibona1
{
    class Recursivo
    {
        public int fibonacci(int numero)
        {
            if(numero < 2){
                return numero;
            }else{
                return fibonacci(numero - 1) + fibonacci(numero - 2);
            }
        }
        public int factorial(int numero)
        {
            if(numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * factorial(numero - 1);
                //3*2*1*1
            }
        }
    }
}
