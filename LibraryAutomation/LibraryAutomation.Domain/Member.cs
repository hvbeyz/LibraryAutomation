namespace LibraryAutomation.Domain
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MemberPhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string IdentityNumber { get; set; }

        public int BranchID { get; set; }
        public Branch Branch { get; set; }

        public int GenderID { get; set; }
        public Gender Gender { get; set; }

        public int RoleID { get; set; }
        public Role Role { get; set; }

        public ICollection<Penalty> Penalties { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Loan> Loans { get; set; }
        public User User { get; set; }
    }
}
