using ContactManagementCodeQuality.Interfaces;
using ContactManagementCodeQuality.Models;
using ContactManagementCodeQuality.Services;
using System;

namespace ContactManagementCodeQuality
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IContactService service = new ContactService();

            Console.WriteLine("Contact Management System");
            Console.WriteLine("-------------------------");

            // Add Contacts
            service.AddContact(new Contact
            {
                Id = 1,
                Name = "Rakesh",
                Email = "rakesh@gmail.com",
                Phone = "9876543210"
            });
            Console.WriteLine("Contact Added Successfully");

            service.AddContact(new Contact
            {
                Id = 2,
                Name = "Rahul",
                Email = "rahul@gmail.com",
                Phone = "9988776655"
            });
            Console.WriteLine("Contact Added Successfully");

            // Update Contact
            service.UpdateContact(2, "Rahul", "rahul@gmail.com", "9123456789");
            Console.WriteLine("Contact Updated Successfully");

            // Delete Contact
            service.DeleteContact(1);
            Console.WriteLine("Contact Deleted Successfully");

            // Display Contacts
            Console.WriteLine();
            Console.WriteLine("Available Contacts");
            Console.WriteLine("-------------------------");

            foreach (Contact item in service.GetAllContacts())
            {
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Email: {item.Email}");
                Console.WriteLine($"Phone: {item.Phone}");
                Console.WriteLine("-------------------------");
            }

            Console.ReadLine();
        }
    }
}