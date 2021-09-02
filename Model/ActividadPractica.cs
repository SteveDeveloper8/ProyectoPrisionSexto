using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class ActividadPractica : Actividad
    {
        public ActividadPractica(int cupos, string descripcion, int remisionCondena) : base(cupos, descripcion, remisionCondena)
        {
            
        }

        public ActividadPractica(int id, int cupos, string descripcion, int remisionCondena) : base(id, cupos, descripcion, remisionCondena)
        {
           
        }
    }
}
