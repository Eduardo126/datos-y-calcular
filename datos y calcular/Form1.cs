using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datos_y_calcular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola es mi primer fomulario");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string mensaje = textBox1.Text;
            MessageBox.Show(mensaje);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            double num1 = double.Parse(textnum1.Text);
            double num2 = double.Parse(textnum2.Text);
            var suma = num1 + num2;
            MessageBox.Show(suma.ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string itemSelected = comboBox1.Text;
            MessageBox.Show(itemSelected);
        }

    }
    
}
