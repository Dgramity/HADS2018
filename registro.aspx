<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="registro.aspx.vb" Inherits="WebApplication7.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        REGISTRO DE USUARIOS<br />
        &nbsp;&nbsp;&nbsp;
        <br />
        Direccion de correo
        <asp:TextBox   height="28"  width="160" ID="TextBox1" runat="server" ValidationGroup="1"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Direccion incorrecta" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*">*</asp:RequiredFieldValidator>
        <br />
        Nombre
        <asp:TextBox  height="28"  width="160" ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*">*</asp:RequiredFieldValidator>
        <br />
        Apellidos
        <asp:TextBox  height="28"  width="160" ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" >*</asp:RequiredFieldValidator>
        <br />
        Password
        <asp:TextBox  height="28"  width="160" ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*" >*</asp:RequiredFieldValidator>
        <br />
        Repite Password
        <asp:TextBox  height="28"  width="160" ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="*" >*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="No coinciden"></asp:CompareValidator>
        <br />
        <br />
        ROL:&nbsp;&nbsp;
            
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="*" >*</asp:RequiredFieldValidator>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Alumno</asp:ListItem>
            <asp:ListItem>Profesor</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="Registrar" Height="41px" Width="176px" />
        &nbsp;<br />
        <br />
        &nbsp;*Tras registrarse, se enviará un mensaje a esa dirección de correo para confirmar la cuenta.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            
    </div>
    </form>
</body>
</html>
