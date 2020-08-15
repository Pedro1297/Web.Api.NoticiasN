using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class Comentarios
    {
        public int IdComentario { get; set; }
        public int? IdNoticia { get; set; }
        public string Comentario { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Noticias IdNoticiaNavigation { get; set; }
    }
}
