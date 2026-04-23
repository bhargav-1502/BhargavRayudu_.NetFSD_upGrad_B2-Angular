using ContactManagementCodeQuality.Interfaces;
using ContactManagementCodeQuality.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactManagementCodeQuality.Services
{
    public class ContactService : IContactService
    {
        private readonly List<Contact> contacts = new();

        public void AddContact(Contact contact)
        {
            if (contacts.Any(c => c.Id == contact.Id))
                throw new Exception("ID already exists");

            contacts.Add(contact);
        }

        public bool UpdateContact(int id, string name, string email, string phone)
        {
            Contact? contact = contacts.FirstOrDefault(c => c.Id == id);

            if (contact == null)
                return false;

            contact.Name = name;
            contact.Email = email;
            contact.Phone = phone;
            return true;
        }

        public bool DeleteContact(int id)
        {
            Contact? contact = contacts.FirstOrDefault(c => c.Id == id);

            if (contact == null)
                return false;

            contacts.Remove(contact);
            return true;
        }

        public List<Contact> GetAllContacts()
        {
            return contacts.OrderBy(c => c.Id).ToList();
        }
    }
}