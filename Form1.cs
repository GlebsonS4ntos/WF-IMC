using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App71
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double imc = double.Parse(txtPeso.Text) / Math.Pow(double.Parse(txtAltura.Text), 2);
            string resultadoIMC;

            if (imc <= 18.5)
            {
                resultadoIMC = "Abaixo do Peso normal";
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                resultadoIMC = "Peso Normal";
            }
            else if (imc > 24.9 && imc < 29.9)
            {
                resultadoIMC = "Excesso de Peso";
            }
            else if (imc > 29.9 && imc < 34.9)
            {
                resultadoIMC = "Obesidade 1";
            }
            else if (imc > 34.9 && imc < 40)
            {
                resultadoIMC = "Obesidade 2";
            }
            else
            {
                resultadoIMC = "Obesidade 3";
            }

            MessageBox.Show("O valor do IMC é: " + imc.ToString("F2") + ", " + resultadoIMC);
        }
    }
}
