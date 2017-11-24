using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinemas2001
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(String nombre_usuario)
        {
            InitializeComponent();
            
            nombre.Text = "Bienvenido " + nombre_usuario;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login programa = new Login();
            programa.Visible = true;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login ventana = new Login();
            ventana.Closed += (sender1, args) => this.Close();
            ventana.Show();
            this.Hide();
        }
    }
}
