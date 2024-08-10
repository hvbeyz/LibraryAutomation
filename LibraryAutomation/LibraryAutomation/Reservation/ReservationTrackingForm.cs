using LibraryAutomation.DAL;
using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.UI
{
    public partial class ReservationTrackingForm : Form
    {
        private readonly AppDBContext _dbContext;

        public ReservationTrackingForm()
        {
            _dbContext = new AppDBContext();
            InitializeComponent();
            LoadReservations();
        }
        private void btnReservationTrackingExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadReservations()
        {
            var reservations = _dbContext.Reservations
                .Include(r => r.User)
                .Include(r => r.Book)
                .Select(r => new
                {
                    r.ReservationID,
                    r.ReservationDate,
                    UserName = r.User.UserName,
                    BookTitle = r.Book.Title
                })
                .ToList();

            dgvReservationTrakingList.DataSource = reservations;
            SetDataGridViewHeaders();
        }
        private void SetDataGridViewHeaders()
        {
            dgvReservationTrakingList.Columns["ReservationID"].HeaderText = "Rezervasyon ID";
            dgvReservationTrakingList.Columns["ReservationDate"].HeaderText = "Rezervasyon Tarihi";
            dgvReservationTrakingList.Columns["UserName"].HeaderText = "Kullanıcı Adı";
            dgvReservationTrakingList.Columns["BookTitle"].HeaderText = "Kitap Adı";
        }
        private void btnAddReservationEmployee_Click(object sender, EventArgs e)
        {
            if (TryGetUserAndBook(out var user, out var book))
            {
                var reservation = new Reservation
                {
                    UserID = user.UserID,
                    BookID = book.BookID,
                    ReservationDate = dtEmployeeReservationDate.Value
                };

                _dbContext.Reservations.Add(reservation);
                _dbContext.SaveChanges();
                LoadReservations();
            }
            else
            {
                ShowUserOrBookNotFoundError();
            }
        }
        private bool TryGetUserAndBook(out User user, out Book book)
        {
            user = _dbContext.Users.FirstOrDefault(u => u.UserName == txtEmployeeReservationUserName.Text);
            book = _dbContext.Books.FirstOrDefault(b => b.Title == txtEmployeeReservationBookName.Text);
            return user != null && book != null;
        }
        private void ShowUserOrBookNotFoundError()
        {
            MessageBox.Show("Kullanıcı veya Kitap bulunamadı.");
        }
        private void btnUpdateReservations_Click(object sender, EventArgs e)
        {
            if (dgvReservationTrakingList.CurrentRow != null)
            {
                var reservationId = (int)dgvReservationTrakingList.CurrentRow.Cells["ReservationID"].Value;
                var reservation = _dbContext.Reservations.FirstOrDefault(r => r.ReservationID == reservationId);

                if (reservation != null && TryGetUserAndBook(out var user, out var book))
                {
                    reservation.UserID = user.UserID;
                    reservation.BookID = book.BookID;
                    reservation.ReservationDate = dtEmployeeReservationDate.Value;

                    _dbContext.SaveChanges();
                    LoadReservations();
                }
                else
                {
                    ShowUserOrBookNotFoundError();
                }
            }
        }
        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (dgvReservationTrakingList.CurrentRow != null)
            {
                var reservationId = (int)dgvReservationTrakingList.CurrentRow.Cells["ReservationID"].Value;
                var reservation = _dbContext.Reservations.FirstOrDefault(r => r.ReservationID == reservationId);

                if (reservation != null)
                {
                    _dbContext.Reservations.Remove(reservation);
                    _dbContext.SaveChanges();
                    LoadReservations();
                }
            }
        }
        private void txtSearchReservation_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtSearchReservation.Text.ToLower();
            var filteredReservations = _dbContext.Reservations
                .Include(r => r.User)
                .Include(r => r.Book)
                .Where(r => r.User.UserName.ToLower().Contains(searchText) ||
                            r.Book.Title.ToLower().Contains(searchText) ||
                            r.ReservationDate.ToString().Contains(searchText))
                .Select(r => new
                {
                    r.ReservationID,
                    r.ReservationDate,
                    UserName = r.User.UserName,
                    BookTitle = r.Book.Title
                })
                .ToList();

            dgvReservationTrakingList.DataSource = filteredReservations;
        }
    }
}
