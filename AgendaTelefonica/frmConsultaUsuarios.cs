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
    public partial class frmConsultaUsuarios : Form
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public frmConsultaUsuarios()
        {
            InitializeComponent();
        }

        public bool Menu { get; set; }
        public UsersBase InfoUsuario;

        // eventos para cambiar la forma del mouse.
        private void pMain_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void frmConsultaUsuarios_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        // eventos para cerrar la ventana
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        // evento textchange el cual se va a usar para buscar los usuarios
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltros.Text == "Nombre")
                {
                    dgvUsuarios.DataSource = Users.searchEngineUsers(txtBusqueda.Text, "");
                }
                else if (cbFiltros.Text == "Apellido")
                {
                    dgvUsuarios.DataSource = Users.searchEngineUsers("", txtBusqueda.Text);
                }
                else
                {
                    MessageBox.Show("Selecciona un filtro de busqueda para poder procesar la busqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbFiltros.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // evento cell content click par tomar la info del usuario.
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Menu)
            {
                if(dgvUsuarios.SelectedRows.Count == 1)
                {
                    try
                    {
                        InfoUsuario = Users.getUserInfoWID(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un usuario de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvUsuarios.Select();
                }
            }
        }
    }
}
