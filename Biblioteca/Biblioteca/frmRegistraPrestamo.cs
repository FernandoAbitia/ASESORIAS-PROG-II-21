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
        ManejaPrestamos Prestamos;

        public frmRegistraPrestamo(ManejaLibros Libros, ManejaPrestamos Prestamos)
        {
            InitializeComponent();
            this.Libros = Libros;
            this.Prestamos = Prestamos;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿Desea Guardar?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.No)
                return;

            if (!Valida())
            {
                return;
            }

            string ISBN = cmbISBN.SelectedItem.ToString();
            Libro L = Libros.ObtenLibroPorISBN(ISBN);
            string Usuario = txtUsuario.Text;
            string TipoUsuario="";

            if (rdbAlumno.Checked)
                TipoUsuario = "Alumno";

            if (rdbMaestro.Checked)
                TipoUsuario = "Mestro";

            if (rdbExterno.Checked)
                TipoUsuario = "Externo";

            Prestamos.Agrega(ISBN,Usuario,TipoUsuario);
            Libros.RestaExistencia(ISBN);

        }

        public bool Valida()
        {
            if (cmbISBN.SelectedIndex == -1)
            {
                MessageBox.Show("NO SE HA SELECCIONADO NINGÚN LIBRO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("INTRODUCE UN USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Libros.ObtenLibroPorISBN(cmbISBN.SelectedItem.ToString()).pSala)
            {
                MessageBox.Show("EL LIBRO ES SÓLO PARA CONSULTA EN BIBLIOTECA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Libros.VerificaExistencia(cmbISBN.SelectedItem.ToString()))
            {
                MessageBox.Show("NO HAY EXISTENCIA DISPONIBLE PARA ESE LIBRO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
