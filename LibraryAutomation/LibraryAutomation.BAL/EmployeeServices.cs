using LibraryAutomation.DAL;
using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.BAL
{
    public class EmployeeServices
    {
        private readonly AppDBContext _dbContext;

        public EmployeeServices()
        {
            _dbContext = new AppDBContext();
        }
        public List<Notification> LoadNotifications()
        {
            return _dbContext.Notifications
                             .Include(n => n.User)
                             .OrderByDescending(n => n.NotificationDate)
                             .ToList();
        }
        public void AddEmployee(string name, string surName, string userName, string password, string email, int maritalStatus, string phone, DateTime birthDate, int genderID, string identityNumber, string city, string country, string postalCode, string district, string neighborhood, string branchName)
        {
            var role = GetRole("Employee");
            var branch = GetOrCreateBranch(branchName);
            var employee = CreateEmployee(name, surName, email, maritalStatus, phone, birthDate, genderID, identityNumber, branch.BranchID, role.RoleID, city, country, postalCode, district, neighborhood);

            _dbContext.SaveChanges();

            CreateAddressEmployee(employee.EmployeeID, city, country, postalCode, district, neighborhood);
            _dbContext.SaveChanges();

            var user = new User
            {
                UserName = userName,
                Password = password,
                BranchID = branch.BranchID,
                RoleID = role.RoleID,
                EmployeeID = employee.EmployeeID,
                MemberID = null
            };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
        public void UpdateEmployee(int employeeID, string name, string surName, string userName, string password, string email, int maritalStatus, string phone, DateTime birthDate, int genderID, string identityNumber, string city, string country, string postalCode, string district, string neighborhood, string branchName)
        {
            var employee = _dbContext.Employees.Include(e => e.User).FirstOrDefault(e => e.EmployeeID == employeeID);
            if (employee == null) throw new Exception("Güncellenecek personel bulunamadı.");

            var role = GetRole("Employee");
            var branch = GetOrCreateBranch(branchName);

            UpdateEmployeeDetails(employee, name, surName, email, maritalStatus, phone, birthDate, genderID, identityNumber, branch.BranchID, role.RoleID, city, country, postalCode, district, neighborhood);
            UpdateAddressEmployee(employee.EmployeeID, city, country, postalCode, district, neighborhood);

            if (employee.User != null)
            {
                UpdateUser(employee.User.UserID, userName, password, branch.BranchID, role.RoleID);
            }
            else
            {
                CreateUser(userName, password, branch.BranchID, role.RoleID, employee.EmployeeID, null);
            }
        }
        public (Employee employee, AddressEmployee? address, User? user) GetEmployeeDetails(int employeeID)
        {
            var employee = _dbContext.Employees
                                     .Include(e => e.Branch)
                                     .Include(e => e.Gender)
                                     .Include(e => e.Role)
                                     .Include(e => e.User)
                                     .FirstOrDefault(e => e.EmployeeID == employeeID);

            if (employee == null) throw new Exception("Employee bulunamadı.");

            var address = _dbContext.AddressesEmployee.FirstOrDefault(a => a.EmployeeID == employeeID);
            var user = _dbContext.Users.FirstOrDefault(u => u.EmployeeID == employeeID);

            return (employee, address, user);
        }
        public List<dynamic> GetAllEmployees()
        {
            return _dbContext.Employees
                             .Include(e => e.Gender)
                             .Include(e => e.Branch)
                             .Include(e => e.Role)
                             .Include(e => e.AddressesEmp)
                             .Select(e => new
                             {
                                 e.EmployeeID,
                                 e.Name,
                                 e.LastName,
                                 e.IdentityNumber,
                                 e.BirthDate,
                                 Gender = e.Gender.Name,
                                 Branch = e.Branch.Name,
                                 Role = e.Role.Name,
                                 e.Email,
                                 e.EmployeePhoneNumber,
                                 Addresses = string.Join(", ", e.AddressesEmp.Select(a => $"{a.City}, {a.Country}, {a.District}, {a.Neighborhood} {a.PostalCode}")),
                                 UserName = e.User.UserName,
                                 Password = e.User.Password
                             })
                             .ToList<dynamic>();
        }
        public List<dynamic> SearchEmployees(string searchText)
        {
            searchText = searchText.ToLower();
            return _dbContext.Employees
                             .Include(e => e.Gender)
                             .Include(e => e.Branch)
                             .Include(e => e.Role)
                             .Where(e => e.Name.ToLower().Contains(searchText) ||
                                         e.LastName.ToLower().Contains(searchText) ||
                                         e.IdentityNumber.Contains(searchText) ||
                                         e.EmployeePhoneNumber.Contains(searchText) ||
                                         e.Email.ToLower().Contains(searchText) ||
                                         e.Gender.Name.ToLower().Contains(searchText) ||
                                         e.Branch.Name.ToLower().Contains(searchText) ||
                                         e.Role.Name.ToLower().Contains(searchText) ||
                                         e.User.UserName.ToLower().Contains(searchText) ||
                                         e.User.Password.Contains(searchText))
                             .Select(e => new
                             {
                                 e.EmployeeID,
                                 e.Name,
                                 e.LastName,
                                 e.IdentityNumber,
                                 e.EmployeePhoneNumber,
                                 e.Email,
                                 e.BirthDate,
                                 Gender = e.Gender.Name,
                                 Branch = e.Branch.Name,
                                 Role = e.Role.Name,
                                 UserName = e.User.UserName,
                                 Password = e.User.Password
                             })
                             .OrderBy(e => e.Name)
                             .ToList<dynamic>();
        }
        private Role GetRole(string roleName)
        {
            var role = _dbContext.Roles.FirstOrDefault(r => r.Name == roleName);
            if (role == null) throw new Exception($"{roleName} rolü bulunamadı. Lütfen geçerli bir rol ismi kullanın.");

            return role;
        }
        private Branch GetOrCreateBranch(string branchName)
        {
            var branch = _dbContext.Branches.FirstOrDefault(b => b.Name == branchName);
            if (branch == null)
            {
                var library = _dbContext.Libraries.FirstOrDefault();
                if (library == null) throw new Exception("Library bulunamadı.");

                branch = new Branch { Name = branchName, Location = "Unknown", LibraryID = library.LibraryID };
                _dbContext.Branches.Add(branch);
                _dbContext.SaveChanges();
            }

            return branch;
        }
        private Employee CreateEmployee(string name, string surName, string email, int maritalStatus, string phone, DateTime birthDate, int genderID, string identityNumber, int branchID, int roleID, string city, string country, string postalCode, string district, string neighborhood)
        {
            var employee = new Employee
            {
                Name = name,
                LastName = surName,
                Email = email,
                EmployeePhoneNumber = phone,
                BirthDate = birthDate,
                GenderID = genderID,
                IdentityNumber = identityNumber,
                BranchID = branchID,
                RoleID = roleID,
                MaritalStatus = maritalStatus,
                AddressEmployee = $"{neighborhood}, {district}, {city}, {country}, {postalCode}"
            };
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();

            return employee;
        }
        private void UpdateEmployeeDetails(Employee employee, string name, string surName, string email, int maritalStatus, string phone, DateTime birthDate, int genderID, string identityNumber, int branchID, int roleID, string city, string country, string postalCode, string district, string neighborhood)
        {
            employee.Name = name;
            employee.LastName = surName;
            employee.Email = email;
            employee.EmployeePhoneNumber = phone;
            employee.BirthDate = birthDate;
            employee.GenderID = genderID;
            employee.IdentityNumber = identityNumber;
            employee.BranchID = branchID;
            employee.RoleID = roleID;
            employee.MaritalStatus = maritalStatus;
            employee.AddressEmployee = $"{neighborhood}, {district}, {city}, {country}, {postalCode}";

            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges();
        }
        private void CreateAddressEmployee(int employeeID, string city, string country, string postalCode, string district, string neighborhood)
        {
            var addressEmployee = new AddressEmployee
            {
                City = city,
                Country = country,
                PostalCode = postalCode,
                District = district,
                Neighborhood = neighborhood,
                EmployeeID = employeeID
            };
            _dbContext.AddressesEmployee.Add(addressEmployee);
            _dbContext.SaveChanges();
        }
        private void UpdateAddressEmployee(int employeeID, string city, string country, string postalCode, string district, string neighborhood)
        {
            var addressEmployee = _dbContext.AddressesEmployee.FirstOrDefault(a => a.EmployeeID == employeeID);
            if (addressEmployee != null)
            {
                addressEmployee.City = city;
                addressEmployee.Country = country;
                addressEmployee.PostalCode = postalCode;
                addressEmployee.District = district;
                addressEmployee.Neighborhood = neighborhood;

                _dbContext.AddressesEmployee.Update(addressEmployee);
                _dbContext.SaveChanges();
            }
        }
        private void CreateUser(string userName, string password, int branchID, int roleID, int? employeeID, int? memberID)
        {
            var user = new User
            {
                UserName = userName,
                Password = password,
                BranchID = branchID,
                RoleID = roleID,
                EmployeeID = employeeID,
                MemberID = memberID
            };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
        private void UpdateUser(int? userID, string userName, string password, int branchID, int roleID)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UserID == userID);
            if (user != null)
            {
                user.UserName = userName;
                user.Password = password;
                user.BranchID = branchID;
                user.RoleID = roleID;

                _dbContext.Users.Update(user);
                _dbContext.SaveChanges();
            }
        }
        public void DeleteEmployee(int employeeID)
        {
            var employee = _dbContext.Employees
                .Include(e => e.AddressesEmp)
                .Include(e => e.User)
                .FirstOrDefault(e => e.EmployeeID == employeeID);

            if (employee != null)
            {
                if (employee.AddressesEmp != null && employee.AddressesEmp.Any())
                {
                    _dbContext.AddressesEmployee.RemoveRange(employee.AddressesEmp);
                }

                if (employee.User != null)
                {
                    _dbContext.Users.Remove(employee.User);
                }

                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }
        }
    }
}