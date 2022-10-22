namespace BooksAPI.Models;

public interface IBookRepository
{
    public Book AddBook(string name);
    public Book GetBook(string name);
    public List<Book> AddBooks(string[] names);
    public List<Book> GetAllBooks();
}