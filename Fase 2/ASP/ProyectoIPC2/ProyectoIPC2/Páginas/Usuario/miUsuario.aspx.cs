using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIPC2.Páginas.Usuario
{
    public partial class miUsuario : System.Web.UI.Page
    {
        WServiceIPC2.WSIPC2 ws = new WServiceIPC2.WSIPC2();
        protected void Page_Load(object sender, EventArgs e)
        {
            String[] datos = ws.getDetallePersona((string)Session["usuario"]);

            //comienza creacion de tabla
            int totalFilas = 2;
            int filaActual;
            int columnaActual;
            int totalColumnas = 5;

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
                                tCell.Text = "Nombre";
                                break;
                            case 1:
                                tCell.Text = "Apellidos";
                                break;
                            case 2:
                                tCell.Text = "Email";
                                break;
                            case 3:
                                tCell.Text = "Numero maximo de empleados";
                                break;
                            case 4:
                                tCell.Text = "Saldo Actual";
                                break;

                        }
                    }
                    else
                    {
                        switch (columnaActual)
                        {
                            case 0:
                                tCell.Text = datos[0];
                                break;
                            case 1:
                                tCell.Text = datos[1];
                                break;
                            case 2:
                                tCell.Text = datos[2];
                                break;
                            case 3:
                                tCell.Text = datos[3];
                                break;
                            case 4:
                                tCell.Text = datos[4];
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
    }
}