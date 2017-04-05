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
    public partial class frmConfirmationActivityContact : Form
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public frmConfirmationActivityContact()
        {
            InitializeComponent();
        }

        public bool eliminar { get; set; }
        public bool cancelar { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminar = false;
            cancelar = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminar = true;
            cancelar = false;
            this.Close();
        }
    }
}
