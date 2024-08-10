using LibraryAutomation.BAL;
using LibraryAutomation.DAL;
using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.UI
{
    public partial class MemberSystem : Form
    {
        private readonly BookServices _bookServices;
        private readonly User _loggedInUser;

        public MemberSystem(User loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            _bookServices = new BookServices();
            lnklblUserName.Text = _loggedInUser.UserName;
            LoadBooks();
        }
        private void btnMemberExit_Click(object sender, EventArgs e)
        {
            OpenForm(new Login());
        }
        private void LoadBooks()
        {
            var books = _bookServices.GetAllBooks();
            if (books.Any())
            {
                dgvMemberSysBookList.DataSource = books;
                ConfigureDataGridView();
            }
            else
            {
                CreateEmptyDataGridViewColumns();
            }
        }
        private void ConfigureDataGridView()
        {
            dgvMemberSysBookList.Columns["BookID"].HeaderText = "Kitap ID";
            dgvMemberSysBookList.Columns["Title"].HeaderText = "Başlık";
            dgvMemberSysBookList.Columns["ISBN"].HeaderText = "ISBN";
            dgvMemberSysBookList.Columns["PublicationYear"].HeaderText = "Yayın Yılı";
            dgvMemberSysBookList.Columns["AuthorName"].HeaderText = "Yazar Adı";
            dgvMemberSysBookList.Columns["PublisherName"].HeaderText = "Yayınevi Adı";
            dgvMemberSysBookList.Columns["Categories"].HeaderText = "Kategoriler";
            dgvMemberSysBookList.Columns["Genres"].HeaderText = "Türler";
        }
        private void CreateEmptyDataGridViewColumns()
        {
            dgvMemberSysBookList.Columns.Add("BookID", "Kitap ID");
            dgvMemberSysBookList.Columns.Add("Title", "Başlık");
            dgvMemberSysBookList.Columns.Add("ISBN", "ISBN");
            dgvMemberSysBookList.Columns.Add("PublicationYear", "Yayın Yılı");
            dgvMemberSysBookList.Columns.Add("AuthorName", "Yazar Adı");
            dgvMemberSysBookList.Columns.Add("PublisherName", "Yayınevi Adı");
            dgvMemberSysBookList.Columns.Add("Categories", "Kategoriler");
            dgvMemberSysBookList.Columns.Add("Genres", "Türler");
        }
        private void btnMemberReservation_Click(object sender, EventArgs e)
        {
            OpenForm(new AddReservation(_loggedInUser));
        }
        private void btnMemberNotification_Click(object sender, EventArgs e)
        {
            OpenForm(new AddNotification());
        }
        private void lnklblUserName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var member = GetMemberDetails(_loggedInUser.UserID);

            if (member != null)
            {
                OpenForm(new Profile(member));
            }
            else
            {
                MessageBox.Show("Üye bilgisi bulunamadı.");
            }
        }
        private Member GetMemberDetails(int userId)
        {
            using (var context = new AppDBContext())
            {
                return context.Members
                              .Include(m => m.User)
                              .Include(m => m.Addresses)
                              .Include(m => m.Branch)
                              .Include(m => m.Gender)
                              .FirstOrDefault(m => m.User.UserID == userId);
            }
        }
        private void OpenForm(Form form)
        {
            form.FormClosed += (s, args) => Show();
            Hide();
            form.Show();
        }
    }
}
