namespace FinalProjectWebAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string Director { get; set; }
        public int Runtime { get; set; }

        public Movie() { }

        public Movie(int id, string title, string genre, string releaseDate, string director, int runtime)
        {
            Id = id;
            Title = title;
            Genre = genre;
            ReleaseDate = releaseDate;
            Director = director;
            Runtime = runtime;
        }
    }
}

