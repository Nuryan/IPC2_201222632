using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Organizacion
{
    public partial class añadirEmpleadoOrganizacion : System.Web.UI.Page
    {
        WServiceIPC2.WSIPC2 ws = new WServiceIPC2.WSIPC2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                return;
            }
            int aux = 0;
            DropDownList1.Items.Clear();
            DropDownList2.Items.Clear();

            String[] empleados = ws.listarEmpleados((string)Session["usuario"]);
            String[] organizaciones = ws.listarOrganizaciones((string)Session["usuario"]);

            for (aux = 0; aux<empleados.Length; aux++)
            {
                DropDownList1.Items.Add(empleados[aux]);
            }
            for (aux = 0; aux < organizaciones.Length; aux++)
            {
                DropDownList2.Items.Add(organizaciones[aux]);
            }
        }

        protected void Button1_Click(object  sender, EventArgs e)
        {
            Label3.Text = ws.añadirParticipanteAOrganizacion(DropDownList1.Text, DropDownList2.Text);
        }
    }
}