
namespace LibraryAutomation.Domain
{
    public class PublisherAddress
    {
        public int PublisherAddressID { get; set; }
        public int PublisherID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public Publisher Publisher { get; set; }



    }
}
