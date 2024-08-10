namespace LibraryAutomation.Domain
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string? ISBN { get; set; }
        public DateTime PublicationYear { get; set; }
        public bool IsHere { get; set; }

        public int AuthorID { get; set; }
        public Author Author { get; set; }

        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<BookGenre> BookGenres { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
