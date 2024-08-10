using LibraryAutomation.DAL;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.UI
{
    public partial class BackBook : Form
    {
        private readonly AppDBContext _dbContext;
        public BackBook()
        {
            _dbContext = new AppDBContext();
            InitializeComponent();
        }
        private void BackBook_Load(object sender, EventArgs e)
        {
            LoadLoanedUsers();
            LoadLoanedBooks();
        }
        private void LoadLoanedUsers()
        {
            var loanedUsers = _dbContext.Loans
                .Include(l => l.Member)
                .ThenInclude(m => m.User)
                .Select(l => l.Member.User.UserName)
                .Distinct()
                .ToList();

            cmbUserNameBackBook.DataSource = loanedUsers;
        }
        private void LoadLoanedBooks()
        {
            var loanedBooks = _dbContext.Loans
                .Include(l => l.Book)
                .Select(l => l.Book.Title)
                .Distinct()
                .ToList();

            cmbBookNameBackBook.DataSource = loanedBooks;
        }
        private void btnLoanBookBackExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLoanBookBack_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedUserName = cmbUserNameBackBook.SelectedItem?.ToString();
                var selectedBookTitle = cmbBookNameBackBook.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedUserName) || string.IsNullOrEmpty(selectedBookTitle))
                {
                    MessageBox.Show("Lütfen kullanıcı ve kitap seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var loanToDelete = _dbContext.Loans
                    .Include(l => l.Member)
                    .ThenInclude(m => m.User)
                    .Include(l => l.Book)
                    .FirstOrDefault(l => l.Member.User.UserName == selectedUserName && l.Book.Title == selectedBookTitle);

                if (loanToDelete != null)
                {
                    loanToDelete.Book.IsHere = true;
                    _dbContext.Loans.Remove(loanToDelete);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Kitap başarıyla alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seçilen kullanıcıya ait ödünç kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadLoanedUsers();
                LoadLoanedBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
