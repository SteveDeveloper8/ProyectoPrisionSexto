using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class GrupoActividad
    {
        private List<Recluso> reclusos;
        private Horario horario;
        private Actividad actividad;

        protected GrupoActividad(List<Recluso> reclusos, Horario horario, Actividad actividad)
        {
            this.reclusos = reclusos;
            this.horario = horario;
            this.actividad = actividad;
        }

        public List<Recluso> Reclusos { get => reclusos; set => reclusos = value; }
        public Horario Horario { get => horario; set => horario = value; }
        public Actividad Actividad { get => actividad; set => actividad = value; }
    }
}
