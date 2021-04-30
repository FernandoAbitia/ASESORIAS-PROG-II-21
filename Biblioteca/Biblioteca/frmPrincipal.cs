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
    public partial class frmPrincipal : Form
    {
        private ManejaLibros Libros;
        private ManejaPrestamos Prestamos;

        public frmPrincipal()
        {
            InitializeComponent();
            Libros = new ManejaLibros();
            Prestamos = new ManejaPrestamos();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistraLibro L = new frmRegistraLibro(Libros);
            L.ShowDialog();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistraPrestamo P = new frmRegistraPrestamo(Libros,Prestamos);
            P.ShowDialog();
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaLibros L = new frmConsultaLibros(Libros);
            L.ShowDialog();
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaPrestamos P = new frmConsultaPrestamos(Prestamos);
            P.ShowDialog();
        }
    }
}
