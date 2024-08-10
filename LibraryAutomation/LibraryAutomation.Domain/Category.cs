namespace LibraryAutomation.Domain
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
