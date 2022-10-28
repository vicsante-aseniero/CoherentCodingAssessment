using System;
using System.Collections.Generic;
using System.Text;

using BooksAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BookController : ControllerBase
{
    private readonly IBookRepository _bookRepo;

    public BookController(IBookRepository bookRepo) => _bookRepo = bookRepo;

    [HttpGet(Name = "SearchBook")]
    public string GetBookByName(string name)
    {
        var bookFound = _bookRepo.GetBook(name);

        return bookFound == null ? String.Empty : bookFound.Name;
    }

    [HttpGet(Name = "GetAll")]
    public IEnumerable<Book> GetAllBooks()
    {
        return _bookRepo.GetAllBooks().ToArray();
    }

    [HttpPost(Name = "SaveBook")]
    public void AddBook(string name)
    {
        _bookRepo.AddBook(name);
    }
}
