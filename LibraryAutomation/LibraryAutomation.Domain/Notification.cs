namespace LibraryAutomation.Domain
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string Message { get; set; }
        public DateTime NotificationDate { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
