using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories
{
    public class MovieStaticDataRepository : IMovieRepository
    {

        public List<Movie> GetAll()
        {
            return StaticDb.Movies;
        }

        public Movie? GetById(int id) 
        {
            if (id == 0)
            {
                return null;
            }

            return StaticDb.Movies.FirstOrDefault(m => m.Id == id);
        }
        public void Add(Movie movie)
        {
           StaticDb.Movies.Add(movie);
        }

        public void Delete(int id)
        {
            
        }
    }

}
