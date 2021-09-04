using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class ControlCursos
    {
        DatosCurso datosCurso = new DatosCurso();
        ActividadCurricular curricular =null;
        public void GuardarEstudio(int cupos, string descripcion, int remision, DateTime fechaInicio, DateTime fechaFin)
        {
            curricular = new ActividadCurricular(cupos, descripcion, remision, fechaInicio, fechaFin);
            datosCurso.InsertarEstudio(curricular);
        }

        public void EliminarEstudio(string estudioDelete)
        {
            datosCurso.EliminarEstudio(estudioDelete);
        }

        public Object FiltrarDesccripcion(string descripcion)
        {

            /*Object distancia= datosCurso.BuscarDescripcionEstudio(descripcion);

            if (distancia == null)
            {
                throw new GeneralExcepcion("Curso no existe");
            }

            return distancia;*/
            return null;
        }
    }
}
