using Microsoft.AspNetCore.Mvc;
using MovieDB.domain.Entities;
using MovieDB.domain.Services;
using MovieDB.infra.Repositories;
using System.IO;

namespace MovieDB.WEBAPI.Controllers
{
    [Route("api/directors")]
    public class DirectorController : ControllerBase
    {
        private readonly DirectorService _director;

        public DirectorController(DirectorService director)
        {
            _director = director;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Director>> Get()
        {
            return _director.GetAll().ToList();
        }

        [HttpGet("{id}")]

        public ActionResult<Director> Get(int id)
        {
            var director = _director.GetById(id);
            if (director == null)
            {
                throw new Exception("O diretor não foi encontrado!");
            }
            return director;
        }

        [HttpPost]

        public void Post(Director director)
        {
            var directorResult = _director.GetById(director.ID);
            if (directorResult == null)
            {
                throw new Exception("Esse diretor já está inserido!");
            }
            _director.Insert(director);
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            var directorResult = _director.GetById(id);
            if (directorResult == null)
            {
                throw new Exception("Esse diretor não existe!");
            }
            _director.Delete(id);
        }

    }
}
