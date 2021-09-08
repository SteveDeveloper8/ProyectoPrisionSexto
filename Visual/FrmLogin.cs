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
        //Envía las credenciales de acceso al sistema y si con consistenetes permite el acceso.
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            Login(usuario, contrasena);
           
        }

        private void Login(string usuario, string contrasena)
        {
            if (!EsVacio(usuario, contrasena))
            {
                try
                {
                    controlUser.validarLogin(usuario, contrasena);
                    AbrirMenu(usuario);
                }
                catch (GeneralExcepcion ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios");
            }
        }

        private void AbrirMenu(string usuario)
        {
            this.Hide();
            if (controlUser.RetornaRol(usuario).Equals("Administrador")) 
            {
                PrincipalAdministrador principal = new PrincipalAdministrador();
                principal.ShowDialog();
            }
            else if(controlUser.RetornaRol(usuario).Equals("Alcaide"))
            {
                EstudioRegistro alcaide = new EstudioRegistro(usuario);
                alcaide.ShowDialog();
            }
            
        }
        //Valida que no haya campos del fromulario sin llenar.
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
