using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class frmConfirmarContrasena : Form
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public frmConfirmarContrasena()
        {
            InitializeComponent();
        }

        // propiedad que se utilizara para alamcenar la confirmacion de la contrasena.
        public string Contrasena { get; set; }

        // boton cancelar.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cancelar la operacion?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // boton confirmar.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtContrasena.Text == string.Empty)
            {
                MessageBox.Show("No se ha digitado la contrasena", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
            }
            else
            {
                Contrasena = txtContrasena.Text;
                this.Close();
            }
        }
    }
}
