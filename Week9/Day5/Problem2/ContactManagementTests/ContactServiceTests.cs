using Moq;
using NUnit.Framework;
using ContactManagementApp.Models;
using ContactManagementApp.Interfaces;
using ContactManagementApp.Services;

namespace ContactManagementTests
{
    [TestFixture]
    public class ContactServiceTests
    {
        private Mock<IContactRepository> _mockRepository;
        private ContactService _service;

        [SetUp]
        public void Setup()
        {
            _mockRepository = new Mock<IContactRepository>();
            _service = new ContactService(_mockRepository.Object);
        }

        [Test]
        public void AddContact_ValidContact_CallsRepository()
        {
            // Arrange
            Contact contact = new Contact
            {
                Id = 1,
                Name = "Rakesh",
                Email = "rakesh@gmail.com"
            };

            // Act
            _service.AddContact(contact);

            // Assert
            _mockRepository.Verify(x => x.AddContact(contact), Times.Once);
        }

        [Test]
        public void GetContacts_ReturnsData()
        {
            // Arrange
            List<Contact> contacts = new List<Contact>
            {
                new Contact { Id = 1, Name = "Akash", Email = "akash@gmail.com" },
                new Contact { Id = 2, Name = "Harish", Email = "harish@gmail.com" }
            };

            _mockRepository.Setup(x => x.GetContacts()).Returns(contacts);

            // Act
            List<Contact> result = _service.GetContacts();

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void RemoveContact_ReturnsTrue()
        {
            // Arrange
            _mockRepository.Setup(x => x.RemoveContact(1)).Returns(true);

            // Act
            bool result = _service.RemoveContact(1);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void AddContact_EmptyName_ThrowsException()
        {
            // Arrange
            Contact contact = new Contact
            {
                Id = 1,
                Name = "",
                Email = "test@gmail.com"
            };

            // Act & Assert
            Assert.Throws<Exception>(() => _service.AddContact(contact));
        }
    }
}