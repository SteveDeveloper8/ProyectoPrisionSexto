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
        private string modalidad;

        public int Id { get => id; set => id = value; }
        public int Cupos { get => cupos; set => cupos = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Modalidad { get => modalidad; set => modalidad = value; }

        public Actividad(int id, int cupos, string descripcion,string modalidad)
        {
            this.cupos = cupos;
            this.descripcion = descripcion;
            this.modalidad = modalidad;
           
        }

        public  Actividad(int cupos, string descripcion,string modalidad)
        {
            this.cupos = cupos;
            this.descripcion = descripcion;
            this.modalidad = modalidad;
        }
        public Actividad() { }



    }
}
