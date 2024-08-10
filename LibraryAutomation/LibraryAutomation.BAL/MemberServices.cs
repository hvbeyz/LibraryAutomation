using LibraryAutomation.DAL;
using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.BAL
{
    public class MemberServices
    {
        private readonly AppDBContext _dbContext;

        public MemberServices()
        {
            _dbContext = new AppDBContext();
        }
        public void AddMember(string name, string surName, string userName, string password, string email, string phone, DateTime birthDate, int genderID, string identityNumber, string city, string country, string postalCode, string district, string neighborhood, string branchName)
        {
            var role = GetRole("Member");
            var branch = GetOrCreateBranch(branchName);
            var member = CreateMember(name, surName, email, phone, birthDate, genderID, identityNumber, branch.BranchID, role.RoleID, city, country, postalCode, district, neighborhood);

            CreateAddress(member.MemberID, city, country, postalCode, district, neighborhood);
            CreateUser(userName, password, branch.BranchID, role.RoleID, null, member.MemberID);
        }
        public (Member member, Address address, User user) GetMemberDetails(int memberID)
        {
            var member = _dbContext.Members
                .Include(m => m.Branch)
                .Include(m => m.Gender)
                .Include(m => m.Role)
                .Include(m => m.User)
                .FirstOrDefault(m => m.MemberID == memberID);

            var address = _dbContext.Addresses.FirstOrDefault(a => a.MemberID == memberID);
            var user = _dbContext.Users.FirstOrDefault(u => u.MemberID == memberID);

            return (member, address, user);
        }
        public List<dynamic> GetAllMembers()
        {
            return _dbContext.Members
                .Include(m => m.Gender)
                .Include(m => m.Branch)
                .Include(m => m.Role)
                .Include(m => m.Addresses)
                .Include(m => m.User)
                .Select(m => new
                {
                    m.MemberID,
                    m.Name,
                    m.LastName,
                    m.IdentityNumber,
                    m.BirthDate,
                    Gender = m.Gender.Name,
                    Branch = m.Branch.Name,
                    Role = m.Role.Name,
                    m.Email,
                    m.MemberPhoneNumber,
                    Addresses = string.Join(", ", m.Addresses.Select(a => $"{a.City}, {a.Country}, {a.District}, {a.Neighborhood} {a.PostalCode}")),
                    UserName = m.User.UserName,
                    Password = m.User.Password
                })
                .ToList<dynamic>();
        }
        private Role GetRole(string roleName)
        {
            var role = _dbContext.Roles.FirstOrDefault(r => r.Name == roleName);
            if (role == null)
                throw new Exception($"{roleName} rolü bulunamadı. Lütfen geçerli bir rol ismi kullanın.");

            return role;
        }
        private Branch GetOrCreateBranch(string branchName)
        {
            var branch = _dbContext.Branches.FirstOrDefault(b => b.Name == branchName);
            if (branch == null)
            {
                var library = _dbContext.Libraries.FirstOrDefault();
                if (library == null)
                    throw new Exception("Library bulunamadı.");

                branch = new Branch { Name = branchName, Location = "Unknown", LibraryID = library.LibraryID };
                _dbContext.Branches.Add(branch);
                _dbContext.SaveChanges();
            }

            return branch;
        }
        private Member CreateMember(string name, string surName, string email, string phone, DateTime birthDate, int genderID, string identityNumber, int branchID, int roleID, string city, string country, string postalCode, string district, string neighborhood)
        {
            var member = new Member
            {
                Name = name,
                LastName = surName,
                Email = email,
                MemberPhoneNumber = phone,
                BirthDate = birthDate,
                GenderID = genderID,
                IdentityNumber = identityNumber,
                BranchID = branchID,
                RoleID = roleID,
                Address = $"{neighborhood}, {district}, {city}, {country}, {postalCode}"
            };
            _dbContext.Members.Add(member);
            _dbContext.SaveChanges();

            return member;
        }
        private void CreateAddress(int memberID, string city, string country, string postalCode, string district, string neighborhood)
        {
            var address = new Address
            {
                City = city,
                Country = country,
                PostalCode = postalCode,
                District = district,
                Neighborhood = neighborhood,
                MemberID = memberID
            };
            _dbContext.Addresses.Add(address);
            _dbContext.SaveChanges();
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
        public void UpdateMember(int memberID, string name, string surName, string userName, string password, string email, string phone, DateTime birthDate, int genderID, string identityNumber, string city, string country, string postalCode, string district, string neighborhood, string branchName)
        {
            var member = _dbContext.Members.Include(m => m.User).FirstOrDefault(m => m.MemberID == memberID);
            if (member == null) throw new Exception("Güncellenecek üye bulunamadı.");

            var role = GetRole("Member");
            var branch = GetOrCreateBranch(branchName);

            UpdateMemberDetails(member, name, surName, email, phone, birthDate, genderID, identityNumber, branch.BranchID, role.RoleID, city, country, postalCode, district, neighborhood);
            UpdateAddress(member.MemberID, city, country, postalCode, district, neighborhood);
            UpdateUser(member.User.UserID, userName, password, branch.BranchID, role.RoleID);
        }
        private void UpdateMemberDetails(Member member, string name, string surName, string email, string phone, DateTime birthDate, int genderID, string identityNumber, int branchID, int roleID, string city, string country, string postalCode, string district, string neighborhood)
        {
            member.Name = name;
            member.LastName = surName;
            member.Email = email;
            member.MemberPhoneNumber = phone;
            member.BirthDate = birthDate;
            member.GenderID = genderID;
            member.IdentityNumber = identityNumber;
            member.BranchID = branchID;
            member.RoleID = roleID;
            member.Address = $"{neighborhood}, {district}, {city}, {country}, {postalCode}";

            _dbContext.Members.Update(member);
            _dbContext.SaveChanges();
        }
        private void UpdateAddress(int memberID, string city, string country, string postalCode, string district, string neighborhood)
        {
            var address = _dbContext.Addresses.FirstOrDefault(a => a.MemberID == memberID);
            if (address != null)
            {
                address.City = city;
                address.Country = country;
                address.PostalCode = postalCode;
                address.District = district;
                address.Neighborhood = neighborhood;

                _dbContext.Addresses.Update(address);
                _dbContext.SaveChanges();
            }
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
        public void DeleteMember(int memberId)
        {
            using var transaction = _dbContext.Database.BeginTransaction();

            var member = _dbContext.Members
                .Include(m => m.Addresses)
                .Include(m => m.Loans)
                .Include(m => m.Penalties)
                .Include(m => m.User)
                .FirstOrDefault(m => m.MemberID == memberId);

            if (member == null)
            {
                throw new Exception("Silinecek üye bulunamadı.");
            }

            _dbContext.Addresses.RemoveRange(member.Addresses);
            _dbContext.Loans.RemoveRange(member.Loans);
            _dbContext.Penalties.RemoveRange(member.Penalties);

            if (member.User != null)
            {
                _dbContext.Users.Remove(member.User);
            }

            _dbContext.Members.Remove(member);
            _dbContext.SaveChanges();
            transaction.Commit();
        }
        public List<dynamic> SearchMembers(string searchText)
        {
            searchText = searchText.ToLower();
            return _dbContext.Members
                .Include(m => m.Gender)
                .Include(m => m.Branch)
                .Include(m => m.Role)
                .Include(m => m.Addresses)
                .Include(m => m.User)
                .Where(m => m.Name.ToLower().Contains(searchText) ||
                            m.LastName.ToLower().Contains(searchText) ||
                            m.IdentityNumber.Contains(searchText) ||
                            m.Email.ToLower().Contains(searchText) ||
                            m.MemberPhoneNumber.Contains(searchText) ||
                            m.Gender.Name.ToLower().Contains(searchText) ||
                            m.Branch.Name.ToLower().Contains(searchText) ||
                            m.Role.Name.ToLower().Contains(searchText) ||
                            m.User.UserName.ToLower().Contains(searchText) ||
                            m.User.Password.Contains(searchText))
                .Select(m => new
                {
                    m.MemberID,
                    m.Name,
                    m.LastName,
                    m.IdentityNumber,
                    m.BirthDate,
                    Gender = m.Gender.Name,
                    Branch = m.Branch.Name,
                    Role = m.Role.Name,
                    m.Email,
                    m.MemberPhoneNumber,
                    Addresses = string.Join(", ", m.Addresses.Select(a => $"{a.City}, {a.Country}, {a.District}, {a.Neighborhood} {a.PostalCode}")),
                    UserName = m.User.UserName,
                    Password = m.User.Password
                })
                .ToList<dynamic>();
        }
    }
}