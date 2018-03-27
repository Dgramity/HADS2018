<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Profesor.aspx.vb" Inherits="WebApplication7.Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 395px">
    <form id="form1" runat="server">
         <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
                <asp:Button ID="ButtonCerrar" runat="server" Text="Cerrar" />
                <strong>PROFESOR<br />GESTIÓN WEB DE TAREAS-DEDICACIÓN</strong></div>
        <div style="font-size: xx-large; margin-left: 2px; height: 471px;" align="center">
       
            &nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:HyperLink ID="Tareas" runat="server" ForeColor="#3366FF" style="text-decoration: underline" NavigateUrl="TareasProfesor.aspx" BorderStyle="None">Editar tareas</asp:HyperLink>
            
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" style="text-decoration: underline" ForeColor="#3366FF" NavigateUrl="InsertarTarea.aspx">Insertar tarea</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" style="text-decoration: underline" ForeColor="#3366FF" NavigateUrl="Estadisticas.aspx">Ver estadisticas</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" style="text-decoration: underline" ForeColor="#3366FF" NavigateUrl="~/ExportarTarea.aspx" Font-Size="XX-Large">Exportar tarea</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" style="text-decoration: underline" ForeColor="#3366FF" NavigateUrl="ImportarTarea.aspx">ImportarTarea</asp:HyperLink>
            <br />
            
        </div>
         <br />
         <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
    </form>
</body>
</html>