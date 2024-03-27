using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> Delete(Guid id)
        {
            var result = await _context.Phones.FindAsync(id);
            if (result == null) return false;

            _context.Phones.Remove(result);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<ICollection<PhoneBookDto>> GetAll()
        {
            var result = await _context.Phones.ToListAsync();
            return result.Select(x => new PhoneBookDto
            {
                Id = x.Id,
                Name = x.Name,
                Phone = x.Phone,
                State = x.State
            }).ToList(); 
        }

    }
}
