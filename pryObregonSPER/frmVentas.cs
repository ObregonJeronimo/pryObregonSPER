using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryObregonSPER
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            StreamReader IDcliente = new StreamReader("./cliente.txt");
            StreamReader IDvendedor = new StreamReader("./vendedor.txt");

            char separador = Convert.ToChar(" ");

            while (!IDcliente.EndOfStream)
            {
                string[] cliente = IDcliente.ReadLine().Split(separador);
                cboIDCliente.Items.Add(cliente[0]);
            }
            while (!IDvendedor.EndOfStream)
            {
                string[] vendedor = IDvendedor.ReadLine().Split(separador);
                cboIDVendedor.Items.Add(vendedor[0]);
            }

            IDcliente.Close();
            IDvendedor.Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TextWriter writeVentas = new StreamWriter("./ventas.txt", true);

            writeVentas.WriteLine(Convert.ToString("ID del Cliente: " + cboIDCliente.Text + "\nID del Vendedor: " + cboIDVendedor.Text + "\nTipo de Factura: " + cboTipoFactura.Text + "\nNumero de factura: " + txtNumeroFactura.Text + "\nMonto: " + txtMontoFactura.Text + "\nFecha: " + dtpFecha.Text + "\n" + "-------------------------------------"));
            writeVentas.Close();

            DialogResult datos = MessageBox.Show("¡Se han registrado los datos!" + "\n¿Desea registrar nuevamente mas datos?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (datos == DialogResult.Yes)
            {
                cboIDCliente.Text = "";
                cboIDVendedor.Text = "";
                cboTipoFactura.Text = "";
                txtNumeroFactura.Text = "";
                txtMontoFactura.Text = "";
            }
            if (datos == DialogResult.No)
            {
                this.Close();
            }
        }

        private void txtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtMontoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
    }
}