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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuClientecs menu = new MenuClientecs();
            menu.ShowDialog();
            this.Close();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPeliculas().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TablaHistorial().ShowDialog();
            this.Close();
        }
    }
}
