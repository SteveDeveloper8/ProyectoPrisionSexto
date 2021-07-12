using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Inscripcion
    {
        private int id;
        private Recluso recluso;
        private Actividad actividad;
        private DateTime fecha;
        private int codigoInscripcion;

        public Inscripcion()
        {
        }

        public Inscripcion(int id, Recluso recluso, Actividad actividad, DateTime fecha, int codigoInscripcion)
        {
            this.id = id;
            this.recluso = recluso;
            this.actividad = actividad;
            this.fecha = fecha;
            this.codigoInscripcion = codigoInscripcion;
        }

        public int Id { get => id; set => id = value; }
        public Recluso Recluso { get => recluso; set => recluso = value; }
        public Actividad Actividad { get => actividad; set => actividad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int CodigoInscripcion { get => codigoInscripcion; set => codigoInscripcion = value; }
    }
}
