using LibrarySystem.Core.Models;

namespace LibrarySystem.Core.Interfaces;

public interface ILoanRepository
{
    Loan? GetLoan(int userId, int bookId);
    void Add(Loan loan);
    void Reove(Loan loan);
}