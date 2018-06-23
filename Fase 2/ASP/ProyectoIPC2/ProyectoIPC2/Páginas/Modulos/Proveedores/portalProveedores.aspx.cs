using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Modulos.Proveedores
{
    public partial class portalProveedores : System.Web.UI.Page
    {
        WServiceIPC2.WSIPC2 ws = new WServiceIPC2.WSIPC2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                return;
            }

            String[] nombres = ws.getNombreProveedores((string)Session["usuario"]);
            String[] telefono = ws.getTelefonoProveedores((string)Session["usuario"]);
            String[] organizacion = ws.getOrganizacionProveedores((string)Session["usuario"]);

            //comienza creacion de tabla
            int totalFilas = nombres.Length;
            int filaActual;
            int columnaActual;
            int totalColumnas = 3;

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
                            case 2:
                                tCell.Text = "Organizacion";
                                break;
                        }
                    }
                    else
                    {
                        switch (columnaActual)
                        {
                            case 0:
                                tCell.Text = nombres[filaActual-1];
                                break;
                            case 1:
                                tCell.Text = telefono[filaActual - 1];
                                break;
                            case 2:
                                tCell.Text = organizacion[filaActual - 1];
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
            if (ws.crearProveedor(TextBox1.Text, Int32.Parse(TextBox2.Text), TextBox3.Text, (string)Session["usuario"])==1)
            {
                Label6.Text = "Proveedor agregado";
            }else
            {
                Label6.Text = "Proveedor no agregado";
            }
        }
    }
}