using Microsoft.AspNetCore.Mvc;
using MovieDB.domain.Entities;
using MovieDB.domain.Services;
using MovieDB.infra.Repositories;

namespace MovieDB.WEBAPI.Controllers
{
    [Route("api/actors")]
    public class ActorController : ControllerBase
    {
        private readonly ActorService _actor;

        public ActorController(ActorService actor)
        {
            _actor = actor;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Actor>> Get()
        {
            return _actor.GetAll().ToList();
        }

        [HttpGet("{id}")]

        public ActionResult<Actor> Get(int id)
        {
            var actor = _actor.GetById(id);
            if (actor == null)
            {
                throw new Exception("O ator não foi encontrado!");
            }
            return actor;
        }

        [HttpPost]

        public void Post(Actor actor)
        {
            _actor.Insert(actor);
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            _actor.Delete(id);
        }

    }
}
