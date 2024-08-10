using LibraryAutomation.BAL;
using LibraryAutomation.Domain;
using Publisher = LibraryAutomation.Domain.Publisher;

namespace LibraryAutomation.UI
{
    public partial class AddPublisher : Form
    {
        private readonly BookServices _bookServices;
        private int _selectedPublisherId = -1;
        public AddPublisher()
        {
            InitializeComponent();
            _bookServices = new BookServices();
            LoadPublishers();
        }
        private void LoadPublishers()
        {
            var publishers = _bookServices.GetAllPublishers();
            var publisherAddresses = _bookServices.GetAllPublisherAddresses();

            var publisherData = publishers.Select(p => new
            {
                p.PublisherID,
                p.Name,
                p.Address,
                Addresses = string.Join(", ", publisherAddresses.Where(pa => pa.PublisherID == p.PublisherID)
                                                                 .Select(pa => $"{pa.City}, {pa.Country}, {pa.PostalCode}"))
            }).ToList();

            dgvPublisherList.DataSource = publisherData;
        }
        private void btnExitPublisherAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvPublisherList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPublisherList.Rows[e.RowIndex];
                _selectedPublisherId = Convert.ToInt32(row.Cells["PublisherID"].Value);
                txtPublisherName.Text = row.Cells["Name"].Value.ToString();
                txtPublisherLongAddress.Text = row.Cells["Address"].Value.ToString();
                var addresses = row.Cells["Addresses"].Value.ToString().Split(new[] { ", " }, StringSplitOptions.None);
                if (addresses.Length > 0) txtPublisherCity.Text = addresses[0];
                if (addresses.Length > 1) txtPublisherCountry.Text = addresses[1];
                if (addresses.Length > 2) txtPublisherPostalCode.Text = addresses[2];
            }
        }
        private void btnPublisherAdded_Click(object sender, EventArgs e)
        {
            try
            {
                var publisherName = txtPublisherName.Text;
                var publisherLongAddress = txtPublisherLongAddress.Text;
                var publisher = new Publisher
                {
                    Name = publisherName,
                    Address = publisherLongAddress,
                };

                _bookServices.AddPublisher(publisher);

                var address = new PublisherAddress
                {
                    PublisherID = publisher.PublisherID,
                    City = txtPublisherCity.Text,
                    Country = txtPublisherCountry.Text,
                    PostalCode = txtPublisherPostalCode.Text
                };

                _bookServices.AddPublisherAddress(address);

                MessageBox.Show("Yayın evi başarıyla eklendi.");
                LoadPublishers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yayın evi eklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            txtPublisherCity.Clear();
            txtPublisherCountry.Clear();
            txtPublisherPostalCode.Clear();
            txtPublisherName.Clear();
            txtPublisherLongAddress.Clear();
            _selectedPublisherId = -1;
        }
    }
}
