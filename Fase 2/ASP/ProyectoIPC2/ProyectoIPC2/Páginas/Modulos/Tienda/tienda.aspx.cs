using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Modulos.Tienda
{
    public partial class tienda : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Páginas/Modulos/Tienda/añadirModulo.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Páginas/Modulos/Tienda/añadirSlotsDeEmpleados.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Páginas/Modulos/Tienda/añadirTiempo.aspx");
        }
    }
}