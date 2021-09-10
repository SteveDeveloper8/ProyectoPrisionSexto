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
        ControladorUsuario controlUser = new ControladorUsuario();
        ControlRecluso controlRecluso=new ControlRecluso();
        //Muestra los datos de todos los relusos registrados al abrir el formulario.
        public FrmConsultarRecluso()
        {
            InitializeComponent();
            consultarReclusos();
        }
        //Consulta al sistema los datos de los reclusos registrados y los muestra.
        private void consultarReclusos()
        {
            List<Object> reclusos = null;
            try
            {
                reclusos = controlRecluso.ListarReclusos();
                LlenarTablaReclusos(reclusos);
            }catch (GeneralExcepcion)
            {
                MessageBox.Show("No hay reclusos registrados en el sistema.");
            }
        }
        //Borra todas las filas de la tabla dejando solo la cabecera.
        private void LimpiarTabla()
        {
            dgvReclusos.Rows.Clear();
        }
        //Muestra  en la tabla una lista de objetos genéricos dada como argumento para ser visualizados.
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
        //Obtiene los datos de un objeto genérico en forma de datos que entienda la tabla y los inserta en la misma en forma de fila.
        private void InsertarFila(Object recluso)
        {
            Type tipo = recluso.GetType();
            string codigo = (string)tipo.GetProperty("codigo").GetValue(recluso);
            string nombre = (string)tipo.GetProperty("nombre").GetValue(recluso);
            string apellidos = (string)tipo.GetProperty("apellidos").GetValue(recluso);
            string genero = (string)tipo.GetProperty("genero").GetValue(recluso);
            string fecha = ((DateTime)tipo.GetProperty("fecha").GetValue(recluso)).ToString("dd/MM/yyyy");
            string cedula = (string)tipo.GetProperty("cedula").GetValue(recluso);
            dgvReclusos.Rows.Add(codigo, nombre, apellidos, cedula, genero, fecha, "Ver expediente");
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
        //Muestra el expediente de un recluso en específico en un nuevo formulario emergente.
        private void dgvReclusos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string cedula = Convert.ToString(dgvReclusos.Rows[e.RowIndex].Cells[3].Value);
                string nombres= Convert.ToString(dgvReclusos.Rows[e.RowIndex].Cells[1].Value);
                string apellidos= Convert.ToString(dgvReclusos.Rows[e.RowIndex].Cells[2].Value);
                new FrmExpedienteRecluso(controlRecluso,cedula, nombres+" "+apellidos).ShowDialog();
            }
        }
        //Muestra los datos de un recluso en específico que coincida con un número de cédula ingresado.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarTabla();
            Object recluso = controlRecluso.BuscarRecluso(txtCedula.Text);
            InsertarFila(recluso);
        }
        //Muestra los dato d etodos los reclusos registrados en el sistema.
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            consultarReclusos();
        }

        private void dgvReclusos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string cedulaRecluso = dgvReclusos.CurrentRow.Cells[3].Value.ToString();
           // controlUser.BuscarUsuario()
        }
    }
}
