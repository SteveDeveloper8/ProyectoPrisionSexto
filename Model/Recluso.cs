using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Recluso : Persona
    {
        private string codigo;
        private Expediente expediente;

        public Expediente Expediente { get => expediente; set => expediente = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        public Recluso(string nombre, string apellidos, string genero, DateTime fecha, string cedula, string codigo, Expediente expediente) : base(codigo, nombre, apellidos, genero, fecha,cedula)
        {
            this.expediente = expediente;
            this.codigo = codigo;
        }

        public Recluso()
        {

        }

        public Recluso(int id, string nombre, string apellidos, string genero, DateTime fecha, string cedula, string codigo, Expediente expediente) : base(id, codigo, nombre, apellidos, genero, fecha,cedula)
        {
            this.expediente = expediente;
        }

        
    }
}
