namespace Cinemas2001
{
    partial class MenuPrincipal
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(42, 41);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(134, 50);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.Location = new System.Drawing.Point(193, 41);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(134, 50);
            this.btnPeliculas.TabIndex = 1;
            this.btnPeliculas.Text = "Películas";
            this.btnPeliculas.UseVisualStyleBackColor = true;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Historial";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cerrar Sesión";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 199);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPeliculas);
            this.Controls.Add(this.btnCliente);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}