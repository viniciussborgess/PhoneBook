using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook.Data
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options)
        {
        }

        public DbSet<Models.PhoneBook> Phones { get; set; }
    }
}
