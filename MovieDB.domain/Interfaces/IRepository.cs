using MovieDB.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.domain.Interfaces
{
    public interface IRepository
    {
        public void Insert(Movie movie);
        public void Delete(int id);
        public void Update(Movie movie);
        public Movie GetById(int id);
        public IEnumerable<Movie> GetAll();

    }
}
