namespace LibraryAutomation.Domain
{
    public class Role
    {
        public int RoleID { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}