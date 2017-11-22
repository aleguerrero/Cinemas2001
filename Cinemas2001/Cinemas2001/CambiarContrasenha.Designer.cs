namespace Cinemas2001
{
    partial class CambiarContrasenha
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
            this.txtPassAnt = new System.Windows.Forms.TextBox();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassNewA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite su contraseña anterior";
            // 
            // txtPassAnt
            // 
            this.txtPassAnt.Location = new System.Drawing.Point(225, 24);
            this.txtPassAnt.Name = "txtPassAnt";
            this.txtPassAnt.PasswordChar = '*';
            this.txtPassAnt.Size = new System.Drawing.Size(250, 20);
            this.txtPassAnt.TabIndex = 1;
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(225, 55);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.PasswordChar = '*';
            this.txtPassNew.Size = new System.Drawing.Size(250, 20);
            this.txtPassNew.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite su nueva contraseña";
            // 
            // txtPassNewA
            // 
            this.txtPassNewA.Location = new System.Drawing.Point(225, 86);
            this.txtPassNewA.Name = "txtPassNewA";
            this.txtPassNewA.PasswordChar = '*';
            this.txtPassNewA.Size = new System.Drawing.Size(250, 20);
            this.txtPassNewA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite su nueva contraseña de nuevo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(168, 123);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(265, 123);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // CambiarContrasenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 171);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPassNewA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassAnt);
            this.Controls.Add(this.label1);
            this.Name = "CambiarContrasenha";
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassAnt;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassNewA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAtras;
    }
}