using LibraryAutomation.DAL;
using LibraryAutomation.Domain;

namespace LibraryAutomation.UI
{
    public partial class Profile : Form
    {
        private readonly AppDBContext _dbContext;
        private readonly Member _member;

        public Profile(Member member)
        {
            _dbContext = new AppDBContext();
            _member = member;
            InitializeComponent();
            LoadMemberData();
        }
        private void LoadMemberData()
        {
            if (_member == null)
            {
                ShowError("Member bilgisi yüklenemedi.");
                return;
            }

            LoadPersonalData();
            LoadUserData();
            LoadAddressData();
            LoadBranchData();
            LoadGenderData();
        }
        private void LoadPersonalData()
        {
            txtMemberName.Text = _member.Name ?? "";
            txtMemberLastName.Text = _member.LastName ?? "";
            txtMemberEmail.Text = _member.Email ?? "";
            txtMemberPhone.Text = _member.MemberPhoneNumber ?? "";
            dtMemberBirthdate.Value = _member.BirthDate;
            txtMemberIdentityNumber.Text = _member.IdentityNumber ?? "";
        }
        private void LoadUserData()
        {
            if (_member.User != null)
            {
                txtMemberUserName.Text = _member.User.UserName ?? "";
                txtMemberPassword.Text = _member.User.Password ?? "";
            }
            else
            {
                ShowError("User bilgisi bulunamadı.");
            }
        }
        private void LoadAddressData()
        {
            var address = _member.Addresses.FirstOrDefault();
            if (address != null)
            {
                txtMemberCountry.Text = address.Country ?? "";
                txtMemberCity.Text = address.City ?? "";
                txtMemberDistrict.Text = address.District ?? "";
                txtMemberNeighborhood.Text = address.Neighborhood ?? "";
                txtMemberPostalCode.Text = address.PostalCode ?? "";
            }
            else
            {
                ClearAddressFields();
            }
        }
        private void ClearAddressFields()
        {
            txtMemberCountry.Clear();
            txtMemberCity.Clear();
            txtMemberDistrict.Clear();
            txtMemberNeighborhood.Clear();
            txtMemberPostalCode.Clear();
        }
        private void LoadBranchData()
        {
            if (_member.Branch != null)
            {
                txtMemberBranchName.Text = _member.Branch.Name ?? "";
            }
            else
            {
                ShowError("Branch bilgisi bulunamadı.");
            }
        }
        private void LoadGenderData()
        {
            if (_member.Gender != null)
            {
                rbtnMemberGenderMan.Checked = _member.Gender.Name == "Erkek";
                rbtnMemberGenderWomen.Checked = _member.Gender.Name == "Kadın";
            }
            else
            {
                ShowError("Gender bilgisi bulunamadı.");
                rbtnMemberGenderMan.Checked = false;
                rbtnMemberGenderWomen.Checked = false;
            }
        }
        private void ShowError(string message)
        {
            MessageBox.Show(message);
        }
        private void btnMemberUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateMemberData();
                _dbContext.SaveChanges();
                MessageBox.Show("Bilgiler başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                ShowError("Bilgiler güncellenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void UpdateMemberData()
        {
            _member.Name = txtMemberName.Text;
            _member.LastName = txtMemberLastName.Text;
            _member.Email = txtMemberEmail.Text;
            _member.MemberPhoneNumber = txtMemberPhone.Text;
            _member.BirthDate = dtMemberBirthdate.Value;
            _member.IdentityNumber = txtMemberIdentityNumber.Text;
            _member.User.UserName = txtMemberUserName.Text;
            _member.User.Password = txtMemberPassword.Text;

            UpdateAddressData();
            UpdateBranchData();
            UpdateGenderData();
        }
        private void UpdateAddressData()
        {
            var address = _member.Addresses.FirstOrDefault();
            if (address != null)
            {
                address.Country = txtMemberCountry.Text;
                address.City = txtMemberCity.Text;
                address.District = txtMemberDistrict.Text;
                address.Neighborhood = txtMemberNeighborhood.Text;
                address.PostalCode = txtMemberPostalCode.Text;
            }
        }
        private void UpdateBranchData()
        {
            var branch = _dbContext.Branches.FirstOrDefault(b => b.Name == txtMemberBranchName.Text);
            if (branch != null)
            {
                _member.BranchID = branch.BranchID;
            }
        }
        private void UpdateGenderData()
        {
            var genderName = rbtnMemberGenderMan.Checked ? "Erkek" : "Kadın";
            var gender = _dbContext.Genders.FirstOrDefault(g => g.Name == genderName);
            if (gender != null)
            {
                _member.GenderID = gender.GenderID;
            }
        }
        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
