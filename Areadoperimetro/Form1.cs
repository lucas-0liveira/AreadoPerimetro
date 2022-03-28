using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio15_03_2022_Areadoperimetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int A, P, b, h;

            h = Convert.ToInt32(txtAltura.Text);
            b = Convert.ToInt32(txtBase.Text);

            //A = Área ---- P = Perimetro
            //b = Base ---- h = Altura

            A = b * h;
            P = (2 * b) + (2 * h);

            MessageBox.Show($"A área é {A} e o perimetro é {P}");
        }
    }
}
