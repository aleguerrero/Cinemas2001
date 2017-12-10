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
                this.precioLabel.Text = Convert.ToString(3000 + Convert.ToInt16(this.precioLabel.Text));
                this.chk2.Enabled = true;
            } else
            {
                this.cmbF1.Enabled = false;
                this.precioLabel.Text = Convert.ToString(Convert.ToInt16(this.precioLabel.Text) - 3000);
                this.chk2.Enabled = false;
            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk2.Checked)
            {
                this.cmbF2.Enabled = true;
                this.precioLabel.Text = Convert.ToString(3000 + Convert.ToInt16(this.precioLabel.Text));
                this.chk3.Enabled = true;
            }
            else
            {
                this.cmbF2.Enabled = false;
                this.precioLabel.Text = Convert.ToString(Convert.ToInt16(this.precioLabel.Text) - 3000);
                this.chk3.Enabled = false;
            }
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk3.Checked)
            {
                this.cmbF3.Enabled = true;
                this.precioLabel.Text = Convert.ToString(3000 + Convert.ToInt16(this.precioLabel.Text));
                this.chk4.Enabled = true;
            }
            else
            {
                this.cmbF3.Enabled = false;
                this.precioLabel.Text = Convert.ToString(Convert.ToInt16(this.precioLabel.Text) - 3000);
                this.chk4.Enabled = false;
            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk4.Checked)
            {
                this.cmbF4.Enabled = true;
                this.precioLabel.Text = Convert.ToString(3000 + Convert.ToInt16(this.precioLabel.Text));
                this.chk5.Enabled = true;
            }
            else
            {
                this.cmbF4.Enabled = false;
                this.precioLabel.Text = Convert.ToString(Convert.ToInt16(this.precioLabel.Text) - 3000);
                this.chk5.Enabled = false;
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
            this.cmbHorario.Enabled = true;
            this.cmbHorario.DataSource = iLN.fn_Cargar_Horarios(this.cmbPeliculas.Text, this.cmbSede.Text);
        }

        private void cmbF1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbA1.Enabled = true;
            TimeSpan vHorario = TimeSpan.Parse(this.cmbHorario.Text.ToString()); 
            this.cmbA1.DataSource = iLN.fn_Cargar_Asientos(this.cmbF1.Text, this.cmbSede.Text, vHorario, this.cmbPeliculas.Text);
        }

        private void cmbF2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbA2.Enabled = true;
            TimeSpan vHorario = TimeSpan.Parse(this.cmbHorario.Text.ToString());
            this.cmbA2.DataSource = iLN.fn_Cargar_Asientos(this.cmbF2.Text, this.cmbSede.Text, vHorario, this.cmbPeliculas.Text);
        }

        private void cmbF3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbA3.Enabled = true;
            TimeSpan vHorario = TimeSpan.Parse(this.cmbHorario.Text.ToString());
            this.cmbA3.DataSource = iLN.fn_Cargar_Asientos(this.cmbF3.Text, this.cmbSede.Text, vHorario, this.cmbPeliculas.Text);
        }

        private void cmbF4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbA4.Enabled = true;
            TimeSpan vHorario = TimeSpan.Parse(this.cmbHorario.Text.ToString());
            this.cmbA4.DataSource = iLN.fn_Cargar_Asientos(this.cmbF4.Text, this.cmbSede.Text, vHorario, this.cmbPeliculas.Text);
        }

        private void cmbF5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbA5.Enabled = true;
            TimeSpan vHorario = TimeSpan.Parse(this.cmbHorario.Text.ToString());
            this.cmbA5.DataSource = iLN.fn_Cargar_Asientos(this.cmbF5.Text, this.cmbSede.Text, vHorario, this.cmbPeliculas.Text);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int vCantidadCompras = Convert.ToInt16(this.precioLabel.Text) / 3000;
            TimeSpan vHorario = TimeSpan.Parse(this.cmbHorario.Text.ToString());
            for (int i = 0; i < vCantidadCompras; i++)
            {
                switch (i)
                {
                    case 0:
                        if(iLN.fn_Guardar_Campos(Convert.ToInt16(this.cmbA1.Text), this.cmbF1.Text, this.cmbPeliculas.Text, this.cmbSede.Text, vHorario))
                        {
                            MessageBox.Show("Pelicula: " + cmbPeliculas.Text
                                + "\nAsiento: " + cmbF1.Text + cmbA1.Text
                                + "\nHora: " + vHorario
                                + "\nSala: " + iLN.fn_Consulta_Sala(this.cmbPeliculas.Text, vHorario)
                                + "\n\n¡Gracias por preferir Cinemas 2001!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else
                        {
                            MessageBox.Show("E R R O R", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case 1:
                        if (iLN.fn_Guardar_Campos(Convert.ToInt16(this.cmbA2.Text), this.cmbF2.Text, this.cmbPeliculas.Text, this.cmbSede.Text, vHorario))
                        {
                            MessageBox.Show("Pelicula: " + cmbPeliculas.Text
                                + "\nAsiento: " + cmbF2.Text + cmbA2.Text
                                + "\nHora: " + vHorario
                                + "\nSala: " + iLN.fn_Consulta_Sala(this.cmbPeliculas.Text, vHorario)
                                + "\n\n¡Gracias por preferir Cinemas 2001!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("E R R O R", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case 2:
                        if (iLN.fn_Guardar_Campos(Convert.ToInt16(this.cmbA3.Text), this.cmbF3.Text, this.cmbPeliculas.Text, this.cmbSede.Text, vHorario))
                        {
                            MessageBox.Show("Pelicula: " + cmbPeliculas.Text
                                + "\nAsiento: " + cmbF3.Text + cmbA3.Text
                                + "\nHora: " + vHorario
                                + "\nSala: " + iLN.fn_Consulta_Sala(this.cmbPeliculas.Text, vHorario)
                                + "\n\n¡Gracias por preferir Cinemas 2001!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("E R R O R", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case 3:
                        if (iLN.fn_Guardar_Campos(Convert.ToInt16(this.cmbA4.Text), this.cmbF4.Text, this.cmbPeliculas.Text, this.cmbSede.Text, vHorario))
                        {
                            MessageBox.Show("Pelicula: " + cmbPeliculas.Text
                                + "\nAsiento: " + cmbF4.Text + cmbA4.Text
                                + "\nHora: " + vHorario
                                + "\nSala: " + iLN.fn_Consulta_Sala(this.cmbPeliculas.Text, vHorario)
                                + "\n\n¡Gracias por preferir Cinemas 2001!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("E R R O R", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case 4:
                        if (iLN.fn_Guardar_Campos(Convert.ToInt16(this.cmbA5.Text), this.cmbF5.Text, this.cmbPeliculas.Text, this.cmbSede.Text, vHorario))
                        {
                            MessageBox.Show("Pelicula: " + cmbPeliculas.Text
                                + "\nAsiento: " + cmbF5.Text + cmbA5.Text
                                + "\nHora: " + vHorario
                                + "\nSala: " + iLN.fn_Consulta_Sala(this.cmbPeliculas.Text, vHorario)
                                + "\n\n¡Gracias por preferir Cinemas 2001!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("E R R O R", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }

            this.Hide();
            new MenuPrincipal().ShowDialog();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().ShowDialog();
            this.Close();
        }

        private void cmbSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbPeliculas.Enabled = true;
        }

        
    }
}
