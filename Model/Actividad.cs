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

    

        public int Id { get => id; set => id = value; }
        public int Cupos { get => cupos; set => cupos = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
       

        public Actividad(int id, int cupos, string descripcion)
        {
            this.cupos = cupos;
            this.descripcion = descripcion;
           
        }

        public  Actividad(int cupos, string descripcion)
        {
            this.cupos = cupos;
            this.descripcion = descripcion;
        }




    }
}
