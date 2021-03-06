using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtVentas.Formulario
{
    public partial class frmVender : Form
    {

        private Font printFont;
        private StreamReader streamToPrint;
        public frmVender()
        {
            InitializeComponent();
           
        }
        private void InstalledPrintersCombo()
        {
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                cmbInstalledPrinters.Items.Add(pkInstalledPrinters);

            }
            cmbInstalledPrinters.Text = "PDFLite";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Formulario.frmConsultar f = new frmConsultar("P");
            fil.Show();
            f.ShowDialog();
            fil.Hide();
            try
            {
                if(ClassBT.clsProducto.idProducto.ToString() =="")
                {

                }
                else
                {
                   
                    if (ClassBT.clsProducto.NombreProducto.ToString() == "")
                    {

                    }
                    else
                    {
                        if (ClassBT.clsProducto.Precio.ToString() == "")
                        {

                        }
                        else
                        {
                            txtIdProducto.Text = ClassBT.clsProducto.idProducto.ToString();
                            lblNombre.Text = ClassBT.clsProducto.NombreProducto.ToString();
                            lblPrecio.Text = ClassBT.clsProducto.Precio.ToString();
                        }
                    }
                                         
                }
                
            }
            catch (Exception ex)
            {
 
            }
            
        }

        private void frmVender_Load(object sender, EventArgs e)
        {
            InstalledPrintersCombo();
            cmbInstalledPrinters.SelectedIndex = 0;
            lblFecha.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString()+"/"+ DateTime.Today.Year.ToString();
        }

        string[,] ListaCompra = new string[200, 8];
        int Fila = 0;
       
        /// <summary>


        public void CostoApagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            for (int i = 0; i < Conteo; i++)
            {

                CostoTotal += float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());

               

            }

           lblCostoApagar .Text = CostoTotal.ToString();



       



        }

        /// </summary>






        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbldevolucion.Text = (float.Parse(textBox3.Text)- float.Parse(lblCostoApagar.Text)).ToString();
            }
            catch 
            {
                lbldevolucion.Text = 0.ToString();

            }

        }

        int Conteo;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnven_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Focus();
            }
            else {

                Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
                if (Conteo != 0)
                {

                    //RegistrarCompra

                    try
                    {
                        ClassBT.clsVenta.Fecha = lblFecha.Text;

                        ClassBT.clsVenta.Costo = float.Parse(lblCostoApagar.Text);

                        ClassFunciones.clsFunciones.EjecutaQuery("RV");

                        DataTable d = new DataTable();
                        d = ClassFunciones.clsFunciones.EjecutaQueryConsulta("", "IDV");

                        ClassBT.clsDetallesVenta.IdVentafk = ClassBT.clsVenta.IdVenta = int.Parse(d.Rows[0][0].ToString());


                        for (int i = 0; i < Conteo; i++)
                        {
                            ClassBT.clsDetallesVenta.idProdcutofk = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()); ;
                            ClassBT.clsDetallesVenta.Cantidad = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                            ClassBT.clsDetallesVenta.CostoDetalle = float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

                            ClassFunciones.clsFunciones.EjecutaQuery("RDV");//registra el detalle de la venta 

                        }
                    }
                    catch (Exception a)
                    {

                        MessageBox.Show(a.Message);
                    }


                    ClassFunciones.clsFunciones.CreaTicket Ticket1 = new ClassFunciones.clsFunciones.CreaTicket();

                    Ticket1.TextoCentro("Zapateria-Don Pablo "); //imprime una linea de descripcion
                    Ticket1.TextoCentro("**********************************");

                    Ticket1.TextoIzquierda("Dirc: xxxx");
                    Ticket1.TextoIzquierda("Tel:xxxx ");
                    Ticket1.TextoIzquierda("Rnc: xxxx");
                    Ticket1.TextoIzquierda("");
                    Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                    Ticket1.TextoIzquierda("No Fac:" + ClassBT.clsDetallesVenta.IdVentafk.ToString());
                    Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                    Ticket1.TextoIzquierda("Le Atendio: xxxx");
                    Ticket1.TextoIzquierda("");
                    ClassFunciones.clsFunciones.CreaTicket.LineasGuion();//-------------------------

                    ClassFunciones.clsFunciones.CreaTicket.EncabezadoVenta();
                    ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
                    //Detalle de la factura
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        // Articulo                     //Precio                                    cantidad                            Subtotal
                        Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
                    }


                    ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
                   
                  
                   
                    Ticket1.TextoIzquierda(" ");
                    Ticket1.AgregaTotales("Total", double.Parse(lblCostoApagar.Text)); // imprime linea con total
                    Ticket1.TextoIzquierda(" ");
                    Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(textBox3.Text));
                    Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lbldevolucion.Text));


                    // Ticket1.LineasTotales(); // imprime linea 

                    Ticket1.TextoIzquierda(" ");
                    Ticket1.TextoCentro("**********************************");
                    Ticket1.TextoCentro("*     Gracias por preferirnos    *");
                    Ticket1.TextoCentro("**********************************");
                    Ticket1.TextoIzquierda(" ");

                    Ticket1.ImprimirTiket(cmbInstalledPrinters.Text); //Imprimir




                    Fila = 0;
                    while (dataGridView1.RowCount > 0)//limpia el dgv
                    { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
                    //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();

                    txtIdProducto.Text = lblNombre.Text = txtCantidad.Text = textBox3.Text = "";
                    lblCostoApagar.Text = lbldevolucion.Text = lblPrecio.Text = "0";
                    txtIdProducto.Focus();
                    MessageBox.Show("Gracias por preferirnos");

                }
            }
       
        }

        private void btn_agregarcarrito_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProducto.Text != "" && txtCantidad.Text != "")
                {


                    ListaCompra[Fila, 0] = txtIdProducto.Text;
                    ListaCompra[Fila, 1] = lblNombre.Text;
                    ListaCompra[Fila, 2] = lblPrecio.Text;
                    ListaCompra[Fila, 3] = txtCantidad.Text;
                    ListaCompra[Fila, 4] = (float.Parse(txtCantidad.Text) * float.Parse(lblPrecio.Text)).ToString();



                    dataGridView1.Rows.Add(ListaCompra[Fila, 0], ListaCompra[Fila, 1], ListaCompra[Fila, 2], ListaCompra[Fila, 3], ListaCompra[Fila, 4]);
                    Fila++;// se le agrega uno a la fila para futuras generaciones jejeje
                    txtIdProducto.Text = lblNombre.Text = lblPrecio.Text = txtCantidad.Text = "";

                    txtIdProducto.Focus();

                }
            }
            catch
            {

            }
            CostoApagar();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cmbInstalledPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
