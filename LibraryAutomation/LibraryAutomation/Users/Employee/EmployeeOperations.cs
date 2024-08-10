using LibraryAutomation.BAL;
using LibraryAutomation.Domain;

namespace LibraryAutomation.UI
{
    public partial class EmployeeOperations : Form
    {
        private readonly EmployeeServices _employeeServices;
        private readonly User _loggedInUser;
        private int _selectedEmployeeID;

        public EmployeeOperations(User loggedInUser)
        {
            InitializeComponent();
            _employeeServices = new EmployeeServices();
            _loggedInUser = loggedInUser;
            LoadEmployees();
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeData = GetEmployeeDataFromForm();
                _employeeServices.AddEmployee(employeeData.Name, employeeData.SurName, employeeData.UserName, employeeData.Password, employeeData.Email, employeeData.MaritalStatus, employeeData.Phone, employeeData.BirthDate, employeeData.GenderID, employeeData.IdentityNumber, employeeData.City, employeeData.Country, employeeData.PostalCode, employeeData.District, employeeData.Neighborhood, employeeData.BranchName);
                MessageBox.Show("Kayıt başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt eklenirken bir hata oluştu. Lütfen bilgilerinizi kontrol edin ve tekrar deneyin.\nHata Mesajı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeData = GetEmployeeDataFromForm();
                _employeeServices.UpdateEmployee(_selectedEmployeeID, employeeData.Name, employeeData.SurName, employeeData.UserName, employeeData.Password, employeeData.Email, employeeData.MaritalStatus, employeeData.Phone, employeeData.BirthDate, employeeData.GenderID, employeeData.IdentityNumber, employeeData.City, employeeData.Country, employeeData.PostalCode, employeeData.District, employeeData.Neighborhood, employeeData.BranchName);
                MessageBox.Show("Kayıt başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt güncellenirken bir hata oluştu. Lütfen bilgilerinizi kontrol edin ve tekrar deneyin.\nHata Mesajı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeID == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz çalışanı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmationResult = MessageBox.Show("Seçili çalışanı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    _employeeServices.DeleteEmployee(_selectedEmployeeID);
                    MessageBox.Show("Çalışan başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Çalışan silinirken bir hata oluştu. Lütfen tekrar deneyin.\nHata Mesajı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadEmployees()
        {
            var employees = _employeeServices.GetAllEmployees();
            dgvEmployeeList.DataSource = employees;
        }

        private void dgvEmployeeList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var row = dgvEmployeeList.Rows[e.RowIndex];
                _selectedEmployeeID = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                var (employee, address, user) = _employeeServices.GetEmployeeDetails(_selectedEmployeeID);

                if (employee != null)
                {
                    PopulateFormWithEmployeeData(employee, address, user);
                }
            }
        }

        private void txtEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtEmployeeSearch.Text.ToLower();
            var filteredEmployees = _employeeServices.SearchEmployees(searchText);
            dgvEmployeeList.DataSource = filteredEmployees;
        }

        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private (string Name, string SurName, string UserName, string Password, string Email, string Phone, DateTime BirthDate, int GenderID, int MaritalStatus, string IdentityNumber, string City, string Country, string PostalCode, string District, string Neighborhood, string BranchName) GetEmployeeDataFromForm()
        {
            return (
                txtEmployeeRegisterName.Text,
                txtEmployeeRegisterLastName.Text,
                txtEmployeeRegisterUserName.Text,
                txtEmployeeRegisterPassword.Text,
                txtEmployeeRegisterEmail.Text,
                txtEmployeeRegisterPhone.Text,
                dtEmployeeRegisterBirthdate.Value,
                rbtnEmployeeRegisterGenderMan.Checked ? 1 : 2,
                rbtEmployeeRegisterMartialStatusSingle.Checked ? 0 : 1,
                txtEmployeeRegisterIdentityNumber.Text,
                txtEmployeeRegisterCity.Text,
                txtEmployeeRegisterCountry.Text,
                txtEmployeeRegisterPostalCode.Text,
                txtEmployeeRegisterDistrict.Text,
                txtEmployeeRgtNeighborhood.Text,
                txtEmployeeRegisterBranchName.Text
            );
        }

        private void PopulateFormWithEmployeeData(Employee employee, AddressEmployee address, User user)
        {
            txtEmployeeRegisterName.Text = employee.Name;
            txtEmployeeRegisterLastName.Text = employee.LastName;
            txtEmployeeRegisterUserName.Text = user?.UserName ?? "";
            txtEmployeeRegisterPassword.Text = user?.Password ?? "";
            txtEmployeeRegisterEmail.Text = employee.Email;
            txtEmployeeRegisterPhone.Text = employee.EmployeePhoneNumber;
            dtEmployeeRegisterBirthdate.Value = employee.BirthDate;
            rbtnEmployeeRegisterGenderMan.Checked = employee.Gender.Name == "Erkek";
            rbtnEmployeeRegisterGenderWomen.Checked = employee.Gender.Name == "Kadın";
            rbtEmployeeRegisterMartialStatusSingle.Checked = employee.MaritalStatus == 0;
            rbtEmployeeRegisterMartialStatusMarried.Checked = employee.MaritalStatus == 1;
            txtEmployeeRegisterIdentityNumber.Text = employee.IdentityNumber;
            txtEmployeeRegisterBranchName.Text = employee.Branch.Name;

            if (address != null)
            {
                txtEmployeeRegisterCity.Text = address.City;
                txtEmployeeRegisterCountry.Text = address.Country;
                txtEmployeeRegisterPostalCode.Text = address.PostalCode;
                txtEmployeeRegisterDistrict.Text = address.District;
                txtEmployeeRgtNeighborhood.Text = address.Neighborhood;
            }
        }

        private void ClearForm()
        {
            txtEmployeeRegisterName.Clear();
            txtEmployeeRegisterLastName.Clear();
            txtEmployeeRegisterUserName.Clear();
            txtEmployeeRegisterPassword.Clear();
            txtEmployeeRegisterEmail.Clear();
            txtEmployeeRegisterPhone.Clear();
            dtEmployeeRegisterBirthdate.Value = DateTime.Now;
            rbtnEmployeeRegisterGenderMan.Checked = false;
            rbtnEmployeeRegisterGenderWomen.Checked = false;
            rbtEmployeeRegisterMartialStatusMarried.Checked = false;
            rbtEmployeeRegisterMartialStatusSingle.Checked = false;
            txtEmployeeRegisterIdentityNumber.Clear();
            txtEmployeeRegisterCity.Clear();
            txtEmployeeRegisterCountry.Clear();
            txtEmployeeRegisterPostalCode.Clear();
            txtEmployeeRegisterDistrict.Clear();
            txtEmployeeRgtNeighborhood.Clear();
            txtEmployeeRegisterBranchName.Clear();
            _selectedEmployeeID = 0;
        }
    }
}
