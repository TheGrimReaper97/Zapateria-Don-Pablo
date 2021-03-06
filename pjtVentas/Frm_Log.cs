using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace pjtVentas
{
    public partial class Frm_Log : Form
    {

        SqlConnection cnx = new SqlConnection("Server=KATALINAHW; Initial Catalog=DB_Ventas;Integrated Security=True");

        public Frm_Log()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        public void logear(string usuario, string contrasena)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_Usuario FROM Usuarios WHERE Usuario = @Usuario AND Password = @pas", cnx);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin"){

                        new AdminMessage(dt.Rows[0][0].ToString()).Show();


                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new UserMessage(dt.Rows[0][0].ToString()).Show();

                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }



            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally {

                cnx.Close();


            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Log_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(this.textBox1.Text, this.textBox2.Text);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Frm_Log_MouseDown(object sender, MouseEventArgs e)
        {
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
    }


    }

