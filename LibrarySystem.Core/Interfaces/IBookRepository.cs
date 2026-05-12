using LibrarySystem.Core.Models;

namespace LibrarySystem.Core.Interfaces;

public interface IBookRepository
{
    Book? GetBook(int bookId);
    void Update(Book book);
}