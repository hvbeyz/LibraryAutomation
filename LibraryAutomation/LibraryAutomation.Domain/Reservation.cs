namespace LibraryAutomation.Domain
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public DateTime ReservationDate { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
