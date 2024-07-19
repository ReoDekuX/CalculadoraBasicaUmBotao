using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasicaUmBotao.View
{
    public partial class CalculadoraBasica : Form
    {
        public CalculadoraBasica()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt16(tbx_valor1.Text);
            int valor2 = Convert.ToInt16(tbx_valor2.Text);
            int total = 0;
            string operador = tbx_Operador.Text;

            if (operador == "+")
            {
                total = valor1 + valor2;
            }
            if (operador == "-")
            {
                total = valor1 - valor2;
            }
            if (operador == "/")
            {
                total = valor1 / valor2;
            }
            if (operador == "*")
            {
                total = valor1 * valor2;
            }
            lbl_Display.Text = total.ToString();
        }
    }

}
