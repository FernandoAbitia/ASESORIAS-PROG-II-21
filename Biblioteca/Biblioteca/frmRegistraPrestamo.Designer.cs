
namespace Biblioteca
{
    partial class frmRegistraPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbISBN = new System.Windows.Forms.ComboBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExterno = new System.Windows.Forms.RadioButton();
            this.rdbAlumno = new System.Windows.Forms.RadioButton();
            this.rdbMaestro = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // cmbISBN
            // 
            this.cmbISBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbISBN.FormattingEnabled = true;
            this.cmbISBN.Location = new System.Drawing.Point(157, 65);
            this.cmbISBN.Name = "cmbISBN";
            this.cmbISBN.Size = new System.Drawing.Size(190, 21);
            this.cmbISBN.TabIndex = 1;
            this.cmbISBN.SelectedIndexChanged += new System.EventHandler(this.cmbISBN_SelectedIndexChanged);
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(157, 132);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.ReadOnly = true;
            this.txtNombreLibro.Size = new System.Drawing.Size(190, 20);
            this.txtNombreLibro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del libro";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(31, 332);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(148, 332);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(272, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(44, 201);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 16);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(157, 198);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExterno);
            this.groupBox1.Controls.Add(this.rdbAlumno);
            this.groupBox1.Controls.Add(this.rdbMaestro);
            this.groupBox1.Location = new System.Drawing.Point(31, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo usuario";
            // 
            // rdbExterno
            // 
            this.rdbExterno.AutoSize = true;
            this.rdbExterno.Location = new System.Drawing.Point(207, 20);
            this.rdbExterno.Name = "rdbExterno";
            this.rdbExterno.Size = new System.Drawing.Size(61, 17);
            this.rdbExterno.TabIndex = 2;
            this.rdbExterno.Text = "Externo";
            this.rdbExterno.UseVisualStyleBackColor = true;
            // 
            // rdbAlumno
            // 
            this.rdbAlumno.AutoSize = true;
            this.rdbAlumno.Location = new System.Drawing.Point(116, 20);
            this.rdbAlumno.Name = "rdbAlumno";
            this.rdbAlumno.Size = new System.Drawing.Size(60, 17);
            this.rdbAlumno.TabIndex = 1;
            this.rdbAlumno.Text = "Alumno";
            this.rdbAlumno.UseVisualStyleBackColor = true;
            // 
            // rdbMaestro
            // 
            this.rdbMaestro.AutoSize = true;
            this.rdbMaestro.Checked = true;
            this.rdbMaestro.Location = new System.Drawing.Point(25, 19);
            this.rdbMaestro.Name = "rdbMaestro";
            this.rdbMaestro.Size = new System.Drawing.Size(63, 17);
            this.rdbMaestro.TabIndex = 0;
            this.rdbMaestro.TabStop = true;
            this.rdbMaestro.Text = "Maestro";
            this.rdbMaestro.UseVisualStyleBackColor = true;
            // 
            // frmRegistraPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.cmbISBN);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistraPrestamo";
            this.Text = "Registrar un préstamo";
            this.Load += new System.EventHandler(this.frmRegistraPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbISBN;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbExterno;
        private System.Windows.Forms.RadioButton rdbAlumno;
        private System.Windows.Forms.RadioButton rdbMaestro;
    }
}