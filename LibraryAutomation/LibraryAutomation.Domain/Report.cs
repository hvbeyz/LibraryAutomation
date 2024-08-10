namespace LibraryAutomation.Domain
{
    public class Report
    {
        public int ReportID { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }

        public int LibraryID { get; set; }
        public Library Library { get; set; }

        public int ReportTypeID { get; set; }
        public ReportType ReportType { get; set; }
    }


}
