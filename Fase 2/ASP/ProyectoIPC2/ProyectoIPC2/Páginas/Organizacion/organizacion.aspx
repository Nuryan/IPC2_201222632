<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/portalMaestra.Master" AutoEventWireup="true" CodeBehind="organizacion.aspx.cs" Inherits="ProyectoIPC2.Páginas.Organizacion.organizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="div2" runat="server">
<div class ="titulo">
    Mi
    Organización
</div>
<br />
<br />
<br />
<br />
<br />
<br />
<center>
    <asp:Button ID="Button1" runat="server" Text="Crear Organizacion" BackColor="Black" ForeColor="White" Width="60%" Height="35px" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Modificar Organizacion" BackColor="Black" ForeColor="White" Width="60%" Height="35px" />
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" Text="Añadir Miembro" BackColor="Black" ForeColor="White" Width="60%" Height="35px" />
    <br />
    <br />
    <asp:Button ID="Button4" runat="server" Text="Eliminar Miembro" BackColor="Black" ForeColor="White" Width="60%" Height="35px" />
    <br />
    <br />
    <asp:Button ID="Button5" runat="server" Text="Eliminar Organizacion" BackColor="Black" ForeColor="White" Width="60%" Height="35px" />
    <br />
    <br />
</center>
</asp:Content>
