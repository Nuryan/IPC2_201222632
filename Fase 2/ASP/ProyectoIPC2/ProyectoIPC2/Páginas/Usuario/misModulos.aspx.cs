using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Usuario
{
    public partial class misModulos : System.Web.UI.Page
    {
        WServiceIPC2.WSIPC2 ws = new WServiceIPC2.WSIPC2();
        protected void Page_Load(object sender, EventArgs e)
        {
            String[] modulos = ws.getModulosAdquiridos((string)Session["usuario"]);
            int numModulos = modulos.Length, auxiliarFor;

            for (auxiliarFor = 0; auxiliarFor<numModulos; auxiliarFor++)
            {
                if (modulos[auxiliarFor].Equals("Clientes"))
                {
                    Button1.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("Proveedores"))
                {
                    Button2.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("Inventario"))
                {
                    Button3.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("Ventas"))
                {
                    Button4.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("Compras"))
                {
                    Button5.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("Facturacion"))
                {
                    Button6.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("Reclutamiento"))
                {
                    Button7.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("Flotas"))
                {
                    Button8.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("Blog"))
                {
                    Button9.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("Eventos"))
                {
                    Button10.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("CRM"))
                {
                    Button11.Visible = true;
                }
                else if (modulos[auxiliarFor].Equals("Descuentos"))
                {
                    Button12.Visible = true;
                }
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Páginas/Modulos/Clientes/portalClientes.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Páginas/Modulos/Proveedores/portalProveedores.aspx");
        }
    }
}