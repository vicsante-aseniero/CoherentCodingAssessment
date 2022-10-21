namespace BooksAPI.Models;

public interface IBookRepository
{
    Book AddBook(string name);
    Book GetBook(string name);
    List<Book> AddBooks(string[] names);
    List<Book> GetAllBooks();
}