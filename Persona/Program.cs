using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        //DEFINIR ARREGLO DE PERSONAS
        public Program()
        {
            //INICIALIZAR
            Principal();
        }

        public void Principal()
        {
            int Edad;
            string Nombre;

            Console.WriteLine("ESCRIBE TU NOMBRE");
            Nombre = Console.ReadLine();
            Console.WriteLine("ESCRIBE TU EDAD");
            Edad = Convert.ToInt32(Console.ReadLine());

            Persona A = new Persona(Edad,Nombre);

            Console.WriteLine("SU NOMBRE ES: "+A.pNombre);
            Console.WriteLine("SU EDAD ES: "+A.pEdad);

            Console.ReadKey();

            Console.WriteLine("CUÁL ES SU NUEVO NOMBRE");
            Nombre = Console.ReadLine();

            A.pNombre = Nombre;

            Console.WriteLine("SU NUEVO NOMBRE ES: "+A.pNombre);

            Console.ReadKey();
        }


        static void Main(string[] args)
        {
           new Program();
        }
    }
}
