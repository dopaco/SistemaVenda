<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="CamadaInterfaceUsuario.CadastroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            height: 143px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table align ="Center" class="auto-style1">
            <tr>
                <td>
                    ID</td>
                <td>
                    <asp:TextBox ID="ID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>
                    Nome</td>
                <td>
                    <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>
                    Data Cadastro</td>
                <td>
                    <asp:TextBox ID="DataCadastro" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>
                    CNPJ</td>
                <td>
                    <asp:TextBox ID="CNPJ" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>
                    <asp:Label ID="IblMensagem" runat="server" ForeColor="Red" Text="Label"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
               <td>
                    <asp:Button ID="BTN_Incluir" runat="server" OnClick="BTN_Incluir_Click" Text="Incluir" />
                    <asp:Button ID="BTN_Consultar" runat="server" OnClick="BTN_Consultar_Clik" Text="Consultar" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>           
        </table>
    </form>
</body>
</html>
