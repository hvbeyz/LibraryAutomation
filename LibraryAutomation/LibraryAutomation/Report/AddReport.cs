using LibraryAutomation.DAL;
using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.UI
{
    public partial class AddReport : Form
    {
        private readonly AppDBContext _dbContext;

        public AddReport()
        {
            InitializeComponent();
            _dbContext = new AppDBContext();
        }
        private void AddReport_Load(object sender, EventArgs e)
        {
            try
            {
                LoadReportTypes();
                LoadLibraries();
                LoadReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void btnCancelReport_Click(object sender, EventArgs e)
        {
            ClearFormComponents();
        }
        private void btnCloseAddReport_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAddReportType_Click(object sender, EventArgs e)
        {
            var addReportTypeForm = new AddReportType();
            addReportTypeForm.FormClosing += AddReportType_FormClosing;
            addReportTypeForm.Show();
        }
        private void AddReportType_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadReportTypes();
        }
        private void LoadReportTypes()
        {
            var reportTypes = _dbContext.ReportTypes.ToList();
            if (!reportTypes.Any())
            {
                MessageBox.Show("Rapor türünüz bulunmamaktadır. Lütfen rapor türü ekleyiniz.");
            }
            else
            {
                cmbChooseType.DataSource = reportTypes;
                cmbChooseType.DisplayMember = "ReportName";
                cmbChooseType.ValueMember = "ReportTypeID";
            }
        }
        private void LoadReports()
        {
            var reports = _dbContext.Reports
                .Include(r => r.ReportType)
                .Include(r => r.Library)
                .Select(r => new
                {
                    r.ReportID,
                    r.Type,
                    r.CreationDate,
                    LibraryName = r.Library.LibraryName,
                    ReportTypeName = r.ReportType.ReportName
                })
                .ToList();
            dgvShowAllReports.DataSource = reports;

            ConfigureReportGridView();
        }
        private void ConfigureReportGridView()
        {
            dgvShowAllReports.Columns["ReportID"].HeaderText = "Rapor ID";
            dgvShowAllReports.Columns["Type"].HeaderText = "Rapor Türü";
            dgvShowAllReports.Columns["CreationDate"].HeaderText = "Oluşturulma Tarihi";
            dgvShowAllReports.Columns["LibraryName"].HeaderText = "Kütüphane Adı";
            dgvShowAllReports.Columns["ReportTypeName"].HeaderText = "Rapor Adı";
        }
        private void LoadLibraries()
        {
            var libraries = _dbContext.Libraries.ToList();
            if (!libraries.Any())
            {
                MessageBox.Show("Kütüphaneniz bulunmamaktadır. Lütfen kütüphane ekleyiniz.");
            }
            else
            {
                cmbChooseLibrary.DataSource = libraries;
                cmbChooseLibrary.DisplayMember = "LibraryName";
                cmbChooseLibrary.ValueMember = "LibraryID";
            }
        }
        private void ClearFormComponents()
        {
            cmbChooseLibrary.DataSource = null;
            cmbChooseType.DataSource = null;
            dtReportCreationDate.Value = DateTime.Now;
        }
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbChooseType.SelectedValue == null || cmbChooseLibrary.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                var report = new Report
                {
                    Type = cmbChooseType.Text,
                    CreationDate = dtReportCreationDate.Value,
                    LibraryID = (int)cmbChooseLibrary.SelectedValue,
                    ReportTypeID = (int)cmbChooseType.SelectedValue
                };

                _dbContext.Reports.Add(report);
                _dbContext.SaveChanges();
                LoadReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor oluşturulurken bir hata oluştu: " + ex.Message);
            }
        }
        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowAllReports.SelectedRows.Count > 0)
                {
                    int reportID = Convert.ToInt32(dgvShowAllReports.SelectedRows[0].Cells["ReportID"].Value);
                    var report = _dbContext.Reports.Find(reportID);
                    if (report != null)
                    {
                        _dbContext.Reports.Remove(report);
                        _dbContext.SaveChanges();
                        LoadReports();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor silinirken bir hata oluştu: " + ex.Message);
            }
        }
        private void btnUpdateReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShowAllReports.SelectedRows.Count > 0)
                {
                    int reportID = Convert.ToInt32(dgvShowAllReports.SelectedRows[0].Cells["ReportID"].Value);
                    var report = _dbContext.Reports.Find(reportID);
                    if (report != null)
                    {
                        report.Type = cmbChooseType.Text;
                        report.CreationDate = dtReportCreationDate.Value;
                        report.LibraryID = (int)cmbChooseLibrary.SelectedValue;
                        report.ReportTypeID = (int)cmbChooseType.SelectedValue;
                        _dbContext.SaveChanges();
                        LoadReports();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor düzenlenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void dgvShowAllReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int reportID = Convert.ToInt32(dgvShowAllReports.Rows[e.RowIndex].Cells["ReportID"].Value);
                var report = _dbContext.Reports.Find(reportID);
                if (report != null)
                {
                    cmbChooseType.SelectedValue = report.ReportTypeID;
                    cmbChooseLibrary.SelectedValue = report.LibraryID;
                    dtReportCreationDate.Value = report.CreationDate;
                }
            }
        }
        private void txtSearchReport_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchReport.Text.ToLower();

            var reports = _dbContext.Reports
                .Include(r => r.ReportType)
                .Include(r => r.Library)
                .Select(r => new
                {
                    r.ReportID,
                    r.Type,
                    r.CreationDate,
                    LibraryName = r.Library.LibraryName,
                    ReportTypeName = r.ReportType.ReportName
                })
                .ToList();

            var filteredReports = reports
                .Where(r => r.Type.ToLower().Contains(searchValue) ||
                            r.LibraryName.ToLower().Contains(searchValue) ||
                            r.ReportTypeName.ToLower().Contains(searchValue) ||
                            r.CreationDate.ToString("yyyy-MM-dd").Contains(searchValue))
                .ToList();

            dgvShowAllReports.DataSource = filteredReports;
        }
    }
}
