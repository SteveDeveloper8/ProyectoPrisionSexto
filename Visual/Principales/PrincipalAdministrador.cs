using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual.Recluso;
using Visual.Usuario;

namespace Visual
{
    public partial class PrincipalAdministrador : Form
    {
        public PrincipalAdministrador()
        {
            InitializeComponent();
            CerrarSesion.Visible = false;
        }


        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarRecluso consultar = new FrmConsultarRecluso();
            consultar.ShowDialog();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarRecluso ingresar = new FrmIngresarRecluso();
            ingresar.ShowDialog();
        }

        private void PrincipalAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_MouseHover(object sender, EventArgs e)
        {
            CerrarSesion.Visible = true;
        }

        private void guna2PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            CerrarSesion.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuRegistrar_Click(object sender, EventArgs e)
        {
            FrmIngresarRecluso ingresar = new FrmIngresarRecluso();
            ingresar.ShowDialog();
        }

        private void MenuRegistrarUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario registrar = new FrmRegistrarUsuario();
            registrar.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmConsultarUsuario usuarios = new FrmConsultarUsuario();
            usuarios.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmConsultaToActualizar actualiza = new FrmConsultaToActualizar();
            actualiza.ShowDialog();
        }
    }
}
