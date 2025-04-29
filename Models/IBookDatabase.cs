public interface IBookDatabase
{
    void AddBook(Book book);
    void RemoveBook(int id);
    Book GetBook(int id);
    List<Book> GetAllBooks();
}