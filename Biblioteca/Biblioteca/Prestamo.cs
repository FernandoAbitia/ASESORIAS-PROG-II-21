using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Prestamo
    {
        private int Clave;
        private string ISBN;
        private string NombreUsuario;
        private string TipoUsuario;

        public Prestamo(int Clave, string ISBN, string NombreUsuario, string TipoUsuario)
        {
            this.Clave = Clave;
            this.ISBN = ISBN;
            this.NombreUsuario = NombreUsuario;
            this.TipoUsuario = TipoUsuario;
        }

        public int pClave
        {
            get
            {
                return Clave;
            }
            set
            {
                Clave = value;
            }
        }

        public string pISBN
        {
            get
            {
                return ISBN;
            }
            set
            {
                ISBN = value;
            }
        }

        public string pNombreUsuario
        {
            get
            {
                return NombreUsuario;
            }
            set
            {
                NombreUsuario = value;
            }
        }

        public string pTipoUsuario
        {
            get
            {
                return TipoUsuario;
            }
            set
            {
                TipoUsuario = value;
            }
        }
        public bool pSala
        {
            get
            {
                return pSala;
            }
            set
            {
                pSala = value;
            }

        }

        public override string ToString()
        {
            return "\n CLAVE: " + Clave + "\n ISBN: " + ISBN + "\n NOMBRE USUARIO: " + NombreUsuario + "TIPO USUARIO: " + TipoUsuario+ "\n";
        }
    }
}
