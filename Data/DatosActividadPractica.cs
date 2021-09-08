using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public class DatosActividadPractica
    {
        public void InsertarActividad(ActividadPractica actividad)
        {
            List<Object> actividades = new List<Object>();
            ActividadPractica actividad1 = new ActividadPractica(50, "Coser balones", "Taller", 50);
            ActividadPractica actividad2 = new ActividadPractica(50, "Limpiar calles", "Trabajo", 50);
            actividades.Add(actividad1);
            actividades.Add(actividad2);
 

        }

        public void EliminarActividad(string actividadDelete, string modalidad)
        {
           
        }

        public List<object> ConsultarActvidadPractica()
        {
            List<Object> actividades = new List<Object>();
            ActividadPractica actividad1 = new ActividadPractica(50, "Coser balones", "Taller", 50);
            ActividadPractica actividad2 = new ActividadPractica(50, "Limpiar calles", "Trabajo", 50);
            actividades.Add(actividad1);
            actividades.Add(actividad2);
            return actividades;
        }

        public List<object> BuscarDescripcionActividad(string descripcion)
        {
            List<Object> actividades = new List<Object>();
            ActividadPractica actividad1 = new ActividadPractica(50, "Coser balones", "Taller", 50);
            ActividadPractica actividad2 = new ActividadPractica(50, "Limpiar calles", "Trabajo", 50);
            actividades.Add(actividad1);
            actividades.Add(actividad2);
            return actividades;
        }

        public List<object> BuscarModalidadActividad(string modalidad)
        {
            List<Object> actividades = new List<Object>();
            ActividadPractica actividad1 = new ActividadPractica(50, "Coser balones", "Taller", 50);
            ActividadPractica actividad2 = new ActividadPractica(50, "Limpiar calles", "Trabajo", 50);
            actividades.Add(actividad1);
            actividades.Add(actividad2);
            return actividades;
        }

        public List<object> BuscarDescripcionModalidadActividad(string descripcion, string modalidad)
        {
            List<Object> actividades = new List<Object>();
            ActividadPractica actividad1 = new ActividadPractica(50, "Coser balones", "Taller", 50);
            ActividadPractica actividad2 = new ActividadPractica(50, "Limpiar calles", "Trabajo", 50);
            actividades.Add(actividad1);
            actividades.Add(actividad2);
            return actividades;
        }
    }
}
