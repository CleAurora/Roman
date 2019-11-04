using Roman.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Repositories
{
    public class TipoUsuarioRepository
    {
        public void Cadastrar(TiposUsuario tipo)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.TiposUsuario.Add(tipo);
                ctx.SaveChanges();
            }
        }

        public List<TiposUsuario> Listar()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.TiposUsuario.ToList();
            }
        }

        public void Deletar(int id)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.TiposUsuario.Remove(ctx.TiposUsuario.Find(id));
                ctx.SaveChanges();
            }
        }

        public void Atualizar(TiposUsuario tipo)
        {
            using (RomanContext ctx = new RomanContext())
            {
                TiposUsuario tipoBuscado = ctx.TiposUsuario.Find(tipo.IdTipo);
                tipoBuscado.Nome = tipo.Nome;
                ctx.TiposUsuario.Update(tipoBuscado);
                ctx.SaveChanges();
            }
        }
    }
}
