using ContactManagementApp.Interfaces;
using ContactManagementApp.Models;

namespace ContactManagementApp.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repository;

        public ContactService(IContactRepository repository)
        {
            _repository = repository;
        }

        public void AddContact(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            if (string.IsNullOrWhiteSpace(contact.Name))
                throw new Exception("Name is required");

            if (string.IsNullOrWhiteSpace(contact.Email))
                throw new Exception("Email is required");

            _repository.AddContact(contact);
        }

        public List<Contact> GetContacts()
        {
            return _repository.GetContacts();
        }

        public bool RemoveContact(int id)
        {
            return _repository.RemoveContact(id);
        }
    }
}