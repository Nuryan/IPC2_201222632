<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/portalMaestra.Master" AutoEventWireup="true" CodeBehind="añadirModulo.aspx.cs" Inherits="ProyectoIPC2.Páginas.Modulos.Tienda.añadirModulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="div2" runat="server">
    <center>
        <div class="titulo">
            Comprar Modulo
        </div>
        <br />
        <br />
        <br />
        <br />
    <asp:Label ID="Label1" runat="server" Text="Módulo">
        </asp:Label>&nbsp;<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        &nbsp;
        <asp:Label ID="Label2" runat="server" Text="Numero de meses:"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="69px"></asp:TextBox>
        &nbsp;<asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" style="height: 26px"></asp:Button>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        <br />
        <br />

        <br />        
        <br />
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
        

        <br />
        <br />
        </center>
</asp:Content>
