namespace pryObregonSPER
{
    partial class frmVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFactura = new System.Windows.Forms.Label();
            this.gbxIDs = new System.Windows.Forms.GroupBox();
            this.cboIDVendedor = new System.Windows.Forms.ComboBox();
            this.cboIDCliente = new System.Windows.Forms.ComboBox();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.gbxFactura = new System.Windows.Forms.GroupBox();
            this.txtMontoFactura = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.lblNumeroDeFactura = new System.Windows.Forms.Label();
            this.gbxIDs.SuspendLayout();
            this.gbxFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(12, 262);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(413, 32);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Registrar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 227);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(105, 18);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha Actual";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(123, 227);
            this.dtpFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(237, 20);
            this.dtpFecha.TabIndex = 15;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(55, 25);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(41, 18);
            this.lblFactura.TabIndex = 14;
            this.lblFactura.Text = "Tipo";
            // 
            // gbxIDs
            // 
            this.gbxIDs.Controls.Add(this.cboIDVendedor);
            this.gbxIDs.Controls.Add(this.cboIDCliente);
            this.gbxIDs.Controls.Add(this.lblClienteID);
            this.gbxIDs.Controls.Add(this.lblVendedorID);
            this.gbxIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxIDs.Location = new System.Drawing.Point(12, 12);
            this.gbxIDs.Name = "gbxIDs";
            this.gbxIDs.Size = new System.Drawing.Size(413, 91);
            this.gbxIDs.TabIndex = 17;
            this.gbxIDs.TabStop = false;
            this.gbxIDs.Text = "ID Cliente y Vendedor";
            // 
            // cboIDVendedor
            // 
            this.cboIDVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDVendedor.FormattingEnabled = true;
            this.cboIDVendedor.Location = new System.Drawing.Point(249, 54);
            this.cboIDVendedor.Name = "cboIDVendedor";
            this.cboIDVendedor.Size = new System.Drawing.Size(121, 21);
            this.cboIDVendedor.TabIndex = 1;
            // 
            // cboIDCliente
            // 
            this.cboIDCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDCliente.FormattingEnabled = true;
            this.cboIDCliente.Location = new System.Drawing.Point(49, 54);
            this.cboIDCliente.Name = "cboIDCliente";
            this.cboIDCliente.Size = new System.Drawing.Size(121, 21);
            this.cboIDCliente.TabIndex = 0;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteID.Location = new System.Drawing.Point(69, 26);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(81, 18);
            this.lblClienteID.TabIndex = 2;
            this.lblClienteID.Text = "ID Cliente";
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorID.Location = new System.Drawing.Point(258, 26);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(100, 18);
            this.lblVendedorID.TabIndex = 3;
            this.lblVendedorID.Text = "ID Vendedor";
            // 
            // gbxFactura
            // 
            this.gbxFactura.Controls.Add(this.txtMontoFactura);
            this.gbxFactura.Controls.Add(this.lblMonto);
            this.gbxFactura.Controls.Add(this.txtNumeroFactura);
            this.gbxFactura.Controls.Add(this.lblFactura);
            this.gbxFactura.Controls.Add(this.cboTipoFactura);
            this.gbxFactura.Controls.Add(this.lblNumeroDeFactura);
            this.gbxFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFactura.Location = new System.Drawing.Point(12, 109);
            this.gbxFactura.Name = "gbxFactura";
            this.gbxFactura.Size = new System.Drawing.Size(413, 105);
            this.gbxFactura.TabIndex = 18;
            this.gbxFactura.TabStop = false;
            this.gbxFactura.Text = "Factura";
            // 
            // txtMontoFactura
            // 
            this.txtMontoFactura.Location = new System.Drawing.Point(281, 55);
            this.txtMontoFactura.Name = "txtMontoFactura";
            this.txtMontoFactura.Size = new System.Drawing.Size(121, 20);
            this.txtMontoFactura.TabIndex = 9;
            this.txtMontoFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoFactura_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(314, 25);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(56, 18);
            this.lblMonto.TabIndex = 10;
            this.lblMonto.Text = "Monto";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(148, 56);
            this.txtNumeroFactura.MaxLength = 4;
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroFactura.TabIndex = 6;
            this.txtNumeroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroFactura_KeyPress);
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Items.AddRange(new object[] {
            "Factura A",
            "Factura B",
            "Factura C",
            "Factura M",
            "Factura E",
            "Factura T"});
            this.cboTipoFactura.Location = new System.Drawing.Point(11, 55);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(121, 21);
            this.cboTipoFactura.TabIndex = 4;
            // 
            // lblNumeroDeFactura
            // 
            this.lblNumeroDeFactura.AutoSize = true;
            this.lblNumeroDeFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeFactura.Location = new System.Drawing.Point(175, 25);
            this.lblNumeroDeFactura.Name = "lblNumeroDeFactura";
            this.lblNumeroDeFactura.Size = new System.Drawing.Size(68, 18);
            this.lblNumeroDeFactura.TabIndex = 7;
            this.lblNumeroDeFactura.Text = "Número";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 307);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.gbxIDs);
            this.Controls.Add(this.gbxFactura);
            this.Name = "frmVentas";
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbxIDs.ResumeLayout(false);
            this.gbxIDs.PerformLayout();
            this.gbxFactura.ResumeLayout(false);
            this.gbxFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.GroupBox gbxIDs;
        private System.Windows.Forms.ComboBox cboIDVendedor;
        private System.Windows.Forms.ComboBox cboIDCliente;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.GroupBox gbxFactura;
        private System.Windows.Forms.TextBox txtMontoFactura;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.Label lblNumeroDeFactura;
    }
}

