using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;
            int numero1 = Convert.ToInt32(num1);
            int numero2 = Convert.ToInt32(num2);
            int resultado = numero1 * numero2;

            MessageBox.Show("La multiplicación es: " + resultado, "Resultado");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
