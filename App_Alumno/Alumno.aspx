<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Alumno.aspx.vb" Inherits="WebApplication7.Alumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 224px">
    <form id="form1" runat="server">
         <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Button ID="ButtonCerrar" runat="server" Text="Cerrar" />
                <strong>ALUMNO<br />GESTIÓN WEB DE TAREAS-DEDICACIÓN</strong></div>
        <div style="font-size: xx-large; margin-left: 2px; height: 115px;" align="center">
       
            &nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:HyperLink ID="Tareas" runat="server" ForeColor="#3366FF" style="text-decoration: underline" NavigateUrl="TareasAlumno.aspx">Tareas genericas</asp:HyperLink>
            
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