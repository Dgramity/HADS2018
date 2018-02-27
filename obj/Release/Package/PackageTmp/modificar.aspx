<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="modificar.aspx.vb" Inherits="WebApplication7.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div style="height: 462px">
    
        <br />
        Email:
           <asp:TextBox ID="email" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="email" ErrorMessage="*"></asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="Direccion incorrecta" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <span id="msgerror">
           <br />
           <asp:Label ID="LabelB1" runat="server" Text="Label" Visible="False"></asp:Label>
           </span>
        <br />
        &nbsp;<asp:Button ID="Button1" runat="server" Text="Solicitar codigo" />
        <br />
        <br />
           Codigo recibido:&nbsp;
           <asp:TextBox ID="codigo" runat="server"></asp:TextBox>
           <br />
           <br />
           <br /> Nueva contraseña:&nbsp; <asp:TextBox ID="password" runat="server"></asp:TextBox>
           <br />Repita contraseña:&nbsp;
           <asp:TextBox ID="repassword" runat="server"></asp:TextBox>
           <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="No coinciden" ControlToCompare="password" ControlToValidate="repassword"></asp:CompareValidator>
        <br />
           <br />
           <asp:Label ID="LabelB2" runat="server" Text="Label" Visible="False"></asp:Label>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Modificar contraseña" />
&nbsp;&nbsp;</p>
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

