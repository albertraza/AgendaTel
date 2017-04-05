namespace AgendaTelefonica
{
    partial class frmMantenimientoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoUsuarios));
            this.pMain = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLimpiarDatos = new System.Windows.Forms.LinkLabel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.cbNivelUsuario = new System.Windows.Forms.ComboBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNivelUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pMain.SuspendLayout();
            this.pCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pMain.Controls.Add(this.txtApellido);
            this.pMain.Controls.Add(this.lblApellido);
            this.pMain.Controls.Add(this.lblLimpiarDatos);
            this.pMain.Controls.Add(this.btnEliminar);
            this.pMain.Controls.Add(this.btnModificar);
            this.pMain.Controls.Add(this.btnBuscar);
            this.pMain.Controls.Add(this.btnRegistrar);
            this.pMain.Controls.Add(this.btnSeleccionarImagen);
            this.pMain.Controls.Add(this.cbNivelUsuario);
            this.pMain.Controls.Add(this.txtContrasena);
            this.pMain.Controls.Add(this.txtNombre);
            this.pMain.Controls.Add(this.lblNivelUsuario);
            this.pMain.Controls.Add(this.lblContrasena);
            this.pMain.Controls.Add(this.lblNombre);
            this.pMain.Controls.Add(this.lblTitulo);
            this.pMain.Controls.Add(this.pCerrar);
            this.pMain.Controls.Add(this.pbImage);
            this.pMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(397, 391);
            this.pMain.TabIndex = 0;
            this.pMain.MouseHover += new System.EventHandler(this.pMain_MouseHover);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(152, 237);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(163, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(99, 239);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblLimpiarDatos
            // 
            this.lblLimpiarDatos.AutoSize = true;
            this.lblLimpiarDatos.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblLimpiarDatos.LinkColor = System.Drawing.Color.Black;
            this.lblLimpiarDatos.Location = new System.Drawing.Point(268, 318);
            this.lblLimpiarDatos.Name = "lblLimpiarDatos";
            this.lblLimpiarDatos.Size = new System.Drawing.Size(81, 13);
            this.lblLimpiarDatos.TabIndex = 13;
            this.lblLimpiarDatos.TabStop = true;
            this.lblLimpiarDatos.Text = "Limpiar Campos";
            this.lblLimpiarDatos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLimpiarDatos_LinkClicked);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(292, 342);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 33);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(209, 342);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(77, 33);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(112, 342);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 33);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar Usuario";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(29, 342);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(77, 33);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(144, 177);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(122, 23);
            this.btnSeleccionarImagen.TabIndex = 4;
            this.btnSeleccionarImagen.Text = "Seleccionar Imagen";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // cbNivelUsuario
            // 
            this.cbNivelUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelUsuario.FormattingEnabled = true;
            this.cbNivelUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cbNivelUsuario.Location = new System.Drawing.Point(152, 291);
            this.cbNivelUsuario.Name = "cbNivelUsuario";
            this.cbNivelUsuario.Size = new System.Drawing.Size(163, 21);
            this.cbNivelUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Location = new System.Drawing.Point(152, 262);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(163, 20);
            this.txtContrasena.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(152, 212);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNivelUsuario
            // 
            this.lblNivelUsuario.AutoSize = true;
            this.lblNivelUsuario.Location = new System.Drawing.Point(58, 294);
            this.lblNivelUsuario.Name = "lblNivelUsuario";
            this.lblNivelUsuario.Size = new System.Drawing.Size(88, 13);
            this.lblNivelUsuario.TabIndex = 4;
            this.lblNivelUsuario.Text = "Nivel de Usuario:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(82, 265);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(64, 13);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "Contrasena:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(99, 214);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(71, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Mantenimiento de Usuarios";
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(344, 3);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(50, 32);
            this.pCerrar.TabIndex = 0;
            this.pCerrar.Click += new System.EventHandler(this.pCerrar_Click);
            this.pCerrar.Paint += new System.Windows.Forms.PaintEventHandler(this.pCerrar_Paint);
            this.pCerrar.MouseHover += new System.EventHandler(this.panel2_MouseHover);
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCerrar.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblCerrar.Location = new System.Drawing.Point(-1, 8);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(51, 16);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.TabStop = true;
            this.lblCerrar.Text = "Cerrar";
            this.lblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::AgendaTelefonica.Properties.Resources.imageres_79;
            this.pbImage.Location = new System.Drawing.Point(136, 40);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(136, 136);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // frmMantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(421, 415);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantenimientoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoUsuarios";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmMantenimientoUsuarios_Load);
            this.MouseHover += new System.EventHandler(this.frmMantenimientoUsuarios_MouseHover);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.ComboBox cbNivelUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNivelUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.LinkLabel lblLimpiarDatos;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
    }
}