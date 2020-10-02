using Foro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Data
{
    public class ForoContext : DbContext
    {
        public ForoContext(DbContextOptions<ForoContext> opt) : base(opt)
        {

        }

        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}
