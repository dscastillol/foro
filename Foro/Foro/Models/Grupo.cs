using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Models
{
    public class Grupo
    {
        public int GrupoID { get; set; }
        public bool Activo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
