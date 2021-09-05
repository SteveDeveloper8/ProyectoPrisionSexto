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
    public partial class FrmDistancia : Form
    {
        ControlCursos controlCursos = new ControlCursos();
        public FrmDistancia()
        {
            InitializeComponent();
            consultarCursos();
        }

        private void consultarCursos()
        {
            List<Object> reclusos = null;
            try
            {
                reclusos = controlCursos.ListarCursosDistancia();
                LlenarTablaCursosDistancia(reclusos);
            }
            catch (GeneralExcepcion ex)
            {
                MessageBox.Show("No hay reclusos registrados en el sistema.");
            }
        }

        private void LlenarTablaCursosDistancia(List<object> cursoDistancia)
        {
            LimpiarTabla();
            foreach (var curso in cursoDistancia)
            {
                InsertarFila(curso);
            }
            dgvDistancia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDistancia.AutoResizeColumns();
        }

        private void LimpiarTabla()
        {
            dgvDistancia.Rows.Clear();
        }

        private bool EsVacio(int cupos, string descripcion, int remision, DateTime fechaInicio, DateTime fechaFin,string modalidad)
        {
            return String.IsNullOrEmpty(cupos+"") || String.IsNullOrEmpty(descripcion) || String.IsNullOrEmpty(remision+"") || fechaInicio==null || fechaFin==null || String.IsNullOrEmpty(modalidad);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (dgvDistancia.Rows.Count > 0)
            {
                pos = dgvDistancia.CurrentRow.Index;
                string estudioDelete = dgvDistancia.CurrentRow.Cells[0].Value.ToString();
                string modalidad = dgvDistancia.CurrentRow.Cells[1].Value.ToString();
                controlCursos.EliminarEstudio(estudioDelete,modalidad);
                dgvDistancia.Rows.RemoveAt(pos);
            }
            else
            {
                MessageBox.Show("No existen registros para eliminar");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string descripcion = txtBuscarDescripcion.Text.Trim();
            string modalidad = cmbFiltrar.Text.Trim();

            if (EsVacioBusqueda(descripcion,modalidad))
            {
                MessageBox.Show("No existen datos a buscar");
            }
            else if(modalidad.CompareTo("Filtrar...")==0)
            {
                try
                {
                    dgvDistancia.Rows.Clear();
                    Object distancia = controlCursos.FiltrarDesccripcion(descripcion);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else if(descripcion.CompareTo("") == 0)
            {
                try
                {
                    dgvDistancia.Rows.Clear();
                    //Object modalidad = controlCursos.FiltrarModalidad(modalidad);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void InsertarFila(Object distancia)
        {
            Type tipo = distancia.GetType();
            int cupos = (int)tipo.GetProperty("descripcion").GetValue(distancia);
            string descripcion = (string)tipo.GetProperty("Nombre").GetValue(distancia);
            int remisionCondena = (int)tipo.GetProperty("Apellidos").GetValue(distancia);
            string fechaInicio = ((DateTime)(tipo.GetProperty("fechaInicio").GetValue(distancia))).ToString("dd/MM/yyyy");
            string fechaFin = ((DateTime)(tipo.GetProperty("fechaFin").GetValue(distancia))).ToString("dd/MM/yyyy");
           
            dgvDistancia.Rows.Add(descripcion,cupos, fechaInicio, fechaFin, remisionCondena);
        }


        private bool EsVacioBusqueda(string descripcion,string modalidad)
        {
            return String.IsNullOrEmpty(descripcion)&&String.IsNullOrEmpty(modalidad);
        }

        private void FrmDistancia_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            int cupos = Convert.ToInt32(txtCupos.Text.Trim());
            string descripcion = txtDescripcion.Text.Trim();
            int remision = Convert.ToInt32(txtRemision.Text.Trim());
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;
            string modalidad = cmbModalidad.Text.Trim();

            if (!EsVacio(cupos, descripcion, remision, fechaInicio, fechaFin,modalidad))
            {
                try
                {
                    controlCursos.GuardarEstudio(cupos, descripcion, remision, fechaInicio, fechaFin,modalidad);
                    MessageBox.Show("Curso Guardado con Exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Existe un campo vacio, o algún dato erróneo");
            }

        }
    }
}
