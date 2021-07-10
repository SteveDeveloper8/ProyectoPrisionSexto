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
        private int condenaDias;

        public Cargo(string descripcion, int condenaDias)
        {
            this.descripcion = descripcion;
            this.condenaDias = condenaDias;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CondenaDias { get => condenaDias; set => condenaDias = value; }
    }
}
