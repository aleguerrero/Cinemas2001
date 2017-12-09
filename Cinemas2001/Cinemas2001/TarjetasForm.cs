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
    public partial class TarjetasForm : Form
    {
        LN_Cinemas2001 iLogica_Negocio = new LN_Cinemas2001();
        public TarjetasForm()
        {
            InitializeComponent();
        }

        private void TarjetasForm_Load(object sender, EventArgs e)
        {
            tbTarjetasC.DataSource = iLogica_Negocio.fn_Consultar_Tarjetas();
        }

        private void btnAtrasT_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuClientecs().ShowDialog();
            this.Close();
        }

        private void btnAgregarT_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Agregar_Tarjeta().ShowDialog();
            this.Close();
        }

        private void btnEliminarT_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EliminarTarjeta().ShowDialog();
            this.Close();
        }

    }
}
