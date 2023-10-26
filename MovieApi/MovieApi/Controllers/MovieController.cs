using Microsoft.AspNetCore.Mvc;
using MovieApi.Data;
using MovieApi.Interfaces;
using MovieApi.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MovieApi.Controllers
{
    [Route("api/cinema")]
    [ApiController]
    public class MovieController : Controller
    {
        private ICinema _repository;

        public MovieController(ICinema repository)
        {
            _repository = repository;
        }

        [HttpGet("halls")]
        public ActionResult<IEnumerable<Hall>> GetCinemaHalls()
        {
            
            var halls = _repository.GetAllHalls();
            return Json(halls);
        }

        [HttpGet("films")]
        public ActionResult<IEnumerable<Film>> GetFilms()
        {
            var films = _repository.GetAllFilms();
            return Json(films);
        }

        [HttpGet("halls/{id}")]
        public ActionResult<Hall> GetHall(int id)
        {
            var hall = _repository.GetHall(id);
            if (hall == null)
                return NotFound();
            return Json(hall);
        }

        [HttpGet("films/{id}")]
        public ActionResult<Film> GetFilm(int id)
        {
            var film = _repository.GetFilm(id);
            if (film == null)
                return NotFound();
            return Json(film);
        
        }
        [HttpPost("halls")]
        public ActionResult<Hall> CreateHall([FromBody] Hall newHall)
        {
            _repository.PostHall(newHall);
            return Content("Hall created");
        }

        [HttpPost("films")]
        public ActionResult<Film> CreateFilm([FromBody] Film newFilm)
        {
            _repository.PostFilm(newFilm);
            return Content("Film created");
        }

        [HttpPut("halls/{id}")]
        public IActionResult UpdateHall( [FromBody] Hall updatedHall)
        {
            if (_repository.TryPutHall(updatedHall))
            {
                return Content($"Hall with id[{updatedHall}] updated");
            }
            else
            {
                return BadRequest("Not updated");
            }
        }

        [HttpPut("films/{id}")]
        public IActionResult UpdateFilm([FromBody] Film updatedFilm)
        {
            if (_repository.TryPutFilm(updatedFilm))
            {
                return Content($"Film with id[{updatedFilm}] updated");
            }
            else
            {
                return BadRequest("Not updated");
            }
         
        }

        [HttpDelete("halls/{id}")]
        public IActionResult DeleteHall(int id)
        {
            if (_repository.TryDeleteHall(id))
            {
                return Content($"ID:[{id}] hall deleted");
            }
            else
            {
                return BadRequest("Not hall deleted");
            }
       
        }

        [HttpDelete("films/{id}")]
        public IActionResult DeleteFilm(int id)
        {
          
            if (_repository.TryDeleteFilm(id))
            {
                return Content($"ID:[{id}] film deleted");
            }
            else
            {
                return BadRequest("Not film deleted");
            }
        }
    }
}
