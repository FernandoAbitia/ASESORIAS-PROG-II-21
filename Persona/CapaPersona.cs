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
                Console.WriteLine(" 1.- AGREGAR \n 2.- CONSULTAR \n 3.- ORDENAR \n 4.- IMPRIMIR ARREGLO \n 5.- MODIFICAR NOMBRE \n 0.- SALIR");
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
                        Ordena();
                        break;

                    case 4:
                        Imprimir();
                        break;

                    case 5:
                        Modifica();
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
            if (MP.pContador == MP.pTamañoArreglo)
            {
                Console.WriteLine("ARREGLO LLENO!!");
                return;
            }

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

            if (MP.PersonaExistente(Nombre, Edad))
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

            P = MP.Consulta(Nombre.ToUpper());


            if (P == null)
            {
                Console.WriteLine("LA PERSONA NO EXISTE EN EL ARREGLO");
                return;
            }

            Console.WriteLine("--DATOS DE LA PERSONA");
            Console.WriteLine("NOMBRE {0} EDAD {1}",P.pNombre,P.pEdad);
        }

        public void Imprimir()
        {
            Console.WriteLine("DATOS DE LAS PERSONAS:");
            Console.WriteLine(MP.ImprimirArreglo());
        }

        public void Ordena()
        {
            int op = -1;

            do
            {
                Console.WriteLine("---SUBMENÚ DE ORDEN---");
                Console.WriteLine("PROPORCIONA UNA OPCIÓN");
                Console.WriteLine(" 1.- ORDENAR POR EDAD \n 2.- ORDENAR POR NOMBR \n 0.- SALIR");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op) 
                {
                    case 1:
                        MP.OrdenarArregloEdad();
                        Console.WriteLine("ARREGLO ORDENADO CORRECTAMENTE");
                        break;

                    case 2:
                        MP.OrdenarArregloNombre();
                        Console.WriteLine("ARREGLO ORDENADO CORRECTAMENTE");
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("PROPORCIONA UNA OPCIÓN VÁLIDA");
                        break;
                }

            } while (op != 0);

        }

        public void Modifica()
        {
            int pos;
            Persona P;
            string Nombre ="";

            Console.WriteLine("PROPORCIONA EL NOMBRE DE LA PERSONA A CAMBIAR");
            Nombre = Console.ReadLine();

            pos = MP.BuscaPosicion(Nombre);

            if (pos == -1)
            {
                Console.WriteLine("LA PERSONA NO ESTÁ REGISTRADA EN EL ARREGLO");
                return;
            }
            Console.WriteLine("PROPORCIONE EL NUEVO NOMBRE");
            Nombre = Console.ReadLine();

            MP.ModificaNombre(pos,Nombre);
            Console.WriteLine("CAMBIO DE NOMBRE CORRECTO");
        }
        public string CamibaMayusculas(string Cadena)
        {
            return Cadena.ToUpper();
        }
    }
}
