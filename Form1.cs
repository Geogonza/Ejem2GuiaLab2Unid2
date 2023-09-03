using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejem2GuiaLab2Unid2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int LadoA, LadoB, LadoC;
            LadoA = Int32.Parse(txtLadoa.Text);
            LadoB = Int32.Parse(txtLadob.Text);
            LadoC = Int32.Parse(txtLadoc.Text);

            if (LadoA == LadoB && LadoA == LadoC)
            {
                txtTriangulo.Text = "Equilatero";
                MessageBox.Show("El triángulo es equilatero");
            }
            else
            {
                MessageBox.Show("No se puede clasificar el triangulo");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLadoa.Text = " ";
            txtLadob.Text = " ";
            txtLadoc.Text = " ";
            txtTriangulo.Text = " ";
            txtTriangulo.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
