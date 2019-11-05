using Roman.Domains;
using Roman.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Repositories
{
    public class LoginRepository
    {
        public Usuarios Login(LoginViewModel login)
        {
            using(RomanContext ctx = new RomanContext())
            {
                Usuarios usuarioBuscado = ctx.Usuarios.FirstOrDefault(x => x.Email == login.Email && x.Senha == login.Senha);
                if (usuarioBuscado == null)
                {
                    return null;
                } return usuarioBuscado;
            }
        }
    }
}
