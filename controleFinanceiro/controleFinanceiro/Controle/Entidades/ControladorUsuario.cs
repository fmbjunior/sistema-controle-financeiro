using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using controleFinanceiro.Interfaces.Interfaces;

namespace controleFinanceiro.Interfaces.Entidades
{
    public class ControladorUsuario
    {

        private IRepositorioUsuario repUsuario;

        public ControladorUsuario(IRepositorioUsuario repUsuario)
        {
            this.repUsuario = repUsuario;
        }



        // Verifica Login
        Usuario Login(String login, String Senha) 
        {
            return repUsuario.Login(login,Senha);
        }


        
        
        // Altera Usuário
        void auterarUsuario(Usuario usuario)
        {
            repUsuario.auterarUsuario(usuario);
        }

        
        
        // Alterar Senha do Usuário
        void auterarSenha(Usuario usuario) 
        {
            repUsuario.auterarSenha(usuario);
        }


        // Busca usuário
        public Usuario buscarUsuario(string cpf)
        {
            return repUsuario.buscaUsuario(cpf);
        }





    }
}
