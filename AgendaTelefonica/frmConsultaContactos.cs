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
    public partial class frmConsultaContactos : Form
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public frmConsultaContactos()
        {
            InitializeComponent();
        }

        // variable para guardar el objeto contacto cuando sea seleccionado.
        public Contact pInfoContact { get; set; }

        // para saber si biene del menu principal o no
        public bool Menu { get; set; }

        // cambiar el tipo de cursor
        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pMain_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void frmConsultaContactos_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }


        // para cerrar la ventana
        private void pCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        // cuando cambia de filtro
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFiltro.Text == "Nombre")
            {
                txtBusqueda.Mask = "";
            }
            else if(cbFiltro.Text == "Apellido")
            {
                txtBusqueda.Mask = "";
            }
        }

        private void txtBusqueda_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltro.Text == "Nombre")
                {
                    dgvContactos.DataSource = Contact.searchEngine(txtBusqueda.Text, "");
                }
                else if (cbFiltro.Text == "Apellido")
                {
                    dgvContactos.DataSource = Contact.searchEngine("", txtBusqueda.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvContactos_Click(object sender, EventArgs e)
        {
            if (!Menu)
            {
                if (dgvContactos.SelectedRows.Count == 1)
                {
                    try
                    {
                        pInfoContact = Contact.getInfoContactWID(Convert.ToInt32(dgvContactos.CurrentRow.Cells[0].Value));
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningun Contacto de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
