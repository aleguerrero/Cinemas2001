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
    public partial class EliminarTarjeta : Form
    {
        LN_Login iLogica_Negocio = new LN_Login();
        public EliminarTarjeta()
        {
            InitializeComponent();
        }

        private void EliminarTarjeta_Load(object sender, EventArgs e)
        {
            cmbSelecTarjeta.DataSource = LN_Login.LTarjetas;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MO_Tarjeta_Credito iTarjeta = new MO_Tarjeta_Credito();
            iTarjeta.Numero_Tarjeta = Convert.ToInt32(cmbSelecTarjeta.SelectedItem.ToString());
            if(iLogica_Negocio.fn_Eliminar_Tarjeta(iTarjeta))
            {
                MessageBox.Show("Tarjeta eliminada con éxito", "Registro Tarjetas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbSelecTarjeta.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Error", "Registro Tarjetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TarjetasForm().ShowDialog();
            this.Close();
        }
    }
}
