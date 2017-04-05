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
    public partial class frmMenuPrincipal : Form
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        // variable para guardar la info del contacto
        private Contact pInfoContact;

        // para hacer visible false el gb de resultados de busqueda.
        private void setVisibleFalsegbResultadoBusqueda()
        {
            gbResultadoBusqueda.Visible = false;
            lblApellido.Visible = false;
            lblCorreoElectronico.Visible = false;
            lblNombre.Visible = false;
            btnMasDetalles.Visible = false;
            pbImagenContacto.Visible = false;
        }

        private void setVisibleTrueDetalles()
        {
            lblApellido.Visible = true;
            lblCorreoElectronico.Visible = true;
            lblNombre.Visible = true;
            btnMasDetalles.Visible = true;
            pbImagenContacto.Visible = true;
        }

        // para limpiar la busqueda
        private void deleteBusqueda()
        {
            lblApellido.Text = "Apellido:";
            lblNombre.Text = "Nombre:";
            lblCorreoElectronico.Text = "Correo Electronico:";
            pbImagenContacto.Image = Resources.imageres_79;
            gbResultadoBusqueda.Visible = false;
        }

        private void salirDeLaAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea salir de la aplicacioc?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMantenimientoUsuarios().Show();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManyenimientoContactos().Show();
        }

        private void contactosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaContactos pConsulta = new frmConsultaContactos();
            pConsulta.Menu = true;
            pConsulta.Show();
        }

        private void reporteDeContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReporteContactos().Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            setVisibleFalsegbResultadoBusqueda();
        }


        // para cuando se le de click al la lista asi poder cargar la infomacion del estudiante
        private void dgvListaEncontrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaEncontrados.SelectedRows.Count == 1)
            {
                try
                {
                    Contact pContact = Contact.getInfoContactWID(Convert.ToInt32(dgvListaEncontrados.CurrentRow.Cells[0].Value));
                    pInfoContact = pContact;
                    setVisibleTrueDetalles();
                    Pictures[] pPicture = Pictures.listPicture(pContact.id).ToArray();
                    pbImagenContacto.Image = Image.FromFile(pPicture[0].Path);
                    lblNombre.Text = pContact.name;
                    lblApellido.Text = pContact.lastName;
                    lblCorreoElectronico.Text = pContact.Email;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un contacto de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gbResultadoBusqueda.Visible = true;
                dgvListaEncontrados.DataSource = Contact.searchEngine(txtNombre.Text, "");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            setVisibleFalsegbResultadoBusqueda();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gbResultadoBusqueda.Visible = true;
                dgvListaEncontrados.DataSource = Contact.searchEngine(txtNombre.Text, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListaEncontrados_Click(object sender, EventArgs e)
        {
            if (dgvListaEncontrados.SelectedRows.Count == 1)
            {
                try
                {
                    Contact pContact = Contact.getInfoContactWID(Convert.ToInt32(dgvListaEncontrados.CurrentRow.Cells[0].Value));
                    pInfoContact = pContact;
                    setVisibleTrueDetalles();
                    Pictures[] pPicture = Pictures.listPicture(pContact.id).ToArray();
                    pbImagenContacto.Image = Image.FromFile(pPicture[0].Path);
                    lblNombre.Text = pContact.name;
                    lblApellido.Text = pContact.lastName;
                    lblCorreoElectronico.Text = pContact.Email;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un contacto de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMasDetalles_Click(object sender, EventArgs e)
        {
            frmManyenimientoContactos pMantenimiento = new frmManyenimientoContactos();
            pMantenimiento.pContactInfo = pInfoContact;
            pMantenimiento.ShowDialog();
        }
    }
}
/// <summary>
/// Hecho por Albert Ramirez para Proyecto 3
/// Fecha: 4 Abril 2017
/// Correo: arbert.jr@hotmail.com
/// </summary>

