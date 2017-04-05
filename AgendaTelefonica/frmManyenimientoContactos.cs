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
using System.Data.SqlClient;

namespace AgendaTelefonica
{
    public partial class frmManyenimientoContactos : Form
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public frmManyenimientoContactos()
        {
            InitializeComponent();
        }
        // variable publica para tener la info del contacto
        public Contact pContactInfo
        {
            get;
            set;
        }
        // variables para controlar el conteo de las fotos.
        private int imageNumLess, imageNumMax, currentImage;

        // metodo para cargar las imagenes
        private void loadImages()
        {
            imageNumLess = 1;
            currentImage = 1;
            imageNumMax = Pictures.listPicture(pContact.id).Count;

            pPictures = null;
            pPictures = Pictures.listPicture(pContact.id).ToArray();
            pbImages.Image = Image.FromFile(pPictures[0].Path);

            lblCuentaImagenes.Text = "Imagen " + currentImage.ToString() + " de " + imageNumMax.ToString();

            if(imageNumLess == imageNumMax)
            {
                btnImagenAnterior.Enabled = false;
                btnImagenProxima.Enabled = false;
            }
            else if(currentImage == 1)
            {
                btnImagenAnterior.Enabled = false;
                btnImagenProxima.Enabled = true;
            }
        }

        // metodo para cargar la proxima imagen
        private void loadNextImage()
        {
            currentImage++;
            pbImages.Image = Image.FromFile(pPictures[currentImage - 1].Path);
            lblCuentaImagenes.Text = "Imagen " + currentImage.ToString() + " de " + imageNumMax.ToString();

            if (currentImage == imageNumMax)
            {
                btnImagenProxima.Enabled = false;
            }
            
            if(currentImage > 1)
            {
                btnImagenAnterior.Enabled = true;
            }
        }

        // metodo para cargar la imagen anterior
        private void loadBeforeImage()
        {
            currentImage--;
            pbImages.Image = Image.FromFile(pPictures[currentImage - 1].Path);
            lblCuentaImagenes.Text = "Imagen " + currentImage.ToString() + " de " + imageNumMax.ToString();

            if (currentImage == 1)
            {
                btnImagenProxima.Enabled = true;
                btnImagenAnterior.Enabled = false;
            }
            if(currentImage < imageNumMax)
            {
                btnImagenProxima.Enabled = true;
            }
        }

        // array for getting all contacts pictures
        private Pictures[] pPictures;

        // metodo para cargar los numeros del contacto when contact has been loaded.
        private void loadNumbers()
        {
            cbCasa.Items.Clear();
            cbCelular.Items.Clear();
            cbTrabajo.Items.Clear();
            using(SqlConnection con = Connection.getConnection())
            {
                // combobox del telefono de la casa.
                SqlCommand Casa = new SqlCommand();
                Casa.Connection = con;
                Casa.CommandType = CommandType.StoredProcedure;
                Casa.CommandText = "getAllHouse";

                Casa.Parameters.Add(new SqlParameter("@codigoContact", SqlDbType.Int));
                Casa.Parameters["@codigoContact"].Value = pContact.id;

                SqlDataReader reCasa = Casa.ExecuteReader();
                while (reCasa.Read())
                {
                    cbCasa.Items.Add(reCasa["Tel"]);
                }
                reCasa.Close();

                // combobox del trabajo
                SqlCommand Trabajo = new SqlCommand();
                Trabajo.Connection = con;
                Trabajo.CommandType = CommandType.StoredProcedure;
                Trabajo.CommandText = "getAllWork";

                Trabajo.Parameters.Add(new SqlParameter("@codigoContact", SqlDbType.Int));
                Trabajo.Parameters["@codigoContact"].Value = pContact.id;

                SqlDataReader reTrabajo = Trabajo.ExecuteReader();
                while (reTrabajo.Read())
                {
                    cbTrabajo.Items.Add(reTrabajo["Tel"]);
                }
                reTrabajo.Close();

                // combobox del celular
                SqlCommand Celular = new SqlCommand();
                Celular.Connection = con;
                Celular.CommandType = CommandType.StoredProcedure;
                Celular.CommandText = "getAllCellPhones";

                Celular.Parameters.Add(new SqlParameter("@codigoContact", SqlDbType.Int));
                Celular.Parameters["@codigoContact"].Value = pContact.id;

                SqlDataReader reCelular = Celular.ExecuteReader();
                while (reCelular.Read())
                {
                    cbCelular.Items.Add(reCelular["Tel"]);
                }
                reCelular.Close();
                con.Close();
            }
        }

        // se usa para guardar la info del contacto a cargar.
        private Contact pContact;

        // se usa para guardar la informacion del numero de telefono
        private Phones pPhone;

        // se usaran para guardar los Fileath de las fotos a anadir.
        private string FilePathFotoSource, FilePathFotoDestiny;

        // set visible false for itens when no contact has been loaded
        private void setVisibleFalseComboBoxes()
        {
            cbCasa.Visible = false;
            cbCelular.Visible = false;
            cbTrabajo.Visible = false;
            lblCuentaImagenes.Visible = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnImagenAnterior.Enabled = false;
            btnImagenProxima.Enabled = false;
            btnGuardarImagen.Visible = false;
            txtCasa.Visible = true;
            txtCelular.Visible = true;
            txtTrabajo.Visible = true;
        }
        // metodo para limpiar todo
        private void cleanEverything()
        {
            txtApellido.Clear();
            txtCasa.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            txtTrabajo.Clear();
            setVisibleFalseComboBoxes();
            setVisibleFalsePBforNumbers();
            pContact = null;
            pPhone = null;
            pbImages.Image = Resources.imageres_79;
            FilePathFotoDestiny = null;
            FilePathFotoSource = null;
            txtNombre.Focus();
            btnRegistrar.Enabled = true;
            btnBuscar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardarImagen.Visible = false;
        }
        // volver invisibles los pictures boxes when no contact is been loaded.
        private void setVisibleFalsePBforNumbers()
        {
            pbAnadirNuevoCasa.Visible = false;
            pbAnadirNuevoCelular.Visible = false;
            pbAnadirNuevoTrabajo.Visible = false;
            pbEliminarCasa.Visible = false;
            pbEliminarCelular.Visible = false;
            pbEliminarTrabajo.Visible = false;
            pbModificarCasa.Visible = false;
            pbModificarCelular.Visible = false;
            pbModificarTrabajo.Visible = false;
        }

        // volver visibles los picture boxes when contact is loaded.
        private void setVisibleTruePBforNumbers()
        {
            pbAnadirNuevoCasa.Visible = true;
            pbAnadirNuevoCelular.Visible = true;
            pbAnadirNuevoTrabajo.Visible = true;
            pbEliminarCasa.Visible = true;
            pbEliminarCelular.Visible = true;
            pbEliminarTrabajo.Visible = true;
            pbModificarCasa.Visible = true;
            pbModificarCelular.Visible = true;
            pbModificarTrabajo.Visible = true;
        }

        // set visible true for itens when contact has been loaded
        private void setVisibleTrueComboBoxes()
        {
            cbCasa.Visible = true;
            cbCelular.Visible = true;
            cbTrabajo.Visible = true;
            txtTrabajo.Visible = false;
            txtCelular.Visible = false;
            txtCasa.Visible = false;
            lblCuentaImagenes.Visible = true;
            btnRegistrar.Enabled = false;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        // evento click del picture box
        private void pbImages_Click(object sender, EventArgs e)
        {
            if (pContact != null)
            {
                if (MessageBox.Show("Desea Elegir esta imagen como la principal?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
            }
        }


        // para cerrar la ventana
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        // evento load
        private void frmManyenimientoContactos_Load(object sender, EventArgs e)
        {
            if (pContactInfo != null)
            {
                pContact = pContactInfo;
                txtNombre.Text = pContact.name;
                txtApellido.Text = pContact.lastName;
                txtCorreo.Text = pContact.Email;

                // para cargar las fotos del contacto
                loadImages();

                setVisibleTrueComboBoxes();
                setVisibleTruePBforNumbers();
                loadNumbers();
            }
            else
            {
                setVisibleFalseComboBoxes();
                pbImages.Image = Resources.imageres_79;
                setVisibleFalsePBforNumbers();
            }
        }


        // eventos para cambiar el tipo de cursor a usar
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pMain_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void frmManyenimientoContactos_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void pbAnadirNuevoCelular_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbAnadirNuevoCasa_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbAnadirNuevoTrabajo_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbModificarCelular_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbModificarCasa_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbModificarTrabajo_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbGuardarCelular_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbGuardarCasa_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbGuardarTrabajo_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbEliminarCelular_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbEliminarCasa_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbEliminarTrabajo_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }


        // boton buscar Contacto
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try {
                frmConsultaContactos pConsulta = new frmConsultaContactos();
                pConsulta.ShowDialog();

                if (pConsulta.pInfoContact != null)
                {
                    pContact = pConsulta.pInfoContact;
                    txtNombre.Text = pContact.name;
                    txtApellido.Text = pContact.lastName;
                    txtCorreo.Text = pContact.Email;

                    // para cargar las fotos del contacto
                    loadImages();

                    setVisibleTrueComboBoxes();
                    setVisibleTruePBforNumbers();
                    loadNumbers();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // boton registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // validar si los campos importantes ya fueron completados
            if(txtNombre.Text == string.Empty)
            {
                MessageBox.Show("El Nombre esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else if(txtApellido.Text == string.Empty)
            {
                MessageBox.Show("El Apellido esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
            }
            else if(txtCorreo.Text == string.Empty)
            {
                MessageBox.Show("El Correo esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
            }
            else if(FilePathFotoDestiny == null)
            {
                MessageBox.Show("No se ha seleccionado una imagen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAnadirImagen.Focus();
            }
            else if(txtTrabajo.Text == txtCelular.Text || txtCelular.Text == txtCasa.Text || txtTrabajo.Text == txtCasa.Text)
            {
                MessageBox.Show("Los numeros de telefono a registrar son iguales", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // si todos los campos fueron completados
            else
            {
                try
                {
                    // validar si el contacto existe
                    if (Contact.Validate(txtNombre.Text, txtApellido.Text))
                    {
                        MessageBox.Show("Ya hay un Contacto Registrado con ese nombre y apellido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    // si el contacto no existe
                    else
                    {
                        Contact pInfoContact = new Contact();
                        pInfoContact.name = txtNombre.Text;
                        pInfoContact.lastName = txtApellido.Text;
                        pInfoContact.Email = txtCorreo.Text;
                        pInfoContact.idImage = 0;

                        MessageBox.Show(Contact.registerContact(pInfoContact), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pContact = Contact.getInfoContact(txtNombre.Text, txtApellido.Text);

                        if (txtCasa.MaskCompleted)
                        {
                            if(Phones.validatePhoneDiff(0, txtCasa.Text))
                            {
                                if(MessageBox.Show(Phones.getContactNameDiff(pContact.id, txtCasa.Text) + "\n ¿DESEA REGISTRAR EL NUMERO DE LA CASA?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    Phones.addNewPhone(pContact.id, txtCasa.Text, "casa");
                                }
                            }
                            else
                            {
                                Phones.addNewPhone(pContact.id, txtCasa.Text, "casa");
                            }
                        }

                        if (txtCelular.MaskCompleted)
                        {
                            if (Phones.validatePhoneSame(pContact.id, txtCelular.Text))
                            {
                                MessageBox.Show(Phones.getContactNameSame(pContact.id, txtCelular.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                            else
                            {
                                if(Phones.validatePhoneDiff(pContact.id, txtCelular.Text))
                                {
                                    if(MessageBox.Show(Phones.getContactNameDiff(pContact.id, txtCelular.Text) + "\n ¿DESEA REGISTRAR EL NUMERO DEL CELULAR?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        Phones.addNewPhone(pContact.id, txtCelular.Text, "celular");
                                    }
                                }
                                else
                                {
                                    Phones.addNewPhone(pContact.id, txtCelular.Text, "celular");
                                }
                            }
                        }

                        if (txtTrabajo.MaskCompleted)
                        {
                            if (Phones.validatePhoneSame(pContact.id, txtTrabajo.Text))
                            {
                                MessageBox.Show(Phones.getContactNameSame(pContact.id, txtTrabajo.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                            else
                            {
                                if (Phones.validatePhoneDiff(pContact.id, txtTrabajo.Text))
                                {
                                    if (MessageBox.Show(Phones.getContactNameDiff(pContact.id, txtTrabajo.Text) + "\n ¿DESEA REGISTRAR EL NUMERO DEL TRABAJO?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        Phones.addNewPhone(pContact.id, txtTrabajo.Text, "trabajo");
                                    }
                                }
                                else
                                {
                                    Phones.addNewPhone(pContact.id, txtTrabajo.Text, "trabajo");
                                }
                            }
                        }

                        if(FilePathFotoDestiny != null)
                        {
                            File.Copy(FilePathFotoSource, FilePathFotoDestiny, true);
                            Pictures.registerImage(FilePathFotoDestiny, pContact.id);
                        }


                        // pregunto al usuario si va a seguir en el mismo contacto
                        if (MessageBox.Show("Desea seguir con el mismo contacto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // hago visible los comboxes para guardar los numeros del contacto.
                            setVisibleTrueComboBoxes();
                            // hago visibles los pbes para poder anadir o modificar los numeros
                            setVisibleTruePBforNumbers();
                            // se cargan los numeros ya registrados
                            loadNumbers();
                            // se cargad las fotos
                            loadImages();
                        }
                        else
                        {
                            cleanEverything();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // boton para guardar la imagen
        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            if(pContact != null)
            {
                try
                {
                    MessageBox.Show(Pictures.registerImage(FilePathFotoDestiny, pContact.id), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.Copy(FilePathFotoSource, FilePathFotoDestiny, true);
                    loadImages();
                    btnGuardarImagen.Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha cargado un Contacto Para guardar la imagen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // label para limpiar todos los campos
        private void lblLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cleanEverything();
        }

        // boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // validar si los campos importantes siguen completos
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("El Nombre esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("El Apellido esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
            }
            else if (txtCorreo.Text == string.Empty)
            {
                MessageBox.Show("El Correo esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
            }
            // si es asi validare que ya se haya cargado un contacto
            else
            {
                if(pContact != null)
                {
                    pContact.name = txtNombre.Text;
                    pContact.lastName = txtApellido.Text;
                    pContact.Email = txtCorreo.Text;

                    try
                    {
                        MessageBox.Show(Contact.modifyContact(pContact), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(MessageBox.Show("Desea seguir con el mismo contacto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            cleanEverything();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha cargado un Contacto para poder modificar la informacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnBuscar.Focus();
                }
            }
        }

        // pb para modificar los numeros de los comboxes
        private void pbModificarCelular_Click(object sender, EventArgs e)
        {
            if (!txtCelular.Visible && cbCelular.Text != string.Empty)
            {
                cbCelular.Visible = false;
                txtCelular.Visible = true;
                txtCelular.Text = cbCelular.Text;
                txtCelular.Focus();
            }
            else if(txtCelular.Visible)
            {
                if (txtCelular.MaskCompleted)
                {
                    try {
                        // validar que no este registrado en un cotacto diferente
                        if (Phones.validatePhoneDiff(pContact.id, txtCelular.Text))
                        {
                            if (MessageBox.Show(Phones.getContactNameDiff(pContact.id, txtCelular.Text) + "¿DESEA REGISTRAR EL NUMERO?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // validar que no este registrado en el mismo contacto
                                if (Phones.validatePhoneSame(pContact.id, txtCelular.Text))
                                {
                                    MessageBox.Show(Phones.getContactNameSame(pContact.id, txtCelular.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(Phones.modifyPhone(pContact.id, pPhone.codigo, txtCelular.Text, "celular"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadNumbers();
                                    setVisibleTrueComboBoxes();
                                }
                            }
                        }
                        else
                        {
                            if (Phones.validatePhoneSame(pContact.id, txtCelular.Text))
                            {
                                MessageBox.Show(Phones.getContactNameSame(pContact.id, txtCelular.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show(Phones.modifyPhone(pContact.id, pPhone.codigo, txtCelular.Text, "celular"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadNumbers();
                                setVisibleTrueComboBoxes();
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha completado el numero de celular", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                }
            }
        }
        private void pbModificarCasa_Click(object sender, EventArgs e)
        {
            if (!txtCasa.Visible && cbCasa.Text != string.Empty)
            {
                cbCasa.Visible = false;
                txtCasa.Visible = true;
                txtCasa.Text = cbCasa.Text;
                txtCasa.Focus();
            }
            else if(txtCasa.Visible)
            {
                if (txtCasa.MaskCompleted)
                {
                    try
                    {
                        // validar que no este registrado en un cotacto diferente
                        if (Phones.validatePhoneDiff(pContact.id, txtCasa.Text))
                        {
                            if (MessageBox.Show(Phones.getContactNameDiff(pContact.id, txtCasa.Text) + "¿DESEA REGISTRAR EL NUMERO?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // validar que no este registrado en el mismo contacto
                                if (Phones.validatePhoneSame(pContact.id, txtCasa.Text))
                                {
                                    MessageBox.Show(Phones.getContactNameSame(pContact.id, txtCasa.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(Phones.modifyPhone(pContact.id, pPhone.codigo, txtCasa.Text, "casa"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadNumbers();
                                    setVisibleTrueComboBoxes();
                                }
                            }
                        }
                        else
                        {
                            if (Phones.validatePhoneSame(pContact.id, txtCasa.Text))
                            {
                                MessageBox.Show(Phones.getContactNameSame(pContact.id, txtCasa.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show(Phones.modifyPhone(pContact.id, pPhone.codigo, txtCasa.Text, "casa"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadNumbers();
                                setVisibleTrueComboBoxes();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void pbModificarTrabajo_Click(object sender, EventArgs e)
        {
            if (!txtTrabajo.Visible && cbTrabajo.Text != string.Empty)
            {
                cbTrabajo.Visible = false;
                txtTrabajo.Visible = true;
                txtTrabajo.Text = cbTrabajo.Text;
                txtTrabajo.Focus();
            }
            else if(txtTrabajo.Visible)
            {
                if (txtTrabajo.MaskCompleted)
                {
                    try
                    {
                        // validar que no este registrado en un cotacto diferente
                        if (Phones.validatePhoneDiff(pContact.id, txtTrabajo.Text))
                        {
                            if (MessageBox.Show(Phones.getContactNameDiff(pContact.id, txtTrabajo.Text) + "¿DESEA REGISTRAR EL NUMERO?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // validar que no este registrado en el mismo contacto
                                if (Phones.validatePhoneSame(pContact.id, txtTrabajo.Text))
                                {
                                    MessageBox.Show(Phones.getContactNameSame(pContact.id, txtTrabajo.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(Phones.modifyPhone(pContact.id, pPhone.codigo, txtTrabajo.Text, "trabajo"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadNumbers();
                                    setVisibleTrueComboBoxes();
                                }
                            }
                        }
                        else
                        {
                            if (Phones.validatePhoneSame(pContact.id, txtTrabajo.Text))
                            {
                                MessageBox.Show(Phones.getContactNameSame(pContact.id, txtTrabajo.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show(Phones.modifyPhone(pContact.id, pPhone.codigo, txtTrabajo.Text, "trabajo"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadNumbers();
                                setVisibleTrueComboBoxes();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // pb para eliminar o cancelar operacion
        private void pbEliminarCelular_Click(object sender, EventArgs e)
        {
            frmConfirmationActivityContact pConfirmation = new frmConfirmationActivityContact();
            pConfirmation.ShowDialog();

            if (pConfirmation.cancelar)
            {
                loadNumbers();
                setVisibleTrueComboBoxes();
            }
            else if (pConfirmation.eliminar)
            {
                if (cbCelular.Text == string.Empty)
                {
                    MessageBox.Show("Seleccione el numero de celular que se va a eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbCelular.Focus();
                }
                else
                {
                    try
                    {
                        MessageBox.Show(Phones.deletePhone(pContact.id, cbCelular.Text, "celular"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadNumbers();
                        setVisibleTrueComboBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void pbEliminarCasa_Click(object sender, EventArgs e)
        {
            frmConfirmationActivityContact pConfirmation = new frmConfirmationActivityContact();
            pConfirmation.ShowDialog();

            if (pConfirmation.cancelar)
            {
                loadNumbers();
                setVisibleTrueComboBoxes();
            }
            else if (pConfirmation.eliminar)
            {
                if (cbCasa.Text == string.Empty)
                {
                    MessageBox.Show("Seleccione el Telefono de casa que se va a eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbCasa.Focus();
                }
                else
                {
                    try
                    {
                        MessageBox.Show(Phones.deletePhone(pContact.id, cbCasa.Text, "casa"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadNumbers();
                        setVisibleTrueComboBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void pbEliminarTrabajo_Click(object sender, EventArgs e)
        {
            frmConfirmationActivityContact pConfirmation = new frmConfirmationActivityContact();
            pConfirmation.ShowDialog();

            if (pConfirmation.cancelar)
            {
                loadNumbers();
                setVisibleTrueComboBoxes();
            }
            else if (pConfirmation.eliminar)
            {
                if (cbTrabajo.Text == string.Empty)
                {
                    MessageBox.Show("Seleccione el Telefono del trabajo que se va a eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbCasa.Focus();
                }
                else
                {
                    try
                    {
                        MessageBox.Show(Phones.deletePhone(pContact.id, cbCasa.Text, "trabajo"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadNumbers();
                        setVisibleTrueComboBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // pb para guardar cambios o guardar nuevo numero
        private void pbAnadirNuevoCelular_Click(object sender, EventArgs e)
        {
            if (!txtCelular.Visible)
            {
                txtCelular.Visible = true;
                cbCelular.Visible = false;
                txtCelular.Focus();
            }
            else
            {
                if (txtCelular.MaskCompleted)
                {
                    try
                    {
                        // validar que no este registrado en un cotacto diferente
                        if (Phones.validatePhoneDiff(pContact.id, txtCelular.Text))
                        {
                            if (MessageBox.Show(Phones.getContactNameDiff(pContact.id, txtCelular.Text) + "¿DESEA REGISTRAR EL NUMERO?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // validar que no este registrado en el mismo contacto
                                if (Phones.validatePhoneSame(pContact.id, txtCelular.Text))
                                {
                                    MessageBox.Show(Phones.getContactNameSame(pContact.id, txtCelular.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(Phones.addNewPhone(pContact.id, txtCelular.Text, "celular"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadNumbers();
                                    setVisibleTrueComboBoxes();
                                }
                            }
                        }
                        else
                        {
                            if (Phones.validatePhoneSame(pContact.id, txtCelular.Text))
                            {
                                MessageBox.Show(Phones.getContactNameSame(pContact.id, txtCelular.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show(Phones.addNewPhone(pContact.id, txtCelular.Text, "celular"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadNumbers();
                                setVisibleTrueComboBoxes();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El numero de celular no esta completo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                }
            }
        }
        private void pbAnadirNuevoCasa_Click(object sender, EventArgs e)
        {
            if (!txtCasa.Visible)
            {
                txtCasa.Visible = true;
                cbCasa.Visible = false;
                txtCasa.Focus();
            }
            else
            {
                if (txtCasa.MaskCompleted)
                {
                    try
                    {
                        // validar que no este registrado en un cotacto diferente
                        if (Phones.validatePhoneDiff(pContact.id, txtCasa.Text))
                        {
                            if (MessageBox.Show(Phones.getContactNameDiff(pContact.id, txtCasa.Text) + "¿DESEA REGISTRAR EL NUMERO?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // validar que no este registrado en el mismo contacto
                                if (Phones.validatePhoneSame(pContact.id, txtCasa.Text))
                                {
                                    MessageBox.Show(Phones.getContactNameSame(pContact.id, txtCasa.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(Phones.addNewPhone(pContact.id, txtCasa.Text, "casa"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadNumbers();
                                    setVisibleTrueComboBoxes();
                                }
                            }
                        }
                        else
                        {
                            if (Phones.validatePhoneSame(pContact.id, txtCasa.Text))
                            {
                                MessageBox.Show(Phones.getContactNameSame(pContact.id, txtCasa.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show(Phones.addNewPhone(pContact.id, txtCasa.Text, "casa"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadNumbers();
                                setVisibleTrueComboBoxes();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El numero de la casa no esta completo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCasa.Focus();
                }
            }
        }
        private void pbAnadirNuevoTrabajo_Click(object sender, EventArgs e)
        {
            if (!txtTrabajo.Visible)
            {
                txtTrabajo.Visible = true;
                cbTrabajo.Visible = false;
                txtTrabajo.Focus();
            }
            else
            {
                if (txtTrabajo.MaskCompleted)
                {
                    try
                    {
                        // validar que no este registrado en un cotacto diferente
                        if (Phones.validatePhoneDiff(pContact.id, txtTrabajo.Text))
                        {
                            if (MessageBox.Show(Phones.getContactNameDiff(pContact.id, txtTrabajo.Text) + "¿DESEA REGISTRAR EL NUMERO?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // validar que no este registrado en el mismo contacto
                                if (Phones.validatePhoneSame(pContact.id, txtTrabajo.Text))
                                {
                                    MessageBox.Show(Phones.getContactNameSame(pContact.id, txtTrabajo.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(Phones.addNewPhone(pContact.id, txtTrabajo.Text, "trabajo"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadNumbers();
                                    setVisibleTrueComboBoxes();
                                }
                            }
                        }
                        else
                        {
                            if (Phones.validatePhoneSame(pContact.id, txtTrabajo.Text))
                            {
                                MessageBox.Show(Phones.getContactNameSame(pContact.id, txtTrabajo.Text), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show(Phones.addNewPhone(pContact.id, txtTrabajo.Text, "trabajo"), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadNumbers();
                                setVisibleTrueComboBoxes();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El numero del trabajo no esta completo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTrabajo.Focus();
                }
            }
        }

        // eventos index changed para tomar la info del numero si esta cargado un contacto
        private void cbCelular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pContact != null)
            {
                if(cbCelular.Text != string.Empty)
                {
                    pPhone = Phones.getPhoneInfo(pContact.id, cbCelular.Text, "celular");
                }
                else
                {
                    pPhone = null;
                }
            }
        }
        private void cbCasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pContact != null)
            {
                if (cbCasa.Text != string.Empty)
                {
                    pPhone = Phones.getPhoneInfo(pContact.id, cbCasa.Text, "casa");
                }
                else
                {
                    pPhone = null;
                }
            }
        }
        private void cbTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pContact != null)
            {
                if (cbTrabajo.Text != string.Empty)
                {
                    pPhone = Phones.getPhoneInfo(pContact.id, cbTrabajo.Text, "trabajo");
                }
                else
                {
                    pPhone = null;
                }
            }
        }


        // botones para ir hacia adelante y hacia atras en las fotos.
        private void btnImagenProxima_Click(object sender, EventArgs e)
        {
            try
            {
                loadNextImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                loadBeforeImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // boton anadir imagen
        private void btnAnadirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageSelector = new OpenFileDialog();
            ImageSelector.Title = "Selecciona una imagen para el Contacto";
            ImageSelector.Filter = "Image Files: (*.jpg, *.png, *.gif)|*.jpg; *.png; *.gif";
            DialogResult SelectedImage = ImageSelector.ShowDialog();

            // verificar si existe el folder
            if (!Directory.Exists(@"C:\AgendaTelefonica"))
            {
                Directory.CreateDirectory(@"C:\AgendaTelefonica");
            }

            // tambien verifico si exite el folder de las imagenes para los contactos
            if (!Directory.Exists(@"C:\AgendaTelefonica\contactimg"))
            {
                Directory.CreateDirectory(@"C:\AgendaTelefonica\contactimg");
            }

            // valido si se selecciono una imagen del file dialog
            if (SelectedImage != DialogResult.Cancel)
            {
                FilePathFotoDestiny = @"C:\AgendaTelefonica\contactimg\" + Path.GetFileName(ImageSelector.FileName);
                FilePathFotoSource = ImageSelector.FileName;
                pbImages.Image = Image.FromFile(ImageSelector.FileName);
                if (pContact != null)
                {
                    btnGuardarImagen.Visible = true;
                }
                else
                {
                    btnGuardarImagen.Visible = false;
                }
            }
            else
            {
                FilePathFotoDestiny = null;
                FilePathFotoSource = null;
                MessageBox.Show("No se ha seleccionadu una imagen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
