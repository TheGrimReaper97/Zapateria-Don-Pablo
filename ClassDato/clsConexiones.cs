using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.Types;
using System.Windows.Forms;
using System.Data;

namespace ClassDato
{
  public  class clsConexiones
    {

        public static SqlConnection cnx = new SqlConnection("Server=KATALINAHW; Initial Catalog=DB_Ventas;Integrated Security=True");
        


        public static void EjecutaQuery( string Opcion)
        {
            

            
            SqlCommand cmd = new SqlCommand();

            
            switch (Opcion)
            {

                case "RP":
                    cmd = new SqlCommand($"INSERT INTO producto(NombreProducto, Precio) VALUES ('{ClassBT.clsProducto.NombreProducto}',{ClassBT.clsProducto.Precio})", cnx);
                    break;

                case "RV":
                    cmd = new SqlCommand($"INSERT INTO ventas ( Fecha, Costo) VALUES ('{ClassBT.clsVenta.Fecha}',{ClassBT.clsVenta.Costo})", cnx);
                    break;

                case "RDV":
                    cmd = new SqlCommand($"INSERT INTO detallaventa ( idProductofk, Cantidad, Costo, idVentasfk) VALUES ({ClassBT.clsDetallesVenta.idProdcutofk},{ClassBT.clsDetallesVenta.Cantidad},{ClassBT.clsDetallesVenta.CostoDetalle},{ClassBT.clsDetallesVenta.IdVentafk})", cnx);
                    break;

            }
            
             try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                
            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR: "+e);
            }
            finally { cnx.Close(); }

        }
        public static DataTable EjecutaQueryConsulta(string Dato,string Opcion)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();


            switch (Opcion)
            {

                case "C":
                    da = new SqlDataAdapter("SELECT * FROM producto ", cnx);
                    break;


                case "IDV":
                    da = new SqlDataAdapter("SELECT MAX( idVentas) FROM ventas", cnx);
                    break;

            
                case "CDV":
                    da = new SqlDataAdapter("SELECT idVentas, Fecha, V.Costo, idProducto, NombreProducto, Precio, idProductofk, dv.Cantidad FROM ventas as V , producto as p,detallaventa as dv WHERE V.idVentas=dv.idVentasfk and idProducto=idProductofk", cnx);
                    break;

            }
            try
            {
                cnx.Open();
                da.Fill(dt);
                cnx.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR: " + e);
            }
            finally { cnx.Close(); }
            return dt;

        }

    }
}
