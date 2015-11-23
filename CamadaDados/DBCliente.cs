using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaMetaDados;
using System.Data.SqlClient;
using System.Data;

namespace CamadaDados
{
    public class DBCliente
    {
        private ConnectionManager objConnManager = new ConnectionManager();

        public bool incluir (Cliente p_objCliente)
        {
            bool blnRetorno = false;
            string strSql = "INSERT INTO Cliente (Id ,Nome, DataCadastro ,CNPJ) VALUES(@pID, @pNome, @pDataCadastro, @pCNPJ)";

            List<SqlParameter> objParams = new List<SqlParameter>();
            objParams.Add(new SqlParameter("@pID", p_objCliente.ID));
            objParams.Add(new SqlParameter("@pNome", p_objCliente.Nome));
            objParams.Add(new SqlParameter("@pDataCadastro", p_objCliente.DataCadastro));
            objParams.Add(new SqlParameter("@pCNPJ", p_objCliente.CNPJ));

            blnRetorno = objConnManager.executarComando(strSql, objParams);

            return blnRetorno;
        }

        public List<Cliente> consultar(int p_intID)
        {
            string strSql = "Select id, nome, DataCadastro, CNPJ from Cliente where id= @pID";

            List<SqlParameter> objParams = new List<SqlParameter>();
            objParams.Add(new SqlParameter("@pID", p_intID));

            DataTable objTbCliente = objConnManager.retornarTabela(strSql, objParams, "Cliente");

            List<Cliente> objClientes = new List<Cliente>();
            foreach (DataRow row in objTbCliente.Rows)
            {
                Cliente objCliente = new Cliente();
                objCliente.ID = (int)row["ID"];
                objCliente.Nome = (string)row["Nome"];
                objCliente.DataCadastro = (string)row["DataCadastro"];
                objCliente.CNPJ = (string)row["CNPJ"];

                objClientes.Add(objCliente);
            }

            return objClientes;
        }
    }
}
