using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class CapaPersona
    {
        ManejaPersonas MP;

        public CapaPersona(ManejaPersonas MP)
        {
            this.MP = MP;
        }

        public void Menu()
        {
            int op = -1;

            do
            {
                Console.WriteLine("--------MENÚ--------");
                Console.WriteLine("SELECCIONA UNA OPCIÓN");
                Console.WriteLine(" 1.- AGREGAR \n 2.- CONSULTAR \n 3.- IMPRIMIR ARREGLO \n 4.- MODIFICAR NOMBRE\n 0.- SALIR");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Agregar();
                        break;

                    case 2:
                        Consulta();
                        break;

                    case 3:
                        Imprimir();
                        break;

                    case 4:
                        ModificaPorClave();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("PROPORCIONA UNA OPCIÓN VÁLIDA");
                        break;
                }

            } while (op != 0);
        }

        public void Agregar()
        {

            string Nombre;
            int Edad;
            Persona P;

            do
            {
                Console.WriteLine("PROPORCIONE EL NOMBRE");
                Nombre = Console.ReadLine();

            }while(Nombre.Length==0);

            do
            {
                Console.WriteLine("PROPORCIONE LA EDAD");
                Edad = Convert.ToInt32(Console.ReadLine());

            } while (Edad < 0);

            if (MP.PersonaExistente(Nombre.ToUpper(), Edad))
            {
                Console.WriteLine("LA PERSONA YA SE ENCUENTRA EN EL ARREGLO");
                return;
            }

            P = new Persona(Edad, Nombre.ToUpper());
            MP.Agregar(P);
        }

        public void Consulta()
        {
            if (MP.pContador == 0)
            {
                Console.WriteLine("NO HAY PERSONAS QUE BUSCAR");
                return;
            }

            string Nombre;
            Persona P;

            do
            {
                Console.WriteLine("PROPORCIONE EL NOMBRE DE LA PERSONA A BUSCAR");
                Nombre = Console.ReadLine();

            } while (Nombre.Length == 0);

            P = MP.ConsultaPorNombre(Nombre.ToUpper());


            if (P == null)
            {
                Console.WriteLine("LA PERSONA NO EXISTE EN EL ARREGLO");
                return;
            }

            Console.WriteLine("--DATOS DE LA PERSONA");
            Console.WriteLine(P.ToString());
        }

        public void Imprimir()
        {
            Console.WriteLine("DATOS DE LAS PERSONAS:");
            Console.WriteLine(MP.ImprimirArreglo());
        }
        public void ModificaPorClave()
        {
            string nvoNombre;
            int Clave;

            Console.WriteLine("PROPORCIONA LA CLAVE DE LA PERSONA");
            Clave = Convert.ToInt32(Console.ReadLine());

            if (!MP.ClaveExistente(Clave))
            {
                Console.WriteLine("La clave no existe");
                return;
            }
            Console.WriteLine("PERSONA ENCONTRADA: "+MP.ConsultaPorClave(Clave).pNombre);
            Console.WriteLine("PROPORCIONA EL NUEVO NOMBRE");
            nvoNombre = Console.ReadLine();
            MP.ModificaNomPorClave(Clave,nvoNombre);
            Console.WriteLine("NOMBRE MODIFICADO CORRECTAMENTE");
        }

        public string CamibaMayusculas(string Cadena)
        {
            return Cadena.ToUpper();
        }
    }
}
