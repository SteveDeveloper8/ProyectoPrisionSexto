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

        public List<object> ListarCursosDistancia()
        {
            List<Object> cursos = datosCurso.ConsultarCursosDistancia();

            if (cursos.Count <= 0)
                throw new GeneralExcepcion("No se encontraron reclusos registrados");
            else
                return cursos;
        }

        ///<summary>
        ///Metodo que se encarga de guardar el curso.
        ///</summary>
        ///<param name= "cupos"> Numero de cupos </param>
        ///<param name= "descripcion"> descripcion del curso </param>
        ///<param name= "remision"> Numero de dias de remision de condena </param>
        ///<param name= "fechaInicio"> Fecha de inicio del curso </param>
        ///<param name= "fechaFin"> Fecha de fin del curso</param>
        public void GuardarEstudio(int cupos, string descripcion, int remision, DateTime fechaInicio, DateTime fechaFin, string modalidad)
        {
            curricular = new ActividadCurricular(cupos, descripcion, remision, fechaInicio, fechaFin);
            datosCurso.InsertarEstudio(curricular,modalidad);
        }

        ///<summary>
        ///Metodo que se encarga de eliminar un curso especifico
        ///</summary>
        ///<param name= "estudioDelete"> Nombre del curso </param>
        public void EliminarEstudio(string estudioDelete, string modalidad)
        {
            datosCurso.EliminarEstudio(estudioDelete,modalidad);
        }

        public Object FiltrarDesccripcion(string descripcion)
        {

            Object distancia= datosCurso.BuscarDescripcionEstudio(descripcion);

            if (distancia == null)
            {
                throw new GeneralExcepcion("Curso no existe");
            }

            return distancia;
        }

        public object FiltrarModalidad(object modalidad)
        {
            throw new NotImplementedException();
        }
    }
}
