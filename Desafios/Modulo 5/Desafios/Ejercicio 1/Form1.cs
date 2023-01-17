using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(numeroDos.Text);
            int n2 = int.Parse(numeroUno.Text);
            int result = n1 + n2;
            resultado.Text = result.ToString(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(numeroDos.Text);
            int n2 = int.Parse(numeroUno.Text);
            int result = n2 - n1;
            
            resultado.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(numeroDos.Text);
            int n2 = int.Parse(numeroUno.Text);
            int result = n1 * n2;
            resultado.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(numeroDos.Text);
            int n2 = int.Parse(numeroUno.Text);
            if (n1 == 0)
            {
                resultado.Text = "Error";
            }
            else
            {
                int result = n2 / n1;
                resultado.Text = result.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            int result = 0;
            int n1 = 0;
            int n2 = 0;

            resultado.Text = result.ToString();
            numeroUno.Text = n1.ToString();
            numeroDos.Text = n2.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
