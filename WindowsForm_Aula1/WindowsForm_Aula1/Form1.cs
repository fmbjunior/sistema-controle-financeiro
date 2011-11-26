using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm_Aula1
{
    public partial class Form1 : Form
    {

        public Form2 Form2 { get; set; }
        public Form1()
        {
            InitializeComponent();

            Form2 = new Form2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            tbSobrenome.Text = tbNome.Text;

            Form2.label1.Text = tbNome.Text;
            Form2.Show();
        }
    }
}
