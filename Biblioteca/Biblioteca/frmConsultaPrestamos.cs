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
    public partial class frmConsultaPrestamos : Form
    {
        ManejaPrestamos Prestamos;
        public frmConsultaPrestamos(ManejaPrestamos Prestamos)
        {
            InitializeComponent();
            this.Prestamos = Prestamos;
        }

        private void frmConsultaPrestamos_Load(object sender, EventArgs e)
        {
            Prestamo[] P = Prestamos.ObtenPrestamos();
            Prestamo temp;
            for (int i = 0; i < P.Length; i++)
            {
                temp = P[i];
                dgvPrestamos.Rows.Add(temp.pClave,temp.pISBN,temp.pNombreUsuario,temp.pTipoUsuario);

            }
        }
    }
}
