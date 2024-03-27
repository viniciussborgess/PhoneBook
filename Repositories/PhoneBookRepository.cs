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

        public async Task<bool> Add(PhoneBookDto request)
        {
            var phoneList = new PhoneList
            {
                Name = request.Name,
                Phone = request.Phone,
                State = request.State
            };

            _context.Phones.Add(phoneList);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
