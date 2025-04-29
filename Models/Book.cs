public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public DateTime PublishedDate { get; set; }

    public Book(int id, string title, string author, string genre, DateTime publishedDate)
    {
        Id = id;
        Title = title;
        Author = author;
        Genre = genre;
        PublishedDate = publishedDate;
    }
    public override string ToString()
    {
        return $"{Title} by {Author}, Genre: {Genre}, Published on: {PublishedDate.ToShortDateString()}";
    }
}