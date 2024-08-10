namespace LibraryAutomation.Domain
{
    public class Library
    {
        public int LibraryID { get; set; }
        public string LibraryName { get; set; }

        public ICollection<Branch> Branches { get; set; }
        public ICollection<Report> Reports { get; set; }
    }
}
