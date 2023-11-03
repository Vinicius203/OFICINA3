using MovieDB.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.domain.Interfaces
{
    public interface IRepositoryActor
    {
        public void Insert(Actor ator);
        public void Delete (int id);
        public void Update (Actor ator);
        public Actor GetById(int id);   
        public IEnumerable<Actor> GetAll();
    }
}
