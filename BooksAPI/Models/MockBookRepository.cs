namespace BooksAPI.Models;

public class MockBookRepository : IBookRepository
{
    private List<Book> _bookList;

    public MockBookRepository()
    {
        _bookList = new List<Book>() 
        {
            new Book() { Id = 1, Name = "Peter Pan" },
            new Book() { Id = 2, Name = "Moby Dick" },
            new Book() { Id = 3, Name = "To Kill a Mockingbird" }
        };
    }

    public Book AddBook(string name)
    {
        Book newBook = new Book() { Id = lastBookId(), Name = name };
        _bookList.Add(newBook);

        return newBook;
    }

    public List<Book> AddBooks(string[] names)
    {
        foreach(string name in names)
        {
            Book newBook = new Book() { Id = lastBookId(), Name = name };
            _bookList.Add(newBook);            
        }

        return _bookList;
    }

    public Book GetBook(string name)
    {
        return _bookList.Where(b => b.Name == name)
                        .Select(b => new Book {
                            Id = b.Id,
                            Name = b.Name}).First();
    }

    public List<Book> GetBooks(string name)
    {
        return _bookList.Where(b => b.Name.Contains(name)).ToList();
    }

    private int lastBookId()
    {
        var lastBookEntered = _bookList.LastOrDefault();
        int lastId = 0;

        if (lastBookEntered != null)
        {
            lastId += lastBookEntered.Id;
        }

        return lastId;
    }
}