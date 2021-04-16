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

        public bool PersonaExistente(string Nombre, int Edad)
        {
            foreach (KeyValuePair<int, Persona> item in Persona)
            {
                if (item.Value.pNombre == Nombre && item.Value.pEdad == Edad)
                    return true;
            }
            return false;
        }
        public bool ClaveExistente(int Clave)
        {
            if (Persona.ContainsKey(Clave))
                return true;

            return false;

        }

        public void ModificaNomPorClave(int Clave, string nvoNombre)
        {
            Persona[Clave].pNombre = nvoNombre;
        }
        public Persona ConsultaPorClave(int Clave)
        {
            if (ClaveExistente(Clave))
                return Persona[Clave];

            return null;
        }

        public Persona ConsultaPorNombre(string Nombre)
        {
            foreach (KeyValuePair<int,Persona> item in Persona)
            {
                if (item.Value.pNombre == Nombre)
                    return item.Value;
            }
            return null;
        }

        public String ImprimirArreglo()
        {
            string Mensaje = "";

            foreach (KeyValuePair<int,Persona> item in Persona)
            {
                Mensaje += "\n"+ "Clave: " +item.Key+ " "+item.Value.ToString();
            }
            return Mensaje;
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
