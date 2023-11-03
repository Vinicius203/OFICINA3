using MovieDB.domain.Entities;
using MovieDB.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.domain.Services
{
    public class MovieService
    {
        private readonly IGenericRepository<Movie> _movie;

        public MovieService(IGenericRepository<Movie> movie)
        {
            _movie = movie;
        }

        public void Insert(Movie movie)
        {
            _movie.Insert(movie);
        }

        public void Update(Movie movie)
        {
            _movie.Update(movie);
        }

        public void Delete(int id)
        {
            _movie.Delete(id);
        }

        public IEnumerable<Movie>? GetAll()
        {
            return _movie.GetAll();
        }

        public Movie GetById(int id)
        {
            return _movie.GetById(id);
        }
    }
}
