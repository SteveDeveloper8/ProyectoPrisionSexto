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
        private string codigo;
        private List<Cargo> cargos;
        private int condenaTotalDias;

        public Expediente(int id, string codigo, List<Cargo> cargos, int condenaTotalDias)
        {
            this.id = id;
            this.codigo = codigo;
            this.cargos = cargos;
            this.condenaTotalDias = condenaTotalDias;
        }
        public Expediente(int id, string codigo)
        {
            this.id = id;
            this.codigo = codigo;
        }
        public Expediente()
        {

        }

        public string Codigo { get => codigo; set => codigo = value; }
        public List<Cargo> Cargos { get => cargos; set => cargos = value; }
        public int CondenaTotalDias { get => condenaTotalDias; set => condenaTotalDias = value; }
        public int Id { get => id; set => id = value; }
    }
}
