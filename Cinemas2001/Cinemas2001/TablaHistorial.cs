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
using Cinemas2001.Modelo;

namespace Cinemas2001
{
    public partial class TablaHistorial : Form
    {

        LN_Cinemas2001 iLN = new LN_Cinemas2001();
        public TablaHistorial()
        {
            InitializeComponent();
        }

        private void TablaHistorial_Load(object sender, EventArgs e)
        {
            this.dataHistorial.DataSource = iLN.fn_Consulta_Historial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().ShowDialog();
            this.Close();
        }
    }
}
