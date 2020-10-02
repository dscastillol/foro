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

        IEnumerable<Grupo> GetAllGrupos();
        Grupo GetGrupoById(int id);
        void CreateGrupo(Grupo grupo);
    }
}
