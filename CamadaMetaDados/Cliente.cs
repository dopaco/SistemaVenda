using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaMetaDados
{
    public class Cliente
    {
        public int ID                   { get; set; }
        public string Nome              { get; set; }
        public String DataCadastro    { get; set; }
        public string CNPJ              { get; set; }

        public Cliente()
        {
            this.ID             = int.MaxValue;
            this.Nome           = string.Empty;
            this.DataCadastro   = string.Empty;
            this.CNPJ           = string.Empty;
        }

    }
}
