using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Excepciones
{
    public class ConsultaFallida:Exception
    {
        string mensaje;
        public ConsultaFallida()
        {
            this.mensaje = "La consulta a la base de datos falló y por ende no devolvió lso resultados esperados.";
        }

        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
