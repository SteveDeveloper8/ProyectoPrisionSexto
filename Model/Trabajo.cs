using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Trabajo : ActividadPractica
    {
        public Trabajo(int id, string nombre, string descripcion) : base(id, nombre, descripcion)
        {
        }
    }
}
