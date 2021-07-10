using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Expediente
    {
        private int id;
        private int codigo;
        private string cedula_recluso;
        private List<string> historialDelictivo;
        private List<Cargo> cargos;
        private int condenaTotalDias;

        public Expediente(int codigo, List<string> historialDelictivo, List<Cargo> cargos)
        {
            this.codigo = codigo;
            this.historialDelictivo = historialDelictivo;
            this.cargos = cargos;
        }
        public Expediente()
        {

        }

        public int Codigo { get => codigo; set => codigo = value; }
        public List<string> HistorialDelictivo { get => historialDelictivo; set => historialDelictivo = value; }
        public List<Cargo> Cargos { get => cargos; set => cargos = value; }
        public int CondenaTotalDias { get => condenaTotalDias; set => condenaTotalDias = value; }
        public int Id { get => id; set => id = value; }
        public string Cedula_recluso { get => cedula_recluso; set => cedula_recluso = value; }
    }
}
