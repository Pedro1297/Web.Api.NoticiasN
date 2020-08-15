using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class Administrador
    {
        public int IdAdministrador { get; set; }
        public int? IdRol { get; set; }
        public int? IdEstado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
    }
}
