using Roman.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Repositories
{
    public class UsuarioRepository
    {
        public void Cadastrar(Usuarios usuario)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }
        }

        public List<Usuarios> Listar()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Usuarios.ToList();
            }
        }

        public void Deletar(int id)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Usuarios.Remove(ctx.Usuarios.Find(id));
                ctx.SaveChanges();
            }
        }

        public void Atualizar(Usuarios usuario)
        {
            using (RomanContext ctx = new RomanContext())
            {
                Usuarios usuarioBuscado = ctx.Usuarios.Find(usuario.IdUsuario);
                usuarioBuscado.Nome = usuario.Nome;
                usuarioBuscado.IdTipo = usuario.IdTipo;
                ctx.Usuarios.Update(usuarioBuscado);
                ctx.SaveChanges();
            }
        }
    }
}
