using LibrarySystem.Core.Models;

namespace LibrarySystem.Core.Interfaces;

public interface IUserRepository
{
    LibraryUser? GetById(int userId);
}