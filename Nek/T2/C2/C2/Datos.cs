using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Datos
    {
        private String nombre;
        private int edad;

        public Datos(String nombre, int edad){  //Constructor, nos sirve para inicializar o asignar cosas al momento que se crea el objeto
            this.nombre = nombre; //Los datos que reciban nombre y edad se le asignaran a las variables de la clase, las que están arriba. 
            this.edad = edad;
            // Resolver ambiguedad 
        }
        public void setNombre(String n) {
            nombre = n;
        }

        public string getNombre() {
            return nombre;
        }

        public void setEdad(int edad){
            this.edad = edad;
        }

        public int getEdad(){
            return edad;
        }

    }
}
