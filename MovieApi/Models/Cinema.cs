namespace MovieApi.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Hall> Halls { get; set; } = new List<Hall>();
        public List<Film> Films { get; set; } = new List<Film>();
    }
}
