namespace AgendaTelefonica
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.pbFotoUsuario = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pPrincipal.Controls.Add(this.btnCancelar);
            this.pPrincipal.Controls.Add(this.btnAcceder);
            this.pPrincipal.Controls.Add(this.lblContrasena);
            this.pPrincipal.Controls.Add(this.txtContrasena);
            this.pPrincipal.Controls.Add(this.lblNombreUsuario);
            this.pPrincipal.Controls.Add(this.txtNombreUsuario);
            this.pPrincipal.Controls.Add(this.pbFotoUsuario);
            this.pPrincipal.Controls.Add(this.lblTitle);
            this.pPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(306, 367);
            this.pPrincipal.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(25, 318);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(83, 34);
            this.btnAcceder.TabIndex = 6;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(120, 256);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 5;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Location = new System.Drawing.Point(89, 272);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(133, 20);
            this.txtContrasena.TabIndex = 4;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(103, 217);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreUsuario.Location = new System.Drawing.Point(89, 233);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(133, 20);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            // 
            // pbFotoUsuario
            // 
            this.pbFotoUsuario.Image = global::AgendaTelefonica.Properties.Resources.imageres_79;
            this.pbFotoUsuario.Location = new System.Drawing.Point(89, 57);
            this.pbFotoUsuario.Name = "pbFotoUsuario";
            this.pbFotoUsuario.Size = new System.Drawing.Size(133, 131);
            this.pbFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoUsuario.TabIndex = 1;
            this.pbFotoUsuario.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(86, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Login de Usuario";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(330, 391);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.PictureBox pbFotoUsuario;
        private System.Windows.Forms.Label lblTitle;
    }
}