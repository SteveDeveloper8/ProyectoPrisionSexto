using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Persona
    {
        private int id;
        private string nombre;
        private string apellidos;
        private string genero;
        private DateTime fecha;
        private string cedula;

        public Persona(string codigo, string nombre, string apellidos, string genero, DateTime fecha,string cedula)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.genero = genero;
            this.fecha = fecha;
            this.cedula = cedula;
        }

        public Persona() { }

        public Persona(int id,string codigo, string nombre, string apellidos, string genero, DateTime fecha,string cedula)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.genero = genero;
            this.fecha = fecha;
            this.cedula = cedula;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id { get => id; set => id = value; }
        public string Cedula { get => cedula; set => cedula = value; }
    }
}
