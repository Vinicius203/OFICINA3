using Microsoft.AspNetCore.Mvc;
using MovieDB.domain.Entities;
using MovieDB.infra.Repositories;

namespace MovieDB.WEBAPI.Controllers
{
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private readonly MovieRepository _movie;

        [HttpGet]

        public ActionResult<IEnumerable<Movie>> Get()
        {
            return _movie.GetAll().ToList();
        }

        [HttpGet("{id}")]
        
        public ActionResult<Movie> Get(int id)
        {
            var movie = _movie.GetById(id);
            if(movie == null)
            {
                throw new Exception("O filme não foi encontrado!");
            }
            return movie;
        }

        [HttpPost]

        public void Post(Movie movie)
        {
            _movie.Insert(movie);
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            _movie.Delete(id);
        }

    }
}
