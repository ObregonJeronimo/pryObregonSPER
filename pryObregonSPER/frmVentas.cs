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
            //crear variables para leer los ADD
            StreamReader IDcliente = new StreamReader("./cliente.txt");
            StreamReader IDvendedor = new StreamReader("./vendedor.txt");

            //sirve como un espacio en blanco 
            char separador = Convert.ToChar(" ");

            //mientras IDcliente no llegue a fin de archivo
            while (!IDcliente.EndOfStream)
            {
               //mientras clienteID sea diferente de EOF, leerá el archivo (ReadLine), y lo va a separar
               //usando "separador" del tipo char
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
            //creo streamwriter para poder escribir en el ADD
            StreamWriter writeVentas = new StreamWriter("./ventas.txt", true);

            //writeline sirve para escribir dentro del streamwriter
            writeVentas.WriteLine(Convert.ToString("ID del Cliente: " + cboIDCliente.Text + "\nID del Vendedor: " + cboIDVendedor.Text + "\nTipo de Factura: " + cboTipoFactura.Text + "\nNumero de factura: " + txtNumeroFactura.Text + "\nMonto: " + txtMontoFactura.Text + "\nFecha: " + dtpFecha.Text + "\n" + "-------------------------------------"));
            writeVentas.Close();

            //mensaje con condicion
            DialogResult datos = MessageBox.Show("¡Se han registrado los datos!" + "\n¿Desea registrar nuevamente mas datos?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (datos == DialogResult.Yes)
            {
                cboIDCliente.Text = "";
                cboIDVendedor.Text = "";
                cboTipoFactura.Text = "";
                txtNumeroFactura.Text = "";
                txtMontoFactura.Text = "";
            }
            //si no desea cargar mas datos, cerrar frm
            if (datos == DialogResult.No)
            {
                this.Close();
            }
        }

        private void txtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evento keypress permite restringir el uso de diferentes caracteres,
            //en este caso, del codigo ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //mensaje que solo admite numeros
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