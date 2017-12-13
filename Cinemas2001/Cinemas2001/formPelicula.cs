using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinemas2001.Modelo;
using Cinemas2001.Logica_Negocio;

namespace Cinemas2001
{
    public partial class formPelicula : Form
    {

        LN_Cinemas2001 iLN = new LN_Cinemas2001();
        int vIDPelicula;

        public formPelicula()
        {
            InitializeComponent();
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            MO_Pelicula sPelicula = new MO_Pelicula();
            sPelicula.Nombre = cmbPelicula.Text;
            sPelicula = iLN.fn_ConsultarPelicula(sPelicula);
            if (sPelicula != null)
            {
                this.txtNomPelicula.Text = sPelicula.Nombre;
                this.txtDuracion.Text = sPelicula.Duracion.ToString();
                this.txtCategoria.Text = sPelicula.Categoria;
                vIDPelicula = sPelicula.Id;
            }
            else
            {
                MessageBox.Show("E R R O R", "Consulta Película", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void formPelicula_Load(object sender, EventArgs e)
        {
            this.cmbPelicula.DataSource = iLN.fn_Cargar_Peliculas();
            cmbPelicula.SelectedIndex = -1;
            this.txtNomPelicula.Text = "";
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            MO_Pelicula iPelicula = new MO_Pelicula();
            iPelicula.Nombre = this.txtNomPelicula.Text;
            iPelicula.Categoria = this.txtCategoria.Text;
            iPelicula.Duracion = TimeSpan.Parse(this.txtDuracion.Text);
            iPelicula.Id = vIDPelicula;
            if (iLN.fn_ActualizarPelicula(iPelicula))
            {
                MessageBox.Show("Pelicula Actualizada", "Actualización Película", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new MenuAdmin().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("E R R O R", "Actualización Película", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuAdmin().ShowDialog();
            this.Close();
        }
    }
}
