namespace PhoneBook.Models
{
    public class PhoneList
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }

    }
}
