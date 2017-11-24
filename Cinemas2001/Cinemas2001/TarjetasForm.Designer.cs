namespace Cinemas2001
{
    partial class TarjetasForm
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
            this.components = new System.ComponentModel.Container();
            this.tarjetaCreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineDataSet = new Cinemas2001.CineDataSet();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new Cinemas2001.CineDataSetTableAdapters.TicketTableAdapter();
            this.tarjeta_CreditoTableAdapter = new Cinemas2001.CineDataSetTableAdapters.Tarjeta_CreditoTableAdapter();
            this.tbTarjetasC = new System.Windows.Forms.DataGridView();
            this.btnAgregarT = new System.Windows.Forms.Button();
            this.btnEliminarT = new System.Windows.Forms.Button();
            this.btnEditarT = new System.Windows.Forms.Button();
            this.btnAtrasT = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjeta_CreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mO_UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaCreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTarjetasC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjeta_CreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mO_UsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tarjetaCreditoBindingSource
            // 
            this.tarjetaCreditoBindingSource.DataMember = "Tarjeta_Credito";
            this.tarjetaCreditoBindingSource.DataSource = this.cineDataSetBindingSource;
            // 
            // cineDataSetBindingSource
            // 
            this.cineDataSetBindingSource.DataSource = this.cineDataSet;
            this.cineDataSetBindingSource.Position = 0;
            // 
            // cineDataSet
            // 
            this.cineDataSet.DataSetName = "CineDataSet";
            this.cineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.cineDataSetBindingSource;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // tarjeta_CreditoTableAdapter
            // 
            this.tarjeta_CreditoTableAdapter.ClearBeforeFill = true;
            // 
            // tbTarjetasC
            // 
            this.tbTarjetasC.AllowUserToAddRows = false;
            this.tbTarjetasC.AllowUserToDeleteRows = false;
            this.tbTarjetasC.AutoGenerateColumns = false;
            this.tbTarjetasC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbTarjetasC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.tbTarjetasC.DataSource = this.tarjeta_CreditoBindingSource;
            this.tbTarjetasC.Enabled = false;
            this.tbTarjetasC.Location = new System.Drawing.Point(26, 31);
            this.tbTarjetasC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTarjetasC.Name = "tbTarjetasC";
            this.tbTarjetasC.RowTemplate.Height = 24;
            this.tbTarjetasC.Size = new System.Drawing.Size(257, 182);
            this.tbTarjetasC.TabIndex = 0;
            // 
            // btnAgregarT
            // 
            this.btnAgregarT.Location = new System.Drawing.Point(52, 240);
            this.btnAgregarT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarT.Name = "btnAgregarT";
            this.btnAgregarT.Size = new System.Drawing.Size(98, 23);
            this.btnAgregarT.TabIndex = 1;
            this.btnAgregarT.Text = "Agregar Tarjeta";
            this.btnAgregarT.UseVisualStyleBackColor = true;
            this.btnAgregarT.Click += new System.EventHandler(this.btnAgregarT_Click);
            // 
            // btnEliminarT
            // 
            this.btnEliminarT.Location = new System.Drawing.Point(158, 240);
            this.btnEliminarT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarT.Name = "btnEliminarT";
            this.btnEliminarT.Size = new System.Drawing.Size(98, 23);
            this.btnEliminarT.TabIndex = 2;
            this.btnEliminarT.Text = "Eliminar Tarjeta";
            this.btnEliminarT.UseVisualStyleBackColor = true;
            // 
            // btnEditarT
            // 
            this.btnEditarT.Location = new System.Drawing.Point(52, 281);
            this.btnEditarT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarT.Name = "btnEditarT";
            this.btnEditarT.Size = new System.Drawing.Size(98, 23);
            this.btnEditarT.TabIndex = 3;
            this.btnEditarT.Text = "Editar Tarjeta";
            this.btnEditarT.UseVisualStyleBackColor = true;
            // 
            // btnAtrasT
            // 
            this.btnAtrasT.Location = new System.Drawing.Point(158, 281);
            this.btnAtrasT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtrasT.Name = "btnAtrasT";
            this.btnAtrasT.Size = new System.Drawing.Size(98, 23);
            this.btnAtrasT.TabIndex = 4;
            this.btnAtrasT.Text = "Atrás";
            this.btnAtrasT.UseVisualStyleBackColor = true;
            this.btnAtrasT.Click += new System.EventHandler(this.btnAtrasT_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Numero_Tarjeta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero_Tarjeta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CVO";
            this.dataGridViewTextBoxColumn3.HeaderText = "CVO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tarjeta_CreditoBindingSource
            // 
            this.tarjeta_CreditoBindingSource.DataSource = typeof(Cinemas2001.Modelo.Tarjeta_Credito);
            // 
            // mO_UsuarioBindingSource
            // 
            this.mO_UsuarioBindingSource.DataSource = typeof(Cinemas2001.Modelo.MO_Usuario);
            // 
            // TarjetasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 336);
            this.Controls.Add(this.btnAtrasT);
            this.Controls.Add(this.btnEditarT);
            this.Controls.Add(this.btnEliminarT);
            this.Controls.Add(this.btnAgregarT);
            this.Controls.Add(this.tbTarjetasC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TarjetasForm";
            this.Text = "Tarjetas Registradas";
            this.Load += new System.EventHandler(this.TarjetasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaCreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTarjetasC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjeta_CreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mO_UsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cineDataSetBindingSource;
        private CineDataSet cineDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private CineDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.BindingSource tarjetaCreditoBindingSource;
        private CineDataSetTableAdapters.Tarjeta_CreditoTableAdapter tarjeta_CreditoTableAdapter;
        private System.Windows.Forms.BindingSource mO_UsuarioBindingSource;
        private System.Windows.Forms.BindingSource tarjeta_CreditoBindingSource;
        private System.Windows.Forms.DataGridView tbTarjetasC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnAgregarT;
        private System.Windows.Forms.Button btnEliminarT;
        private System.Windows.Forms.Button btnEditarT;
        private System.Windows.Forms.Button btnAtrasT;
    }
}