using Foro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Dtos
{
    public class ComentarioCreateDto
    {        
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int PublicacionID { get; set; }
        public int UserID { get; set; }

    }
}
