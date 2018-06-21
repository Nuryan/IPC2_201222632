<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Maestra/portalMaestra.Master" AutoEventWireup="true" CodeBehind="crearEmpleado.aspx.cs" Inherits="ProyectoIPC2.Páginas.Modulos.Empleado.crearEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="div2" runat="server">
    <div class="titulo">
        Crear Empleado
    </div>
    <br />
    <br />
    <br />
    <br />
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
                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
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
            <asp:Button ID="Button1" runat="server" Text="Crear Empleado" OnClick="Button1_Click"  ></asp:Button>
            <br />
            </center>


    </div>

</asp:Content>
