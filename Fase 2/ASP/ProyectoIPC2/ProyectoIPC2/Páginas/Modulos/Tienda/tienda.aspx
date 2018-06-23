<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/portalMaestra.Master" AutoEventWireup="true" CodeBehind="tienda.aspx.cs" Inherits="ProyectoIPC2.Páginas.Modulos.Tienda.tienda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="div2" runat="server">
    <center>
        <div class="titulo">
            Tienda
        </div>
        <br />
                <asp:Button ID="Button1" runat="server" Text="Añadir Modulos" BackColor="Black" ForeColor="White" Width="40%" Height="35px" OnClick="Button1_Click1" />
        <br />
        <br />
                <asp:Button ID="Button2" runat="server" Text="Añadir Slots de Empleados" BackColor="Black" ForeColor="White" Width="40%" Height="35px" OnClick="Button2_Click" />
        <br />
        <br />
                <asp:Button ID="Button3" runat="server" Text="Añadir Tiempo" BackColor="Black" ForeColor="White" Width="40%" Height="35px" OnClick="Button3_Click" />
        <br />
        <br />
        <br />
        
        <br />
    </center>
</asp:Content>
