using CamadaDados;
using CamadaMetaDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class NGCliente
    {
        public bool incluir(Cliente p_objCliente)
        {
            #region Validação de campos Obrigatorios
            if (p_objCliente.ID == int.MinValue)
            {
                throw new Exception("O campo ID é obrigatorio");
            }
            if (p_objCliente.Nome == string.Empty)
            {
                throw new Exception("O campo nome é obrigatorio");
            }
            if (p_objCliente.DataCadastro == string.Empty)
            {
                throw new Exception("O campo Data Cadastro é obrigatorio");
            }
            if (p_objCliente.CNPJ == string.Empty)
            {
                throw new Exception("O campo CNPJ é obrigatorio");
            }
            #endregion

            DBCliente objDados = new DBCliente();
            return objDados.incluir(p_objCliente);
        }

        public List<Cliente> Concultar(int p_intID)
        {
            DBCliente objDados = new DBCliente();
            return objDados.consultar(p_intID);
        }

    }
}
