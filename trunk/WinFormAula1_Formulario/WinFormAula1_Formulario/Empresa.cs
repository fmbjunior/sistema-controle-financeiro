using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormAula1_Formulario
{
    public partial class form_empresa : Form
    {
        public  cadastroCliente cadClientes{get;set;}
        public  List<Cliente> clientes{get;set;}

        public form_empresa()
        {
            
        
            InitializeComponent();
            clientes = new List<Cliente>();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            cadClientes = new cadastroCliente(clientes);
            cadClientes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbox_Cliente.Refresh();
            cbox_Cliente.DataSource = clientes;
            cbox_Cliente.DisplayMember = "nome";
            
        }

      
    }
}
