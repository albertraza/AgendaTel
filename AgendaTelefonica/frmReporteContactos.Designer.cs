namespace AgendaTelefonica
{
    partial class frmReporteContactos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteContactos));
            this.reportContactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAgenda = new AgendaTelefonica.dsAgenda();
            this.pMain = new System.Windows.Forms.Panel();
            this.btnBuscarContacto = new System.Windows.Forms.Button();
            this.gbReporte = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pCerrar = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.reportContactoTableAdapter = new AgendaTelefonica.dsAgendaTableAdapters.reportContactoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportContactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgenda)).BeginInit();
            this.pMain.SuspendLayout();
            this.gbReporte.SuspendLayout();
            this.pCerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportContactoBindingSource
            // 
            this.reportContactoBindingSource.DataMember = "reportContacto";
            this.reportContactoBindingSource.DataSource = this.dsAgenda;
            // 
            // dsAgenda
            // 
            this.dsAgenda.DataSetName = "dsAgenda";
            this.dsAgenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pMain.Controls.Add(this.btnBuscarContacto);
            this.pMain.Controls.Add(this.gbReporte);
            this.pMain.Controls.Add(this.pCerrar);
            this.pMain.Controls.Add(this.lblTitle);
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(837, 522);
            this.pMain.TabIndex = 0;
            this.pMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pMain.MouseHover += new System.EventHandler(this.pMain_MouseHover);
            // 
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.Location = new System.Drawing.Point(27, 45);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(151, 48);
            this.btnBuscarContacto.TabIndex = 1;
            this.btnBuscarContacto.Text = "Buscar Contacto";
            this.btnBuscarContacto.UseVisualStyleBackColor = true;
            this.btnBuscarContacto.Click += new System.EventHandler(this.btnBuscarContacto_Click);
            // 
            // gbReporte
            // 
            this.gbReporte.Controls.Add(this.reportViewer1);
            this.gbReporte.Location = new System.Drawing.Point(3, 99);
            this.gbReporte.Name = "gbReporte";
            this.gbReporte.Size = new System.Drawing.Size(831, 420);
            this.gbReporte.TabIndex = 2;
            this.gbReporte.TabStop = false;
            this.gbReporte.Text = "Reporte";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsAgenda";
            reportDataSource1.Value = this.reportContactoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AgendaTelefonica.reporteContacto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(825, 401);
            this.reportViewer1.TabIndex = 0;
            // 
            // pCerrar
            // 
            this.pCerrar.BackColor = System.Drawing.Color.Red;
            this.pCerrar.Controls.Add(this.lblCerrar);
            this.pCerrar.Location = new System.Drawing.Point(784, 3);
            this.pCerrar.Name = "pCerrar";
            this.pCerrar.Size = new System.Drawing.Size(50, 32);
            this.pCerrar.TabIndex = 1;
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
            this.lblTitle.Location = new System.Drawing.Point(325, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reporte de Contacto";
            // 
            // reportContactoTableAdapter
            // 
            this.reportContactoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(861, 546);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteContactos";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.frmReporteContactos_Load);
            this.MouseHover += new System.EventHandler(this.frmReporteContactos_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.reportContactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgenda)).EndInit();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.gbReporte.ResumeLayout(false);
            this.pCerrar.ResumeLayout(false);
            this.pCerrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel pCerrar;
        private System.Windows.Forms.LinkLabel lblCerrar;
        private System.Windows.Forms.Button btnBuscarContacto;
        private System.Windows.Forms.BindingSource reportContactoBindingSource;
        private dsAgenda dsAgenda;
        private dsAgendaTableAdapters.reportContactoTableAdapter reportContactoTableAdapter;
    }
}