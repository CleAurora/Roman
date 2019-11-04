using Roman.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Repositories
{
    public class TemaRepository
    {
        public void Cadastrar(Temas tema)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Temas.Add(tema);
                ctx.SaveChanges();
            }
        }

        public List<Temas> Listar()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Temas.ToList();
            }
        }

        public void Deletar(int id)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Temas.Remove(ctx.Temas.Find(id));
                ctx.SaveChanges();
            }
        }

        public void Atualizar(Temas tema)
        {
            using (RomanContext ctx = new RomanContext())
            {
                Temas temaBuscado = ctx.Temas.Find(tema.IdTema);
                temaBuscado.Nome = tema.Nome;
                ctx.Temas.Update(temaBuscado);
                ctx.SaveChanges();
            }
        }
    }
}
