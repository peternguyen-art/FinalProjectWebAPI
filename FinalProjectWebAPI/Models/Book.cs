namespace FinalProjectWebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int YearPublished { get; set; }
        public string Description { get; set; }

        public Book() { }
        public Book(int id, string title, string author, string genre, int yearPublished, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            YearPublished = yearPublished;
            Description = description;
        }
    }
}
