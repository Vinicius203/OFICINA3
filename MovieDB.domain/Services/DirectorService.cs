using MovieDB.domain.Entities;
using MovieDB.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.domain.Services
{
    public class DirectorService
    {
        private readonly IGenericRepository<Director> _director;

        public DirectorService(IGenericRepository<Director> director)
        {
            _director = director;
        }

        public void Insert(Director director) {
            _director.Insert(director);
        }
    
        public void Update(Director director)
        {
            _director.Update(director);
        }

        public void Delete(int id)
        {
            _director.Delete(id);
        }

        public IEnumerable<Director> GetAll()
        {
            return _director.GetAll();
        }

        public Director GetById(int id)
        {
            return _director.GetById(id);   
        }
    }
}
