using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmConsultaLibros : Form
    {
        ManejaLibros Libros;
        public frmConsultaLibros(ManejaLibros Libros)
        {
            InitializeComponent();
            this.Libros = Libros;
        }

        private void frmConsultaLibros_Load(object sender, EventArgs e)
        {
            Libro L;
            string ISBN;

            KeyValuePair<string, Libro>[] Arreglo = Libros.ObtenLibros();

            foreach (KeyValuePair<string,Libro> item in Arreglo)
            {
                L = item.Value;
                ISBN = item.Key;

                dgvLibros.Rows.Add(ISBN,L.pNombre,L.pAutor,L.pExistencia,L.pEditorial,L.pSala);
            }
        }
    }
}
