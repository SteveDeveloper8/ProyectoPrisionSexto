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
        private int remisionTotal;

        public ActividadCurricular(int cupos, string descripcion,int remisionTotal, DateTime fechaInicio, DateTime fechaFin): base(cupos,descripcion)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.remisionTotal = remisionTotal;
        }

        public ActividadCurricular(int id, int cupos, string descripcion, int remisionTotal, DateTime fechaInicio, DateTime fechaFin) : base(cupos, descripcion)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.remisionTotal = remisionTotal;
        }

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
    }
}
