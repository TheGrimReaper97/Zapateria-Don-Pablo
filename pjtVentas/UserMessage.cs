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
    public partial class UserMessage : Form
    {
        public UserMessage(string nombre)
        {
            InitializeComponent();
            lblmensaje.Text = nombre;

        }

        private void UserMessage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new Frm_Principal();
            formulario.Show();

        }
    }
}
