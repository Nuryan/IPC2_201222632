<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/portalMaestra.Master" AutoEventWireup="true" CodeBehind="portalClientes.aspx.cs" Inherits="ProyectoIPC2.Páginas.Modulos.Clientes.portalClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="div2" runat="server">
    <div class ="titulo">Clientes</div>
    <br />
    <br />
    <center>
        <asp:Label ID="Label1" runat="server" Text="Inserta nuevo Cliente"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nit"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button10" runat="server"  Text="Agregar Cliente" OnClick="Button10_Click" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Eliminar"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button11" runat="server" Text="Eliminar" />
        <br />
        <asp:Label ID="Label7" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
        <br />
        <br />
        <br />
        <br />
    </center>
</asp:Content>
