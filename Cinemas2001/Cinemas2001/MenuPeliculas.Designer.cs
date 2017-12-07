namespace Cinemas2001
{
    partial class MenuPeliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.cmbPeliculas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.Asiento = new System.Windows.Forms.Label();
            this.cmbF1 = new System.Windows.Forms.ComboBox();
            this.cmbA1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbA2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbF2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbA3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbF3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbA4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbF4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbA5 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbF5 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sede";
            // 
            // cmbSede
            // 
            this.cmbSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Items.AddRange(new object[] {
            "San José",
            "Alajuela",
            "Cartago"});
            this.cmbSede.Location = new System.Drawing.Point(164, 30);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(276, 21);
            this.cmbSede.TabIndex = 1;
            // 
            // cmbPeliculas
            // 
            this.cmbPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeliculas.FormattingEnabled = true;
            this.cmbPeliculas.Location = new System.Drawing.Point(164, 57);
            this.cmbPeliculas.Name = "cmbPeliculas";
            this.cmbPeliculas.Size = new System.Drawing.Size(276, 21);
            this.cmbPeliculas.TabIndex = 3;
            this.cmbPeliculas.SelectedIndexChanged += new System.EventHandler(this.cmbPeliculas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Película";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(198, 459);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(279, 459);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horario";
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(164, 84);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(276, 21);
            this.cmbHorario.TabIndex = 7;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(115, 142);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(39, 17);
            this.chk1.TabIndex = 8;
            this.chk1.Text = "#1";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // Asiento
            // 
            this.Asiento.AutoSize = true;
            this.Asiento.Location = new System.Drawing.Point(112, 168);
            this.Asiento.Name = "Asiento";
            this.Asiento.Size = new System.Drawing.Size(23, 13);
            this.Asiento.TabIndex = 9;
            this.Asiento.Text = "Fila";
            // 
            // cmbF1
            // 
            this.cmbF1.AutoCompleteCustomSource.AddRange(new string[] {
            "C",
            "B",
            "A"});
            this.cmbF1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbF1.Enabled = false;
            this.cmbF1.FormattingEnabled = true;
            this.cmbF1.Items.AddRange(new object[] {
            "C",
            "B",
            "A"});
            this.cmbF1.Location = new System.Drawing.Point(141, 165);
            this.cmbF1.Name = "cmbF1";
            this.cmbF1.Size = new System.Drawing.Size(121, 21);
            this.cmbF1.TabIndex = 10;
            this.cmbF1.SelectedIndexChanged += new System.EventHandler(this.cmbF1_SelectedIndexChanged);
            // 
            // cmbA1
            // 
            this.cmbA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbA1.Enabled = false;
            this.cmbA1.FormattingEnabled = true;
            this.cmbA1.Location = new System.Drawing.Point(320, 165);
            this.cmbA1.Name = "cmbA1";
            this.cmbA1.Size = new System.Drawing.Size(121, 21);
            this.cmbA1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Asiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Asiento";
            // 
            // cmbA2
            // 
            this.cmbA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbA2.Enabled = false;
            this.cmbA2.FormattingEnabled = true;
            this.cmbA2.Location = new System.Drawing.Point(320, 215);
            this.cmbA2.Name = "cmbA2";
            this.cmbA2.Size = new System.Drawing.Size(121, 21);
            this.cmbA2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 17;
            // 
            // cmbF2
            // 
            this.cmbF2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbF2.Enabled = false;
            this.cmbF2.FormattingEnabled = true;
            this.cmbF2.Items.AddRange(new object[] {
            "C",
            "B",
            "A"});
            this.cmbF2.Location = new System.Drawing.Point(141, 215);
            this.cmbF2.Name = "cmbF2";
            this.cmbF2.Size = new System.Drawing.Size(121, 21);
            this.cmbF2.TabIndex = 16;
            this.cmbF2.SelectedIndexChanged += new System.EventHandler(this.cmbF2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fila";
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Enabled = false;
            this.chk2.Location = new System.Drawing.Point(115, 192);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(39, 17);
            this.chk2.TabIndex = 14;
            this.chk2.Text = "#2";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Asiento";
            // 
            // cmbA3
            // 
            this.cmbA3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbA3.Enabled = false;
            this.cmbA3.FormattingEnabled = true;
            this.cmbA3.Location = new System.Drawing.Point(320, 265);
            this.cmbA3.Name = "cmbA3";
            this.cmbA3.Size = new System.Drawing.Size(121, 21);
            this.cmbA3.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 23;
            // 
            // cmbF3
            // 
            this.cmbF3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbF3.Enabled = false;
            this.cmbF3.FormattingEnabled = true;
            this.cmbF3.Items.AddRange(new object[] {
            "C",
            "B",
            "A"});
            this.cmbF3.Location = new System.Drawing.Point(141, 265);
            this.cmbF3.Name = "cmbF3";
            this.cmbF3.Size = new System.Drawing.Size(121, 21);
            this.cmbF3.TabIndex = 22;
            this.cmbF3.SelectedIndexChanged += new System.EventHandler(this.cmbF3_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fila";
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Enabled = false;
            this.chk3.Location = new System.Drawing.Point(115, 242);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(39, 17);
            this.chk3.TabIndex = 20;
            this.chk3.Text = "#3";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Asiento";
            // 
            // cmbA4
            // 
            this.cmbA4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbA4.Enabled = false;
            this.cmbA4.FormattingEnabled = true;
            this.cmbA4.Location = new System.Drawing.Point(320, 315);
            this.cmbA4.Name = "cmbA4";
            this.cmbA4.Size = new System.Drawing.Size(121, 21);
            this.cmbA4.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 29;
            // 
            // cmbF4
            // 
            this.cmbF4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbF4.Enabled = false;
            this.cmbF4.FormattingEnabled = true;
            this.cmbF4.Items.AddRange(new object[] {
            "C",
            "B",
            "A"});
            this.cmbF4.Location = new System.Drawing.Point(141, 315);
            this.cmbF4.Name = "cmbF4";
            this.cmbF4.Size = new System.Drawing.Size(121, 21);
            this.cmbF4.TabIndex = 28;
            this.cmbF4.SelectedIndexChanged += new System.EventHandler(this.cmbF4_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(112, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Fila";
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Enabled = false;
            this.chk4.Location = new System.Drawing.Point(115, 292);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(39, 17);
            this.chk4.TabIndex = 26;
            this.chk4.Text = "#4";
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.chk4_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(272, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Asiento";
            // 
            // cmbA5
            // 
            this.cmbA5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbA5.Enabled = false;
            this.cmbA5.FormattingEnabled = true;
            this.cmbA5.Location = new System.Drawing.Point(320, 365);
            this.cmbA5.Name = "cmbA5";
            this.cmbA5.Size = new System.Drawing.Size(121, 21);
            this.cmbA5.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(286, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 35;
            // 
            // cmbF5
            // 
            this.cmbF5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbF5.Enabled = false;
            this.cmbF5.FormattingEnabled = true;
            this.cmbF5.Items.AddRange(new object[] {
            "C",
            "B",
            "A"});
            this.cmbF5.Location = new System.Drawing.Point(141, 365);
            this.cmbF5.Name = "cmbF5";
            this.cmbF5.Size = new System.Drawing.Size(121, 21);
            this.cmbF5.TabIndex = 34;
            this.cmbF5.SelectedIndexChanged += new System.EventHandler(this.cmbF5_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(112, 368);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Fila";
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Enabled = false;
            this.chk5.Location = new System.Drawing.Point(115, 342);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(39, 17);
            this.chk5.TabIndex = 32;
            this.chk5.Text = "#5";
            this.chk5.UseVisualStyleBackColor = true;
            this.chk5.CheckedChanged += new System.EventHandler(this.chk5_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(248, 416);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Precio:";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Location = new System.Drawing.Point(292, 416);
            this.precioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(13, 13);
            this.precioLabel.TabIndex = 39;
            this.precioLabel.Text = "0";
            // 
            // MenuPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(553, 511);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbA5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbF5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.chk5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbA4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbF4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chk4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbA3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbF3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chk3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbA2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbF2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbA1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbF1);
            this.Controls.Add(this.Asiento);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.cmbPeliculas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.label1);
            this.Name = "MenuPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione Sede y Película";
            this.Load += new System.EventHandler(this.MenuPeliculas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.ComboBox cmbPeliculas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Label Asiento;
        private System.Windows.Forms.ComboBox cmbF1;
        private System.Windows.Forms.ComboBox cmbA1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbA2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbF2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbA3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbF3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbA4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbF4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbA5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbF5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label precioLabel;
    }
}