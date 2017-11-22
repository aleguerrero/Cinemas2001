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
    public partial class CambiarContrasenha : Form
    {
        LN_Login iLogica_Negocio = new LN_Login();
        public CambiarContrasenha()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassNew.Text == txtPassNewA.Text)
                {
                    if(iLogica_Negocio.fn_Cambiar_Password(txtPassAnt.Text, txtPassNew.Text)){
                        MessageBox.Show("Contraseña cambiada con éxito", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } catch (Exception c)
            {
                MessageBox.Show("E R R O R\nError " + c, "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuClientecs mc = new MenuClientecs();
            mc.ShowDialog();
            this.Close();
        }
    }
}
