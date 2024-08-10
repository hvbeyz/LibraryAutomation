using LibraryAutomation.Domain;

namespace LibraryAutomation.UI
{
    public partial class ManagementSystem : Form
    {
        private readonly User _loggedInUser;

        public ManagementSystem(User loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
        }
        private void btnEmployeeCreateAndUpdate_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeOperations(_loggedInUser));
        }
        private void btnManagementSystemExit_Click(object sender, EventArgs e)
        {
            CloseFormAndOpenNew(new Login());
        }
        private void btnMemberRegisterUpdate_Click(object sender, EventArgs e)
        {
            OpenForm(new MemberOperations());
        }
        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            OpenForm(new ShowAllUsersForm());
        }
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            OpenForm(new AddReport());
        }
        private void OpenForm(Form form)
        {
            form.Show();
        }
        private void CloseFormAndOpenNew(Form form)
        {
            Close();
            form.Show();
        }
    }
}
