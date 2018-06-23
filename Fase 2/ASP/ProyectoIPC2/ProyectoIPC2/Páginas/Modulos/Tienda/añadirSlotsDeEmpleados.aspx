<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/portalMaestra.Master" AutoEventWireup="true" CodeBehind="añadirSlotsDeEmpleados.aspx.cs" Inherits="ProyectoIPC2.Páginas.Modulos.Tienda.añadirSlotsDeEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="div2" runat="server">
    <center>
    <div class="titulo">
        Añadir Slots para Empleados
    </div>
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Tome en cuenta que se le cargaran Q.50.00 al saldo acutal de su cuenta por cada slot para empleado agregado"></asp:Label>
    <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"></asp:Button>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</center>
</asp:Content>
