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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkComision_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (chkOnline.Checked == true)
            {
                if (chkComision.Checked == true)
                {
                    TextWriter writeVendedor = new StreamWriter("./vendedor.txt", true);

                    writeVendedor.WriteLine(Convert.ToString(txtIDVendedor.Text + " " + txtNombreVendedor.Text + " " + "-Activo: SI-" + " // " + "-Cobra Comisión: SI"));
                    writeVendedor.Close();
                    MessageBox.Show("Vendedor cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (chkComision.Checked == false)
                {
                    TextWriter writeVendedor = new StreamWriter("./vendedor.txt", true);

                    writeVendedor.WriteLine(Convert.ToString(txtIDVendedor.Text + " " + txtNombreVendedor.Text + " " + "-Activo: SI-" + " // " + "-Cobra Comisión: NO"));
                    writeVendedor.Close();
                    MessageBox.Show("¡Se ha cargado el vendedor con éxito!", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}