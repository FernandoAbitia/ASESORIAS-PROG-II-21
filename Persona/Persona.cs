using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Persona
    {
        private int Edad;
        private string Nombre;

        public Persona(int Edad, string Nombre)
        {
            this.Edad = Edad;
            this.Nombre = Nombre;
        }

        public int pEdad
        {
            get
            {
                return Edad;
            }

            set
            {
                Edad = value;
            }

        }

        public string pNombre
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }
    }
}
