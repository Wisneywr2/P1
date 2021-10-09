using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wesley_isney_de_Jesus_Reis___Prova01
{
    public partial class Form1 : Form
    {
     
       
        string operacao;
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(textBox1.Text);
            double valor2 = Convert.ToDouble(textBox2.Text);
            double resultado = valor1 + valor2;
            textBox3.Text = resultado.ToString();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            double valor1 = Convert.ToDouble(textBox1.Text);
            double valor2 = Convert.ToDouble(textBox2.Text);
            double resultado = valor1 - valor2;
            textBox3.Text = resultado.ToString();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(textBox1.Text);
            double valor2 = Convert.ToDouble(textBox2.Text);
            double resultado = valor1 * valor2;
            textBox3.Text = resultado.ToString();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(textBox1.Text);
            double valor2 = Convert.ToDouble(textBox2.Text);
            double resultado = valor1 / valor2;
            textBox3.Text = resultado.ToString();

        }
    }
}
