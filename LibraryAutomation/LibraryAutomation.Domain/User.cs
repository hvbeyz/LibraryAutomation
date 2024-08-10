namespace LibraryAutomation.Domain
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int ? MemberID { get; set; }
        public Member Member { get; set; }

        public int BranchID { get; set; }
        public Branch Branch { get; set; }

        public int RoleID { get; set; }
        public Role Role { get; set; }

        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
