namespace LibraryAutomation.Domain
{
    public class Loan
    {
        public int LoanID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int? PenaltyID { get; set; }

        public int MemberID { get; set; }
        public Member Member { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }

        public Penalty Penalty { get; set; }


    }
}
