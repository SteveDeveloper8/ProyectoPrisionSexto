using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class ControlActividadPractica
    {

        DatosActividadPractica datosActividad = new DatosActividadPractica();
        ActividadPractica actividad = null;

        ///<summary>
        ///Metodo que se encarga de consultar actividades existentes.
        ///</summary>
        ///<return>Retorna una lista de actividades</return>
        public List<object> ListarActividadesPracticas()
        {
            List<Object> actividades = datosActividad.ConsultarActvidadPractica();

            if (actividades.Count <= 0)
                throw new GeneralExcepcion("No se encontraron actividades registrados");
            else
                return actividades;
        }

        ///<summary>
        ///Metodo que se encarga de guardar la actividad.
        ///</summary>
        ///<param name= "cupos"> Numero de cupos </param>
        ///<param name= "descripcion"> descripcion del curso </param>
        ///<param name= "remision"> Numero de dias de remision de condena </param>
        ///<param name= "fechaInicio"> Fecha de inicio del curso </param>
        ///<param name= "fechaFin"> Fecha de fin del curso</param>
        public Object GuardarActividadPractica(int cupos, string descripcion, int remision, string modalidad)
        {
            actividad = new ActividadPractica(cupos, descripcion, modalidad, remision);
            datosActividad.InsertarActividad(actividad);
            return actividad;
        }

        ///<summary>
        ///Metodo que se encarga de eliminar una actividad especifico
        ///</summary>
        ///<param name= "estudioDelete"> Nombre de la actividad </param>
        public void EliminarActividad(string ActividadDelete, string modalidad)
        {
            datosActividad.EliminarActividad(ActividadDelete, modalidad);
        }


        ///<summary>
        ///Metodo que se encarga de buscar actividades a partir de una descripcion.
        ///</summary>
        ///<param name= "descripcion"> Descripcion de la actividad </param>
        //////<return>Retorna una lista de actividades </return>
        public List<Object> FiltrarDesccripcion(string descripcion)
        {
            List<Object> ActividadPractica = datosActividad.BuscarDescripcionActividad(descripcion);
            if (ActividadPractica == null)
            {
                throw new GeneralExcepcion("Actividad no existe con esa descripcion");
            }
            return ActividadPractica;
        }


        ///<summary>
        ///Metodo que se encarga de buscar actividades a partir de su modalidad.
        ///</summary>
        ///<param name= "modalidad"> Modalidad de la actividad </param>
        ///<return>Retorna una lista de actividades </return>
        public List<Object> FiltrarModalidad(string modalidad)
        {
            List<Object> ActividadPractica = datosActividad.BuscarModalidadActividad(modalidad);
            if (ActividadPractica == null)
            {
                throw new GeneralExcepcion("No existen actividades con dicha modalidad");
            }
            return ActividadPractica;
        }

        ///<summary>
        ///Metodo que se encarga de buscar actividades a partir de su descripcion y modalidad.
        ///</summary>
        ///<param name= "descripcion"> Descripcion de la actividad </param>
        ///<param name= "modalidad"> Modalidad de la actividad </param>
        ///<return>Retorna una lista de actividades </return>
        public List<object> FiltrarDescripcionModalidad(string descripcion, string modalidad)
        {
            List<Object> ActividadPractica = datosActividad.BuscarDescripcionModalidadActividad(descripcion, modalidad);
            if (ActividadPractica == null)
            {
                throw new GeneralExcepcion("Actividad no existe");
            }
            return ActividadPractica;
        }

   
    }
}
