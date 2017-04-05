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
    public partial class frmReporteContactos : Form
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public frmReporteContactos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmReporteContactos_Load(object sender, EventArgs e)
        {

        }

        private void pCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pMain_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void frmReporteContactos_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pCerrar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            frmConsultaContactos pConsulta = new frmConsultaContactos();
            pConsulta.Menu = false;
            pConsulta.ShowDialog();

            if (pConsulta.pInfoContact != null)
            {
                try
                {
                    // TODO: This line of code loads data into the 'dsAgenda.reportContacto' table. You can move, or remove it, as needed.
                    this.reportContactoTableAdapter.Fill(this.dsAgenda.reportContacto, pConsulta.pInfoContact.id);
                    this.reportViewer1.RefreshReport();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se selecciono un contacto para poder general el reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
/// <summary>
/// Hecho por Albert Ramirez para Proyecto 3
/// Fecha: 4 Abril 2017
/// Correo: arbert.jr@hotmail.com
/// </summary>

