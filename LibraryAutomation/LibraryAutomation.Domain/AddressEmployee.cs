namespace LibraryAutomation.Domain
{
    public class AddressEmployee
    {
        public int AddressEmployeeID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }

        public int? EmployeeID { get; set; }

        public Employee Employee { get; set; }
    }
}
