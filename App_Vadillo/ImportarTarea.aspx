<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ImportarTarea.aspx.vb" Inherits="WebApplication7.ImportarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
                <strong>PROFESOR<br />IMPORTAR TAREAS GENERICAS</strong></div>
        </div>
         <br />
&nbsp;&nbsp;&nbsp; Seleccionar Asignatura a Importar:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <asp:DropDownList ID="ListaAsig" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Xml ID="Xml1" runat="server"></asp:Xml>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="61px" Text="Importar" Width="135px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Profesor.aspx">Menú profesor</asp:LinkButton>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
