using LibraryAutomation.BAL;
using LibraryAutomation.Domain;
using LibraryAutomation.UI;
using System.Diagnostics;

namespace LibraryAutomation
{
    public partial class Login : Form
    {
        private readonly UserServices _userServices;

        public Login()
        {
            InitializeComponent();
            _userServices = new UserServices();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtUserPasswordLogin.PasswordChar = cbShowPassword.Checked ? default : '*';
        }

        private void btnLoginLibrary_Click(object sender, EventArgs e)
        {
            string username = txtUserNameLogin.Text;
            string password = txtUserPasswordLogin.Text;

            User user = _userServices.ValidateUser(username, password);

            if (user != null)
            {
                OpenUserForm(user);
            }
            else
            {
                ShowErrorMessage("Kullanýcý adý veya þifre hatalý!");
            }
        }

        private void OpenUserForm(User user)
        {
            Form userForm;

            switch (user.Role.Name)
            {
                case "Admin":
                    userForm = new ManagementSystem(user);
                    break;
                case "Employee":
                    userForm = new EmployeeSystem(user);
                    break;
                case "Member":
                    userForm = new MemberSystem(user);
                    break;
                default:
                    ShowErrorMessage("Geçersiz rol!");
                    BackColor = Color.Red;
                    return;
            }

            userForm.Show();
            this.Hide();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelLibrary_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMemberRegister_Click(object sender, EventArgs e)
        {
            OpenForm(new MemberRegister());
        }

        private void OpenForm(Form form)
        {
            form.Show();
        }

        private void lnklblForgetMyPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("mailto:muhammed.kilic8@outlook.com");
            }
            catch (Exception)
            {
                ShowErrorMessage("Týklanan baðlantý açýlamýyor.");
            }
        }

        private void VisitLink(string url)
        {
            try
            {
                lnklblForgetMyPassword.LinkVisited = true;
                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Týklanan baðlantý açýlamýyor: " + ex.Message);
            }
        }
    }
}
