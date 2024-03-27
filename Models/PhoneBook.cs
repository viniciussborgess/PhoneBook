

namespace PhoneBook.Models
{
    public class PhoneBook
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string State { get; private set; }

        public PhoneBook(string name, string phone, string state)
        {
            Name = name;
            Phone = phone;
            State = state;
        }
    }
}

