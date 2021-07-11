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
        ControlRecluso controlRecluso=new ControlRecluso();
        public FrmConsultarRecluso()
        {
            InitializeComponent();
            consultarReclusos();
        }

        private void consultarReclusos()
        {
            List<Object> reclusos = null;
            try
            {
                reclusos = controlRecluso.ListarReclusos();
                llenarTablaReclusos(reclusos);
            }catch (GeneralExcepcion ex)
            {
                MessageBox.Show("No hay");
            }
        }
        private void llenarTablaReclusos(List<Object> reclusos)
        {
            foreach (var recluso in reclusos)
            {
                Type tipo = recluso.GetType();
                string codigo= (string)tipo.GetProperty("Codigo").GetValue(recluso);
                string nombre= (string)tipo.GetProperty("Nombre").GetValue(recluso);
                string apellidos= (string)tipo.GetProperty("Apellidos").GetValue(recluso);
                string genero= (string)tipo.GetProperty("Genero").GetValue(recluso);
                string fecha= ((DateTime)tipo.GetProperty("Fecha").GetValue(recluso)).ToString("dd/MM/yyyy");
                string cedula= (string)tipo.GetProperty("Cedula").GetValue(recluso);
                dgvReclusos.Rows.Add(codigo, nombre, apellidos, cedula, genero, fecha, "Ver expediente");
            }
            dgvReclusos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReclusos.AutoResizeColumns();
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

        private void dgvReclusos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                MessageBox.Show(Convert.ToString(dgvReclusos.Rows[e.RowIndex].Cells[3].Value));
            }
        }   
    }
}
