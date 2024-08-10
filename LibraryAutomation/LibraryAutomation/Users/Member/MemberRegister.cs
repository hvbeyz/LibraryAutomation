using LibraryAutomation.BAL;

namespace LibraryAutomation.UI
{
    public partial class MemberRegister : Form
    {
        private readonly MemberServices _memberServices;

        public MemberRegister()
        {
            InitializeComponent();
            _memberServices = new MemberServices();
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
                Close();
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
    }
}
