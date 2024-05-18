<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoDeSucursales.aspx.cs" Inherits="TP5_GRUPO_1.ListadoDeSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 44px;
        }
        .auto-style3 {
            font-size: x-large;
            width: 224px;
        }
        .auto-style4 {
            width: 224px;
        }
        .auto-style5 {
            width: 227px;
        }
        .auto-style6 {
            width: 121px;
        }
        .auto-style7 {
            width: 68px;
        }
        .auto-style8 {
            width: 40px;
        }
        .auto-style9 {
            width: 168px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:HyperLink ID="hlAgregarSucursal2" runat="server" NavigateUrl="~/AgregarSucursal.aspx">AgregarSucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style5">
                        <asp:HyperLink ID="hlListadoSucursales2" runat="server" NavigateUrl="~/ListadoDeSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style6">
                        <asp:HyperLink ID="hlEliminarSucursal2" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3" colspan="2"><strong>Listado de Sucursales</strong></td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="2">Búsqueda Ingrese Id sucursal:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtBuscarSucursal" runat="server" ValidationGroup="Grupo1" Width="220px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Flitrar" ValidationGroup="Grupo1" />
                    </td>
                    <td>
                        <asp:Button ID="btnMostrarTodos" runat="server" OnClick="btnMostrarTodos_Click" Text="Mostrar todos" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="2">&nbsp;</td>
                    <td colspan="5">
                        <asp:RequiredFieldValidator ID="rfvIdSucursal" runat="server" ControlToValidate="txtBuscarSucursal" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="Grupo1">Ingrese un Id de sucursal.</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revIdSucursal" runat="server" ControlToValidate="txtBuscarSucursal" ForeColor="Red" ValidationExpression="^[0-9]*$" ValidationGroup="Grupo1">Ingresar solo numeros.</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="7">
                        <asp:GridView ID="gvSucursales" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
