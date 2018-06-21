using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Modulos.Empleado
{
    public partial class crearEmpleado : System.Web.UI.Page
    {
        WServiceIPC2.WSIPC2 ws = new WServiceIPC2.WSIPC2();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = ws.crearEmpleado(DPI.Text, nombres.Text, apellidos.Text, pass.Text, passRepetido.Text, email.Text, (string)Session["usuario"]);
        }
    }
}