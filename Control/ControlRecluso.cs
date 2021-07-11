using Data;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class ControlRecluso
    {
        DatosRecluso datosRecluso = new DatosRecluso();
        List<Recluso> reclusos = new List<Recluso>();
        Recluso recluso = null;
        internal bool ValidarCodigo(string codigo)
        {
            bool x = true;
            if (codigo.Length != 10)
            {
                x = false;
            }
            return x;
        }
        
        public bool existeCodigo(string codigo)
        {
            foreach (Recluso recluso in reclusos)
            {
                if (recluso.Codigo.Equals(codigo))
                {
                    MessageBox.Show("Código ya registrado");
                    return true;
                }
            }
            return false;
        }

        public int buscarExpediente(string cedula)
        {
            Expediente expediente = null;
            expediente = datosRecluso.buscarExpedienteBD(cedula);

            if (expediente == null)
            {
                throw new GeneralExcepcion("Expediente de recluso no existente");
            }
            else
            {
                return expediente.Id;
            }
        }


        public void GuardarRecluso(string codigo, string nombre, string apellido, string genero, DateTime fecha, int idExpediente, string cedula)
        {
            Expediente exp = datosRecluso.buscarExpedienteBD(cedula);
            recluso = new Recluso(nombre, apellido, genero, fecha, cedula, codigo, exp);
            string message = datosRecluso.InsertarRecluso(recluso);

            if (message.Equals("fallido"))
            {
                throw new GeneralExcepcion("Existio un error en base de datos");
            }
        }


        public List<Object> ListarReclusos()
        {
            List<Object> reclusos= datosRecluso.ConsultarReclusos();

            if (reclusos.Count <= 0)
                throw new GeneralExcepcion("No se encontraron reclusos registrados");
            else
                return reclusos;
        }

        
    }
}
