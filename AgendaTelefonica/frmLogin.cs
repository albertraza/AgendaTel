using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaTelefonica.Properties;

namespace AgendaTelefonica
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir de la aplicacion?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // boton acceder.
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // se validan las entradas de los usuarios
            if(txtNombreUsuario.Text == string.Empty)
            {
                MessageBox.Show("El Nombre de Usuario esta vacio, Digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario.Focus();
            }
            else if(txtContrasena.Text == string.Empty)
            {
                MessageBox.Show("La contrasena esta vacia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
            }
            else
            {
                try
                {
                    if(Users.login(txtNombreUsuario.Text, txtContrasena.Text))
                    {
                        new frmMenuPrincipal().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de Usuario o Contrasena incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // evento textchange para cargar la foto cuando se esciba el nombre de usuario.
        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UsersBase InfoUser = Users.getUserInfoWUsername(txtNombreUsuario.Text);
                if(InfoUser != null)
                {
                    pbFotoUsuario.Image = Image.FromFile(InfoUser.Foto);
                }
                else
                {
                    pbFotoUsuario.Image = Resources.imageres_79;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
