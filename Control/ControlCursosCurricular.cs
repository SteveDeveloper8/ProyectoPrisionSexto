using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class ControlCursosCurricular
    {
        DatosCursoCurricular datosCurso = new DatosCursoCurricular();
        ActividadCurricular curricular =null;

        ///<summary>
        ///Metodo que se encarga de consultar cursos existentes.
        ///</summary>
        ///<return>Retorna una lista de cursos </return>
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
        ///<return>Retorna una actividad Curricular </return>
        public Object GuardarEstudio(int cupos, string descripcion, int remision, DateTime fechaInicio, DateTime fechaFin, string modalidad)
        {
            curricular = new ActividadCurricular(cupos, descripcion,modalidad, remision, fechaInicio, fechaFin);
            datosCurso.InsertarEstudio(curricular);
            return curricular;
        }

        ///<summary>
        ///Metodo que se encarga de eliminar un curso especifico
        ///</summary>
        ///<param name= "estudioDelete"> Nombre del curso </param>
        public void EliminarEstudio(string estudioDelete, string modalidad)
        {
            datosCurso.EliminarEstudio(estudioDelete,modalidad);
        }

        ///<summary>
        ///Metodo que se encarga de buscar cursos a partir de una descripcion.
        ///</summary>
        ///<param name= "descripcion"> Descripcion del curso </param>
        //////<return>Retorna una lista de cursos </return>
        public List<Object> FiltrarDesccripcion(string descripcion)
        {
            List<Object> CursosCurriculares= datosCurso.BuscarDescripcionEstudio(descripcion);
            if (CursosCurriculares == null)
            {
                throw new GeneralExcepcion("Curso no existe con esa descripcion");
            }
            return CursosCurriculares;
        }

        ///<summary>
        ///Metodo que se encarga de buscar cursos a partir de su modalidad.
        ///</summary>
        ///<param name= "modalidad"> Modalidad del curso </param>
        ///<return>Retorna una lista de cursos </return>
        public List<Object> FiltrarModalidad(string modalidad)
        {
            List<Object> CursosCurriculares = datosCurso.BuscarModalidadEstudio(modalidad);
            if (CursosCurriculares == null)
            {
                throw new GeneralExcepcion("No existen cursos con dicha modalidad");
            }
            return CursosCurriculares;
        }


        ///<summary>
        ///Metodo que se encarga de buscar cursos a partir de su descripcion y modalidad.
        ///</summary>
        ///<param name= "descripcion"> Descripcion del curso </param>
        ///<param name= "modalidad"> Modalidad del curso </param>
        ///<return>Retorna una lista de cursos </return>
        public List<object> FiltrarDescripcionModalidad(string descripcion, string modalidad)
        {
            List<Object> CursosCurriculares = datosCurso.BuscarDescripcionModalidadEstudio(descripcion,modalidad);
            if (CursosCurriculares == null)
            {
                throw new GeneralExcepcion("Curso no existe");
            }
            return CursosCurriculares;
        }
    }
}
