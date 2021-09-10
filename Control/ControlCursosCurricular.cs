﻿using Data;
using Data.Excepciones;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    /// <summary>
    /// Controlador que gestiona la información de <seealso cref="ActividadCurricular"/>.
    /// </summary>
    public class ControlCursosCurricular
    {
        /// <summary>
        /// Atributo tipo <see cref="DatosCursoCurricular"/> que permite el acceso a la capa de Datos.
        /// </summary>
        DatosCursoCurricular datosCurso = new DatosCursoCurricular();
        /// <summary>
        /// Instancia de <see cref="ActividadCurricular"/> sirve como auxiliar para los métodos de control.
        /// </summary>
        ActividadCurricular curricular =null;

        ///<summary>
        ///Metodo que se encarga de consultar cursos existentes.
        ///</summary>
        ///<return>Retorna una lista de cursos </return>
        public List<object> ListarCursosDistancia()
        {
            List<ActividadCurricular> cursos = datosCurso.ConsultarCursosDistancia();
            if (cursos.Count <= 0)
                throw new GeneralExcepcion("No se encontraron reclusos registrados");
            else
                return GetListaDatosCursos(cursos);
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
            return ConvertirAnonimo(curricular);
        }

        ///<summary>
        ///Metodo que se encarga de eliminar un curso especifico
        ///</summary>
        ///<param name= "estudioDelete"> Nombre del curso </param>
        public bool EliminarEstudio(string Descripcion, string modalidad)
        {
            try
            {
                datosCurso.EliminarEstudio(Descripcion, modalidad);
                return true;
            }
            catch(ConsultaFallida)
            {
                return false;
            }
        }

        ///<summary>
        ///Metodo que se encarga de buscar cursos a partir de una descripcion.
        ///</summary>
        ///<param name= "descripcion"> Descripcion del curso </param>
        ///<return>Retorna una lista de cursos </return>
        public List<Object> FiltrarDesccripcion(string descripcion)
        {
            List<ActividadCurricular> CursosCurriculares= datosCurso.BuscarDescripcionEstudio(descripcion);
            if (CursosCurriculares == null)
            {
                throw new GeneralExcepcion("Curso no existe con esa descripcion");
            }
            return GetListaDatosCursos(CursosCurriculares);
        }
        /// <summary>
        /// Convierte una lista de objetos <seealso cref="ActividadCurricular"/> en una lista de objetos anónimos(<seealso cref="Object"/>) que la capa de vista pueda entender.
        /// </summary>
        /// <param name="actividades">Lista de actividades a convertir.</param>
        /// <returns>Una lista de objetos anónimos(<seealso cref="Object"/>).</returns>
        private List<Object> GetListaDatosCursos(List<ActividadCurricular> actividades)
        {
            List<Object> cargosDatos = new List<object>();
            foreach (ActividadCurricular curso in actividades)
            {
                cargosDatos.Add(ConvertirAnonimo(curso));
            }
            return cargosDatos;
        }
        /// <summary>
        /// Convierte un objeto <seealso cref="ActividadCurricular"/> en un objeto anónimo(<seealso cref="Object"/>) que la capa de Vista puede entender.
        /// </summary>
        /// <param name="curso">Curso a convertir.</param>
        /// <returns>Un <seealso cref="Object"/> con los datos del <paramref name="curso"/>.</returns>
        private Object ConvertirAnonimo(ActividadCurricular curso)
        {
            return new
            {
                cupos = curso.Cupos,
                descripcion = curso.Descripcion,
                modalidad=curso.Modalidad,
                remisionTotal=curso.RemisionTotal,
                fechaInicio=curso.FechaInicio,
                fechaFin = curso.FechaFin
            };
        }
        ///<summary>
        ///Metodo que se encarga de buscar cursos a partir de su modalidad.
        ///</summary>
        ///<param name= "modalidad"> Modalidad del curso. </param>
        ///<return>Retorna una lista de cursos. </return>
        public List<Object> FiltrarModalidad(string modalidad)
        {
            List<ActividadCurricular> CursosCurriculares = datosCurso.BuscarModalidadEstudio(modalidad);
            if (CursosCurriculares == null)
            {
                throw new GeneralExcepcion("No existen cursos con dicha modalidad");
            }
            return GetListaDatosCursos(CursosCurriculares);
        }


        ///<summary>
        ///Metodo que se encarga de buscar cursos a partir de su descripcion y modalidad.
        ///</summary>
        ///<param name= "descripcion"> Descripcion del curso. </param>
        ///<param name= "modalidad"> Modalidad del curso. </param>
        ///<return>Retorna una lista de cursos. </return>
        public List<Object> FiltrarDescripcionModalidad(string descripcion, string modalidad)
        {
            List<ActividadCurricular> CursosCurriculares = datosCurso.BuscarDescripcionModalidadEstudio(descripcion,modalidad);
            if (CursosCurriculares == null)
            {
                throw new GeneralExcepcion("Curso no existe");
            }
            return GetListaDatosCursos(CursosCurriculares);
        }
    }
}
