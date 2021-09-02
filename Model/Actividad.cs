using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Actividad
    {
        private int id;
        private int cupos;
        private string descripcion;
        private int remisionCondena;

        public int Id { get => id; set => id = value; }
        public int Cupos { get => cupos; set => cupos = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int RemisionCondena { get => remisionCondena; set => remisionCondena = value; }

        public Actividad(int id, int cupos, string descripcion, int remisionCondena)
        {
            this.cupos = cupos;
            this.descripcion = descripcion;
            this.remisionCondena = remisionCondena;
        }

        public  Actividad(int cupos, string descripcion, int remisionCondena)
        {
            this.cupos = cupos;
            this.descripcion = descripcion;
            this.remisionCondena = remisionCondena;
        }




    }
}
