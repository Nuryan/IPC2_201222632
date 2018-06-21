using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Maestra
{
    public partial class Portal : System.Web.UI.MasterPage
    {
        WServiceIPC2.WSIPC2 ws = new WServiceIPC2.WSIPC2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ws.getCargoUsuario((string)(Session["usuario"])) != 2)
            {
                Button3.Visible = false;
                Button4.Visible = false;
                Button5.Visible = false;
            }
            if(ws.getCargoUsuario((string)(Session["usuario"])) == 3)
            {
                Button1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Páginas/Modulos/Tienda/tienda.aspx", true);
        }
        

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Páginas/Organizacion/organizacion.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Páginas/Usuario/miUsuario.aspx");
        }

        protected void Button6_Click1(object sender, EventArgs e)
        {

            Response.Redirect("~/Páginas/Login/Login.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Páginas/Modulos/Empleado/empleado.aspx");
        }
    }
}