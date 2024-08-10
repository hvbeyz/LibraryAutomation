namespace LibraryAutomation.Domain
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<PublisherAddress> AddressList { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
