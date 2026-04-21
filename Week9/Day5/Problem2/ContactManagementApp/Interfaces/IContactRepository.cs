using ContactManagementApp.Models;

namespace ContactManagementApp.Interfaces
{
    public interface IContactRepository
    {
        void AddContact(Contact contact);
        List<Contact> GetContacts();
        bool RemoveContact(int id);
    }
}