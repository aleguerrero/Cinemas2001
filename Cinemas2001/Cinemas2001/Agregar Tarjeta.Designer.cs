namespace Cinemas2001
{
    partial class Agregar_Tarjeta
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
            this.txtBNumTarjeta = new System.Windows.Forms.TextBox();
            this.txtBCVO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarTC = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Tarjeta";
            // 
            // txtBNumTarjeta
            // 
            this.txtBNumTarjeta.Location = new System.Drawing.Point(132, 31);
            this.txtBNumTarjeta.Name = "txtBNumTarjeta";
            this.txtBNumTarjeta.Size = new System.Drawing.Size(221, 20);
            this.txtBNumTarjeta.TabIndex = 1;
            // 
            // txtBCVO
            // 
            this.txtBCVO.Location = new System.Drawing.Point(132, 57);
            this.txtBCVO.Name = "txtBCVO";
            this.txtBCVO.Size = new System.Drawing.Size(71, 20);
            this.txtBCVO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CVO";
            // 
            // btnAgregarTC
            // 
            this.btnAgregarTC.Location = new System.Drawing.Point(109, 93);
            this.btnAgregarTC.Name = "btnAgregarTC";
            this.btnAgregarTC.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTC.TabIndex = 4;
            this.btnAgregarTC.Text = "Agregar";
            this.btnAgregarTC.UseVisualStyleBackColor = true;
            this.btnAgregarTC.Click += new System.EventHandler(this.btnAgregarTC_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(200, 93);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Agregar_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 150);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregarTC);
            this.Controls.Add(this.txtBCVO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBNumTarjeta);
            this.Controls.Add(this.label1);
            this.Name = "Agregar_Tarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_Tarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBNumTarjeta;
        private System.Windows.Forms.TextBox txtBCVO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarTC;
        private System.Windows.Forms.Button btnAtras;
    }
}