using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Modulos.Tienda
{
    public partial class añadirSlotsDeEmpleados : System.Web.UI.Page
    {
        WServiceIPC2.WSIPC2 ws = new WServiceIPC2.WSIPC2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ws.comprarSlots((string)Session["usuario"], Int32.Parse( TextBox1.Text))==1)
            {
                Label2.Text = "Slots añadidos";
            }
            else
            {
                Label2.Text = "Slots no añadidos";
            }
                
        }
    }
}