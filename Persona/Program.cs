using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        Persona[] Personas;
        public Program()
        {
            Personas = new Persona[5];
            Principal();
            ImprimeArreglo();
        }

        public void Principal()
        {
            int Edad;
            string Nombre;
            Persona P;

            for (int i = 0; i < Personas.Length; i++)
            {
                Console.WriteLine("ESCRIBE TU NOMBRE");
                Nombre = Console.ReadLine();

                Console.WriteLine("ESCRIBE TU EDAD");
                Edad = Convert.ToInt32(Console.ReadLine());

                P = new Persona(Edad, Nombre);

                Personas[i] = P;
            }

        }

        public void ImprimeArreglo()
        {
            Persona P;
            Console.WriteLine();
            Console.WriteLine("----PERSONAS EN EL ARREGLO----");
            for (int i = 0; i < Personas.Length; i++)
            {
                P = Personas[i];
                Console.WriteLine("NOMBRE: {0} EDAD: {1}",P.pNombre,P.pEdad);
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
           new Program();
        }
    }
}
