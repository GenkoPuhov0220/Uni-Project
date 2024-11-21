using Microsoft.AspNetCore.Mvc;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        
        private readonly IMoviesService _moviesService;

        public MovieController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
           return  _moviesService.GetAll();
        }
       [HttpGet("GetById")]
        public Movie GetById(int id)
        {
            return _moviesService.GetById(id);
        }
        [HttpPost("AddMovie")]
        public void Add(Movie movie)
        {
            _moviesService.Add(movie);
        }
        [HttpDelete("DeleteMovie")]
        public void Delete(int id)
        {
            var movie = _moviesService.GetById(id);
            if (movie != null)
            {
                _moviesService.Delete(id);
            }
        }
    }
}
