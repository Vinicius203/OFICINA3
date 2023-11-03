using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.domain.Interfaces
{
    public interface IGenericRepository<T>
    {
        public void Insert(T entity);
        public void Delete(int id);
        public void Update(T entity);
        public T GetById(int id);
        public IEnumerable<T> GetAll();
    }
}
