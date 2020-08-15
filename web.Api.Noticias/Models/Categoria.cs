using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Noticias = new HashSet<Noticias>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Noticias> Noticias { get; set; }
    }
}
