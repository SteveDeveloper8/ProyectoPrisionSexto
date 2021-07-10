using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Horario
    {
        private List<Jornada> jornadas;

        public Horario(List<Jornada> jornadas)
        {
            this.jornadas = jornadas;
        }

        public List<Jornada> Jornadas { get => jornadas; set => jornadas = value; }
    }
}
