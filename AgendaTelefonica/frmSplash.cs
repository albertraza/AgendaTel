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
    public partial class frmSplash : Form
    {
        /// <summary>
        /// Hecho por Albert Ramirez para Proyecto 3
        /// Fecha: 4 Abril 2017
        /// Correo: arbert.jr@hotmail.com
        /// </summary>

        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            tClock.Start();
        }

        int conteo;
        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            progressBar1.Value = conteo;
            if (conteo == 100)
            {
                tClock.Stop();
                new frmLogin().Show();
                this.Hide();
            }
        }
    }
}
/// <summary>
/// Hecho por Albert Ramirez para Proyecto 3
/// Fecha: 4 Abril 2017
/// Correo: arbert.jr@hotmail.com
/// </summary>

