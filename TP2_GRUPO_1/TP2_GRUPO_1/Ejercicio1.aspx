<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_GRUPO_1.Ejercicio1" %>

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
            width: 200px;
        }
        .auto-style3 {
            width: 215px;
        }
        .auto-style4 {
            width: 3px;
        }
        .auto-style5 {
            width: 70px;
        }
        .auto-style11 {
            width: 200px;
            height: 40px;
        }
        .auto-style12 {
            width: 215px;
            height: 40px;
        }
        .auto-style13 {
            width: 3px;
            height: 40px;
        }
        .auto-style14 {
            width: 70px;
            height: 40px;
        }
        .auto-style15 {
            height: 40px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">Ingrese nombre del producto: </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtProducto1" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style13"></td>
                    <td class="auto-style14">Cantidad:</td>
                    <td class="auto-style15">
                        <asp:TextBox ID="txtCantidad1" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                </tr>
                <tr>
                    <td class="auto-style11">Ingrese nombre del producto: </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="txtProducto2" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style13"></td>
                    <td class="auto-style14">Cantidad:</td>
                    <td class="auto-style15">
                        <asp:TextBox ID="txtCantidad2" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:Button ID="btnGenerar" runat="server" Text="Generar Tabla" OnClick="btnGenerar_Click" />
                    </td>
                    <td class="auto-style12"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblTabla" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
