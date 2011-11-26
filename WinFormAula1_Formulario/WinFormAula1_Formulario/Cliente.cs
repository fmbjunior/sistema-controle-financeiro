using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormAula1_Formulario
{
    public class Cliente
    {

        public string nome { set; get; }
        public string endereco { set; get; }
        public string email { set; get; }
        public string telefone { set; get; }


        public Cliente(string nome, string endereco, string email, string telefone) 
        {
            this.nome = nome;
            this.endereco = endereco;
            this.email = email;
            this.telefone = telefone;
        }

    }
}
