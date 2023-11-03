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
    public class DirectorRepository : IGenericRepository<Director>
    {

        private readonly MyDBContext _context;

        public DirectorRepository(MyDBContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            _context.Remove(GetById(id));
        }

        public IEnumerable<Director> GetAll()
        {
            return _context.Directors.ToList();
        }

        public Director GetById(int id)
        {
            return _context.Directors.FirstOrDefault(d => d.ID == id);
        }

        public void Insert(Director director)
        {
            // _movies.Add(movie);
            _context.Directors.Add(director);
            var result = _context.SaveChanges();
        }

        public void Update(Director director)
        {
            _context.Directors.Update(director);
            var result = _context.SaveChanges();
        }
    }
}
