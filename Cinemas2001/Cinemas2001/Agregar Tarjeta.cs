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
    public partial class Agregar_Tarjeta : Form
    {
        LN_Login iLogica_Negocio = new LN_Login();
        public Agregar_Tarjeta()
        {
            InitializeComponent();
        }

        private void btnAgregarTC_Click(object sender, EventArgs e)
        {
            MO_Tarjeta_Credito iTarjeta = new MO_Tarjeta_Credito();
            iTarjeta.Numero_Tarjeta = Convert.ToInt32(this.txtBNumTarjeta.Text);
            iTarjeta.Cvo = Convert.ToInt32(this.txtBCVO.Text);
            if (iLogica_Negocio.fn_Registro_Tarjeta(iTarjeta))
            {
                MessageBox.Show("Tarjeta Agregada con éxito", "Registro Tarjetas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBNumTarjeta.Clear();
                this.txtBCVO.Clear();
            } else
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
