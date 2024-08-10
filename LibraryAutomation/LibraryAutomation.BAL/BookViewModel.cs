namespace LibraryAutomation.BAL
{
    public class BookViewModel
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationYear { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string Categories { get; set; }
        public string Genres { get; set; }
        public bool IsHere { get; set; }
    }

}
