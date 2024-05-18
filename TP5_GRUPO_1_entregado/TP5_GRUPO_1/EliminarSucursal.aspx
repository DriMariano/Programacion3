<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP5_GRUPO_1.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1209px;
        }
        .auto-style17 {
            width: 201px;
        }
        .auto-style18 {
            width: 202px;
        }
        .auto-style19 {
            width: 100%;
        }
        .auto-style20 {
            width: 76px;
        }
        .auto-style21 {
            width: 244px;
        }
        .auto-style23 {
            width: 264px;
        }
        .auto-style24 {
            width: 197px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">
                <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
            </td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">
                <asp:HyperLink ID="hlListarSucursal" runat="server" NavigateUrl="~/ListarSucursal.aspx">Listado de Sucursales</asp:HyperLink>
            </td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style18">
                <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
        </tr>
    </table>
</div>
    <table class="auto-style19">
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style21"><strong><big>Eliminar Sucursal</big></strong></td>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style23">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style23">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style21">Ingresar ID Sucursal:</td>
            <td class="auto-style24">
                <asp:TextBox ID="txtIdSucursal" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style23">
                <asp:RegularExpressionValidator ID="revIdSucursal" runat="server" ControlToValidate="txtIDSucursal" ValidationExpression="^[0-9]*$" ForeColor="Red">Ingresar solo numeros positivos.</asp:RegularExpressionValidator>
            </td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style23">
                <asp:RequiredFieldValidator ID="rgvIdSucursal" runat="server" ControlToValidate="txtIDSucursal" ForeColor="Red">Debe ingresar una Id .</asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style24">
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td class="auto-style23">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>
