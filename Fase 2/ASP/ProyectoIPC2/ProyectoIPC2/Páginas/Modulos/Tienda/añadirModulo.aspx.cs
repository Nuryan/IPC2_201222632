using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Modulos.Tienda
{
    public partial class añadirModulo : System.Web.UI.Page
    {
        WServiceIPC2.WSIPC2 ws = new WServiceIPC2.WSIPC2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                return;
            }

            DropDownList1.Items.Clear();

            añadirModulosAlDrop();

            String[] nombres = ws.listarNombresModulos();
            String[] descripciones = ws.listarDescripcionModulos();
            float[] precios = ws.listarPrecioModulos();

            //comienza creacion de tabla
            int totalFilas = ws.getNumModulos();
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
                                tCell.Text = "Módulo";
                                break;
                            case 1:
                                tCell.Text = "Descripción";
                                break;
                            case 2:
                                tCell.Text = "Precio (Q)";
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
                                tCell.Text = descripciones[filaActual - 1];
                                break;
                            case 2:
                                tCell.Text = precios[filaActual - 1].ToString();
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

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (ws.comprarModulo((string)Session["usuario"], DropDownList1.Text, Int32.Parse(TextBox1.Text)).Equals("1"))
            {
                Label3.Text = "Modulos añadidos a la cuenta";
            }
            else
            {
                Label3.Text = "no se ha podido añadir a la cuetna";
            }
        }

        private void añadirModulosAlDrop()
        {
            int aux;
            for (aux = 0; aux < ws.getNumModulos(); aux++)
            {
                DropDownList1.Items.Add(ws.listarNombresModulos()[aux]);
            }
        }
    }
}