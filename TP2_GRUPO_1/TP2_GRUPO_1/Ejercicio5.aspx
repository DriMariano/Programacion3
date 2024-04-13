<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP2_GRUPO_1.Ejercicio5" %>

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
            font-size: xx-large;
            width: 304px;
        }
        .auto-style4 {
            font-size: large;
        }
        .auto-style5 {
            font-size: large;
            height: 70px;
            width: 304px;
        }
        .auto-style6 {
            height: 70px;
        }
        .auto-style8 {
            height: 50px;
        }
        .auto-style9 {
            height: 70px;
            width: 304px;
        }
        .auto-style10 {
            height: 50px;
            width: 304px;
        }
        .auto-style13 {
            width: 228px;
        }
        .auto-style14 {
            height: 70px;
            width: 228px;
        }
        .auto-style15 {
            height: 50px;
            width: 228px;
        }
        .auto-style16 {
            height: 50px;
            width: 196px;
        }
        .auto-style17 {
            height: 50px;
            width: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style2" colspan="3"><strong>Elija su configuración </strong></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style9" colspan="3"><strong><span class="auto-style4">Seleccione de cantidad de memoria:</span></strong> </td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style10" colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlMemoria" runat="server" Height="25px" Width="130px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style5" colspan="3"><strong>Seleccione accesorios:</strong></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style17">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style16">
                        <asp:CheckBoxList ID="cblAccesorios" runat="server">
                        </asp:CheckBoxList>
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style10" colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnCalcular" runat="server" Height="25px" OnClick="btnCalcular_Click" Text="Calcular precio" Width="170px" />
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style10" colspan="3">
                        <asp:Label ID="lblResultado" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
