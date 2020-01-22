using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Get
{
    class Animal
    {
        // atributos son variables 
        private String raza;

        // métodos son miembros de la clase

        // camel case
        //Estos métodos son comunes y cotidianos por ejemplo de java, hay una forma de hacerlos para C#:
        public String Raza
        {
            set { this.raza = value; }
            get {
                switch (raza)
                {
                    case "Labrador":
                        this.raza += " y es un perro";
                        break;
                }
                return this.raza;
            }
        }
       /* public void setRaza(String raza) 
        {
            this.raza = raza;
            // this, estamos haciendo una referencia a esta clase 
            // o a este objeto el cual es la clase Animal
        }

        public String getRaza()
        {
            switch (raza) {
                case "Labrador":
                    this.raza += " y es un perro";
                    break;
            }
            return this.raza;
        }*/
    }
}
