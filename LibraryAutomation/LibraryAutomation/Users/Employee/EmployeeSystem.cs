using LibraryAutomation.BAL;
using LibraryAutomation.DAL;
using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.UI
{
    public partial class EmployeeSystem : Form
    {
        private readonly EmployeeServices _services;
        private readonly BookServices _bookServices;
        private readonly User _loggedInUser;

        public EmployeeSystem(User loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            _bookServices = new BookServices();
            _services = new EmployeeServices();
            InitializeForm();
        }
        private void InitializeForm()
        {
            ShowAllBooks();
            LoadNotifications();
            LoadAllReports();
        }
        private void LoadAllReports()
        {
            using (var context = new AppDBContext())
            {
                var reports = context.Reports
                    .Include(r => r.Library)
                    .Include(r => r.ReportType)
                    .Select(r => new
                    {
                        r.ReportID,
                        r.Type,
                        r.CreationDate,
                        LibraryName = r.Library.LibraryName,
                    })
                    .ToList();

                dgvAllReports.DataSource = reports;
                ConfigureReportDataGridView();
            }
        }
        private void ConfigureReportDataGridView()
        {
            dgvAllReports.Columns["ReportID"].HeaderText = "Rapor ID";
            dgvAllReports.Columns["Type"].HeaderText = "Rapor Tipi";
            dgvAllReports.Columns["CreationDate"].HeaderText = "Tarih";
            dgvAllReports.Columns["LibraryName"].HeaderText = "Kütüphane Adı";
        }
        private void LoadNotifications()
        {
            var notifications = _services.LoadNotifications()
                .Select(n => new
                {
                    n.NotificationID,
                    KullaniciAdi = n.User.UserName,
                    n.Message,
                    n.NotificationDate
                })
                .ToList();

            dgvNotificationList.DataSource = notifications;
            ConfigureNotificationDataGridView();
        }
        private void ConfigureNotificationDataGridView()
        {
            dgvNotificationList.Columns["NotificationID"].HeaderText = "Bildirim ID";
            dgvNotificationList.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";
            dgvNotificationList.Columns["Message"].HeaderText = "Mesaj";
            dgvNotificationList.Columns["NotificationDate"].HeaderText = "Bildirim Tarihi";
        }
        private void ShowAllBooks()
        {
            var books = _bookServices.GetAllBooks();
            dgvBookList.DataSource = books;
            ConfigureBookDataGridView();
        }
        private void ConfigureBookDataGridView()
        {
            dgvBookList.Columns["BookID"].HeaderText = "Kitap ID";
            dgvBookList.Columns["Title"].HeaderText = "Başlık";
            dgvBookList.Columns["ISBN"].HeaderText = "ISBN";
            dgvBookList.Columns["PublicationYear"].HeaderText = "Yayın Yılı";
            dgvBookList.Columns["AuthorName"].HeaderText = "Yazar Adı";
            dgvBookList.Columns["PublisherName"].HeaderText = "Yayınevi Adı";
            dgvBookList.Columns["Categories"].HeaderText = "Kategoriler";
            dgvBookList.Columns["Genres"].HeaderText = "Türler";
            dgvBookList.Columns["IsHere"].HeaderText = "Burada mı";
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            OpenForm(new AddBook());
            
        }
        private void btnPublisherAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new AddPublisher());
        }
        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            OpenForm(new LoanBook());
        }
        private void btnBackBook_Click(object sender, EventArgs e)
        {
            OpenForm(new BackBook());
        }
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedBook = dgvBookList.SelectedRows[0].DataBoundItem as BookViewModel;
                if (selectedBook != null)
                {
                    var updateBookForm = new BookUpdate(selectedBook.BookID, _loggedInUser);
                    updateBookForm.FormClosed += (s, args) => ShowAllBooks();
                    updateBookForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kitabı seçin.", "Kitap Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedBook = dgvBookList.SelectedRows[0].DataBoundItem as BookViewModel;
                if (selectedBook != null)
                {
                    var result = MessageBox.Show("Bu kitabı silmek istediğinizden emin misiniz?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _bookServices.DeleteBook(selectedBook.BookID);
                        ShowAllBooks();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabı seçin.", "Kitap Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnExitEmployeeSystem_Click(object sender, EventArgs e)
        {
            Close();
            OpenForm(new Login());
        }
        private void OpenForm(Form form)
        {
            form.FormClosed += (s, args) => Show();
            form.Show();
            Hide();
        }

        private void btnReservationTracking_Click(object sender, EventArgs e)
        {
            OpenForm(new ReservationTrackingForm());
        }

        private void btnLoanTracking_Click(object sender, EventArgs e)
        {
            OpenForm(new LoanTrackingForm());
        }
    }
}
