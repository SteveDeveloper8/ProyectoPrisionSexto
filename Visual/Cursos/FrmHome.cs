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

namespace Visual.Cursos
{
    public partial class FrmHome : Form
    {
        ControlRecluso controlRecluso = new ControlRecluso();
        public FrmHome()
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
                LlenarTablaReclusos(reclusos);
            }
            catch (GeneralExcepcion ex)
            {
                MessageBox.Show("No hay reclusos registrados en el sistema.");
            }

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

    }
}
