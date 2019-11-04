using System;
using System.Collections.Generic;

namespace Roman.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Projetos = new HashSet<Projetos>();
        }

        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public int? IdTipo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public TiposUsuario IdTipoNavigation { get; set; }
        public ICollection<Projetos> Projetos { get; set; }
    }
}
