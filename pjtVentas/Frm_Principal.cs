using pjtVentas.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtVentas
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }
        private void MostrarFormulario(string opcion)
        {

            Form f = new Form();



            switch (opcion)
            {
                case "V":
                    f = new Formulario.frmVender();
                    break;
                case "NP":
                    f = new Formulario.frmNuevoProducto();
                    break;
                case "C":
                    f = new Formulario.frmConsultar("C");
                    break;
                case "A":
                    //f = new Formulario.frmAyuda();
                    break;
                case "H":
                    f = new Formulario.frmHerramientas();
                    break;


            }

            f.ShowDialog();

        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();           
            fil.Show();
            MostrarFormulario("V");
            fil.Hide();
        }

        private void bt_produc_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            fil.Show();
            MostrarFormulario("NP");
            fil.Hide();
        }

        private void bt_consul_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();         
            fil.Show();
            MostrarFormulario("C");
            fil.Hide();
        }

        private void bt_herramientas_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            fil.Show();
            MostrarFormulario("H");
            fil.Hide();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void elButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
