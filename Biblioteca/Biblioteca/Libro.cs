using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        private string Autor;
        private string NombreLibro;
        private string Editorial;
        private byte Existencia;
        private bool Sala;//true si es para consulta en la sala
                          //por lo tanto no se presta
        public Libro(string Autor, string NombreLibro, string Editorial, byte Existencia, bool Sala)
        {
            this.Autor = Autor;
            this.NombreLibro = NombreLibro;
            this.Editorial = Editorial;
            this.Existencia = Existencia;
            this.Sala = Sala;
        }

        public string pAutor 
        {
            get
            {
                return Autor;
            }
            set
            {
                Autor = value;
            }
        }
        public string pNombre 
        {
            get
            {
                return NombreLibro;
            }
            set
            {
                NombreLibro = value;
            }
        }
        public string pEditorial 
        {
            get 
            { 
                return Editorial; 
            }
            set
            {
                Editorial = value;
            }
        }
        public byte pExistencia 
        {
            get
            {
                return Existencia;
            }
            set
            {
                Existencia = value;
            }  
        }
        public bool pSala 
        {
            get 
            { 
                return Sala; 
            }

            set 
            {
                Sala = value;
            }
        }

        public override string ToString()
        {
            return "\n AUTOR: " + Autor+ "\n NOMBRE: "+NombreLibro+ "\n EDITORIAL: "+Editorial+ "\n EXISTENCIA: "+Existencia+ "\n SALA: "+Sala+ "\n";
        }
    }
}
