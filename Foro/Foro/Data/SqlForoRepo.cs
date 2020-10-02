using Foro.Models;
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

        public void CreateGrupo(Grupo grupo)
        {
            if (grupo == null)
            {
                throw new ArgumentNullException(nameof(grupo));
            }

            _context.Grupos.Add(grupo);
        }

        public IEnumerable<Grupo> GetAllGrupos()
        {
            return _context.Grupos.ToList();
        }

        public Grupo GetGrupoById(int id)
        {
            return _context.Grupos.FirstOrDefault(x => x.GrupoID == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
