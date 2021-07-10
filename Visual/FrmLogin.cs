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

namespace Visual
{
    public partial class FrmLogin : Form
    {
        ControladorUsuario controlUser = new ControladorUsuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (!EsVacio(usuario,contrasena))
            {
                string message = "";
                try
                {
                    controlUser.validarLogin(usuario, contrasena);
                }
                catch (GeneralExcepcion ex)
                {
                    message = ex.Message;
                }

                if (message.Equals(""))
                {
                    this.Hide();
                    PrincipalAdministrador principal = new PrincipalAdministrador();
                    principal.ShowDialog();
                }
                else
                {
                    MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios");
            }
        }

        private bool EsVacio(String usuario, String contrasena)
        {
            return String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(contrasena);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
