namespace AgendaTelefonica
{
    partial class frmConsultaContactos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaContactos));
            this.pMain = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.MaskedTextBox();
            this.lblDigiteSuBusqueda = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltroTitle = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.pCerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pMain.Controls.Add(this.txtBusqueda);
            this.pMain.Controls.Add(this.lblDigiteSuBusqueda);
            this.pMain.Controls.Add(this.cbFiltro);
            this.pMain.Controls.Add(this.lblFiltroTitle);
            this.pMain.Controls.Add(this.dgvContactos);
            this.pMain.Controls.Add(this.pCerrar);
            this.pMain.Controls.Add(this.lblTitle);
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(585, 421);
            this.pMain.TabIndex = 0;
            this.pMain.MouseHover += new System.EventHandler(this.pMain_MouseHover);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Location = new System.Drawing.Point(216, 85);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(332, 20);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBusqueda_MaskInputRejected);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblDigiteSuBusqueda
            // 
            this.lblDigiteSuBusqueda.AutoSize = true;
            this.lblDigiteSuBusqueda.Location = new System.Drawing.Point(214, 69);
            this.lblDigiteSuBusqueda.Name = "lblDigiteSuBusqueda";
            this.lblDigiteSuBusqueda.Size = new System.Drawing.Size(102, 13);
            this.lblDigiteSuBusqueda.TabIndex = 6;
            this.lblDigiteSuBusqueda.Text = "Digite su Busqueda:";
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbFiltro.Location = new System.Drawing.Point(26, 85);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(178, 21);
            this.cbFiltro.TabIndex = 5;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // lblFiltroTitle
            // 
            this.lblFiltroTitle.AutoSize = true;
            this.lblFiltroTitle.Location = new System.Drawing.Point(23, 69);
            this.lblFiltroTitle.Name = "lblFiltroTitle";
            this.lblFiltroTitle.Size = new System.Drawing.Size(53, 13);
            this.lblFiltroTitle.TabIndex = 4;
            this.lblFiltroTitle.Text = "Filtrar por:";
            // 
            // dgvContactos
            // 
            this.dgvContactos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvContactos.Location = new System.Drawing.Point(12, 133);
            this.dgvContactos.Name = "dgvContactos";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvContactos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(554, 267);
            this.dgvContactos.TabIndex = 3;
            this.dgvContactos.Click += new System.EventHandler(this.dgvContactos_Click);
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(532, 3);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(50, 32);
            this.pCerrar.TabIndex = 2;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(194, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Consulta Contactos";
            // 
            // frmConsultaContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 445);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaContactos";
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseHover += new System.EventHandler(this.frmConsultaContactos_MouseHover);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MaskedTextBox txtBusqueda;
        private System.Windows.Forms.Label lblDigiteSuBusqueda;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label lblFiltroTitle;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
    }
}