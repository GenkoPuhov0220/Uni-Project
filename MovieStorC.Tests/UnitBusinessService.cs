using Moq;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;

namespace MovieStorC.Tests
{

    public class UnitBusinessService
    {
        private readonly Mock<IMovieRepository> _movieRepository;
        private readonly Mock<IActorRepository> _actorRepository;

        public UnitBusinessService() 
        {
            _movieRepository = new Mock<IMovieRepository>();
            _actorRepository = new Mock<IActorRepository>();
        }
        public static List<Movie> movies { get; set; } = new List<Movie>()
        {
            new Movie()
            {
                Id = "1",
                Title = "Test",
                Year = 2016,
                Actors = new List<string>(){ "1", "2" }
            },
            new Movie()
            {
                Id = "2",
                Title = "Test2",
               Year = 2017,
               Actors = new List<string>(){ "2", "3" }
           },
           new Movie()
            {
              Id = "3",
                Title = "Test3",
               Year = 2018,
                Actors = new List<string>(){ "1", "3" }
           }
        };
        public static List<Actor> actors { get; set; } = new List<Actor>()
        {
            new Actor()
            {
                Id = "1",
                Name = "Actor1"
            },
            new Actor()
            {
                Id = "2",
                Name = "Actor2"
            },
            new Actor()
            {
                Id = "3",
                Name = "Actor3"
            }
        };

        [Fact]
        public void GetAllMoviesTets()
        {
            var expectedCount = 2;

            _movieRepository.Setup(x => x.GetAll())
                .Returns(movies);
            _actorRepository.Setup(x => x.GetById(It.IsAny<string>()))
                .Returns((string id) => actors.FirstOrDefault(x => x.Id == id));

            //inject
            var búsinessServices = new BusinessService(
                 _movieRepository.Object,
                 _actorRepository.Object);
           
        }
    }
}