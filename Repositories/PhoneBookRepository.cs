using PhoneBook.Data;
using PhoneBook.Data.Dtos;
using PhoneBook.Models;
using System.Threading.Tasks;

namespace PhoneBook.Repositories
{
    public class PhoneBookRepository : IPhoneBookRepository
    {
        private readonly PhoneBookContext _context;

        public PhoneBookRepository(PhoneBookContext context)
        {
            _context = context;
        }

        public Task<bool> Add(string name, string phone, string state)
        {
            var phonwBook = new PhoneBook { Name = name, Phone = phone,}
        }
    }
}
