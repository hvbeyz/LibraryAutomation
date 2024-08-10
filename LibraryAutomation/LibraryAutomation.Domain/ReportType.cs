namespace LibraryAutomation.Domain
{
    public class ReportType
    {
        public int? ReportTypeID { get; set; }
        public string? ReportName { get; set; }
        public ICollection<Report> Reports { get; set; }
    }
}
