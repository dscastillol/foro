using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Models
{
    public class Comentario
    {
        public int ComentarioID { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int PublicacionID { get; set; }
        public int UserID { get; set; }

        public Publicacion Publicacion { get; set; }
    }
}
