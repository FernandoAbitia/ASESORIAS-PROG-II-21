using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteca
{
    public partial class frmRegistraLibro : Form
    {
        public frmRegistraLibro()
        {
            InitializeComponent();
        }

        private void frmRegistraLibro_Load(object sender, EventArgs e)
        {
            string Conexion = "Data Source=DESKTOP-94SDT5C\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;Integrated Security=True";
            SqlConnection Conecta = new SqlConnection(Conexion);
            try
            {
                Conecta.Open();
            }catch(SqlException Ex)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");
                foreach (SqlError Error in Ex.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }

            MessageBox.Show("CONECTADO A LA BASE DE DATOS");

            SqlDataReader Lector = null;

            String Query = "SELECT NOMBRE FROM EDITORIAL";

            SqlCommand cmd = new SqlCommand(Query,Conecta);
            try
            {

                Lector = cmd.ExecuteReader();

            }catch(SqlException Ex)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");
                foreach (SqlError Error in Ex.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }

            if (Lector.HasRows)
            {
                cmbEditorial.Items.Clear();
                while (Lector.Read())
                {
                    string Editorial = Lector.GetValue(0).ToString();
                    cmbEditorial.Items.Add(Editorial);
                }
                Conecta.Close();
            }
            Conecta.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿Desea Guardar?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.No)
                return;

            if (!Valida())
                return;

            string Conexion = "Data Source=DESKTOP-94SDT5C\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;Integrated Security=True";
            SqlConnection Conecta = new SqlConnection(Conexion);
            try
            {
                Conecta.Open();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");
                foreach (SqlError Error in Ex.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            string ISBN, Autor, NombreLibro;
            int Editorial;
            byte Existencia;
            int Sala;

            ISBN = txtISBN.Text;
            Autor = txtAutor.Text;
            NombreLibro = txtNombreLibro.Text;
            Editorial = ObtenIDEditorial(cmbEditorial.SelectedItem.ToString());
            Existencia = Convert.ToByte(nupExistencia.Value);

            if (chkSala.Checked)
                Sala = 1;
            else
                Sala = 0;

            String Query = "INSERT INTO LIBRO(ISBN,AUTOR,NOMBRE,EXISTENCIA,CONSULTA,EDITORIAL)";
            Query += " VALUES(@ISBN,@AUTOR,@NOMBRE,@EXISTENCIA,@CONSULTA,@EDITORIAL)";

            SqlCommand cmd = new SqlCommand(Query,Conecta);
            cmd.Parameters.AddWithValue("@ISBN",ISBN);
            cmd.Parameters.AddWithValue("@AUTOR", Autor);
            cmd.Parameters.AddWithValue("@NOMBRE", NombreLibro);
            cmd.Parameters.AddWithValue("@EXISTENCIA", Existencia);
            cmd.Parameters.AddWithValue("@CONSULTA", Sala);
            cmd.Parameters.AddWithValue("@EDITORIAL", Editorial);

            try
            {
                cmd.ExecuteNonQuery();
            }catch(SqlException Ex)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");
                foreach (SqlError Error in Ex.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            MessageBox.Show("LIBRO AGREGADO CORRECTAMENTE","CORRECTO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public int ObtenIDEditorial(string Nombre)
        {
            int ID = -1;
            string Conexion = "Data Source=DESKTOP-94SDT5C\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;Integrated Security=True";
            SqlConnection Conecta = new SqlConnection(Conexion);
            try
            {
                Conecta.Open();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");
                foreach (SqlError Error in Ex.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return ID;
            }

            SqlDataReader Lector = null;
            string Query = "SELECT ID FROM EDITORIAL WHERE NOMBRE =" + "'" + Nombre + "'";
            SqlCommand cmd = new SqlCommand(Query, Conecta);
            try
            {

                Lector = cmd.ExecuteReader();

            }
            catch (SqlException Ex)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");
                foreach (SqlError Error in Ex.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return ID;
            }

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    ID = Convert.ToInt32(Lector.GetValue(0).ToString());
                    return ID;
                }
            }
            return ID;
        }

        public bool Valida()
        {
            if (txtAutor.Text.Length == 0)
            {
                MessageBox.Show("INTRODUCE UN AUTOR","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (txtISBN.Text.Length == 0)
            {
                MessageBox.Show("INTRODUCE UN ISBN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNombreLibro.Text.Length == 0)
            {
                MessageBox.Show("INTRODUCE UN NOMBRE DE LIBRO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nupExistencia.Value <= 0)
            {
                MessageBox.Show("SELECCIONA UNA EXISTENCIA MAYOR A 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbEditorial.SelectedIndex < 0)
            {
                MessageBox.Show("SELECCIONA UNA EDITORIAL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿Desea salir?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }
    }
}
