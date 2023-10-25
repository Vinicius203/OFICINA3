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
    public class MovieRepository : IRepository
    {
        private readonly MyDBContext _context;

        public MovieRepository(MyDBContext context) {
            _context = context;
        }
        public void Delete(int id)
        {
            _context.Remove(GetById(id));
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return _context.Movies.FirstOrDefault(m => m.ID == id);
        }

        public void Insert(Movie movie)
        {
            // _movies.Add(movie);
            _context.Movies.Add(movie);
            var result = _context.SaveChanges();
        }

        public void Update(Movie movie)
        {
            _context.Movies.Update(movie);
            var result = _context.SaveChanges();
        }
    }
}
