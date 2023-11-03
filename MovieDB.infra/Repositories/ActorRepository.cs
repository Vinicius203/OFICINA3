using MovieDB.domain.Entities;
using MovieDB.domain.Interfaces;
using MovieDB.infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.infra.Repositories
{
    public class ActorRepository : IGenericRepository<Actor>
    {
        private readonly MyDBContext _context;

        public ActorRepository(MyDBContext context)
        {
            _context = context;
        }
    
        public void Delete(int id)
        {
            _context.Remove(GetById(id));   
        }

        public IEnumerable<Actor> GetAll()
        {
            return _context.Actors.ToList();
        }

        public Actor GetById(int id)
        {
            return _context.Actors.FirstOrDefault(a => a.ID == id);
        }

        public void Insert(Actor actor)
        {
            _context.Actors.Add(actor);
            var result = _context.SaveChanges();
        }

        public void Update(Actor actor)
        {
            _context.Actors.Update(actor);
            var result = _context.SaveChanges();
        }
    }
}
