using Data;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control.Excepciones;

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

        public Object buscarExpediente(string cedula)
        {
            Expediente expediente = null;
            expediente = datosRecluso.buscarExpedienteBD(cedula);

            if (expediente == null)
            {
                MessageBox.Show("no hay expedientes");
                throw new GeneralExcepcion("Expediente de recluso no existente");
            }
            else
            {
                return expediente;
            }
        }


        public bool GuardarRecluso(string codigo, string nombre, string apellido, string genero, DateTime fecha, int idExpediente, string cedula)
        {
            if (BuscarRecluso(cedula) == null)
            {
                Expediente exp = datosRecluso.buscarExpedienteBD(cedula);
                recluso = new Recluso(nombre, apellido, genero, fecha, cedula, codigo, exp);
                datosRecluso.InsertarRecluso(recluso);
                return true;
            }
            else {
                return false;
                throw new CedulaRepetidaException();
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

        public Object BuscarRecluso(string cedula)
        {
            return datosRecluso.BuscarRecluso(cedula);
        }
        public void ValidarRecluso(string cedula)
        {
            if (BuscarRecluso(cedula)!=null) {
                throw new Exception("Cedula Repetida");
            }
        }
        public List<Object> ListarCargos(string codigoExpediente)
        {
            List<Cargo> cargos = datosRecluso.ConsultarCargos(codigoExpediente);

            if (cargos.Count <= 0)
                throw new GeneralExcepcion("No se encontraron cargos registrados");
            else
                return GetListaDatosCargos(cargos);
        }
        public List<Object> GetListaDatosCargos(List<Cargo> cargos)
        {
            List<Object> cargosDatos = new List<object>();
            foreach (Cargo cargo in cargos)
            {
                cargosDatos.Add(ConvertirAnonimo(cargo));
            }
            return cargosDatos;
        }
        public Object ConvertirAnonimo(Cargo cargo)
        {
            return new
            {
                delito = cargo.Delito,
                descripcion = cargo.Descripcion,
                fecha = cargo.FechaHechos,
                localidad = cargo.LugarHechos.NombreLocalidad,
                ciudad = cargo.LugarHechos.NombreCiudad,
                pais = cargo.LugarHechos.NombrePais
            };
        }

        
    }
}
