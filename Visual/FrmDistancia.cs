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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cupos = Convert.ToInt32(txtCupos.Text.Trim());
            string descripcion = txtDescripcion.Text.Trim();
            int remision = Convert.ToInt32(txtRemision.Text.Trim());
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;

            if (!EsVacio(cupos, descripcion, remision, fechaInicio, fechaFin))
            {
                try
                {
                    controlCursos.GuardarEstudio(cupos, descripcion, remision, fechaInicio, fechaFin);
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

        private bool EsVacio(int cupos, string descripcion, int remision, DateTime fechaInicio, DateTime fechaFin)
        {
            return String.IsNullOrEmpty(cupos+"") || String.IsNullOrEmpty(descripcion) || String.IsNullOrEmpty(remision+"") || fechaInicio==null || fechaFin==null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (dgvDistancia.Rows.Count > 0)
            {
                pos = dgvDistancia.CurrentRow.Index;
                string estudioDelete = dgvDistancia.CurrentRow.Cells[0].Value.ToString();
                controlCursos.EliminarEstudio(estudioDelete);
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

            if (!EsVacioBusqueda(descripcion))
            {
                try
                {
                    dgvDistancia.Rows.Clear();
                    Object distancia=controlCursos.FiltrarDesccripcion(descripcion);
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No existen datos a buscar");
            }
        }

        private void InsertarFila(Object distancia)
        {
            Type tipo = distancia.GetType();
            int cupos = (int)tipo.GetProperty("descripcion").GetValue(distancia);
            string descripcion = (string)tipo.GetProperty("Nombre").GetValue(distancia);
            int remisionCondena = (int)tipo.GetProperty("Apellidos").GetValue(distancia);
            DateTime fechaInicio = (tipo.GetProperty("fechaInicio").GetValue(distancia)).ToString("dd/MM/yyyy");
            DateTime fechaFin = (tipo.GetProperty("fechaFin").GetValue(distancia)).ToString("dd/MM/yyyy");
           
            dgvDistancia.Rows.Add(descripcion,cupos, fechaInicio, fechaFin, remisionCondena);
        }


        private bool EsVacioBusqueda(string descripcion)
        {
            return String.IsNullOrEmpty(descripcion);
        }
    }
}
}
