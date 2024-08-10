using LibraryAutomation.DAL;
using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.UI
{
    public partial class LoanTrackingForm : Form
    {
        public LoanTrackingForm()
        {
            InitializeComponent();
            LoadListViewData();
        }
        private void btnLoanExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadListViewData()
        {
            using (var context = new AppDBContext())
            {
                var loans = context.Loans
                    .Include(l => l.Member)
                    .ThenInclude(m => m.User)
                    .Include(l => l.Book)
                    .Include(l => l.Penalty)
                    .ToList();

                PopulateListView(loans);
            }
        }
        private void PopulateListView(List<Loan> loans)
        {
            lvReservationsList.Items.Clear();

            foreach (var loan in loans)
            {
                var item = new ListViewItem(loan.LoanID.ToString());
                item.SubItems.Add(loan.LoanDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add(loan.ReturnDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add(loan.Penalty != null ? loan.Penalty.PenaltyScore.ToString() : "0");
                item.SubItems.Add(loan.Member.User.UserName);
                item.SubItems.Add(loan.Member.MemberPhoneNumber);
                item.SubItems.Add(loan.Member.Email);
                item.SubItems.Add(loan.Book.Title);

                lvReservationsList.Items.Add(item);
            }
        }
        private void lvReservationsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvReservationsList.SelectedItems.Count > 0)
            {
                var selectedItem = lvReservationsList.SelectedItems[0];
                DisplayLoanDetails(selectedItem);
            }
        }
        private void DisplayLoanDetails(ListViewItem selectedItem)
        {
            txtUserNameLoans.Text = selectedItem.SubItems[4].Text;
            int memberId = int.Parse(selectedItem.SubItems[0].Text);

            using (var context = new AppDBContext())
            {
                var penalty = context.Penalties.FirstOrDefault(p => p.MemberID == memberId);
                txtPenaltyLoans.Text = penalty != null ? penalty.PenaltyScore.ToString() : "0";
            }
        }
        private void txtSearchReservationsList_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchReservationsList.Text.ToLower();
            HighlightSearchResults(searchText);
        }
        private void HighlightSearchResults(string searchText)
        {
            foreach (ListViewItem item in lvReservationsList.Items)
            {
                bool match = item.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(subItem => subItem.Text.ToLower().Contains(searchText));
                item.BackColor = match ? SystemColors.Window : SystemColors.Control;
                item.ForeColor = match ? SystemColors.WindowText : SystemColors.GrayText;
            }
        }
    }
}
