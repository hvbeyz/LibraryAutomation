using LibraryAutomation.DAL;
using LibraryAutomation.Domain;

namespace LibraryAutomation.UI
{
    public partial class AddReportType : Form
    {
        private readonly AppDBContext _dbContext;

        public AddReportType()
        {
            InitializeComponent();
            _dbContext = new AppDBContext();
        }
        private void btnReportTypeExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddReportType_Load(object sender, EventArgs e)
        {
            LoadReportTypes();
        }
        private void LoadReportTypes()
        {
            lvShowAllReportTypes.Items.Clear();
            var reportTypes = _dbContext.ReportTypes.ToList();
            foreach (var reportType in reportTypes)
            {
                var item = new ListViewItem(reportType.ReportTypeID.ToString())
                {
                    SubItems = { reportType.ReportName }
                };
                lvShowAllReportTypes.Items.Add(item);
            }
        }
        private void btnAddReportType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddReportType.Text))
            {
                MessageBox.Show("Lütfen bir rapor türü adı girin.");
                return;
            }

            var reportType = new ReportType { ReportName = txtAddReportType.Text };
            _dbContext.ReportTypes.Add(reportType);
            _dbContext.SaveChanges();
            LoadReportTypes();
            ClearForm();
        }
        private void btnDeleteReportType_Click(object sender, EventArgs e)
        {
            if (lvShowAllReportTypes.SelectedItems.Count > 0)
            {
                int reportTypeID = Convert.ToInt32(lvShowAllReportTypes.SelectedItems[0].Text);
                var reportType = _dbContext.ReportTypes.Find(reportTypeID);
                if (reportType != null)
                {
                    _dbContext.ReportTypes.Remove(reportType);
                    _dbContext.SaveChanges();
                    LoadReportTypes();
                    ClearForm();
                }
            }
        }
        private void btnReportTypeUpdate_Click(object sender, EventArgs e)
        {
            if (lvShowAllReportTypes.SelectedItems.Count > 0)
            {
                int reportTypeID = Convert.ToInt32(lvShowAllReportTypes.SelectedItems[0].Text);
                var reportType = _dbContext.ReportTypes.Find(reportTypeID);
                if (reportType != null)
                {
                    reportType.ReportName = txtAddReportType.Text;
                    _dbContext.SaveChanges();
                    LoadReportTypes();
                    ClearForm();
                }
            }
        }
        private void txtReportTypesSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtReportTypesSearch.Text.ToLower();
            var filteredReportTypes = _dbContext.ReportTypes
                .Where(rt => rt.ReportTypeID.ToString().Contains(searchValue) || rt.ReportName.ToLower().Contains(searchValue))
                .ToList();
            lvShowAllReportTypes.Items.Clear();
            foreach (var reportType in filteredReportTypes)
            {
                var item = new ListViewItem(reportType.ReportTypeID.ToString())
                {
                    SubItems = { reportType.ReportName }
                };
                lvShowAllReportTypes.Items.Add(item);
            }
        }
        private void lvShowAllReportTypes_DoubleClick(object sender, EventArgs e)
        {
            if (lvShowAllReportTypes.SelectedItems.Count > 0)
            {
                int reportTypeID = Convert.ToInt32(lvShowAllReportTypes.SelectedItems[0].Text);
                var reportType = _dbContext.ReportTypes.Find(reportTypeID);
                if (reportType != null)
                {
                    txtAddReportType.Text = reportType.ReportName;
                }
            }
        }
        private void ClearForm()
        {
            txtAddReportType.Clear();
        }
    }
}
