using Foro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Dtos
{
    public class PublicacionCreateDto
    {
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Contenido { get; set; }
        public int GrupoID { get; set; }
        public int UserID { get; set; }

        [ForeignKey("GrupoID")]
        public Grupo Grupo { get; set; }
    }
}
