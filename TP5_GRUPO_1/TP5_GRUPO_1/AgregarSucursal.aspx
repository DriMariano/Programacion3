<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="TP5_GRUPO_1.AgregarSucursal" %>

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
            width: 42px;
        }
        .auto-style3 {
            width: 42px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            height: 29px;
            font-size: xx-large;
            width: 258px;
        }
        .auto-style7 {
            width: 258px;
            font-size: x-large;
            height: 30px;
        }
        .auto-style13 {
            width: 42px;
            height: 30px;
        }
        .auto-style14 {
            width: 197px;
            height: 30px;
        }
        .auto-style15 {
            height: 30px;
        }
        .auto-style18 {
            width: 258px;
            height: 23px;
        }
        .auto-style23 {
            width: 258px;
        }
        .auto-style26 {
            width: 197px;
            height: 23px;
        }
        .auto-style27 {
            width: 197px;
        }
        .auto-style32 {
            width: 42px;
            height: 29px;
        }
        .auto-style33 {
            width: 197px;
            height: 29px;
        }
        .auto-style34 {
            height: 29px;
        }
        .auto-style36 {
            width: 126px;
        }
        .auto-style37 {
            width: 188px;
            height: 23px;
        }
        .auto-style38 {
            width: 188px;
        }
        .auto-style39 {
            width: 108px;
            height: 23px;
        }
        .auto-style40 {
            width: 126px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style40"></td>
                    <td class="auto-style37">
                        <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">AgregarSucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style26">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoDeSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style39">
                        &nbsp;</td>
                    <td class="auto-style4">
                        <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style23" colspan="2">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style32"></td>
                    <td class="auto-style5" colspan="2"><strong>GRUPO Nº 1</strong></td>
                    <td class="auto-style33"></td>
                    <td class="auto-style34" colspan="2"></td>
                    <td class="auto-style34"></td>
                    <td class="auto-style34"></td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style18" colspan="2"></td>
                    <td class="auto-style26"></td>
                    <td class="auto-style4" colspan="2"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style23" colspan="2">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style7" colspan="2"><strong>Agregar Sucursal</strong></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15" colspan="2"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style15"></td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style18" colspan="2"></td>
                    <td class="auto-style26"></td>
                    <td class="auto-style4" colspan="2"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style36">Nombre Sucursal:</td>
                    <td colspan="2">
                        <asp:TextBox ID="txtNombreSucursal" runat="server" Width="340px" ValidationGroup="Grupo1"></asp:TextBox>
                    </td>
                    <td colspan="2">
                        <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server" ControlToValidate="txtNombreSucursal" ForeColor="Red" ValidationGroup="Grupo1" ErrorMessage="Ingrese un nombre de sucursal.">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style36">Descripción:</td>
                    <td colspan="2">
                        <asp:TextBox ID="txtDescripcion" runat="server" Height="36px" Width="340px"></asp:TextBox>
                    </td>
                    <td colspan="2">
                        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" ForeColor="Red" ValidationGroup="Grupo1" ErrorMessage="Ingrese una descripción.">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style40">Provincia:</td>
                    <td class="auto-style4" colspan="2">
                        <asp:DropDownList ID="ddlProvincias" runat="server" AutoPostBack="True" Width="347px" AppendDataBoundItems="True" ValidationGroup="Grupo1">
                            <asp:ListItem Value="0">--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4" colspan="2">
                        <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="ddlProvincias" ForeColor="Red" InitialValue="0" ValidationGroup="Grupo1" ErrorMessage="Seleccione una provincia.">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style36">Dirección:</td>
                    <td colspan="2">
                        <asp:TextBox ID="txtDireccion" runat="server" Width="340px"></asp:TextBox>
                    </td>
                    <td colspan="2">
                        <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ForeColor="Red" ValidationGroup="Grupo1" ErrorMessage="Ingrese una dirección.">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style36">&nbsp;</td>
                    <td class="auto-style38">
                        &nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style36">&nbsp;</td>
                    <td class="auto-style38">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" ValidationGroup="Grupo1" />
                    </td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style36">&nbsp;</td>
                    <td class="auto-style38">
                        <asp:Label ID="lblMensaje" runat="server" ForeColor="Black"></asp:Label>
                    </td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style23" colspan="2">
                        <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="Red" HeaderText="Errores: " ShowMessageBox="True" ValidationGroup="Grupo1" />
                    </td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style23" colspan="2">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style23" colspan="2">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style23" colspan="2">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style23" colspan="2">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style23" colspan="2">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
