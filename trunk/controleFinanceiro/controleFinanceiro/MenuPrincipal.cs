using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace controleFinanceiro
{
    public partial class MenuPrincipal : Form
    {
        public CadastroUsuario cadUsuario { get; set; }

        public MenuPrincipal()
        {
           
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadUsuario = new CadastroUsuario();
            cadUsuario.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
