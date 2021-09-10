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
    public partial class FrmConsultaToActualizar : Form
    {
        ControladorUsuario controlUsuario = new ControladorUsuario();
        public FrmConsultaToActualizar()
        {
            InitializeComponent();
            ConsultarUsuarios();
        }

        private void ConsultarUsuarios()
        {
            List<Object> usuarios = null;
            try
            {
                usuarios = controlUsuario.ListarUsuarios();
                LlenarTablaUsuarios(usuarios);
            }
            catch (GeneralExcepcion)
            {
                MessageBox.Show("No hay usuarios registrados en el sistema.");
            }
        }

        private void LlenarTablaUsuarios(List<object> usuarios)
        {
            LimpiarTabla();
            foreach (var usuario in usuarios)
            {
                InsertarFila(usuario);
            }
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.AutoResizeColumns();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();

            if (!EsVacio(user))
            {
                LimpiarTabla();
                Object usuario = controlUsuario.BuscarUsuario(user);
                InsertarFila(usuario);
            }
            else
            {
                MessageBox.Show("Favor ingrese un apellido");
            }

        }

        private void InsertarFila(object usuario)
        {
            Type tipo = usuario.GetType();
            string nombres = (string)tipo.GetProperty("nombres").GetValue(usuario);
            string apellidos = (string)tipo.GetProperty("apellidos").GetValue(usuario);
            string user = (string)tipo.GetProperty("usuario").GetValue(usuario);
            string contrasena = (string)tipo.GetProperty("contrasena").GetValue(usuario);
            string rol = (string)tipo.GetProperty("rol").GetValue(usuario);

            dgvUsuarios.Rows.Add(nombres, apellidos, user, contrasena, rol);
        }

        private void LimpiarTabla()
        {
            dgvUsuarios.Rows.Clear();
        }

        private bool EsVacio(string apellidos)
        {
            return String.IsNullOrEmpty(apellidos);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios();
        }

        private void dgvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string usuario = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            FrmActualizarUsuario actualiza = new FrmActualizarUsuario(usuario);
            actualiza.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;

        private void FrmConsultaToActualizar_MouseMove(object sender, MouseEventArgs e)
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
