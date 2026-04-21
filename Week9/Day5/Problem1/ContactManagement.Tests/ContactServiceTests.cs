using NUnit.Framework;
using ContactManagement.Interfaces;
using ContactManagement.Models;
using ContactManagement.Services;

namespace ContactManagement.Tests.Tests
{
    public class ContactServiceTests
    {
        private IContactService _service;

        [SetUp]
        public void Setup()
        {
            _service = new ContactService();
        }

        [Test]
        public void AddContact_ShouldAddSuccessfully()
        {
            // Arrange
            var contact = new Contact
            {
                Id = 1,
                Name = "Arun",
                Email = "arun@gmail.com"
            };

            // Act
            _service.AddContact(contact);
            var result = _service.GetAllContacts();

            // Assert
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetAllContacts_ShouldNotBeEmpty()
        {
            // Arrange
            _service.AddContact(new Contact
            {
                Id = 2,
                Name = "Raj",
                Email = "raj@gmail.com"
            });

            // Act
            var result = _service.GetAllContacts();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        [Test]
        public void GetContactById_ShouldReturnCorrectContact()
        {
            // Arrange
            _service.AddContact(new Contact
            {
                Id = 3,
                Name = "Kiran",
                Email = "kiran@gmail.com"
            });

            // Act
            var result = _service.GetContactById(3);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Name, Is.EqualTo("Kiran"));
        }

        [Test]
        public void DeleteContact_ShouldRemoveSuccessfully()
        {
            // Arrange
            _service.AddContact(new Contact
            {
                Id = 4,
                Name = "Ram",
                Email = "ram@gmail.com"
            });

            // Act
            var deleted = _service.DeleteContact(4);
            var result = _service.GetContactById(4);

            // Assert
            Assert.IsTrue(deleted);
            Assert.IsNull(result);
        }
    }
}