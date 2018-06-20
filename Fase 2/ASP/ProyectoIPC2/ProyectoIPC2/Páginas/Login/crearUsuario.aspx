<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/loginYCreacion.Master" AutoEventWireup="true" CodeBehind="crearUsuario.aspx.cs" Inherits="ProyectoIPC2.Páginas.Login.crearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <style type="text/css">
        .alin {
            text-align: right;
        }
    </style>
    <p class="titulo">
        Crear Usuario
    </p>
    <div style="width: 100%">
        <center>
        <table>
            <tr>
                <td class="alin">
                    Nombres:*<br />
                </td>
                <td>
                    <asp:TextBox ID="nombres" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="alin">
                   
            Apellidos:*<br />
                </td>
                <td>
                    <asp:TextBox ID="apellidos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="alin">
                   
                    email: *</td>
                <td>
                    <asp:TextBox ID="apodo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="alin">
                   
            Contraseña:*<br />
                </td>
                <td>
                    <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr><tr>
                <td class="alin">
                   
            Repita la Contraseña:*<br />
                </td>
                <td>
                    <asp:TextBox ID="passRepetido" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr><tr>
                <td class="alin">
                   
            DPI:*<br />
                </td>
                <td>
                    <asp:TextBox ID="DPI" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
        </table>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Crear Usuario" OnClick="Button1_Click" ></asp:Button>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Ir  a inicio de sesion" OnClick="Button2_Click" ></asp:Button>
            </center>


    </div>
</asp:Content>
