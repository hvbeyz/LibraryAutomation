using LibraryAutomation.DAL;
using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.BAL
{
    public class UserServices
    {
        private readonly AppDBContext _dbContext;

        public UserServices()
        {
            _dbContext = new AppDBContext();
        }
        public User ValidateUser(string username, string password)
        {
            return _dbContext.Users
                .Include(u => u.Role)
                .FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
        public List<UserViewModel> GetAllUsers()
        {
            var employees = _dbContext.Employees
                .Include(e => e.Gender)
                .Include(e => e.Branch)
                .Include(e => e.Role)
                .Include(e => e.User)
                .Select(e => new UserViewModel
                {
                    ID = e.EmployeeID,
                    Name = e.Name,
                    LastName = e.LastName,
                    IdentityNumber = e.IdentityNumber,
                    BirthDate = e.BirthDate,
                    Gender = e.Gender.Name,
                    Branch = e.Branch.Name,
                    Role = e.Role.Name,
                    Email = e.Email,
                    PhoneNumber = e.EmployeePhoneNumber,
                    Addresses = string.Join(", ", e.AddressesEmp.Select(a => $"{a.City}, {a.Country}, {a.District}, {a.Neighborhood} {a.PostalCode}")),
                    UserName = e.User.UserName,
                    Password = e.User.Password
                }).ToList();

            var members = _dbContext.Members
                .Include(m => m.Gender)
                .Include(m => m.Branch)
                .Include(m => m.Role)
                .Include(m => m.User)
                .Select(m => new UserViewModel
                {
                    ID = m.MemberID,
                    Name = m.Name,
                    LastName = m.LastName,
                    IdentityNumber = m.IdentityNumber,
                    BirthDate = m.BirthDate,
                    Gender = m.Gender.Name,
                    Branch = m.Branch.Name,
                    Role = m.Role.Name,
                    Email = m.Email,
                    PhoneNumber = m.MemberPhoneNumber,
                    Addresses = string.Join(", ", m.Addresses.Select(a => $"{a.City}, {a.Country}, {a.District}, {a.Neighborhood} {a.PostalCode}")),
                    UserName = m.User.UserName,
                    Password = m.User.Password
                }).ToList();

            return employees.Concat(members).ToList();
        }
    }
}
