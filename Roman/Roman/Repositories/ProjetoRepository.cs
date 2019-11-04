using Roman.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Repositories
{
    public class ProjetoRepository
    {
        public void Cadastrar(Projetos projeto)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Projetos.Add(projeto);
                ctx.SaveChanges();
            }
        }

        public List<Projetos> Listar()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Projetos.ToList();
            }
        }

        public void Deletar(int id)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Projetos.Remove(ctx.Projetos.Find(id));
                ctx.SaveChanges();
            }
        }

        public void Atualizar(Projetos projeto)
        {
            using (RomanContext ctx = new RomanContext())
            {
                Projetos projetoBuscado = ctx.Projetos.Find(projeto.IdProjeto);
                projetoBuscado.Nome = projeto.Nome;
                projetoBuscado.Descricao = projeto.Descricao;
                projetoBuscado.IdTema = projeto.IdTema;
                projetoBuscado.IdUsuario = projeto.IdUsuario;
                ctx.Projetos.Update(projetoBuscado);
                ctx.SaveChanges();
            }
        }
    }
}
