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
    public partial class ListaFilmes : Form
    {
        public ListaFilmes()
        {
            InitializeComponent();
        }

        private void ListaFilmes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadora2DataSet2.Filme' table. You can move, or remove it, as needed.
            this.filmeTableAdapter1.Fill(this.locadora2DataSet2.Filme);
        }

        private void filmeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
