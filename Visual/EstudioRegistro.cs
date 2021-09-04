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
    public partial class EstudioRegistro : Form
    {
        ControlRecluso controlRecluso = new ControlRecluso();
        public EstudioRegistro()
        {
            InitializeComponent();
            consultarReclusos();
        }


        private void abrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelPrincipal.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(formulario);
                panelPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            abrirFormulario<FrmDistancia>();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            abrirFormulario<FrmProfesional>();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            abrirFormulario<FrmTrabajo>();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            abrirFormulario<FrmTalleres>();
        }
        private void InsertarFila(Object recluso)
        {
            Type tipo = recluso.GetType();
            string codigo = (string)tipo.GetProperty("Codigo").GetValue(recluso);
            string nombre = (string)tipo.GetProperty("Nombre").GetValue(recluso);
            string apellidos = (string)tipo.GetProperty("Apellidos").GetValue(recluso);
            string genero = (string)tipo.GetProperty("Genero").GetValue(recluso);
            string fecha = ((DateTime)tipo.GetProperty("Fecha").GetValue(recluso)).ToString("dd/MM/yyyy");
            string cedula = (string)tipo.GetProperty("Cedula").GetValue(recluso);
            dgvReclusos.Rows.Add(codigo, nombre, apellidos, cedula, genero, fecha, "Ver expediente");
        }

        private void LimpiarTabla()
        {
            dgvReclusos.Rows.Clear();
        }

        private void LlenarTablaReclusos(List<Object> reclusos)
        {
            LimpiarTabla();
            foreach (var recluso in reclusos)
            {
                InsertarFila(recluso);
            }
            dgvReclusos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReclusos.AutoResizeColumns();
        }

        private void consultarReclusos()
        {
            List<Object> reclusos = null;
            try
            {
                reclusos = controlRecluso.ListarReclusos();
                LlenarTablaReclusos(reclusos);
            }
            catch (GeneralExcepcion ex)
            {
                MessageBox.Show("No hay reclusos registrados en el sistema.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
