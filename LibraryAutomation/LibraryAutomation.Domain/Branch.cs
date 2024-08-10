namespace LibraryAutomation.Domain
{
    public class Branch
    {
        public int BranchID { get; set; }
        public string Name { get; set; }
        public string? Location { get; set; }

        public int LibraryID { get; set; }
        public Library Library { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Member> Members { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
