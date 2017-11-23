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
    public partial class TarjetasForm : Form
    {
        public TarjetasForm()
        {
            InitializeComponent();
        }

        private void TarjetasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cineDataSet.Tarjeta_Credito' table. You can move, or remove it, as needed.
            this.tarjeta_CreditoTableAdapter.Fill(this.cineDataSet.Tarjeta_Credito);
            // TODO: This line of code loads data into the 'cineDataSet.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.cineDataSet.Ticket);
        }

    }
}
