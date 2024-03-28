using PhoneBook.Data.Dtos;
using PhoneBook.Models;

namespace PhoneBook.Repositories
{
    public interface IPhoneBookRepository
    {
        Task<bool> Add(PhoneBookDto request);
        Task<ICollection<PhoneBookDto>> GetAll();
        Task<bool> Delete(Guid id);
        Task<bool> Update(PhoneBookDto request);
    }
}
