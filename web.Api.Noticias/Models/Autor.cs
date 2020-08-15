using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class Autor
    {
        public Autor()
        {
            Noticias = new HashSet<Noticias>();
        }

        public int IdAutor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Noticias> Noticias { get; set; }
    }
}
