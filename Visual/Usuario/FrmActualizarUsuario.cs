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
    public partial class FrmActualizarUsuario : Form
    {
        private  string username;
        ControladorUsuario controlUsuario = new ControladorUsuario();
        public FrmActualizarUsuario(string usuario)
        {
            InitializeComponent();
            this.username = usuario;
            txtUsuario.Enabled = false;
            Inicializar();
        }

        private void Inicializar()
        {
            Object usuario = BuscarUsuario();
            Type tipo = usuario.GetType();
            txtNombre.Text = (string)tipo.GetProperty("nombres").GetValue(usuario);
            txtApellido.Text = (string)tipo.GetProperty("apellidos").GetValue(usuario);
            txtUsuario.Text = (string)tipo.GetProperty("usuario").GetValue(usuario);
            txtContrasena.Text = (string)tipo.GetProperty("contrasena").GetValue(usuario);
            cmbRol.Text = (string)tipo.GetProperty("rol").GetValue(usuario);
        }

        private Object BuscarUsuario()
        {
            Object usuario = controlUsuario.BuscarUsuario(username);
            return usuario;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string confirmacion = txtConfimacion.Text.Trim();
            string rol = cmbRol.Text.Trim();

            if (!esVacio(nombre, apellido, usuario, contrasena, confirmacion, rol))
            {
                try
                {
                    if (validarConfirmacion(contrasena, confirmacion))
                    {// el parametro username es el que debes especificar en el where del sp
                        controlUsuario.ActualizarUsuario(nombre, apellido, usuario, contrasena, rol);
                        MessageBox.Show("Usuario Actualizado");
                    }
                }
                catch (Exception ex)
                {
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

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;
        private void FrmActualizarUsuario_MouseMove(object sender, MouseEventArgs e)
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
