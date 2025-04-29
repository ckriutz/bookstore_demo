public class InMemoryBookDatabase : IBookDatabase
{
    private List<Book> books = new List<Book>();
    private int nextId = 1;

    public void AddBook(Book book)
    {
        book.Id = nextId++;
        books.Add(book);
    }

    public void RemoveBook(int id)
    {
        var book = GetBook(id);
        if (book != null)
        {
            books.Remove(book);
        }
    }

    public Book GetBook(int id)
    {
        return books.FirstOrDefault(b => b.Id == id);
    }

    public List<Book> GetAllBooks()
    {
        return books.ToList();
    }
}