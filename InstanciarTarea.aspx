<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InstanciarTarea.aspx.vb" Inherits="WebApplication7.InstanciarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 120px;
        }
    </style>
</head>
<body style="height: 924px">
    <form id="form1" runat="server">
         <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
        <h1 style="text-align: center">ALUMNOS</h1>
        <h1 style="text-align: center">INSTANCIAR TAREA GENÉRICA</h1>
    </div>
        <div class="auto-style1">
            <asp:Label ID="labelUsuario" runat="server" Text="Usuario"></asp:Label>
&nbsp;
            <asp:TextBox ID="textoUsuario" runat="server"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="labelTarea" runat="server" Text="Tarea"></asp:Label>
&nbsp;
            <asp:TextBox ID="textoTarea" runat="server"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="labelEstimadas" runat="server" Text="Horas Est."></asp:Label>
&nbsp;
            <asp:TextBox ID="textoEstimadas" runat="server"></asp:TextBox>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="labelReales" runat="server" Text="Horas reales"></asp:Label>
&nbsp;
            <asp:TextBox ID="textoReales" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Instanciar tarea" />
            <br />
            <br />
            <br />
        </div>


            <asp:GridView ID="GridViewTareas" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="202px" Width="276px">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>


        <asp:HyperLink ID="Inicio" runat="server" NavigateUrl="Alumno.aspx">Atras</asp:HyperLink>


    </form>
</body>
</html>
