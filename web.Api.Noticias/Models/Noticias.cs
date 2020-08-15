using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class Noticias
    {
        public Noticias()
        {
            Comentarios = new HashSet<Comentarios>();
        }

        public int IdNoticia { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdAutor { get; set; }
        public int? IdCategoria { get; set; }
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Comentarios> Comentarios { get; set; }
    }
}
