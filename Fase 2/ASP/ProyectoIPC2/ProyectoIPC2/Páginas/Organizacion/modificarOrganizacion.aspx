<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/portalMaestra.Master" AutoEventWireup="true" CodeBehind="modificarOrganizacion.aspx.cs" Inherits="ProyectoIPC2.Páginas.Organizacion.modificarOrganizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="div2" runat="server">
    <div class="titulo">Modificar Organizacion</div><br /><br /><br /><br /><br /><br />
    <center>
    <asp:Label runat="server" Text="Cargar Informacion de:  "></asp:Label>
    <asp:dropdownlist runat="server"></asp:dropdownlist>
    <asp:Button runat="server" Text="Cargar" OnClick="Unnamed3_Click"></asp:Button>

    </center>
</asp:Content>
