using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class ActividadPractica : Actividad
    {
        private int remisionDiaria;
        public ActividadPractica(int cupos, string descripcion, int remisionDiaria) : base(cupos, descripcion)
        {
            this.remisionDiaria = remisionDiaria;
        }

        public ActividadPractica(int id, int cupos, string descripcion, int remisionDiaria) : base(id, cupos, descripcion)
        {
            this.remisionDiaria = remisionDiaria;
        }

        public int RemisionDiaria { get => remisionDiaria; set => remisionDiaria = value; }
    }
}
