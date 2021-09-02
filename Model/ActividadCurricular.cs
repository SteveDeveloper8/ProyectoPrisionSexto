using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ActividadCurricular : Actividad
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public ActividadCurricular(int cupos, string descripcion,int remisionCondena,DateTime fechaInicio, DateTime fechaFin): base(cupos,descripcion,remisionCondena)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        public  ActividadCurricular(int id,int cupos, string descripcion, int remisionCondena, DateTime fechaInicio, DateTime fechaFin) : base(id,cupos, descripcion, remisionCondena)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
    }
}
