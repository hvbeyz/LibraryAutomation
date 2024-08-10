using LibraryAutomation.DAL;
using LibraryAutomation.Domain;

namespace LibraryAutomation.UI
{
    public partial class AddNotification : Form
    {
        public AddNotification()
        {
            InitializeComponent();
        }
        private void btnNotificationCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnNotificationSend_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out string kullaniciAdi, out string mesaj))
            {
                try
                {
                    SendNotification(kullaniciAdi, mesaj);
                    MessageBox.Show("Bildirim başarıyla gönderildi.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bildirim gönderilirken bir hata oluştu: " + ex.Message);
                }
            }
        }
        private bool ValidateInputs(out string kullaniciAdi, out string mesaj)
        {
            kullaniciAdi = txtUserNameNotification.Text;
            mesaj = rtbSendMessage.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(mesaj))
            {
                MessageBox.Show("Kullanıcı adı ve mesaj alanları boş olamaz.");
                return false;
            }

            return true;
        }
        private void SendNotification(string kullaniciAdi, string mesaj)
        {
            using (var context = new AppDBContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == kullaniciAdi);
                if (user == null)
                {
                    throw new Exception("Kullanıcı bulunamadı.");
                }

                var notification = new Notification
                {
                    Message = mesaj,
                    NotificationDate = DateTime.Now,
                    UserID = user.UserID
                };

                context.Notifications.Add(notification);
                context.SaveChanges();
            }
        }
    }
}
