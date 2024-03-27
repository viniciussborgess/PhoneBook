using PhoneBook.Data.Dtos;
using PhoneBook.Models;

namespace PhoneBook.Repositories
{
    public interface IPhoneBookRepository
    {
        Task<bool> Add(PhoneBookDto request); 
    }
}
