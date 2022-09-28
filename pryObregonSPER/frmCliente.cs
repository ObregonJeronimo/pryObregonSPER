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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //streamwriter para que pueda leer dentro de cliente.txt
            StreamWriter CargaDatos = new StreamWriter("./cliente.txt", true);

            //writeline sirve para escribir dentro del ADD
            CargaDatos.WriteLine(Convert.ToString(txtIDCliente.Text + " " + txtNombreCliente.Text));

            //cierra StreamWriter
            CargaDatos.Close();

            MessageBox.Show("¡Se cargó el cliente con éxito!", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //vaciar
            txtNombreCliente.Text = "";
            txtIDCliente.Text = "";
            txtNombreCliente.Focus();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
