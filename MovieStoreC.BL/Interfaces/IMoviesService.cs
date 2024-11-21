using MovieStoreC.Models.DTO;
using MovieStoreC.Models.DTO.Request;

namespace MovieStoreC.BL.Interfaces
{
    public interface IMoviesService
    {
        List<Movie> GetAll();
        Movie GetById(int id);
        void Add(Movie movie);
        void Delete(int id);
    }
}
