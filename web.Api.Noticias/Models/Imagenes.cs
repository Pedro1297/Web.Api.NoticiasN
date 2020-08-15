using System;
using System.Collections.Generic;

namespace web.Api.Noticias.Models
{
    public partial class Imagenes
    {
        public int IdImagen { get; set; }
        public string Nombre { get; set; }
        public byte[] ArchivoImagen { get; set; }
    }
}
