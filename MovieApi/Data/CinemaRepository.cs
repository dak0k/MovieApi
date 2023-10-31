using Microsoft.OpenApi.Any;
using MovieApi.Models;
using System;
using System.Threading.Tasks;
using Cinema = MovieApi.Models.Cinema;
using ICinema = MovieApi.Interfaces.ICinema;
namespace MovieApi.Data
{
    public class CinemaRepository: ICinema
    {
        private Cinema _cinema = new Cinema();
        
        public Cinema Cinema => _cinema;

        public List<Hall> GetAllHalls()
        {
           
                return Cinema.Halls;
          
        } 
        public List<Film> GetAllFilms()
        {
        
                return Cinema.Films;
           
        }

        public Hall GetHall(int id)
        {
           if(Cinema.Halls.Any(h => h.Id == id))
            {
                return Cinema.Halls[id];
            }
            else
            {
                return null;
            }
        }
        public Film GetFilm(int id)
        {
            if (Cinema.Films.Any(f => f.Id == id))
            {
                return Cinema.Films[id];
            }
            else
            {
                return null;
            }
        }

        public void PostHall(Hall hall)
        {
            Cinema.Halls.Add(hall);
        }

        public void PostFilm(Film film) {
            Cinema.Films.Add(film);
        }

        public bool TryPutHall(Hall hall)
        {
           int hall_id = Cinema.Halls.FindIndex(h => h.Id == hall.Id);
            if (hall_id>=0)
            {
                Hall hall_update = (Hall)hall;

                Cinema.Halls[hall_id] = hall_update;
                return true;

            }
            return false;
        }

        public bool TryPutFilm(Film film)
        {
            int film_id = Cinema.Films.FindIndex(f => f.Id==film.Id);
            if(film_id>=0)
            {
                Film film_update = (Film)film;
                Cinema.Films[film_id] = film_update;
                return true;
            }
            return false;
        }

        public bool TryDeleteHall(int id)
        {
            int hallIndex = Cinema.Halls.FindIndex(h => h.Id == id);
            if (hallIndex >= 0)
            {
                Cinema.Halls.RemoveAt(hallIndex);
                return true;
            }
            return false;
        }

        public bool TryDeleteFilm(int id)
        {
            int filmIndex = Cinema.Films.FindIndex(f => f.Id == id);
            if (filmIndex >= 0)
            {
                Cinema.Films.RemoveAt(filmIndex);
                return true;
            }
            return false;
        }

    }
}
