namespace AgendaTelefonica
{
    partial class frmConsultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaUsuarios));
            this.pMain = new System.Windows.Forms.Panel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbFiltros = new System.Windows.Forms.ComboBox();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.pCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pMain.Controls.Add(this.gbFiltros);
            this.pMain.Controls.Add(this.pCerrar);
            this.pMain.Controls.Add(this.dgvUsuarios);
            this.pMain.Controls.Add(this.lblTitle);
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(500, 352);
            this.pMain.TabIndex = 0;
            this.pMain.MouseHover += new System.EventHandler(this.pMain_MouseHover);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.linkLabel1);
            this.gbFiltros.Controls.Add(this.btnBuscar);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.txtBusqueda);
            this.gbFiltros.Controls.Add(this.cbFiltros);
            this.gbFiltros.Location = new System.Drawing.Point(16, 42);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(467, 77);
            this.gbFiltros.TabIndex = 4;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Busqueda Usuarios";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(285, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Limpiar Campos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(383, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite su Busqueda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Location = new System.Drawing.Point(124, 35);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(243, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbFiltros
            // 
            this.cbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltros.FormattingEnabled = true;
            this.cbFiltros.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbFiltros.Location = new System.Drawing.Point(19, 35);
            this.cbFiltros.Name = "cbFiltros";
            this.cbFiltros.Size = new System.Drawing.Size(97, 21);
            this.cbFiltros.TabIndex = 0;
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(447, 4);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(50, 32);
            this.pCerrar.TabIndex = 3;
            this.pCerrar.Click += new System.EventHandler(this.pCerrar_Click);
            this.pCerrar.MouseHover += new System.EventHandler(this.pCerrar_MouseHover);
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
            this.lblCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrar_LinkClicked);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 125);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(500, 224);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(136, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Consulta de Usuarios";
            // 
            // frmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(524, 376);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaUsuarios";
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseHover += new System.EventHandler(this.frmConsultaUsuarios_MouseHover);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbFiltros;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
    }
}