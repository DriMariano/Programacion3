<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP5_GRUPO_1.EliminarSucursal" %>

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
            width: 32px;
        }
        .auto-style3 {
            font-size: x-large;
            width: 196px;
        }
        .auto-style4 {
            width: 196px;
        }
        .auto-style5 {
            width: 138px;
        }
        .auto-style6 {
            width: 36px;
        }
        .auto-style7 {
            width: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:HyperLink ID="hlAgregarSucursal3" runat="server" NavigateUrl="~/AgregarSucursal.aspx">AgregarSucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="hlListadoSucursales3" runat="server" NavigateUrl="~/ListadoDeSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlEliminarSucursal3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3" colspan="3"><strong>Eliminar Sucursal</strong></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5" colspan="2">Ingrese Id sucursal:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtIdSucursalEliminar" runat="server" ValidationGroup="Grupo1" Width="240px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" ValidationGroup="Grupo1" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td colspan="3">
                        <asp:RequiredFieldValidator ID="rfvIdSucursal2" runat="server" ControlToValidate="txtIdSucursalEliminar" ForeColor="Red" ValidationGroup="Grupo1">Ingrese un Id de sucursal.</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revIdSucursal2" runat="server" ControlToValidate="txtIdSucursalEliminar" ForeColor="Red" ValidationExpression="^[0-9]*$" ValidationGroup="Grupo1">Ingresar solo numeros.</asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="3">
                        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
