<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/portalMaestra.Master" AutoEventWireup="true" CodeBehind="añadirEmpleadoOrganizacion.aspx.cs" Inherits="ProyectoIPC2.Páginas.Organizacion.añadirEmpleadoOrganizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="div2" runat="server">
    <div class="titulo">Añadir Empleado a Organizacion</div>
    <br />
    <br />
    <br />
    <br />
    <center>
    <asp:Label ID="Label1" runat="server" Text="Empleados:  "></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Organizacion:  "></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Añadir Participante" OnClick="Button1_Click"></asp:Button>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </center>
</asp:Content>
