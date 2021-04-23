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
    public partial class frmRegistraLibro : Form
    {
        private ManejaLibros Libros;
        public frmRegistraLibro(ManejaLibros Libros)
        {
            InitializeComponent();
            this.Libros = Libros;
        }

        private void frmRegistraLibro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string ISBN, Autor, NombreLibro, Editorial;
            byte Existencia;
            bool Sala;

            ISBN = txtISBN.Text;
            Autor = txtAutor.Text;
            NombreLibro = txtNombreLibro.Text;
            Editorial = cmbEditorial.SelectedItem.ToString();
            Existencia = Convert.ToByte(nupExistencia.Value);

            if (chkSala.Checked)
                Sala = true;
            else
                Sala = false;

            Libro L = new Libro(Autor,NombreLibro,Editorial,Existencia,Sala);
            Libros.Agregar(ISBN,L);
        }
    }
}
