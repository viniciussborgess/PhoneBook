using PhoneBook.Data.Dtos;

namespace PhoneBook.Repositories
{
    public interface IPhoneBookRepository
    {
        Task<bool> Add(string name, string phone, string state); 
    }
}
