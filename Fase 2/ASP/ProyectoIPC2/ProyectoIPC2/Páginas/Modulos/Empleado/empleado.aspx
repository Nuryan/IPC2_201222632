<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/portalMaestra.Master" AutoEventWireup="true" CodeBehind="empleado.aspx.cs" Inherits="ProyectoIPC2.Páginas.Modulos.Empleado.empleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="div2" runat="server">
    <div class="titulo">
        Empleados
    </div>
    <center>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Crear Empleado" BackColor="Black" ForeColor="White" Width="60%" Height="35px" OnClick="Button1_Click"  />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Modificar Empleado" BackColor="Black" ForeColor="White" Width="60%" Height="35px" />
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" Text="Eliminar Empleado" BackColor="Black" ForeColor="White" Width="60%" Height="35px" />
    <br />
    <br />
    <asp:Button ID="Button4" runat="server" Text="Visualizar Empleados" BackColor="Black" ForeColor="White" Width="60%" Height="35px" />
    <br />
    <br />
    <br />
    <br />
    </center>
</asp:Content>
