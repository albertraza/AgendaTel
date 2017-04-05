using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AgendaTelefonica.Properties;

namespace AgendaTelefonica
{
    public partial class frmMantenimientoUsuarios : Form
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>
        
        public frmMantenimientoUsuarios()
        {
            InitializeComponent();
        }
        // variables para guardar el filepath de la foto.
        private string FilePathImageSource, FilePathImageDestiny;

        // variable tipo objeto para guardar la info del usuario cargado.
        private UsersBase UserInfo;

        // for to set enable false buttons at the begining
        private void setEnableFalse()
        {
            btnRegistrar.Enabled = true;
            btnBuscar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        // for setting enable true when loaded Usuario
        private void setEnableTrue()
        {
            btnRegistrar.Enabled = false;
            btnBuscar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        // para limpiar todos los campos y variables del filePath de la foto
        private void cleanEverything()
        {
            pbImage.Image = Resources.imageres_79;
            txtNombre.Clear();
            txtContrasena.Clear();
            txtApellido.Clear();
            cbNivelUsuario.SelectedIndex = -1;
            txtNombre.Focus();
            setEnableFalse();
            FilePathImageDestiny = null;
            FilePathImageSource = null;
            UserInfo = null;
        }
        // para cambiar la forma del cursor
        private void panel2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void frmMantenimientoUsuarios_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void pMain_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        // para cerrar la ventana
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void pCerrar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        { 
            // valido todas las entradas.
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado el nombre del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Select();
            }
            else if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado el apellido del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Select();
            }
            else if (txtContrasena.Text == string.Empty)
            {
                MessageBox.Show("No se ha digitado una contrasena para el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Select();
            }
            else if (cbNivelUsuario.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado un Nivel de Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Select();
            }
            else
            {
                // verifico si ya esta cargado el usuario que se va a modificar.
                if (UserInfo != null)
                {
                    if (MessageBox.Show("Esta seguro que desea modificar el Usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            // verificar si la contrasena coincide con la confirmada
                            frmConfirmarContrasena pContraConfirma = new frmConfirmarContrasena();
                            pContraConfirma.ShowDialog();

                            if (pContraConfirma.Contrasena == txtContrasena.Text)
                            {
                                // objeto donde almacenare la informacion a modificar del usuario.
                                UsersBase InfoUsersModify = UserInfo;

                                InfoUsersModify.Nombre = txtNombre.Text;
                                InfoUsersModify.Apellido = txtApellido.Text;
                                InfoUsersModify.Nivel = cbNivelUsuario.Text;
                                InfoUsersModify.Contrasena = txtContrasena.Text;


                                // verifico si se ha cargado otra foto
                                if (FilePathImageSource != null)
                                {
                                    InfoUsersModify.Foto = FilePathImageDestiny;
                                    File.Copy(FilePathImageSource, FilePathImageDestiny, true);
                                }

                                // cuando ya todo se ha validado correctamente.
                                MessageBox.Show
                                    (Users.modifyUsuario(InfoUsersModify.ID, InfoUsersModify.Nombre, InfoUsersModify.Apellido, InfoUsersModify.Contrasena, InfoUsersModify.Nivel, InfoUsersModify.Foto),
                                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cleanEverything();
                            }
                            // si las contrasenas no coinciden
                            else
                            {
                                MessageBox.Show("Las Contraseñas no coinciden, Intentelo nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // sino se ha cargado un usuario.
                else
                {
                    MessageBox.Show("No se ha cargado un usuario para poder modificar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el Usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // verificar si ya se ha cargado un usuario para eliminar
                if (UserInfo != null)
                {
                    try
                    {
                        MessageBox.Show(Users.deleteUsuario(UserInfo.ID), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // se elimina el archivo de la foto
                        //pbImage.Image = Resources.imageres_79;
                        //File.Delete(UserInfo.Foto);

                        cleanEverything();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // sino
                else
                {
                    MessageBox.Show("No se ha cargado un usuario para poder eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // evento load
        private void frmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            setEnableFalse();
        }

        // label limpiar Campos
        private void lblLimpiarDatos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cleanEverything();
        }

        // boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaUsuarios pConsulta = new frmConsultaUsuarios();
                pConsulta.Menu = false;
                pConsulta.ShowDialog();

                // valido si se ha seleccionado un usuario
                if (pConsulta.InfoUsuario != null)
                {
                    UserInfo = pConsulta.InfoUsuario;
                    txtNombre.Text = UserInfo.Nombre;
                    txtApellido.Text = UserInfo.Apellido;
                    txtContrasena.Text = UserInfo.Contrasena;
                    cbNivelUsuario.Text = UserInfo.Nivel;
                    pbImage.Image = Image.FromFile(UserInfo.Foto);

                    setEnableTrue();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // boton para registrar un nuevo usuario.
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(FilePathImageSource == null || FilePathImageDestiny == null)
            {
                MessageBox.Show("No se ha seleccionado una imagen para el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSeleccionarImagen.Focus();
            }
            else if(txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado el nombre del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Select();
            }
            else if(txtApellido.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado el apellido del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Select();
            }
            else if(txtContrasena.Text == string.Empty)
            {
                MessageBox.Show("No se ha digitado una contrasena para el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Select();
            }
            else if(cbNivelUsuario.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado un Nivel de Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Select();
            }
            else
            {
                frmConfirmarContrasena pConfirmarC = new frmConfirmarContrasena();
                pConfirmarC.ShowDialog();

                if(pConfirmarC.Contrasena == txtContrasena.Text)
                {
                    if(Users.validate(txtNombre.Text + "."+ txtApellido.Text))
                    {
                        MessageBox.Show("El Usuario: " + txtNombre.Text + "." + txtApellido.Text + " ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            MessageBox.Show(Users.registerUsuario(txtNombre.Text, txtApellido.Text, txtContrasena.Text, cbNivelUsuario.Text, FilePathImageDestiny), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            File.Copy(FilePathImageSource, FilePathImageDestiny, true);
                            cleanEverything();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las contrasenas no son identicas, digitelas nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        // boton para seleccionar una imagen.
        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageSelector = new OpenFileDialog();
            ImageSelector.Title = "Seleccione una imagen para el usuario";
            ImageSelector.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg; *.png; *.gif";
            DialogResult SelectedImage =  ImageSelector.ShowDialog();

            if (!Directory.Exists(@"C:\AgendaTelefonica"))
            {
                Directory.CreateDirectory(@"C:\AgendaTelefonica");
            }

            if (!Directory.Exists(@"C:\AgendaTelefonica\userimg"))
            {
                Directory.CreateDirectory(@"C:\AgendaTelefonica\userimg");
            }

            if (SelectedImage != DialogResult.Cancel)
            {
                FilePathImageDestiny = @"C:\AgendaTelefonica\userimg\" + Path.GetFileName(ImageSelector.FileName);
                FilePathImageSource = ImageSelector.FileName;
                pbImage.Image = Image.FromFile(ImageSelector.FileName);
            }
            else
            {
                FilePathImageDestiny = null;
                FilePathImageSource = null;
                MessageBox.Show("No se ha seleccionadu una imagen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
