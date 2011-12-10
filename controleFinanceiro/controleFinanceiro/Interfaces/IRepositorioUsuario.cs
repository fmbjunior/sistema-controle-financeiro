using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controleFinanceiro.Interfaces
{
    public interface IRepositorioUsuario
    {
        Usuario Login(String Login,String Senha);
        void inserirUsuario();
        void removerUsuario();
        void auterarUsuario(Usuario usuario);
        void auterarSenha(Usuario usuario);
        Usuario buscaUsuario(string cpf);

    }
}
