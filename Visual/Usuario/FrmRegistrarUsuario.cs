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

namespace Visual.Usuario
{
    public partial class FrmRegistrarUsuario : Form
    {
        ControladorUsuario controlUsuario = new ControladorUsuario();
        public FrmRegistrarUsuario()
        {
            InitializeComponent();

        }
        //Guarda lso datos del nuevo usuario en el sistema.
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string confirmacion = txtConfimacion.Text.Trim();
            string rol = cmbRol.Text.Trim();

            if (!esVacio(nombre,apellido,usuario,contrasena,confirmacion,rol))
            {
                try
                {
                    if (validarConfirmacion(contrasena, confirmacion)) {
                        controlUsuario.GuardarUsuario(nombre, apellido, usuario, contrasena, rol);
                        MessageBox.Show("Usuario Registrado");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
               
            }

        }
        //Valida que todos los campos del formulario esten llenos.
         private bool esVacio(string nombre, string apellido, string usuario, string contrasena, string confirmacion, string rol)
        {
            
            return String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido) || String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(contrasena) ||
                String.IsNullOrEmpty(confirmacion) || String.IsNullOrEmpty(rol);
        }
        //Valida si el usuario confirmó la contraseña correctamente.
        private bool validarConfirmacion(string contrasena, string confirmacion)
        {
            if (contrasena.Equals(confirmacion))
                return true;
            else
                return false;
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
