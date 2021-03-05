using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class ManejaPersonas
    {
        private Persona[] Personas;
        private int Contador;

        public ManejaPersonas()
        {
            Personas = new Persona[5];
            Contador = 0;
        }

        public void Agregar(Persona P)
        {
            Personas[Contador] = P;
            Contador++;
        }

        public Persona Consulta(string Nombre)
        {
            for (int i = 0; i < Contador; i++)
            {
                if (Personas[i].pNombre == Nombre)
                    return Personas[i];
            }
            return null;
        }

        public bool ModificaNombre(Persona P, string NvoNombre)
        {
            //CAMBIAR LÓGICA DEL MÉTODO Y PARÁMETROS
            for (int i = 0; i < Contador; i++)
            {
                if (Personas[i].pNombre == P.pNombre)
                {
                    Personas[i].pNombre = NvoNombre;
                    return true;
                }
            }
            return false;
        }

        public int BuscaPosicion(string Nombre)
        {
            int pos = -1;

            //BUSCAR LA POSICIÓN DE ESA PERSONA EN EL ARREGLO A TRAVÉS DEL NOMBRE

            return pos;
        }

        public String ImprimirArreglo()
        {
            string Mensaje = "";

            for (int i = 0; i < Contador; i++)
                Mensaje += "\nNOMBRE: " + Personas[i].pNombre + " EDAD: " + Personas[i].pEdad;

            return Mensaje;
        }

        public void OrdenarArregloEdad()
        {
            Persona aux;

            for (int i = 0; i < Contador-1; i++)
            {
                for (int j=i+1; j < Contador; j++)
                {
                    if (Personas[i].pEdad > Personas[j].pEdad)
                    {
                        aux = Personas[i];
                        Personas[i] = Personas[j];
                        Personas[j] = aux;
                    }
                }
            }
        }

        public void OrdenarArregloNombre()
        {
            Persona aux;

            for (int i = 0; i < Contador - 1; i++)
            {
                for (int j = i + 1; j < Contador; j++)
                {
                    if (Personas[i].pNombre.CompareTo(Personas[j].pNombre) == 1)
                    {
                        aux = Personas[i];
                        Personas[i] = Personas[j];
                        Personas[j] = aux;
                    }
                }
            }

        }

        public bool PersonaExistente(string Nombre, int Edad)
        {
            for (int i=0;i<Contador; i++)
            {
                if (Personas[i].pNombre == Nombre && Personas[i].pEdad == Edad)
                    return true;
            }
            return false;
        }

        public int pContador
        {
            get
            {
                return Contador;
            }
        }

        public int pTamañoArreglo
        {
            get
            {
                return Personas.Length;
            }
        }
    }
}
