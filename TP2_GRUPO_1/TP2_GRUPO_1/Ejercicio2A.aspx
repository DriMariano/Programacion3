<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2A.aspx.cs" Inherits="TP2_GRUPO_1.Ejercicio2A" %>

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
            width: 74px;
        }
        .auto-style5 {
            height: 45px;
            width: 74px;
        }
        .auto-style6 {
            height: 45px;
        }
        .auto-style7 {
            height: 45px;
            width: 175px;
        }
        .auto-style8 {
            width: 175px;
        }
        .auto-style12 {
            height: 60px;
            width: 74px;
        }
        .auto-style13 {
            height: 60px;
            width: 175px;
        }
        .auto-style14 {
            height: 60px;
        }
        .auto-style15 {
            height: 50px;
            width: 74px;
        }
        .auto-style16 {
            height: 50px;
            width: 175px;
        }
        .auto-style17 {
            height: 50px;
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
                    <td class="auto-style12">Nombre:</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtNombre" runat="server" Height="25px" Width="160px"></asp:TextBox>
                    </td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style12">Apellido:</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtApellido" runat="server" Height="25px" Width="160px"></asp:TextBox>
                    </td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style12">Ciudad:</td>
                    <td class="auto-style13">
                        <asp:DropDownList ID="ddlCiudad" runat="server" Height="25px" Width="160px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style5">Temas:</td>
                    <td class="auto-style7">
                        <asp:CheckBoxList ID="cblTemas" runat="server">
                            <asp:ListItem>Ciencias</asp:ListItem>
                            <asp:ListItem>Literatura</asp:ListItem>
                            <asp:ListItem>Historia</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style15"></td>
                    <td class="auto-style16">
                        <asp:Button ID="btnResumen" runat="server" Height="26px" OnClick="btnResumen_Click" Text="Ver resumen" Width="140px" />
                    </td>
                    <td class="auto-style17"></td>
                    <td class="auto-style17"></td>
                    <td class="auto-style17"></td>
                    <td class="auto-style17"></td>
                    <td class="auto-style17"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
