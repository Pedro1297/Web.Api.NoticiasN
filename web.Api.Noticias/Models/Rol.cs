using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Administrador = new HashSet<Administrador>();
            PermisoPorRol = new HashSet<PermisoPorRol>();
        }

        public int IdRol { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Administrador> Administrador { get; set; }
        public virtual ICollection<PermisoPorRol> PermisoPorRol { get; set; }
    }
}
