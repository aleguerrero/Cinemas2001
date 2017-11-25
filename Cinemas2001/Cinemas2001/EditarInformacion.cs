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
    public partial class EditarInformacion : Form
    {

        LN_Login iLogica_Negocio = new LN_Login();

        public EditarInformacion()
        {
            InitializeComponent();
        }

        private void EditarInformacion_Load(object sender, EventArgs e)
        {
            MO_Usuario iUsuario = new MO_Usuario();
            iUsuario = iLogica_Negocio.fn_Usuario_En_Sesión();
            txtNombre.Text = iUsuario.Nombre;
            txtApellidos.Text = iUsuario.Apellidos;
            txtDNI.Text = Convert.ToString(iUsuario.Dni);
            txtUsername.Text = iUsuario.Username;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MO_Usuario iUsuario = new MO_Usuario();
            iUsuario.Nombre = this.txtNombre.Text;
            iUsuario.Apellidos = this.txtApellidos.Text;
            iUsuario.Dni = Convert.ToInt32(this.txtDNI.Text);
            iUsuario.Username = this.txtUsername.Text;
            if (iLogica_Negocio.fn_Editar_Usuario(iUsuario))
            {
                MessageBox.Show("Usuario editado con éxito", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new MenuClientecs().ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("E R R O R", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuClientecs().ShowDialog();
            this.Close();
        }
    }
}
