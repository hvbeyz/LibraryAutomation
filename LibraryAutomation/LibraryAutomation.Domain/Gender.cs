namespace LibraryAutomation.Domain
{
    public class Gender
    {
        public int GenderID { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
