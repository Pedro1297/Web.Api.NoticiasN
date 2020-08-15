using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Noticias = new HashSet<Noticias>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? IdEstado { get; set; }

        public virtual Estados IdEstadoNavigation { get; set; }
        public virtual ICollection<Noticias> Noticias { get; set; }
    }
}
