using Control;
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
    public partial class FrmConsultarRecluso : Form
    {
        ControlRecluso controlRecluso = new ControlRecluso();
        public FrmConsultarRecluso()
        {
            InitializeComponent();
            
        }

        private void consultarReclusos()
        {

            try
            {
                controlRecluso.

            }catch (GeneralExcepcion ex)
            {

            }
        }









        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int posY = 0;
        int posX = 0;
        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
