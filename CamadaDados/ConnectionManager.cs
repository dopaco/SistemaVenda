using CamadaDados.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CamadaDados
{
    public class ConnectionManager : IConnect
    {
        private string strConnStr = @"Data Source=127.0.0.1;Initial Catalog=DB_VENDAS;User ID=sa;Password=Copado32";
        SqlConnection objConn = null;
        
        public bool conectar()
        {
            // Inicia objeto de conexão
            objConn = new SqlConnection(strConnStr);

            try
            {
                // Abre conexão
                objConn.Open();                
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool desconectar()
        {
            try
            {
                if (objConn.State != ConnectionState.Closed)
                {
                    // Fecha conexão
                    objConn.Close();
                    // Destroi objeto instanciado
                    objConn.Dispose();
                }
            }
            catch
            {
                return false;
            }

            return true;
                 
        }

        public DataTable retornarTabela(string p_strSql, List<SqlParameter> p_obParams, string p_strNmTabelaRetorno)
        {
            // Abro a conexão e testo ao mesmo tempo;
            if (!this.conectar())
            {
                return null;        
            }

            // Obejeto do comando do SQL. Classe que implementa o comando no SLQServer
            // p_strSQL = Comando em SQL
            // objConn = Objeto  conexao  
            SqlCommand objCmd = new SqlCommand(p_strSql, objConn);


            foreach (SqlParameter param in p_obParams)
            {
                objCmd.Parameters.Add(param);
            }

            SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
            DataSet ds = new DataSet();

            try
            {
                objAdp.Fill(ds, p_strNmTabelaRetorno);
            }
            catch
            {
                return null;
            }

            this.desconectar();
            return ds.Tables[p_strNmTabelaRetorno];

        }

        public bool executarComando(string p_strSql, List<SqlParameter> p_obParams)
        {
            bool blnResult = false;
            // Abro a conexão e testo ao mesmo tempo;
            if (!this.conectar())
            {
                return false;
            }


            // Obejeto do comando do SQL. Classe que implementa o comando no SLQServer
            // p_strSQL = Comando em SQL
            // objConn = Objeto  conexao 
            SqlCommand objCmd = new SqlCommand(p_strSql, objConn);

            foreach (SqlParameter param in p_obParams)
            {
                objCmd.Parameters.Add(param);
            }
            try
            {
                   blnResult  = (objCmd.ExecuteNonQuery() > 0 ? true : false);
            }
            catch
            {
                return false;
            }
            this.desconectar();
            return blnResult;

        }
    }
}
