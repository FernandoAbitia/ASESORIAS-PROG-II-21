using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ManejaPrestamos
    {
        private int Clave;
        private List<Prestamo> Prestamos;

        public ManejaPrestamos()
        {
            Clave = 0;
            Prestamos = new List<Prestamo>();
        }

        public void Agrega(string ISBN, string Usuario, string TipoUsuario)
        {
            Clave++;
            Prestamo P = new Prestamo(Clave,ISBN,Usuario,TipoUsuario);
            Prestamos.Add(P);
        }
        public Prestamo[] ObtenPrestamos()
        {
            Prestamo[] P = new Prestamo[Prestamos.Count];

            for (int i = 0; i < Prestamos.Count; i++)
            {
                P[i] = Prestamos[i];
            }
            return P;
        }
    }
}
