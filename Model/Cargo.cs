using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cargo
    {
        private string descripcion;
        private string delito;
        private int id;
        private Lugar lugarHechos;
        private DateTime fechaHechos;
        public Cargo(string descripcion, string delito, int id, Lugar lugarHechos, DateTime fechaHechos)
        {
            this.descripcion = descripcion;
            this.delito = delito;
            this.id = id;
            this.lugarHechos = lugarHechos;
            this.fechaHechos = fechaHechos;
        }
        public Cargo() { }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Delito { get => delito; set => delito = value; }
        public int Id { get => id; set => id = value; }
        public Lugar LugarHechos { get => lugarHechos; set => lugarHechos = value; }
        public DateTime FechaHechos { get => fechaHechos; set => fechaHechos = value; }
    }
}
