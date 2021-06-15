using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtVentas.Formulario
{
    public partial class frmHerramientas : Form
    {
        public frmHerramientas()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_produc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
            
        }
    }
}
