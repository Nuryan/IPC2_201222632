<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/portalMaestra.Master" AutoEventWireup="true" CodeBehind="crearOrganizacion.aspx.cs" Inherits="ProyectoIPC2.Páginas.Organizacion.crearOrganizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="div2" runat="server">
    <br />
    <div class="titulo">
        Crear Organizacion
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <center>

        <asp:Label ID="Label1" runat="server" Text="Insertar el nombre de la organizacion"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Crear Organizacion" OnClick="Button1_Click"></asp:Button>
        <br />
        <br />
        <br />
        
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </center>
    <br />

</asp:Content>
