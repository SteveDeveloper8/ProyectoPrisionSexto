using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Excepciones
{
    public class ConexionFallida : Exception
    {
        string mensaje;
        public ConexionFallida(string mensaje)
        {
            this.mensaje = mensaje;
        }

        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
