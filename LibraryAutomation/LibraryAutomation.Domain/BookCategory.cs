namespace LibraryAutomation.Domain
{
    public class BookCategory
    {
        public int BookCategoryID { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
