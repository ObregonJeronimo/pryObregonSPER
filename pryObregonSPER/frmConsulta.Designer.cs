namespace pryObregonSPER
{
    partial class frmConsulta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDCliente,
            this.cIDVendedor,
            this.cTipoFactura,
            this.cNumeroFactura,
            this.cMonto,
            this.cFecha});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // cIDCliente
            // 
            this.cIDCliente.HeaderText = "ID Cliente";
            this.cIDCliente.Name = "cIDCliente";
            // 
            // cIDVendedor
            // 
            this.cIDVendedor.HeaderText = "ID Vendedor";
            this.cIDVendedor.Name = "cIDVendedor";
            // 
            // cTipoFactura
            // 
            this.cTipoFactura.HeaderText = "Tipo Factura";
            this.cTipoFactura.Name = "cTipoFactura";
            // 
            // cNumeroFactura
            // 
            this.cNumeroFactura.HeaderText = "Número Factura";
            this.cNumeroFactura.Name = "cNumeroFactura";
            // 
            // cMonto
            // 
            this.cMonto.HeaderText = "Monto";
            this.cMonto.Name = "cMonto";
            // 
            // cFecha
            // 
            this.cFecha.HeaderText = "Fecha";
            this.cFecha.Name = "cFecha";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 357);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
    }
}