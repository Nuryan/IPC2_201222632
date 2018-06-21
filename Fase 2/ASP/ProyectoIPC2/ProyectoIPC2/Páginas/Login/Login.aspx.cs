using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Login
{
    public partial class Login : System.Web.UI.Page
    {
        WServiceIPC2.WSIPC2 ws = new WServiceIPC2.WSIPC2();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ws.login(TextBox1.Text, TextBox2.Text).Equals("No Encontrado"))
            {
                Label1.Text = "Usuario o Contraseña Incorrectos";
            }else
            {
                Session["usuario"] = TextBox1.Text;
                Server.Transfer("~/Páginas/Modulos/portal.aspx", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("crearUsuario.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}