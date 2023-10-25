namespace MovieApi.Models
{
    public  class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Session> Sessions { get; set; } = new List<Session>();
        public List<Seats> seats { get; set; } = new List<Seats>();

    }
}
