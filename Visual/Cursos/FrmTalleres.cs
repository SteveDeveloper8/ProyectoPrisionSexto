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
    public partial class FrmTalleres : Form
    {
        ControlActividadPractica controlActividad = new ControlActividadPractica();
        public FrmTalleres()
        {
            InitializeComponent();
            consultarActividades();
            cmbFiltrar.SelectedIndex = cmbFiltrar.FindStringExact("Filtrar...");
        }

        private void consultarActividades()
        {
            List<Object> actividades = null;
            try
            {
                actividades = controlActividad.ListarActividadesPracticas();
                LlenarTablaActividadesPracticas(actividades);
            }
            catch (GeneralExcepcion)
            {
                MessageBox.Show("No hay reclusos registrados en el sistema.");
            }
        }

        private void LlenarTablaActividadesPracticas(List<object> actividades)
        {
            LimpiarTabla();
            foreach (var actividad in actividades)
            {
                InsertarFila(actividad);
            }
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvActividades.AutoResizeColumns();
        }

        private void LimpiarTabla()
        {
            dgvActividades.Rows.Clear();
        }

        private bool EsVacio(int cupos, string descripcion, int remision, string modalidad)
        {
            return String.IsNullOrEmpty(cupos + "") || String.IsNullOrEmpty(descripcion) || String.IsNullOrEmpty(remision + "") || String.IsNullOrEmpty(modalidad);
        }



        private void FiltrarDescripcion(string descripcion)
        {
            List<Object> actividades = null;
            try
            {
                actividades = controlActividad.FiltrarDesccripcion(descripcion);
                LlenarTablaActividades(actividades);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FiltrarModalidad(string modalidad)
        {
            List<Object> actividades = null;
            try
            {
                actividades = controlActividad.FiltrarModalidad(modalidad);
                LlenarTablaActividades(actividades);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FiltrarDescripcionModalidad(string descripcion, string modalidad)
        {
            List<Object> actividades = null;
            try
            {
                actividades = controlActividad.FiltrarDescripcionModalidad(descripcion, modalidad);
                LlenarTablaActividades(actividades);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LlenarTablaActividades(List<Object> actividades)
        {
            LimpiarTabla();
            foreach (var actividad in actividades)
            {
                InsertarFila(actividad);
            }
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvActividades.AutoResizeColumns();
        }



        private void InsertarFila(Object actividad)
        {
            Type tipo = actividad.GetType();
            int cupos = (int)tipo.GetProperty("cupos").GetValue(actividad);
            string descripcion = (string)tipo.GetProperty("descripcion").GetValue(actividad);
            string modalidad = (string)tipo.GetProperty("modalidad").GetValue(actividad);
            int remisionDiaria = (int)tipo.GetProperty("remisionDiaria").GetValue(actividad);

            dgvActividades.Rows.Add(descripcion, modalidad, cupos, remisionDiaria);
        }


        private bool EsVacioBusqueda(string descripcion, string modalidad)
        {
            return String.IsNullOrEmpty(descripcion) && String.IsNullOrEmpty(modalidad);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cupos = Convert.ToInt32(txtCupos.Text.Trim());
            string descripcion = txtDescripcion.Text.Trim();
            int remision = Convert.ToInt32(txtRemision.Text.Trim());
            string modalidad = cmbModalidad.Text.Trim();

            if (!EsVacio(cupos, descripcion, remision, modalidad))
            {
                try
                {
                    Object actividad = controlActividad.GuardarActividadPractica(cupos, descripcion, remision, modalidad);
                    MessageBox.Show("Actividad Guardada con Exito");
                    InsertarFila(actividad);
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int pos = 0;
            if (dgvActividades.Rows.Count > 0)
            {
                pos = dgvActividades.CurrentRow.Index;
                string ActividadDelete = dgvActividades.CurrentRow.Cells[0].Value.ToString();
                string modalidad = dgvActividades.CurrentRow.Cells[1].Value.ToString();
                controlActividad.EliminarActividad(ActividadDelete, modalidad);
                dgvActividades.Rows.RemoveAt(pos);
                MessageBox.Show("Actividad Eliminada con Exito");
            }
            else
            {
                MessageBox.Show("No existen registros para eliminar");
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string descripcion = txtBuscarDescripcion.Text.Trim();
            string modalidad = cmbFiltrar.Text.Trim();

            if (EsVacioBusqueda(descripcion, modalidad))
            {
                MessageBox.Show("No existen datos a buscar");
            }
            else if (modalidad.CompareTo("Filtrar...") == 0)
            {
                FiltrarDescripcion(descripcion);
            }
            else if (descripcion.CompareTo("") == 0)
            {
                FiltrarModalidad(modalidad);
            }
            else if (!(descripcion.CompareTo("") == 0) && !(modalidad.CompareTo("") == 0))
            {
                FiltrarDescripcionModalidad(descripcion, modalidad);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarDescripcion.Clear();
            cmbFiltrar.SelectedIndex = cmbFiltrar.FindStringExact("Filtrar...");
            consultarActividades();
        }
    }
}
