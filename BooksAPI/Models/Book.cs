using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace BooksAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!; // we can also disable the <Nullable>enable</Nullable> to disable in the csproj file
    }

    public enum ReadType
    {
        Completed, Abandoned, Reading
    }
}
