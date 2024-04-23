<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_1.aspx.cs" Inherits="TP3_GRUPO_1.Ejercicio_1" %>

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
            width: 239px;
        }
        .auto-style3 {
            font-size: large;
            width: 152px;
        }
        .auto-style4 {
            width: 152px;
        }
        .auto-style8 {
            width: 239px;
            height: 65px;
        }
        .auto-style9 {
            font-size: large;
            width: 152px;
            height: 65px;
        }
        .auto-style10 {
            height: 65px;
        }
        .auto-style12 {
            width: 152px;
            height: 50px;
        }
        .auto-style16 {
            width: 152px;
            height: 95px;
        }
        .auto-style17 {
            width: 239px;
            height: 95px;
        }
        .auto-style18 {
            height: 95px;
        }
        .auto-style19 {
            width: 218px;
        }
        .auto-style20 {
            height: 50px;
            width: 218px;
        }
        .auto-style21 {
            height: 65px;
            width: 218px;
            font-size: x-large;
        }
        .auto-style23 {
            height: 95px;
            width: 218px;
        }
        .auto-style26 {
            height: 65px;
            width: 359px;
        }
        .auto-style27 {
            width: 359px;
        }
        .auto-style30 {
            width: 359px;
            height: 95px;
        }
        .auto-style31 {
            width: 239px;
            height: 45px;
        }
        .auto-style32 {
            width: 152px;
            height: 45px;
        }
        .auto-style33 {
            height: 45px;
            width: 218px;
        }
        .auto-style34 {
            width: 359px;
            height: 45px;
        }
        .auto-style35 {
            height: 45px;
        }
        .auto-style41 {
            width: 239px;
            height: 42px;
        }
        .auto-style42 {
            width: 152px;
            height: 42px;
        }
        .auto-style43 {
            width: 218px;
            height: 42px;
        }
        .auto-style44 {
            width: 359px;
            height: 42px;
        }
        .auto-style45 {
            height: 42px;
        }
        .auto-style46 {
            width: 218px;
            font-size: x-large;
        }
        .auto-style47 {
            width: 239px;
            height: 50px;
        }
        .auto-style48 {
            height: 50px;
            width: 359px;
        }
        .auto-style49 {
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="Ejercicio_1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style46"><strong>Localidades</strong></td>
                    <td class="auto-style27">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style47">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style12">&nbsp; Nombre de localidad:</td>
                    <td class="auto-style20">
                        <asp:TextBox ID="txtLocalidad" runat="server" ValidationGroup="Grupo1" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style48">
                        <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="txtLocalidad" ValidationGroup="Grupo1">Debe ingresar una localidad.</asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="revLocalidad" runat="server" ControlToValidate="txtLocalidad" ValidationGroup="Grupo1" ValidationExpression="^[A-Za-z0-9\s]+$">Ingrese solo numeros y letras.</asp:RegularExpressionValidator>
                        <br />
                        <asp:Label ID="lblError" runat="server"></asp:Label>
                        <br />
                    </td>
                    <td class="auto-style49"></td>
                    <td class="auto-style49"></td>
                </tr>
                <tr>
                    <td class="auto-style31"></td>
                    <td class="auto-style32"></td>
                    <td class="auto-style33">
                        <asp:Button ID="btnGuardarLocalidad" runat="server" OnClick="btnGuardarLocalidad_Click" Text="Guardar Localidad" ValidationGroup="Grupo1" />
                    </td>
                    <td class="auto-style34">&nbsp;</td>
                    <td class="auto-style35"></td>
                    <td class="auto-style35"></td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style21"><strong>Usuarios</strong></td>
                    <td class="auto-style26"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style41">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style42">Nombre de usuario:</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="txtNombreUsuario" runat="server" ValidationGroup="grupo2" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style44">
                        <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtNombreUsuario" ValidationGroup="Grupo2">Ingrese Nombre de usuario.</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style45"></td>
                    <td class="auto-style45"></td>
                </tr>
                <tr>
                    <td class="auto-style41">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style42">Contraseña:</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" ValidationGroup="Grupo2" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style44">
                        <asp:RequiredFieldValidator ID="rfvContrasenia" runat="server" ControlToValidate="txtContrasenia" ValidationGroup="Grupo2">Ingrese una contraseña.</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style45"></td>
                    <td class="auto-style45"></td>
                </tr>
                <tr>
                    <td class="auto-style41">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style42">Repetir contraseña:</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="txtRepetirContr" runat="server" TextMode="Password" ValidationGroup="Grupo2" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style44">
                        <asp:RequiredFieldValidator ID="rfvRepetirContr" runat="server" ControlToValidate="txtRepetirContr" ValidationGroup="Grupo2">Repita la contraseña.</asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="cvContrasenia" runat="server" ControlToCompare="txtContrasenia" ControlToValidate="txtRepetirContr" ValidationGroup="Grupo2">La contraseña no coincide.</asp:CompareValidator>
                    </td>
                    <td class="auto-style45"></td>
                    <td class="auto-style45"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style4">Correo electronico:</td>
                    <td class="auto-style19">
                        <asp:TextBox ID="txtCorreo" runat="server" ValidationGroup="Grupo2" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style27">
                        <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ValidationGroup="Grupo2">Ingrese un correo electronico.</asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="revCorreo" runat="server" ControlToValidate="txtCorreo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Grupo2">Correo invalido. (Ej: juan@gmail.com)</asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style41">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style42">C.P.:</td>
                    <td class="auto-style43">
                        <asp:TextBox ID="txtCP" runat="server" ValidationGroup="Grupo2" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style44">
                        <asp:RequiredFieldValidator ID="rfvCP" runat="server" ControlToValidate="txtCP" ValidationGroup="Grupo2">Ingrese un Codigo Postal.</asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="revCP" runat="server" ControlToValidate="txtCP" ValidationExpression="\d{4}" ValidationGroup="Grupo2">Codigo invalido. Solo admite 4 digitos.</asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style45"></td>
                    <td class="auto-style45"></td>
                </tr>
                <tr>
                    <td class="auto-style41">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style42">Localidades:</td>
                    <td class="auto-style43">
                        <asp:DropDownList ID="ddlLocalidades" runat="server" ValidationGroup="Grupo2" Width="180px">
                            <asp:ListItem>--Seleccione Localidad--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style44">
                        <asp:RequiredFieldValidator ID="rfvLocalidades" runat="server" ControlToValidate="ddlLocalidades" InitialValue="--Seleccione Localidad--" ValidationGroup="Grupo2">Seleccione una localidad.</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style45"></td>
                    <td class="auto-style45"></td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style16">&nbsp;&nbsp; </td>
                    <td class="auto-style23">
                        <asp:Button ID="btnGuardarUsuario" runat="server" OnClick="btnGuardarUsuario_Click" Text="Guardar Usuario" ValidationGroup="Grupo2" />
                    </td>
                    <td class="auto-style30">
                        <asp:Label ID="lblSaludo" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    </td>
                    <td class="auto-style18"></td>
                    <td class="auto-style18"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnIrInicio" runat="server" OnClick="btnIrInicio_Click" Text="Ir a Inicio.aspx" />
                    </td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
