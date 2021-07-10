using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual.Recluso
{
    public partial class FrmExpedienteRecluso : Form
    {
        private int idExpediente;
        public FrmExpedienteRecluso(int idExpediente)
        {
            InitializeComponent();
            this.idExpediente = idExpediente;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
