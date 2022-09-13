using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_interes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textnum1.Text);
            double num2 = double.Parse(textnum2.Text);
            double num3 = double.Parse(textnum3.Text);

            string itemSelectd = comboBox1.Text;
            switch (itemSelectd)
            {
                case "Anual":
                    var anual = num1 * num2 * num3;
                    MessageBox.Show(anual.ToString());

                    break;

                case "Mensual":
                    var mensual = num1 * num2 * num3 / 12;
                    MessageBox.Show(mensual.ToString());
                    break;

                case "Diario":
                    var diario = num1 * num2 * num3 / 360;
                    MessageBox.Show(diario.ToString());
                    break;

            }
        }
    }
}
