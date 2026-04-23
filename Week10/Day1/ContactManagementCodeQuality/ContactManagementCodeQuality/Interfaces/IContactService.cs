using ContactManagementCodeQuality.Models;
using System.Collections.Generic;

namespace ContactManagementCodeQuality.Interfaces
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        bool UpdateContact(int id, string name, string email, string phone);
        bool DeleteContact(int id);
        List<Contact> GetAllContacts();
    }
}