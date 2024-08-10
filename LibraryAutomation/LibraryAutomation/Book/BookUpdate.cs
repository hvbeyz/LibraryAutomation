using LibraryAutomation.BAL;
using LibraryAutomation.Domain;

namespace LibraryAutomation.UI
{
    public partial class BookUpdate : Form
    {
        private readonly BookServices _bookServices;
        private readonly int _bookId;
        private readonly User _loggedInUser;
        public BookUpdate(int bookId, User user)
        {
            InitializeComponent();
            _bookServices = new BookServices();
            _bookId = bookId;
            _loggedInUser = user;
            LoadBookDetails();
            LoadPublishers();
        }
        private void LoadBookDetails()
        {
            var book = _bookServices.GetBookById(_bookId);
            if (book != null)
            {
                txtUpdateBookTitle.Text = book.Title;
                txtUpdateBookISBN.Text = book.ISBN;
                dtUpdatePublishYear.Value = book.PublicationYear;
                txtUpdateBookAuthorName.Text = book.AuthorName;
                txtUpdateBookGenre.Text = book.Genres;
                txtUpdateBookCategory.Text = book.Categories;
                cmbUpdatePublisherChoose.SelectedItem = book.PublisherName;
            }
        }
        private void LoadPublishers()
        {
            var publishers = _bookServices.GetAllPublishers();
            cmbUpdatePublisherChoose.DataSource = publishers;
            cmbUpdatePublisherChoose.DisplayMember = "Name";
            cmbUpdatePublisherChoose.ValueMember = "PublisherID";
        }
        private void btnCancelAddBook_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                _bookServices.UpdateBook(_bookId,
                    txtUpdateBookTitle.Text,
                    txtUpdateBookISBN.Text,
                    dtUpdatePublishYear.Value,
                    txtUpdateBookAuthorName.Text,
                    txtUpdateBookGenre.Text,
                    txtUpdateBookCategory.Text,
                    (int)cmbUpdatePublisherChoose.SelectedValue);

                MessageBox.Show("Kitap başarıyla güncellendi.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap güncellenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
