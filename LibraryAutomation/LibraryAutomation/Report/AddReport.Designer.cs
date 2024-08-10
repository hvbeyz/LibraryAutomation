namespace LibraryAutomation.UI
{
    partial class AddReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvShowAllReports = new DataGridView();
            cmbChooseType = new ComboBox();
            dtReportCreationDate = new DateTimePicker();
            cmbChooseLibrary = new ComboBox();
            btnCreateReport = new Button();
            btnCancelReport = new Button();
            btnAddReportType = new Button();
            btnCloseAddReport = new Button();
            btnUpdateReport = new Button();
            btnDeleteReport = new Button();
            txtSearchReport = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvShowAllReports).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "Rapor Oluştur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(133, 22);
            label2.TabIndex = 1;
            label2.Text = "Rapor Türü : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 2;
            label3.Text = "Tarih :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(124, 22);
            label4.TabIndex = 3;
            label4.Text = "Kütüphane :";
            // 
            // dgvShowAllReports
            // 
            dgvShowAllReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowAllReports.Dock = DockStyle.Bottom;
            dgvShowAllReports.Location = new Point(0, 281);
            dgvShowAllReports.Name = "dgvShowAllReports";
            dgvShowAllReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShowAllReports.Size = new Size(685, 251);
            dgvShowAllReports.TabIndex = 4;
            dgvShowAllReports.CellContentClick += dgvShowAllReports_CellContentClick;
            // 
            // cmbChooseType
            // 
            cmbChooseType.FormattingEnabled = true;
            cmbChooseType.Location = new Point(151, 84);
            cmbChooseType.Name = "cmbChooseType";
            cmbChooseType.Size = new Size(200, 23);
            cmbChooseType.TabIndex = 5;
            // 
            // dtReportCreationDate
            // 
            dtReportCreationDate.Location = new Point(151, 115);
            dtReportCreationDate.Name = "dtReportCreationDate";
            dtReportCreationDate.Size = new Size(200, 23);
            dtReportCreationDate.TabIndex = 6;
            // 
            // cmbChooseLibrary
            // 
            cmbChooseLibrary.FormattingEnabled = true;
            cmbChooseLibrary.Location = new Point(151, 151);
            cmbChooseLibrary.Name = "cmbChooseLibrary";
            cmbChooseLibrary.Size = new Size(200, 23);
            cmbChooseLibrary.TabIndex = 7;
            // 
            // btnCreateReport
            // 
            btnCreateReport.Location = new Point(445, 194);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(92, 33);
            btnCreateReport.TabIndex = 8;
            btnCreateReport.Text = "Oluştur";
            btnCreateReport.UseVisualStyleBackColor = true;
            btnCreateReport.Click += btnCreateReport_Click;
            // 
            // btnCancelReport
            // 
            btnCancelReport.Location = new Point(151, 194);
            btnCancelReport.Name = "btnCancelReport";
            btnCancelReport.Size = new Size(92, 33);
            btnCancelReport.TabIndex = 9;
            btnCancelReport.Text = "İptal";
            btnCancelReport.UseVisualStyleBackColor = true;
            btnCancelReport.Click += btnCancelReport_Click;
            // 
            // btnAddReportType
            // 
            btnAddReportType.Location = new Point(463, 9);
            btnAddReportType.Name = "btnAddReportType";
            btnAddReportType.Size = new Size(102, 38);
            btnAddReportType.TabIndex = 10;
            btnAddReportType.Text = "Rapor Türü Ekle";
            btnAddReportType.UseVisualStyleBackColor = true;
            btnAddReportType.Click += btnAddReportType_Click;
            // 
            // btnCloseAddReport
            // 
            btnCloseAddReport.Location = new Point(571, 9);
            btnCloseAddReport.Name = "btnCloseAddReport";
            btnCloseAddReport.Size = new Size(102, 38);
            btnCloseAddReport.TabIndex = 11;
            btnCloseAddReport.Text = "Çıkış";
            btnCloseAddReport.UseVisualStyleBackColor = true;
            btnCloseAddReport.Click += btnCloseAddReport_Click;
            // 
            // btnUpdateReport
            // 
            btnUpdateReport.Location = new Point(347, 194);
            btnUpdateReport.Name = "btnUpdateReport";
            btnUpdateReport.Size = new Size(92, 33);
            btnUpdateReport.TabIndex = 12;
            btnUpdateReport.Text = "Düzenle";
            btnUpdateReport.UseVisualStyleBackColor = true;
            btnUpdateReport.Click += btnUpdateReport_Click;
            // 
            // btnDeleteReport
            // 
            btnDeleteReport.Location = new Point(249, 194);
            btnDeleteReport.Name = "btnDeleteReport";
            btnDeleteReport.Size = new Size(92, 33);
            btnDeleteReport.TabIndex = 13;
            btnDeleteReport.Text = "Sil";
            btnDeleteReport.UseVisualStyleBackColor = true;
            btnDeleteReport.Click += btnDeleteReport_Click;
            // 
            // txtSearchReport
            // 
            txtSearchReport.Location = new Point(463, 252);
            txtSearchReport.Name = "txtSearchReport";
            txtSearchReport.PlaceholderText = "Ara";
            txtSearchReport.Size = new Size(210, 23);
            txtSearchReport.TabIndex = 14;
            txtSearchReport.TextChanged += txtSearchReport_TextChanged;
            // 
            // AddReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 532);
            Controls.Add(txtSearchReport);
            Controls.Add(btnDeleteReport);
            Controls.Add(btnUpdateReport);
            Controls.Add(btnCloseAddReport);
            Controls.Add(btnAddReportType);
            Controls.Add(btnCancelReport);
            Controls.Add(btnCreateReport);
            Controls.Add(cmbChooseLibrary);
            Controls.Add(dtReportCreationDate);
            Controls.Add(cmbChooseType);
            Controls.Add(dgvShowAllReports);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddReport";
            Text = "Rapor Oluştur";
            Load += AddReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowAllReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvShowAllReports;
        private ComboBox cmbChooseType;
        private DateTimePicker dtReportCreationDate;
        private ComboBox cmbChooseLibrary;
        private Button btnCreateReport;
        private Button btnCancelReport;
        private Button btnAddReportType;
        private Button btnCloseAddReport;
        private Button btnUpdateReport;
        private Button btnDeleteReport;
        private TextBox txtSearchReport;
    }
}