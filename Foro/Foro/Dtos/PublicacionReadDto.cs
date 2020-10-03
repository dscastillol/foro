using Foro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Dtos
{
    public class PublicacionReadDto
    {
        public int PublicacionID { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Contenido { get; set; }
        public int GrupoID { get; set; }
        public int UserID { get; set; }

        public Grupo Grupo { get; set; }

    }
}
