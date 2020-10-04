using Foro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Data
{
    public class SqlForoRepo : IForoRepo
    {
        private readonly ForoContext _context;

        public SqlForoRepo(ForoContext context)
        {
            _context = context;
        }

        public void CreateComentario(Comentario comentario)
        {
            if (comentario == null)
            {
                throw new ArgumentNullException(nameof(comentario));
            }

            _context.Comentarios.Add(comentario);
        }

        public void CreateGrupo(Grupo grupo)
        {
            if (grupo == null)
            {
                throw new ArgumentNullException(nameof(grupo));
            }

            _context.Grupos.Add(grupo);
        }

        public void CreatePublicacion(Publicacion publicacion)
        {
            if (publicacion == null)
            {
                throw new ArgumentNullException(nameof(publicacion));
            }

            _context.Publicaciones.Add(publicacion);
        }

        public IEnumerable<Comentario> GetAllComentarios()
        {
            return _context.Comentarios.Include(x => x.Publicacion).Include(x => x.Publicacion.Grupo).ToList();
        }

        public IEnumerable<Grupo> GetAllGrupos()
        {
            return _context.Grupos.ToList();
        }

        public IEnumerable<Publicacion> GetAllPublicaciones()
        {
            return _context.Publicaciones.Include(x => x.Grupo).ToList();
        }

        public Comentario GetComentarioById(int id)
        {
            return _context.Comentarios.Include(x => x.Publicacion).Include(x => x.Publicacion.Grupo).FirstOrDefault(x => x.ComentarioID == id);
        }

        public Grupo GetGrupoById(int id)
        {
            return _context.Grupos.FirstOrDefault(x => x.GrupoID == id);
        }

        public Publicacion GetPublicacionById(int id)
        {
            return _context.Publicaciones.Include(x => x.Grupo).FirstOrDefault(x => x.PublicacionID == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
