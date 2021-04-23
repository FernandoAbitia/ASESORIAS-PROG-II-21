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
    public partial class frmRegistraPrestamo : Form
    {
        ManejaLibros Libros;

        public frmRegistraPrestamo(ManejaLibros Libros)
        {
            InitializeComponent();
            this.Libros = Libros;
        }

        private void frmRegistraPrestamo_Load(object sender, EventArgs e)
        {
            string[] ArreglosISBN = Libros.ObtenISBN();

            for (int i = 0; i < ArreglosISBN.Length; i++)
            {
                cmbISBN.Items.Add(ArreglosISBN[i]);
            }
        }

        private void cmbISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ISBN = cmbISBN.SelectedItem.ToString();

            Libro L = Libros.ObtenLibroPorISBN(ISBN);

            txtNombreLibro.Text = L.pNombre;

        }
    }
}
