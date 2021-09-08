using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ActividadPractica : Actividad
    {
        private int remisionDiaria;
        public ActividadPractica(int cupos, string descripcion,string modalidad, int remisionDiaria) : base(cupos, descripcion,modalidad)
        {
            this.remisionDiaria = remisionDiaria;
        }

        public ActividadPractica(int id, int cupos, string descripcion,string modalidad,int remisionDiaria) : base(id, cupos, descripcion,modalidad)
        {
            this.remisionDiaria = remisionDiaria;
        }
        public ActividadPractica() { }
        public int RemisionDiaria { get => remisionDiaria; set => remisionDiaria = value; }
    }
}
