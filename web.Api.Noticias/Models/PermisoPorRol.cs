using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class PermisoPorRol
    {
        public int IdPermiso { get; set; }
        public int? IdRol { get; set; }
        public int IdOperacion { get; set; }

        public virtual Operaciones IdOperacionNavigation { get; set; }
        public virtual Rol IdRolNavigation { get; set; }
    }
}
