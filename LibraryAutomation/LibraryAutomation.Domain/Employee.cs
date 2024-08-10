using System.Net;

namespace LibraryAutomation.Domain
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? EmployeePhoneNumber { get; set; }
        public string? AddressEmployee { get; set; }
        public string IdentityNumber { get; set; }
        public int MaritalStatus { get; set; }
        public string Email { get; set; }
        public int BranchID { get; set; }
        public Branch Branch { get; set; }

        public int GenderID { get; set; }
        public Gender Gender { get; set; }

        public int RoleID { get; set; }
        public Role Role { get; set; }
        public ICollection<AddressEmployee> AddressesEmp { get; set; }
        public User User { get; set; }
    }
}
