using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Modulos.Clientes
{
    public partial class portalClientes : System.Web.UI.Page
    {
        WServiceIPC2.WSIPC2 ws = new WServiceIPC2.WSIPC2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                return;
            }

            String[] nombres = ws.getNombresClientes((string)Session["usuario"]);
            String[] nit = ws.getNitClientes((string)Session["usuario"]);

            //comienza creacion de tabla
            int totalFilas = nombres.Length;
            int filaActual;
            int columnaActual;
            int totalColumnas = 2;

            for (filaActual = 0; filaActual <= totalFilas; filaActual++)
            {

                TableRow tRow = new TableRow();
                Table1.Rows.Add(tRow);
                Table1.BorderWidth = 1;
                tRow.BorderWidth = 1;
                for (columnaActual = 0; columnaActual < totalColumnas; columnaActual++)
                {

                    // Create a new cell and add it to the row.
                    TableCell tCell = new TableCell();
                    if (filaActual == 0)
                    {
                        switch (columnaActual)
                        {
                            case 0:
                                tCell.Text = "Proveedor";
                                break;
                            case 1:
                                tCell.Text = "Telefono";
                                break;
                        }
                    }
                    else
                    {
                        switch (columnaActual)
                        {
                            case 0:
                                tCell.Text = nombres[filaActual - 1];
                                break;
                            case 1:
                                tCell.Text = nit[filaActual - 1];
                                break;
                        }
                    }
                    //tCell.Text = "Row " + filaActual + ", Cell " + columnaActual;
                    tRow.Cells.Add(tCell);
                    tCell.BorderWidth = 1;
                    tCell.Width = 400;
                    tCell.Height = 50;
                    tCell.HorizontalAlign = HorizontalAlign.Center;
                }
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (ws.crearCliente(TextBox1.Text, Int32.Parse(TextBox2.Text), (string)Session["usuario"])==1)
            {
                Label6.Text = "Cliente Creado";
            }
            else
            {
                Label6.Text = "Cliente no creado";
            }

        }
    }
}