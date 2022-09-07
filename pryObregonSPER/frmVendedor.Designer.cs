namespace pryObregonSPER
{
    partial class frmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedor));
            this.chkComision = new System.Windows.Forms.CheckBox();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtIDVendedor = new System.Windows.Forms.TextBox();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkComision
            // 
            this.chkComision.AutoSize = true;
            this.chkComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComision.Location = new System.Drawing.Point(31, 141);
            this.chkComision.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkComision.Name = "chkComision";
            this.chkComision.Size = new System.Drawing.Size(168, 22);
            this.chkComision.TabIndex = 18;
            this.chkComision.Text = "¿Cobra Comisión?";
            this.chkComision.UseVisualStyleBackColor = true;
            this.chkComision.CheckedChanged += new System.EventHandler(this.chkComision_CheckedChanged);
            // 
            // chkOnline
            // 
            this.chkOnline.AutoSize = true;
            this.chkOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnline.Location = new System.Drawing.Point(31, 109);
            this.chkOnline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkOnline.Name = "chkOnline";
            this.chkOnline.Size = new System.Drawing.Size(75, 22);
            this.chkOnline.TabIndex = 17;
            this.chkOnline.Text = "Online";
            this.chkOnline.UseVisualStyleBackColor = true;
            this.chkOnline.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorID.Location = new System.Drawing.Point(51, 63);
            this.lblVendedorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(110, 15);
            this.lblVendedorID.TabIndex = 16;
            this.lblVendedorID.Text = "ID del Vendedor";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(14, 24);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(147, 15);
            this.lblVendedor.TabIndex = 15;
            this.lblVendedor.Text = "Nombre del Vendedor";
            // 
            // txtIDVendedor
            // 
            this.txtIDVendedor.Location = new System.Drawing.Point(169, 63);
            this.txtIDVendedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIDVendedor.MaxLength = 3;
            this.txtIDVendedor.Name = "txtIDVendedor";
            this.txtIDVendedor.Size = new System.Drawing.Size(116, 21);
            this.txtIDVendedor.TabIndex = 14;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(169, 24);
            this.txtNombreVendedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(116, 21);
            this.txtNombreVendedor.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(168, 182);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(117, 36);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(316, 247);
            this.Controls.Add(this.chkComision);
            this.Controls.Add(this.chkOnline);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtIDVendedor);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmVendedor";
            this.Text = "Registro de Vendedor";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkComision;
        private System.Windows.Forms.CheckBox chkOnline;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtIDVendedor;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Button btnAceptar;
    }
}