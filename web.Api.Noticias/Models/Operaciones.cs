using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class Operaciones
    {
        public Operaciones()
        {
            PermisoPorRol = new HashSet<PermisoPorRol>();
        }

        public int IdOperaciones { get; set; }
        public string Nombre { get; set; }
        public int IdModulo { get; set; }

        public virtual Modulo IdModuloNavigation { get; set; }
        public virtual ICollection<PermisoPorRol> PermisoPorRol { get; set; }
    }
}
