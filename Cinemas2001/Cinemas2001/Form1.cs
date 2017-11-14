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
    public partial class Login : Form
    {
        LN_Login iLn_Login = new LN_Login();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MO_Usuario oUsuario = new MO_Usuario();
            oUsuario.Username = txtUser.Text;
            oUsuario.Contrasena = txtPass.Text;
            MO_Usuario iUsuario = iLn_Login.fn_LoginUsuario(oUsuario);
            if (iUsuario.Nombre != null)
            {
                MessageBox.Show("Bienvenido " + iUsuario.Nombre + " " + iUsuario.Apellidos, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("E R R O R", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
