using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class ManejaPersonas
    {
        private Dictionary<int, Persona> Persona;
        private int Clave;

        public ManejaPersonas()
        {
            Persona = new Dictionary<int, Persona>();
            Clave = 1;
        }

        public void Agregar(Persona P)
        {
            Persona.Add(Clave,P);
            Clave++;
        }

        public Persona Consulta(string Nombre)
        {
            foreach (KeyValuePair<int,Persona> item in Persona)
            {
                if (item.Value.pNombre == Nombre)
                    return item.Value;
            }
            return null;
        }

        public bool ModificaNombre(int Clave, string nvoNombre)
        {
            foreach (KeyValuePair<int, Persona> item in Persona)
            {
                if (item.Key == Clave)
                {
                    item.Value.pNombre = nvoNombre;
                    return true;
                }
            }
            return false;
        }

        public String ImprimirArreglo()
        {
            string Mensaje = "";

            foreach (KeyValuePair<int,Persona> item in Persona)
            {
                Mensaje += "NOMBRE: " + item.Value.pNombre + " EDAD: " + item.Value.pEdad;
            }
            return Mensaje;
        }

        public void OrdenarArregloEdad()
        {

        }

        public void OrdenarArregloNombre()
        {


        }

        public bool PersonaExistente(string Nombre, int Edad)
        {
            foreach (KeyValuePair<int, Persona> item in Persona)
            {
                if (item.Value.pNombre == Nombre && item.Value.pEdad == Edad)
                    return true;
            }
            return false;
        }

        public int pContador
        {
            get
            {
                return Persona.Count;
            }
        }
    }
}
