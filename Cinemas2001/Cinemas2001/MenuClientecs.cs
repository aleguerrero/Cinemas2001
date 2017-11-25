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
    public partial class MenuClientecs : Form
    {
        LN_Login iLogica_Negocio = new LN_Login();
        public MenuClientecs()
        {
            InitializeComponent();
        }

        private void MenuClientecs_Load(object sender, EventArgs e)
        {
            MO_Usuario cUsuario = new MO_Usuario();
            cUsuario = iLogica_Negocio.fn_Usuario_En_Sesión();
            this.lblName.Text = cUsuario.Nombre;
            this.lblApellido.Text = cUsuario.Apellidos;
            this.lblDNI.Text = Convert.ToString(cUsuario.Dni);
            this.lblUsername.Text = cUsuario.Username;
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            CambiarContrasenha cc = new CambiarContrasenha();
            cc.ShowDialog();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal mp = new MenuPrincipal();
            mp.ShowDialog();
            this.Close();
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            this.Hide();
            TarjetasForm tf = new TarjetasForm();
            tf.ShowDialog();
            this.Close();
        }

        private void btnEditarInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarInformacion ei = new EditarInformacion();
            ei.ShowDialog();
            this.Close();
        }
    }
}
