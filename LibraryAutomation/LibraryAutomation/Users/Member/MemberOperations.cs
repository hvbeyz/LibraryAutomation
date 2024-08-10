using LibraryAutomation.BAL;

namespace LibraryAutomation.UI
{
    public partial class MemberOperations : Form
    {
        private readonly MemberServices _memberServices;
        private int _selectedMemberID;

        public MemberOperations()
        {
            InitializeComponent();
            _memberServices = new MemberServices();
            LoadMembers();
        }
        private void btnRegisterMember_Click(object sender, EventArgs e)
        {
            try
            {
                _memberServices.AddMember(
                    txtMemberRegisterName.Text,
                    txtMemberRegisterLastName.Text,
                    txtMemberRegisterUserName.Text,
                    txtMemberRegisterPassword.Text,
                    txtMemberRegisterEmail.Text,
                    txtMemberRegisterPhone.Text,
                    dtMemberRegisterBirthdate.Value,
                    rbtnMemberRegisterGenderMan.Checked ? 1 : 2,
                    txtMemberRegisterIdentityNumber.Text,
                    txtMemberRegisterCity.Text,
                    txtMemberRegisterCountry.Text,
                    txtMemberRegisterPostalCode.Text,
                    txtMemberRegisterDistrict.Text,
                    txtMemberRgtNeighborhood.Text,
                    txtMemberRegisterBranchName.Text);

                MessageBox.Show("Kayıt Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMembers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt eklenirken bir hata oluştu. Lütfen bilgilerinizi kontrol edin ve tekrar deneyin.\nHata Mesajı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadMembers()
        {
            var members = _memberServices.GetAllMembers();
            dgvMemberList.DataSource = members;
        }
        private void dgvMemberList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMemberList.Rows[e.RowIndex];
                _selectedMemberID = Convert.ToInt32(row.Cells["MemberID"].Value);

                var (member, address, user) = _memberServices.GetMemberDetails(_selectedMemberID);

                if (member != null)
                {
                    txtMemberRegisterName.Text = member.Name;
                    txtMemberRegisterLastName.Text = member.LastName;
                    txtMemberRegisterUserName.Text = user?.UserName ?? "";
                    txtMemberRegisterPassword.Text = user?.Password ?? "";
                    txtMemberRegisterEmail.Text = member.Email;
                    txtMemberRegisterPhone.Text = member.MemberPhoneNumber;
                    dtMemberRegisterBirthdate.Value = member.BirthDate;
                    rbtnMemberRegisterGenderMan.Checked = member.Gender.Name == "Erkek";
                    rbtnMemberRegisterGenderWomen.Checked = member.Gender.Name == "Kadın";
                    txtMemberRegisterIdentityNumber.Text = member.IdentityNumber;
                    txtMemberRegisterBranchName.Text = member.Branch.Name;

                    if (address != null)
                    {
                        txtMemberRegisterCity.Text = address.City;
                        txtMemberRegisterCountry.Text = address.Country;
                        txtMemberRegisterPostalCode.Text = address.PostalCode;
                        txtMemberRegisterDistrict.Text = address.District;
                        txtMemberRgtNeighborhood.Text = address.Neighborhood;
                    }
                }
            }
        }
        private void btnMemberUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _memberServices.UpdateMember(
                    _selectedMemberID,
                    txtMemberRegisterName.Text,
                    txtMemberRegisterLastName.Text,
                    txtMemberRegisterUserName.Text,
                    txtMemberRegisterPassword.Text,
                    txtMemberRegisterEmail.Text,
                    txtMemberRegisterPhone.Text,
                    dtMemberRegisterBirthdate.Value,
                    rbtnMemberRegisterGenderMan.Checked ? 1 : 2,
                    txtMemberRegisterIdentityNumber.Text,
                    txtMemberRegisterCity.Text,
                    txtMemberRegisterCountry.Text,
                    txtMemberRegisterPostalCode.Text,
                    txtMemberRegisterDistrict.Text,
                    txtMemberRgtNeighborhood.Text,
                    txtMemberRegisterBranchName.Text);

                MessageBox.Show("Üye başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMembers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında bir hata oluştu. Lütfen bilgilerinizi kontrol edin ve tekrar deneyin.\nHata Mesajı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMemberDelete_Click(object sender, EventArgs e)
        {
            if (_selectedMemberID > 0)
            {
                var confirmResult = MessageBox.Show("Bu üyeyi silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _memberServices.DeleteMember(_selectedMemberID);
                        MessageBox.Show("Üye başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMembers();
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Üye silinirken bir hata oluştu. Lütfen tekrar deneyin.\nHata Mesajı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir üye seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearForm()
        {
            txtMemberRegisterName.Clear();
            txtMemberRegisterLastName.Clear();
            txtMemberRegisterUserName.Clear();
            txtMemberRegisterPassword.Clear();
            txtMemberRegisterEmail.Clear();
            txtMemberRegisterPhone.Clear();
            dtMemberRegisterBirthdate.Value = DateTime.Now;
            rbtnMemberRegisterGenderMan.Checked = false;
            rbtnMemberRegisterGenderWomen.Checked = false;
            txtMemberRegisterIdentityNumber.Clear();
            txtMemberRegisterCity.Clear();
            txtMemberRegisterCountry.Clear();
            txtMemberRegisterPostalCode.Clear();
            txtMemberRegisterDistrict.Clear();
            txtMemberRgtNeighborhood.Clear();
            txtMemberRegisterBranchName.Clear();
            _selectedMemberID = 0;
        }
        private void txtMemberSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtMemberSearch.Text;
            var searchResults = _memberServices.SearchMembers(searchText);
            dgvMemberList.DataSource = searchResults;
        }
    }
}
