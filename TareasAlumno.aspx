<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasAlumno.aspx.vb" Inherits="WebApplication7.TareasAlumno" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 595px">
    <form id="form1" runat="server">
         <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
                <strong>ALUMNO<br />GESTIÓN WEB DE TAREAS-DEDICACIÓN</strong></div>
        <div style="font-size: xx-large; margin-left: 2px; height: 115px;" align="center">

            
            <br />
            Selecciona Asignatura&nbsp;
            <asp:Label ID="LabelUser" runat="server" Text="Label"></asp:Label>

            
        </div>
         <asp:DropDownList ID="ListAsig" runat="server">
         </asp:DropDownList>
         <asp:GridView ID="GridViewTareas" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="238px" Width="355px" GridLines="Horizontal">
             <AlternatingRowStyle BackColor="#F7F7F7" />
             <Columns>
                 <asp:CommandField ShowSelectButton="True" SelectText="Instanciar" />
             </Columns>
             <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
             <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
             <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
             <RowStyle ForeColor="#4A3C8C" BackColor="#E7E7FF" />
             <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
             <SortedAscendingCellStyle BackColor="#F4F4FD" />
             <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
             <SortedDescendingCellStyle BackColor="#D8D8F0" />
             <SortedDescendingHeaderStyle BackColor="#3E3277" />
         </asp:GridView>
         <br />
         <br />
         <br />
         <asp:HyperLink ID="InicioLink" runat="server" NavigateUrl="Alumno.aspx">Atras</asp:HyperLink>
    </form>
</body>
</html>