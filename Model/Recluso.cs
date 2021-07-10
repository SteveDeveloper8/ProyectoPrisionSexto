using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Recluso : Persona
    {
        private int expediente;

        public Recluso(string codigo, string nombre, string apellidos, string genero, DateTime fecha, string cedula, int expediente) : base(codigo, nombre, apellidos, genero, fecha,cedula)
        {
            this.expediente = expediente;
        }

        public Recluso(int id, string codigo, string nombre, string apellidos, string genero, DateTime fecha, string cedula,int expediente) : base(id, codigo, nombre, apellidos, genero, fecha,cedula)
        {
            this.expediente = expediente;
        }

        public int Expediente { get => expediente; set => expediente = value; }
    }
}
