using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class ActividadPractica : Actividad
    {
        public ActividadPractica(int id, string nombre, string descripcion) : base(id, nombre, descripcion)
        {
        }
    }
}
