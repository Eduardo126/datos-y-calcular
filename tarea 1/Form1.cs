using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);


            string itemSelectd = comboBox1.Text;
            switch (itemSelectd)
            {
                case "Suma":
                    var suma = num1 + num2;
                    MessageBox.Show(suma.ToString());

                    break;

                case "Resta":

                    var resta = num1 - num2;
                    MessageBox.Show(resta.ToString());

                    break;

                case "Multiplicacion":
                    var multiplicacion = num1 * num2;
                    MessageBox.Show(multiplicacion.ToString());

                    break;

                case "Division":
                    var division = num1 / num2;
                    MessageBox.Show(division.ToString());
                    break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
