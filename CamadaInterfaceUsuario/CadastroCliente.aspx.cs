using CamadaMetaDados;
using CamadaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CamadaInterfaceUsuario
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Incluir_Click(object sender, EventArgs e)
        {
            try
            {
                NGCliente objNegocios = new NGCliente();
                Cliente objCliente = new Cliente();

                objCliente.ID = int.Parse(ID.Text);
                objCliente.Nome = Nome.Text;
                objCliente.DataCadastro = DataCadastro.Text;
                objCliente.CNPJ = CNPJ.Text;

                IblMensagem.Text = (objNegocios.incluir(objCliente) ? "Registro incluido com sucesso" : "Erro na inclusão");

            }
            catch(Exception ex)
            {
                IblMensagem.Text = ex.Message;
            }
        }

        protected void BTN_Consultar_Clik(object sender, EventArgs e)
        {
            NGCliente objNegocios = new NGCliente();
            Cliente objCliente = new Cliente();

            try
            {
                objCliente.ID = int.Parse(ID.Text);

                List<Cliente> objRetConsulta = objNegocios.Concultar(objCliente.ID);

                if (objRetConsulta.Count > 0)
                {
                    Nome.Text = objRetConsulta[0].Nome;
                    DataCadastro.Text = objRetConsulta[0].DataCadastro;
                    CNPJ.Text = objRetConsulta[0].CNPJ;
                }
                else {
                    IblMensagem.Text = "Registro não encontrado";
                }

            }
            catch(Exception ex)
            {
                IblMensagem.Text = ex.Message;
            }
        }
    }
}