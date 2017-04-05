namespace AgendaTelefonica
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeContactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acecaDeLaAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeLaAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMenuPrincipal = new System.Windows.Forms.Panel();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.gbResultadoBusqueda = new System.Windows.Forms.GroupBox();
            this.btnMasDetalles = new System.Windows.Forms.Button();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbImagenContacto = new System.Windows.Forms.PictureBox();
            this.dgvListaEncontrados = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.msMenuPrincipal.SuspendLayout();
            this.pMenuPrincipal.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.gbResultadoBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEncontrados)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.msMenuPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.msMenuPrincipal.Location = new System.Drawing.Point(18, 15);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Size = new System.Drawing.Size(432, 24);
            this.msMenuPrincipal.TabIndex = 0;
            this.msMenuPrincipal.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.contactosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientosToolStripMenuItem.Image")));
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactosToolStripMenuItem.Image")));
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.contactosToolStripMenuItem.Text = "Contactos";
            this.contactosToolStripMenuItem.Click += new System.EventHandler(this.contactosToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactosToolStripMenuItem1});
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // contactosToolStripMenuItem1
            // 
            this.contactosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("contactosToolStripMenuItem1.Image")));
            this.contactosToolStripMenuItem1.Name = "contactosToolStripMenuItem1";
            this.contactosToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.contactosToolStripMenuItem1.Text = "Contactos";
            this.contactosToolStripMenuItem1.Click += new System.EventHandler(this.contactosToolStripMenuItem1_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeContactosToolStripMenuItem});
            this.reporteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteToolStripMenuItem.Image")));
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // reporteDeContactosToolStripMenuItem
            // 
            this.reporteDeContactosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeContactosToolStripMenuItem.Image")));
            this.reporteDeContactosToolStripMenuItem.Name = "reporteDeContactosToolStripMenuItem";
            this.reporteDeContactosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reporteDeContactosToolStripMenuItem.Text = "Reporte de Contactos";
            this.reporteDeContactosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeContactosToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acecaDeLaAplicacionToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // acecaDeLaAplicacionToolStripMenuItem
            // 
            this.acecaDeLaAplicacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acecaDeLaAplicacionToolStripMenuItem.Image")));
            this.acecaDeLaAplicacionToolStripMenuItem.Name = "acecaDeLaAplicacionToolStripMenuItem";
            this.acecaDeLaAplicacionToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.acecaDeLaAplicacionToolStripMenuItem.Text = "Aceca de la Aplicacion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDeLaAplicacionToolStripMenuItem});
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDeLaAplicacionToolStripMenuItem
            // 
            this.salirDeLaAplicacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirDeLaAplicacionToolStripMenuItem.Image")));
            this.salirDeLaAplicacionToolStripMenuItem.Name = "salirDeLaAplicacionToolStripMenuItem";
            this.salirDeLaAplicacionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.salirDeLaAplicacionToolStripMenuItem.Text = "Salir de la Aplicacion";
            this.salirDeLaAplicacionToolStripMenuItem.Click += new System.EventHandler(this.salirDeLaAplicacionToolStripMenuItem_Click);
            // 
            // pMenuPrincipal
            // 
            this.pMenuPrincipal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pMenuPrincipal.Controls.Add(this.gbBusqueda);
            this.pMenuPrincipal.Controls.Add(this.gbResultadoBusqueda);
            this.pMenuPrincipal.Controls.Add(this.lblTitle);
            this.pMenuPrincipal.Controls.Add(this.msMenuPrincipal);
            this.pMenuPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pMenuPrincipal.Name = "pMenuPrincipal";
            this.pMenuPrincipal.Size = new System.Drawing.Size(694, 462);
            this.pMenuPrincipal.TabIndex = 1;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.BackColor = System.Drawing.Color.DarkGray;
            this.gbBusqueda.Controls.Add(this.btnLimpiarBusqueda);
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Controls.Add(this.txtNombre);
            this.gbBusqueda.Controls.Add(this.lblNombreBusqueda);
            this.gbBusqueda.Location = new System.Drawing.Point(18, 85);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(659, 55);
            this.gbBusqueda.TabIndex = 3;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Buscar Contacto";
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(367, 16);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(114, 23);
            this.btnLimpiarBusqueda.TabIndex = 7;
            this.btnLimpiarBusqueda.Text = "Limpiar Busqueda";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = true;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(274, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(75, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(22, 22);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(47, 13);
            this.lblNombreBusqueda.TabIndex = 4;
            this.lblNombreBusqueda.Text = "Nombre:";
            // 
            // gbResultadoBusqueda
            // 
            this.gbResultadoBusqueda.BackColor = System.Drawing.Color.DarkGray;
            this.gbResultadoBusqueda.Controls.Add(this.btnMasDetalles);
            this.gbResultadoBusqueda.Controls.Add(this.lblCorreoElectronico);
            this.gbResultadoBusqueda.Controls.Add(this.lblApellido);
            this.gbResultadoBusqueda.Controls.Add(this.lblNombre);
            this.gbResultadoBusqueda.Controls.Add(this.pbImagenContacto);
            this.gbResultadoBusqueda.Controls.Add(this.dgvListaEncontrados);
            this.gbResultadoBusqueda.Location = new System.Drawing.Point(18, 146);
            this.gbResultadoBusqueda.Name = "gbResultadoBusqueda";
            this.gbResultadoBusqueda.Size = new System.Drawing.Size(659, 289);
            this.gbResultadoBusqueda.TabIndex = 2;
            this.gbResultadoBusqueda.TabStop = false;
            this.gbResultadoBusqueda.Text = "Resultado de Busqueda";
            // 
            // btnMasDetalles
            // 
            this.btnMasDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasDetalles.Location = new System.Drawing.Point(522, 235);
            this.btnMasDetalles.Name = "btnMasDetalles";
            this.btnMasDetalles.Size = new System.Drawing.Size(113, 39);
            this.btnMasDetalles.TabIndex = 5;
            this.btnMasDetalles.Text = "Mas Detalles...";
            this.btnMasDetalles.UseVisualStyleBackColor = true;
            this.btnMasDetalles.Click += new System.EventHandler(this.btnMasDetalles_Click);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(211, 212);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(141, 16);
            this.lblCorreoElectronico.TabIndex = 4;
            this.lblCorreoElectronico.Text = "Correo Electronico:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(211, 181);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 16);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(211, 152);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // pbImagenContacto
            // 
            this.pbImagenContacto.Image = global::AgendaTelefonica.Properties.Resources.imageres_79;
            this.pbImagenContacto.Location = new System.Drawing.Point(25, 138);
            this.pbImagenContacto.Name = "pbImagenContacto";
            this.pbImagenContacto.Size = new System.Drawing.Size(160, 145);
            this.pbImagenContacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenContacto.TabIndex = 1;
            this.pbImagenContacto.TabStop = false;
            // 
            // dgvListaEncontrados
            // 
            this.dgvListaEncontrados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListaEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaEncontrados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaEncontrados.Location = new System.Drawing.Point(6, 16);
            this.dgvListaEncontrados.Name = "dgvListaEncontrados";
            this.dgvListaEncontrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEncontrados.Size = new System.Drawing.Size(647, 116);
            this.dgvListaEncontrados.TabIndex = 0;
            this.dgvListaEncontrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEncontrados_CellContentClick);
            this.dgvListaEncontrados.Click += new System.EventHandler(this.dgvListaEncontrados_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(270, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Menu Principal";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(716, 486);
            this.Controls.Add(this.pMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msMenuPrincipal;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            this.pMenuPrincipal.ResumeLayout(false);
            this.pMenuPrincipal.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbResultadoBusqueda.ResumeLayout(false);
            this.gbResultadoBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEncontrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acecaDeLaAplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeLaAplicacionToolStripMenuItem;
        private System.Windows.Forms.Panel pMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeContactosToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreBusqueda;
        private System.Windows.Forms.GroupBox gbResultadoBusqueda;
        private System.Windows.Forms.Button btnMasDetalles;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbImagenContacto;
        private System.Windows.Forms.DataGridView dgvListaEncontrados;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
    }
}