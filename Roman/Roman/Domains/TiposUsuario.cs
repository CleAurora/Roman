using System;
using System.Collections.Generic;

namespace Roman.Domains
{
    public partial class TiposUsuario
    {
        public TiposUsuario()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdTipo { get; set; }
        public string Nome { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
