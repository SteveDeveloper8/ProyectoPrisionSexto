using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rol
    {
        private int id;
        private string descripcion;

        public Rol(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public Rol()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
