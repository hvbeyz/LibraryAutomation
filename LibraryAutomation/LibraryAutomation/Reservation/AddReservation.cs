using LibraryAutomation.DAL;
using LibraryAutomation.Domain;

namespace LibraryAutomation.UI
{
    public partial class AddReservation : Form
    {
        private readonly AppDBContext _dbContext;
        private readonly User _loggedInUser;
        public AddReservation(User loggedInUser)
        {
            _dbContext = new AppDBContext();
            _loggedInUser = loggedInUser;
            InitializeComponent();
            LoadBooks();
            LoadLoggedInUser();
        }
        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadBooks()
        {
            var availableBooks = _dbContext.Books
                                           .Where(b => b.IsHere)
                                           .Select(b => new { b.BookID, b.Title })
                                           .ToList();

            cmbBookName.DataSource = availableBooks;
            cmbBookName.DisplayMember = "Title";
            cmbBookName.ValueMember = "BookID";
        }
        private void LoadLoggedInUser()
        {
            txtAddReservationUserName.Text = _loggedInUser.UserName;
            txtAddReservationUserName.Enabled = false;
        }
        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBookName.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir kitap seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int selectedBookID = (int)cmbBookName.SelectedValue;

                var reservation = new Reservation
                {
                    ReservationDate = dtAddReservationDate.Value,
                    UserID = _loggedInUser.UserID,
                    BookID = selectedBookID
                };

                _dbContext.Reservations.Add(reservation);
                _dbContext.SaveChanges();

                MessageBox.Show("Rezervasyon başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon yapılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
