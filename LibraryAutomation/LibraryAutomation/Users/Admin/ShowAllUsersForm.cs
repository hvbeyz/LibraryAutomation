using LibraryAutomation.BAL;


namespace LibraryAutomation.UI
{
    public partial class ShowAllUsersForm : Form
    {
        private readonly UserServices _userServices;
        private List<UserViewModel> _allUsers;

        public ShowAllUsersForm()
        {
            InitializeComponent();
            _userServices = new UserServices();
            LoadAllUsers();
        }
        private void LoadAllUsers()
        {
            _allUsers = _userServices.GetAllUsers();
            dgvShowAllUsers.DataSource = _allUsers;
            ConfigureDataGridView();
        }
        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            FilterUsers(txtSearchUser.Text.ToLower());
        }
        private void FilterUsers(string searchText)
        {
            var filteredUsers = _allUsers
                .Where(u =>
                    (u.Name?.ToLower().Contains(searchText) ?? false) ||
                    (u.LastName?.ToLower().Contains(searchText) ?? false) ||
                    (u.Email?.ToLower().Contains(searchText) ?? false) ||
                    (u.UserName?.ToLower().Contains(searchText) ?? false))
                .ToList();

            dgvShowAllUsers.DataSource = filteredUsers;
        }
        private void btnCloseAllUsersForm_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ConfigureDataGridView()
        {
            dgvShowAllUsers.AutoGenerateColumns = false;
            dgvShowAllUsers.Columns.Clear();

            dgvShowAllUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Ad" });
            dgvShowAllUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Soyad" });
            dgvShowAllUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "E-Mail" });
            dgvShowAllUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UserName", HeaderText = "Kullanıcı Adı" });
            dgvShowAllUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Password", HeaderText = "Şifre" });
            dgvShowAllUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Gender", HeaderText = "Cinsiyet" });
            dgvShowAllUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Branch", HeaderText = "Şube" });
            dgvShowAllUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Role", HeaderText = "Rol" });
            dgvShowAllUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Telefon Numarası" });
            dgvShowAllUsers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Addresses", HeaderText = "Adresler" });
        }
    }
}
