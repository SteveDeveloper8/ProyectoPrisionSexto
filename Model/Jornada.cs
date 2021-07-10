using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jornada
    {
        private string dia;
        private DateTime horaInicio;
        private DateTime horaFin;

        public Jornada(string dia, DateTime horaInicio, DateTime horaFin)
        {
            this.dia = dia;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }

        public string Dia { get => dia; set => dia = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
    }
}
