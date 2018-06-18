<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/loginYCreacion.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoIPC2.Páginas.Login.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <p class="titulo">
        <br />
        Ninty&#39;s
    </p>
    <br />
    <div style ="width:100%">
        <div class="centradoIzquierda">

            Correo:<br />
            Contraseña:<br />
            </div>
        <div class ="centradoDerecha">

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>

            <br />

        </div>
        <center>

            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />

            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar Sesión" Width="150px"/>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Crear Usuario"  Width="150px" OnClick="Button2_Click"/>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Recordar Contraseña"  Width="150px" OnClick="Button3_Click"/>
            <br />

            <br />

        </center>
    </div>
</asp:Content>
