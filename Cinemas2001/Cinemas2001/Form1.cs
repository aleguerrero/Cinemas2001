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
                MenuPrincipal ventana = new MenuPrincipal(iUsuario.Nombre);
                ventana.Closed += (sender1, args) => this.Close();
                ventana.Show();
                this.Hide();
                // ↑ esto es para cargar el siguiente form y darle como la capacidad de cerrar el programa, de otra forma no lo logra.

            } else
            {
                MessageBox.Show("E R R O R", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MO_Usuario pUsuario = new MO_Usuario();
            pUsuario.Nombre = txt_R_Nombre.Text;
            pUsuario.Apellidos = txt_R_Apellidos.Text;
            pUsuario.Username = txt_R_Username.Text;
            pUsuario.Dni = Convert.ToInt32(txt_R_DNI.Text);
            pUsuario.FechaDeNacimiento = Convert.ToDateTime(dtp_R_Fecha.Text);
            pUsuario.Contrasena = txt_R_Contra.Text;

            if (iLn_Login.fn_Registro_Usuario(pUsuario))
            {
                MessageBox.Show("Registro completado exitosamente,\n---Gracias " + txt_R_Nombre.Text + "---");
            }
            else
            {
                MessageBox.Show("Registro NO completado\n\n--Intentalo de Nuevo--");
            }
        }

    }
}
