using Foro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Data
{
    public interface IForoRepo
    {
        bool SaveChanges();

        //Grupos
        IEnumerable<Grupo> GetAllGrupos();
        Grupo GetGrupoById(int id);
        void CreateGrupo(Grupo grupo);

        //Publicaciones
        IEnumerable<Publicacion> GetAllPublicaciones();
        Publicacion GetPublicacionById(int id);
        void CreatePublicacion(Publicacion publicacion);

        //Comentarios
        IEnumerable<Comentario> GetAllComentarios();
        Comentario GetComentarioById(int id);
        void CreateComentario(Comentario comentario);

    }
}
