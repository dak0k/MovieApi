namespace MovieApi.Models
{
    public class Film 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Genres> Genres { get; set; } = new List<Genres>();
        public float KinoKzRating { get; set; }
        public float KpRating { get; set; }
        public float ImdbRating { get; set; }
        public string ReleaseDate { get; set; }
        public string CoverUrl { get; set; }

    }
}
