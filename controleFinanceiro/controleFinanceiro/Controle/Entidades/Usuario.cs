using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controleFinanceiro
{
    public class Usuario
    {
        #region Atributos
        
        public string Nome {get;set;}
        public string Endereco { get; set; }
        public DateTime DataNascimento{get;set;}        
        public string Email { get; set; }
        public string Fone { get; set; }        
        public string Cpf { get; set; }

        public string Login { get; set; }
        public string Senha { get; set; }

        #endregion


        #region Construtor
        public Usuario(string Nome, string Endereco, DateTime DataNascimento,
            string Email, string Fone, string cpf, string Login, string Senha) 
        {
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.DataNascimento = DataNascimento;
            this.Email = Email;
            this.Fone = Fone;
            this.Cpf = cpf;
            this.Login = Login;
            this.Senha = Senha;


        }

        #endregion




    }
}
