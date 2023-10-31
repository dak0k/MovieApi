using MovieApi.Models;

namespace MovieApi.Interfaces
{
    public interface ICinema
    {   
        public List<Hall> GetAllHalls();
        public List<Film> GetAllFilms();

        public Hall GetHall(int id);
        public Film GetFilm(int id);
        public void PostHall(Hall hall);

        public void PostFilm(Film film);

        public bool TryPutHall(Hall hall);

        public bool TryPutFilm(Film film);

        public bool TryDeleteHall(int id);
        public bool TryDeleteFilm(int id);
    }
}
