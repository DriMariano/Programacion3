<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP4_GRUPO_1.Ejercicio1" %>

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
            width: 149px;
        }
        .auto-style3 {
            width: 148px;
        }
        .auto-style5 {
            width: 149px;
            height: 40px;
        }
        .auto-style6 {
            width: 148px;
            text-decoration: underline;
            height: 40px;
        }
        .auto-style7 {
            height: 40px;
        }
        .auto-style8 {
            width: 149px;
            height: 46px;
        }
        .auto-style9 {
            width: 148px;
            text-decoration: underline;
            height: 46px;
        }
        .auto-style10 {
            height: 46px;
        }
        .auto-style11 {
            height: 40px;
            width: 151px;
        }
        .auto-style12 {
            width: 151px;
        }
        .auto-style13 {
            height: 46px;
            width: 151px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">DESTINO INICIO</td>
                    <td class="auto-style11"></td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3"><strong>PROVINCIA:</strong></td>
                    <td class="auto-style12">
                        <asp:DropDownList ID="ddlProvInicio" runat="server" Width="130px" OnSelectedIndexChanged="ddlProvInicio_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong></strong></td>
                    <td class="auto-style3"><strong>LOCALIDAD:</strong></td>
                    <td class="auto-style12">
                        <asp:DropDownList ID="ddlLocalidadInicio" runat="server" AutoPostBack="True" Width="130px">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style9">DESTINO FINAL</td>
                    <td class="auto-style13"></td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3"><strong>PROVINCIA:</strong></td>
                    <td class="auto-style12">
                        <asp:DropDownList ID="ddlProvFinal" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvFinal_SelectedIndexChanged" Width="130px">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3"><strong>LOCALIDAD:</strong></td>
                    <td class="auto-style12">
                        <asp:DropDownList ID="ddlLocalidadFinal" runat="server" AutoPostBack="True" Width="130px">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
