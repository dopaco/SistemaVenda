using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CamadaDados.Interfaces
{
    public interface IConnect
    {
        bool conectar();
        bool desconectar();
        // Utilizado para fazer consulta de dados
        DataTable retornarTabela(string p_strSql, List<SqlParameter> p_obParams, string p_strnmTabelaRetorno);
        // Metod para Upadate Delete Inserte
        // Utilizado para fazer alateração de dados
        bool executarComando(string p_strSql, List<SqlParameter> p_obParams);

    }
}
