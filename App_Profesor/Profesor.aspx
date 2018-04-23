<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Profesor.aspx.vb" Inherits="WebApplication7.Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 395px">
    <form id="form1" runat="server">
         <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
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
            <asp:HyperLink ID="HyperLink4" runat="server" style="text-decoration: underline" ForeColor="#3366FF" NavigateUrl="../App_Vadillo/ExportarTarea.aspx" Font-Size="XX-Large">Exportar tarea</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" style="text-decoration: underline" ForeColor="#3366FF" NavigateUrl="../App_Vadillo/ImportarTarea.aspx">ImportarTarea</asp:HyperLink>
            <br />
            
        </div>
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
                 <asp:GridView ID="GridView1" runat="server">
                 </asp:GridView>
                 <asp:Timer ID="Timer1" runat="server" Interval="2000">
                 </asp:Timer>
             </ContentTemplate>
         </asp:UpdatePanel>
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