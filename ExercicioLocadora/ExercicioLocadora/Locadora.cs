using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExercicioLocadora
{
    public partial class Locadora : Form
    {
        ListaFilmes lista { set; get; }
        public Locadora()
        {

            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = new ListaFilmes();
            lista.Show();


        }
    }
}
