using System;

namespace MovieApi.Models
{
    public  class Session 
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public List<Film> Films { get; set; } = new List<Film>();

     
    }
}
