using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class ActividadCurricular : Actividad
    {
        public ActividadCurricular(int id, string nombre, string descripcion) : base(id, nombre, descripcion)
        {
        }
    }
}
