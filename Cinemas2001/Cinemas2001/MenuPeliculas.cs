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
    public partial class MenuPeliculas : Form
    {
        LN_Cinemas2001 iLN = new LN_Cinemas2001();
        Boolean first = true;

        public MenuPeliculas()
        {
            InitializeComponent();
        }

        private void MenuPeliculas_Load(object sender, EventArgs e)
        {
            this.cmbPeliculas.DataSource = iLN.fn_Cargar_Peliculas();
            this.cmbPeliculas.SelectedIndex = -1;
            this.cmbSede.SelectedIndex = -1;
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk1.Checked)
            {
                this.cmbF1.Enabled = true;
            } else
            {
                this.cmbF1.Enabled = false;
            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk2.Checked)
            {
                this.cmbF2.Enabled = true;
            }
            else
            {
                this.cmbF2.Enabled = false;
            }
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk3.Checked)
            {
                this.cmbF3.Enabled = true;
            }
            else
            {
                this.cmbF3.Enabled = false;
            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk4.Checked)
            {
                this.cmbF4.Enabled = true;
            }
            else
            {
                this.cmbF4.Enabled = false;
            }
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk5.Checked)
            {
                this.cmbF5.Enabled = true;
            }
            else
            {
                this.cmbF5.Enabled = false;
            }
        }

        private void cmbPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (first == false)
            {
                first = true;
            } else
            {
                this.cmbHorario.DataSource = iLN.fn_Cargar_Horarios(this.cmbPeliculas.Text);
            }
        }

        private void cmbF1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbA1.Enabled = true;
            this.cmbA1.DataSource = iLN.fn_Cargar_Asientos(this.cmbF1.Text, this.cmbSede.Text);
        }

        private void cmbF2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbA2.Enabled = true;
            this.cmbA2.DataSource = iLN.fn_Cargar_Asientos(this.cmbF2.Text, this.cmbSede.Text);
        }

        private void cmbF3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbA3.Enabled = true;
            this.cmbA3.DataSource = iLN.fn_Cargar_Asientos(this.cmbF3.Text, this.cmbSede.Text);
        }

        private void cmbF4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbA4.Enabled = true;
            this.cmbA4.DataSource = iLN.fn_Cargar_Asientos(this.cmbF4.Text, this.cmbSede.Text);
        }

        private void cmbF5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbA5.Enabled = true;
            this.cmbA5.DataSource = iLN.fn_Cargar_Asientos(this.cmbF5.Text, this.cmbSede.Text);
        }
    }
}
