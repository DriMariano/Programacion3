<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP4_GRUPO_1.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 136px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style8 {
            width: 115px;
        }
        .auto-style12 {
            width: 78px;
        }
        .auto-style13 {
            width: 95px;
        }
        .auto-style14 {
            width: 36px;
        }
        .auto-style15 {
            width: 78px;
            height: 23px;
        }
        .auto-style16 {
            width: 95px;
            height: 23px;
        }
        .auto-style17 {
            width: 36px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style15"></td>
                    <td class="auto-style16"></td>
                    <td class="auto-style17"></td>
                    <td colspan="3" class="auto-style5"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13">Id Producto:</td>
                    <td class="auto-style14">
                        <asp:DropDownList ID="ddlProducto" runat="server" AutoPostBack="True">
                            <asp:ListItem Value="Igual a">Igual a:</asp:ListItem>
                            <asp:ListItem Value="Mayor a">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="Menor a">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="txtProducto" runat="server" Width="220px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="revProducto" runat="server" ControlToValidate="txtProducto" ValidationExpression="^[0-9]*$">Ingresar solo números.</asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13">Id Categoria:</td>
                    <td class="auto-style14">
                        <asp:DropDownList ID="ddlCategoria" runat="server" AutoPostBack="True">
                            <asp:ListItem Value="Igual a">Igual a:</asp:ListItem>
                            <asp:ListItem Value="Mayor a">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="Menor a">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="txtCategoria" runat="server" Width="220px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="revCategoria" runat="server" ControlToValidate="txtCategoria" ValidationExpression="^[0-9]*$">Ingresar solo números.</asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnQuitarFiltro" runat="server" OnClick="btnQuitarFiltro_Click" Text="Quitar filtro" />
                    </td>
                    <td></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="8">
                        <asp:GridView ID="gvProductos" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
