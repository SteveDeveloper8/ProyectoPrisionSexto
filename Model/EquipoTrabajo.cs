using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EquipoTrabajo:GrupoActividad
    {
        private float razonDiariaRedencion;

        public EquipoTrabajo(List<Recluso> reclusos, Horario horario, Actividad actividad, float razonDiariaRedencion) : base(reclusos, horario, actividad)
        {
            this.razonDiariaRedencion = razonDiariaRedencion;
        }
    }
}
