using LibraryAutomation.BAL;

namespace LibraryAutomation.UI
{
    public partial class AddBook : Form
    {
        private readonly BookServices _bookServices;
        public AddBook()
        {
            InitializeComponent();
            _bookServices = new BookServices();
            LoadPublishers();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    var bookDetails = GetBookDetailsFromForm();
                    _bookServices.AddBook(bookDetails.Title, bookDetails.ISBN, bookDetails.PublicationYear, bookDetails.AuthorName, bookDetails.Genres, bookDetails.Categories, bookDetails.PublisherID);
                    MessageBox.Show("Kitap başarıyla eklendi.");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap eklenirken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        }
        private void LoadPublishers()
        {
            var publishers = _bookServices.GetAllPublishers();
            cmbPublisherChoose.DataSource = publishers;
            cmbPublisherChoose.DisplayMember = "Name";
            cmbPublisherChoose.ValueMember = "PublisherID";
        }
        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(txtAddBookTitle.Text) &&
                   !string.IsNullOrWhiteSpace(txtAddBookISBN.Text) &&
                   !string.IsNullOrWhiteSpace(txtAddBookAuthorName.Text) &&
                   cmbPublisherChoose.SelectedValue != null &&
                   !string.IsNullOrWhiteSpace(txtAddBookGenre.Text) &&
                   !string.IsNullOrWhiteSpace(txtAddBookCategory.Text);
        }
        private (string Title, string ISBN, DateTime PublicationYear, string AuthorName, string Genres, string Categories, int PublisherID) GetBookDetailsFromForm()
        {
            return (
                Title: txtAddBookTitle.Text,
                ISBN: txtAddBookISBN.Text,
                PublicationYear: dtPublishYear.Value,
                AuthorName: txtAddBookAuthorName.Text,
                Genres: txtAddBookGenre.Text,
                Categories: txtAddBookCategory.Text,
                PublisherID: (int)cmbPublisherChoose.SelectedValue
            );
        }
        private void btnCancelAddBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
