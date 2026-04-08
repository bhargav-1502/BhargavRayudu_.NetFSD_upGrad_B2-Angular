using Dapper;
using DataAccessLayer.Context;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DapperContext _context;

        public ContactRepository(DapperContext context)
        {
            _context = context;
        }

        public List<ContactInfo> GetAllContacts()
        {
            var query = @"SELECT c.*, comp.CompanyName, d.DepartmentName
                          FROM ContactInfo c
                          INNER JOIN Company comp ON c.CompanyId = comp.CompanyId
                          INNER JOIN Department d ON c.DepartmentId = d.DepartmentId";

            using var conn = _context.CreateConnection();
            return conn.Query<ContactInfo>(query).ToList();
        }

        public ContactInfo GetContactById(int id)
        {
            using var conn = _context.CreateConnection();
            return conn.QueryFirstOrDefault<ContactInfo>(
                "SELECT * FROM ContactInfo WHERE ContactId=@Id",
                new { Id = id });
        }

        public void AddContact(ContactInfo contact)
        {
            var query = @"INSERT INTO ContactInfo
                        (FirstName, LastName, EmailId, MobileNo, Designation, CompanyId, DepartmentId)
                        VALUES (@FirstName,@LastName,@EmailId,@MobileNo,@Designation,@CompanyId,@DepartmentId)";

            using var conn = _context.CreateConnection();
            conn.Execute(query, contact);
        }

        public void UpdateContact(ContactInfo contact)
        {
            var query = @"UPDATE ContactInfo SET
                        FirstName=@FirstName,
                        LastName=@LastName,
                        EmailId=@EmailId,
                        MobileNo=@MobileNo,
                        Designation=@Designation,
                        CompanyId=@CompanyId,
                        DepartmentId=@DepartmentId
                        WHERE ContactId=@ContactId";

            using var conn = _context.CreateConnection();
            conn.Execute(query, contact);
        }

        public void DeleteContact(int id)
        {
            using var conn = _context.CreateConnection();
            conn.Execute("DELETE FROM ContactInfo WHERE ContactId=@Id", new { Id = id });
        }

        public List<Company> GetCompanies()
        {
            using var conn = _context.CreateConnection();
            return conn.Query<Company>("SELECT * FROM Company").ToList();
        }

        public List<Department> GetDepartments()
        {
            using var conn = _context.CreateConnection();
            return conn.Query<Department>("SELECT * FROM Department").ToList();
        }
    }
}
