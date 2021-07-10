using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Curso: GrupoActividad
    {
        private int totalDiasRedencion;
        private int diasDuracion;

        public Curso(List<Recluso> reclusos, Horario horario, Actividad actividad, int totalDiasRedencion, int diasDuracion) : base(reclusos, horario, actividad)
        {
            this.totalDiasRedencion = totalDiasRedencion;
            this.diasDuracion = diasDuracion;
        }

        public int TotalDiasRedencion { get => totalDiasRedencion; set => totalDiasRedencion = value; }
        public int DiasDuracion { get => diasDuracion; set => diasDuracion = value; }
    }
}
