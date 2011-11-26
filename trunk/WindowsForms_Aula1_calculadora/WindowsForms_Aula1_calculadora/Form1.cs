using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForms_Aula1_calculadora.Calculadora;

namespace WindowsForms_Aula1_calculadora
{
    public partial class Form1 : Form
    {
        public string num;
        char op;
        Calculadora calc;
        public Form1()
        {

            calc = new Calculadora();

            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            tbContas.Text +="1";
            num = "1";

        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            tbContas.Text += "2";
            num = "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            tbContas.Text += "3";
            num = "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            tbContas.Text += "4";
            num = "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            tbContas.Text += "5";
            num = "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            tbContas.Text += "6";
            num = "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            tbContas.Text += "7";
            num = "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            tbContas.Text += "8";
            num = "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            tbContas.Text += "9";
            num = "9";
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            tbContas.Text += "0";
            num = "0";
        }

        private void bt_ponto_Click(object sender, EventArgs e)
        {
            tbContas.Text += ".";
           

        }

        private void bt_igual_Click(object sender, EventArgs e)
        {
            calc.num1 = Convert.ToDouble(num);
            calc.calcular();
            num=null;
        }

        private void bt_soma_Click(object sender, EventArgs e)
        {
            tbContas.Text += "+";
            calc.num1 = Convert.ToDouble(num);
            num = null;

        }

        private void bt_subtracao_Click(object sender, EventArgs e)
        {

        }

        private void bt_multiplicacao_Click(object sender, EventArgs e)
        {

        }

        private void bt_divisao_Click(object sender, EventArgs e)
        {

        }


      
       
    }
}
