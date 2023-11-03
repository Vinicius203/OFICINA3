using MovieDB.domain.Entities;
using MovieDB.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.domain.Services
{
    public class ActorService
    {
        private readonly IGenericRepository<Actor> _actor;

        public ActorService(IGenericRepository<Actor> actor)
        {
            _actor = actor;
        }

        public void Insert(Actor actor)
        {
            _actor.Insert(actor);
        }

        public void Update(Actor actor)
        {
            _actor.Update(actor);
        }

        public void Delete(int id)
        {
            _actor.Delete(id);
        }

        public IEnumerable<Actor> GetAll()
        {
            return _actor.GetAll();
        }

        public Actor GetById(int id)
        {
            return _actor.GetById(id);
        }
    }
}
