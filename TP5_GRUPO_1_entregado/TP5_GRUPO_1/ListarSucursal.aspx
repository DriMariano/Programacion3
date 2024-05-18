<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarSucursal.aspx.cs" Inherits="TP5_GRUPO_1.ListarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1207px;
            height: 96px;
        }
        .auto-style33 {
            height: 19px;
            width: 25px;
        }
        .auto-style34 {
            width: 137px;
            height: 19px;
        }
        .auto-style35 {
            height: 19px;
            width: 30px;
        }
        .auto-style36 {
            width: 200px;
            height: 19px;
        }
        .auto-style37 {
            height: 19px;
            width: 10px;
        }
        .auto-style38 {
            width: 147px;
            height: 19px;
        }
        .auto-style39 {
            width: 100%;
        }
        .auto-style40 {
            width: 70px;
        }
        .auto-style41 {
            width: 70px;
            height: 26px;
        }
        .auto-style43 {
            width: 328px;
        }
        .auto-style44 {
            height: 26px;
            width: 328px;
        }
        .auto-style45 {
            width: 265px;
        }
        .auto-style46 {
            height: 26px;
            width: 265px;
        }
        .auto-style47 {
            width: 357px;
        }
        .auto-style48 {
            height: 26px;
            width: 357px;
        }
        .auto-style49 {
            width: 173px;
        }
        .auto-style50 {
            height: 26px;
            width: 173px;
        }
        .auto-style51 {
            width: 82px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style33"></td>
            <td class="auto-style34">
                <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
            </td>
            <td class="auto-style35"></td>
            <td class="auto-style36">
                <asp:HyperLink ID="hlListarSucursal" runat="server" NavigateUrl="~/ListarSucursal.aspx">Listado de Sucursales</asp:HyperLink>
            </td>
            <td class="auto-style37"></td>
            <td class="auto-style38">
                <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
            </td>
        </tr>
        </table>
</div>
    <table class="auto-style39">
        <tr>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43"><strong><big>Listado de Sucursales</big></strong></td>
            <td class="auto-style45">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td class="auto-style47">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style45">&nbsp;</td>
            <td class="auto-style49">&nbsp;</td>
            <td class="auto-style47">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43"><strong>Busqueda </strong>ingrese Id Sucursal</td>
            <td class="auto-style45">
                <asp:TextBox ID="txtIDSucursal" runat="server" ></asp:TextBox>
            </td>
            <td class="auto-style49">
                <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
            </td>
            <td class="auto-style47">
                <asp:Button ID="btnMostrarTodos" runat="server" Text="Mostrar Todos" OnClick="btnMostrarTodos_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style43">&nbsp;</td>
            <td class="auto-style45">
                <asp:RequiredFieldValidator ID="rgvIdSucursal" runat="server" ControlToValidate="txtIDSucursal" ForeColor="Red">Debe ingrasar una Id .</asp:RequiredFieldValidator>
            </td>
            <td class="auto-style49">&nbsp;</td>
            <td class="auto-style47">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style41"></td>
            <td class="auto-style44"></td>
            <td class="auto-style46">
                <asp:RegularExpressionValidator ID="revIdSucursal" runat="server" ControlToValidate="txtIDSucursal" ValidationExpression="^[0-9]*$" ForeColor="Red">Ingresar solo numeros positivos.</asp:RegularExpressionValidator>
            </td>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style48"></td>
        </tr>
        </table>
        <table class="auto-style39">
            <tr>
                <td class="auto-style51">&nbsp;</td>
                <td>
                    <asp:GridView ID="gvSucursales" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style51">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    </body>
</html>
