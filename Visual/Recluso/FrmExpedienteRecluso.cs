using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
namespace Visual.Recluso
{
    public partial class FrmExpedienteRecluso : Form
    {
        ControlRecluso controlRecluso;
        public FrmExpedienteRecluso(ControlRecluso controlRecluso, string cedula, string nombreRecluso)
        {
            InitializeComponent();
            this.controlRecluso = controlRecluso;
            lblNombre.Text = nombreRecluso;
            ConsultarExpediente(cedula);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ConsultarExpediente(string cedula)
        {
            List<Object> cargos;
            string codigoExpediente=GetCodigoExpediente(controlRecluso.buscarExpediente(cedula));
            cargos=controlRecluso.ListarCargos(codigoExpediente);
            lblCodigo.Text = codigoExpediente;
            LlenarTablaCargos(cargos);
        }
        private string GetCodigoExpediente(Object expediente)
        {
            Type tipo = expediente.GetType();
            return (string)tipo.GetProperty("Codigo").GetValue(expediente);
        }
        private void InsertarFila(Object cargo)
        {
            Type tipo = cargo.GetType();
            string delito = (string)tipo.GetProperty("delito").GetValue(cargo);
            string descripcion = (string)tipo.GetProperty("descripcion").GetValue(cargo);
            string fecha = ((DateTime)tipo.GetProperty("fecha").GetValue(cargo)).ToString("dd/MM/yyyy");
            string localidad = (string)tipo.GetProperty("localidad").GetValue(cargo);
            string ciudad = (string)tipo.GetProperty("ciudad").GetValue(cargo);
            string pais = (string)tipo.GetProperty("pais").GetValue(cargo);
            dgvCargos.Rows.Add(delito, descripcion, fecha, localidad, ciudad, pais);
        }
        private void LlenarTablaCargos(List<Object> cargos)
        {
            LimpiarTabla();
            foreach (var cargo in cargos)
            {
                InsertarFila(cargo);
            }
            dgvCargos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCargos.AutoResizeColumns();
        }
        private void LimpiarTabla()
        {
            dgvCargos.Rows.Clear();
        }
    }
}
