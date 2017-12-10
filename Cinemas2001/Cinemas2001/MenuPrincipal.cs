using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinemas2001.Logica_Negocio;

namespace Cinemas2001
{
    public partial class MenuPrincipal : Form
    {
        LN_Cinemas2001 iLN = new LN_Cinemas2001();

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (iLN.fn_Cerrar_Sesion())
            {
                MessageBox.Show("Sesión Cerrada", "Cerrar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Login().ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("E R R O R", "Cerrar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
