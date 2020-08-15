using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class Estados
    {
        public Estados()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdEstado { get; set; }
        public int IdUsuario { get; set; }
        public int IdAdministrador { get; set; }
        public int IdAutor { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
