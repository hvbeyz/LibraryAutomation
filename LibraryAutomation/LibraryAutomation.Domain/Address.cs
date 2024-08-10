namespace LibraryAutomation.Domain
{
    public class Address
    {
        public int AddressID { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? District { get; set; }
        public string? Neighborhood { get; set; }
        
        public int? MemberID { get; set; }
        
        public Member Member { get; set; }
    }
}
