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
            this.mO_UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarjeta_CreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarjeta_CreditoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarT = new System.Windows.Forms.Button();
            this.btnEliminarT = new System.Windows.Forms.Button();
            this.btnEditarT = new System.Windows.Forms.Button();
            this.btnAtrasT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaCreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mO_UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjeta_CreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjeta_CreditoDataGridView)).BeginInit();
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
            // mO_UsuarioBindingSource
            // 
            this.mO_UsuarioBindingSource.DataSource = typeof(Cinemas2001.Modelo.MO_Usuario);
            // 
            // tarjeta_CreditoBindingSource
            // 
            this.tarjeta_CreditoBindingSource.DataSource = typeof(Cinemas2001.Modelo.Tarjeta_Credito);
            // 
            // tarjeta_CreditoDataGridView
            // 
            this.tarjeta_CreditoDataGridView.AutoGenerateColumns = false;
            this.tarjeta_CreditoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarjeta_CreditoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.tarjeta_CreditoDataGridView.DataSource = this.tarjeta_CreditoBindingSource;
            this.tarjeta_CreditoDataGridView.Location = new System.Drawing.Point(34, 38);
            this.tarjeta_CreditoDataGridView.Name = "tarjeta_CreditoDataGridView";
            this.tarjeta_CreditoDataGridView.RowTemplate.Height = 24;
            this.tarjeta_CreditoDataGridView.Size = new System.Drawing.Size(343, 224);
            this.tarjeta_CreditoDataGridView.TabIndex = 0;
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
            // btnAgregarT
            // 
            this.btnAgregarT.Location = new System.Drawing.Point(69, 296);
            this.btnAgregarT.Name = "btnAgregarT";
            this.btnAgregarT.Size = new System.Drawing.Size(131, 28);
            this.btnAgregarT.TabIndex = 1;
            this.btnAgregarT.Text = "Agregar Tarjeta";
            this.btnAgregarT.UseVisualStyleBackColor = true;
            // 
            // btnEliminarT
            // 
            this.btnEliminarT.Location = new System.Drawing.Point(210, 296);
            this.btnEliminarT.Name = "btnEliminarT";
            this.btnEliminarT.Size = new System.Drawing.Size(131, 28);
            this.btnEliminarT.TabIndex = 2;
            this.btnEliminarT.Text = "Eliminar Tarjeta";
            this.btnEliminarT.UseVisualStyleBackColor = true;
            // 
            // btnEditarT
            // 
            this.btnEditarT.Location = new System.Drawing.Point(69, 346);
            this.btnEditarT.Name = "btnEditarT";
            this.btnEditarT.Size = new System.Drawing.Size(131, 28);
            this.btnEditarT.TabIndex = 3;
            this.btnEditarT.Text = "Editar Tarjeta";
            this.btnEditarT.UseVisualStyleBackColor = true;
            // 
            // btnAtrasT
            // 
            this.btnAtrasT.Location = new System.Drawing.Point(210, 346);
            this.btnAtrasT.Name = "btnAtrasT";
            this.btnAtrasT.Size = new System.Drawing.Size(131, 28);
            this.btnAtrasT.TabIndex = 4;
            this.btnAtrasT.Text = "Atrás";
            this.btnAtrasT.UseVisualStyleBackColor = true;
            // 
            // TarjetasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 413);
            this.Controls.Add(this.btnAtrasT);
            this.Controls.Add(this.btnEditarT);
            this.Controls.Add(this.btnEliminarT);
            this.Controls.Add(this.btnAgregarT);
            this.Controls.Add(this.tarjeta_CreditoDataGridView);
            this.Name = "TarjetasForm";
            this.Text = "Tarjetas Registradas";
            this.Load += new System.EventHandler(this.TarjetasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaCreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mO_UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjeta_CreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjeta_CreditoDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView tarjeta_CreditoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnAgregarT;
        private System.Windows.Forms.Button btnEliminarT;
        private System.Windows.Forms.Button btnEditarT;
        private System.Windows.Forms.Button btnAtrasT;
    }
}