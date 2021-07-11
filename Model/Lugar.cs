using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lugar
    {
        private string nombreLocalidad;
        private string nombreCiudad;
        private string nombrePais;

        public string NombreLocalidad { get => nombreLocalidad; set => nombreLocalidad = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }
        public string NombrePais { get => nombrePais; set => nombrePais = value; }
    }
}
