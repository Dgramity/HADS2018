<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ExportarTarea.aspx.vb" Inherits="WebApplication7.ExportarTarea" %>

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
                <strong>PROFESOR<br />EXPORTAR TAREAS GENERICAS</strong></div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            Seleccionar Asignatura a Exportar:</p>
        <p>
            <asp:DropDownList ID="Lista" runat="server" Height="23px" Width="173px">
            </asp:DropDownList>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Exportar DataSet" Width="215px" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Exportar XML" />
        </p>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Profesor.aspx">Menú profesor</asp:LinkButton>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Tareas exportadas en fichero:" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
