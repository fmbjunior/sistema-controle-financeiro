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
    public partial class cadastroCliente : Form
    {
        Cliente cliente;
        public List<Cliente> clientes { get; set; }


        public cadastroCliente(List<Cliente> clientes)
        {
            
            InitializeComponent();
            this.clientes = clientes;
        }



        private void button1_Click(object sender, EventArgs e)
        {
             cliente = new Cliente(tb_Nome.Text,tb_Endereco.Text,tb_email.Text,tb_telefone.Text);
             clientes.Add(cliente);
             Close();
             


        }

        private void cadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
