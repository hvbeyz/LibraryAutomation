using LibraryAutomation.DAL;
using LibraryAutomation.Domain;

namespace LibraryAutomation.UI
{
    public partial class LoanBook : Form
    {
        private readonly AppDBContext _dbContext;
        private List<string> originalUserList;
        private List<string> originalBookList;

        public LoanBook()
        {
            _dbContext = new AppDBContext();
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            LoadUsers();
            LoadBooks();
        }
        private void LoadUsers()
        {
            var users = _dbContext.Users.Select(u => u.UserName).ToList();
            originalUserList = users;
            cmbUserNameLoan.DataSource = users;
        }
        private void LoadBooks()
        {
            var books = _dbContext.Books
                .Where(b => b.IsHere)
                .Select(b => b.Title)
                .ToList();
            originalBookList = books;
            cmbBookNameLoan.DataSource = books;
        }
        private void btnLoanBookExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            try
            {
                var member = _dbContext.Members.FirstOrDefault(m => m.User.UserName == cmbUserNameLoan.Text);
                var book = _dbContext.Books.FirstOrDefault(b => b.Title == cmbBookNameLoan.Text);

                if (member == null)
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                    return;
                }

                if (book == null)
                {
                    MessageBox.Show("Kitap bulunamadı.");
                    return;
                }

                LoanBookToMember(member, book);
                MessageBox.Show("Kitap başarıyla ödünç verildi.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödünç verme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }
        private void LoanBookToMember(Member member, Book book)
        {
            book.IsHere = false;

            var loan = new Loan
            {
                LoanDate = dtLoanDate.Value,
                ReturnDate = dtReturnDate.Value,
                MemberID = member.MemberID,
                BookID = book.BookID
            };

            _dbContext.Loans.Add(loan);
            _dbContext.SaveChanges();
        }
        private void btnLoanBookCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            cmbUserNameLoan.DataSource = new List<string>(originalUserList);
            cmbBookNameLoan.DataSource = new List<string>(originalBookList);
            dtLoanDate.Value = DateTime.Now;
            dtReturnDate.Value = DateTime.Now;
        }
        private void cmbUserNameLoan_TextChanged(object sender, EventArgs e)
        {
            FilterComboBoxItems(cmbUserNameLoan, originalUserList);
        }
        private void cmbBookNameLoan_TextChanged(object sender, EventArgs e)
        {
            FilterComboBoxItems(cmbBookNameLoan, originalBookList);
        }
        private void FilterComboBoxItems(ComboBox comboBox, List<string> originalItems)
        {
            string searchValue = comboBox.Text.ToLower();
            var filteredItems = originalItems.Where(item => item.ToLower().Contains(searchValue)).ToList();

            comboBox.DataSource = null;
            comboBox.DataSource = filteredItems;

            comboBox.SelectionStart = searchValue.Length;
            comboBox.SelectionLength = 0;
        }
    }
}
