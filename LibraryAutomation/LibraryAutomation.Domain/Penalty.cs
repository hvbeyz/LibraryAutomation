

namespace LibraryAutomation.Domain
{
    public class Penalty
    {
        public int PenaltyID { get; set; }
        public int PenaltyLevel { get; set; }
        public DateTime PenaltyDate { get; set; }
        public string PenaltyDescription { get; set; }
        public float PenaltyScore { get; set; }
        public int MemberID { get; set; }
        public Member Member { get; set; }

        public ICollection<Loan> Loans { get; set; }

    }
}
