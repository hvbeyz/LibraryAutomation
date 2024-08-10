namespace LibraryAutomation.UI
{
    partial class EmployeeSystem
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
            dgvBookList = new DataGridView();
            btnLoanTracking = new Button();
            btnReservationTracking = new Button();
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            btnAddBook = new Button();
            btnExitEmployeeSystem = new Button();
            btnPublisherAdd = new Button();
            dgvNotificationList = new DataGridView();
            label1 = new Label();
            dgvAllReports = new DataGridView();
            label2 = new Label();
            btnLoanBook = new Button();
            btnBackBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotificationList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllReports).BeginInit();
            SuspendLayout();
            // 
            // dgvBookList
            // 
            dgvBookList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(12, 56);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.Size = new Size(776, 210);
            dgvBookList.TabIndex = 0;
            // 
            // btnLoanTracking
            // 
            btnLoanTracking.Location = new Point(141, 12);
            btnLoanTracking.Name = "btnLoanTracking";
            btnLoanTracking.Size = new Size(123, 38);
            btnLoanTracking.TabIndex = 1;
            btnLoanTracking.Text = "Ödünç Takip";
            btnLoanTracking.UseVisualStyleBackColor = true;
            btnLoanTracking.Click += btnLoanTracking_Click;
            // 
            // btnReservationTracking
            // 
            btnReservationTracking.Location = new Point(12, 12);
            btnReservationTracking.Name = "btnReservationTracking";
            btnReservationTracking.Size = new Size(123, 38);
            btnReservationTracking.TabIndex = 2;
            btnReservationTracking.Text = "Rezervasyon Takip";
            btnReservationTracking.UseVisualStyleBackColor = true;
            btnReservationTracking.Click += btnReservationTracking_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(409, 272);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(123, 38);
            btnDeleteBook.TabIndex = 3;
            btnDeleteBook.Text = "Kitap Sil";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(538, 272);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(123, 38);
            btnUpdateBook.TabIndex = 4;
            btnUpdateBook.Text = "Kitap Güncelle";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(666, 272);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(123, 38);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Kitap Ekle";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnExitEmployeeSystem
            // 
            btnExitEmployeeSystem.Location = new Point(665, 12);
            btnExitEmployeeSystem.Name = "btnExitEmployeeSystem";
            btnExitEmployeeSystem.Size = new Size(123, 38);
            btnExitEmployeeSystem.TabIndex = 6;
            btnExitEmployeeSystem.Text = "Çıkış";
            btnExitEmployeeSystem.UseVisualStyleBackColor = true;
            btnExitEmployeeSystem.Click += btnExitEmployeeSystem_Click;
            // 
            // btnPublisherAdd
            // 
            btnPublisherAdd.Location = new Point(528, 12);
            btnPublisherAdd.Name = "btnPublisherAdd";
            btnPublisherAdd.Size = new Size(123, 38);
            btnPublisherAdd.TabIndex = 7;
            btnPublisherAdd.Text = "Yayıncı Ekle";
            btnPublisherAdd.UseVisualStyleBackColor = true;
            btnPublisherAdd.Click += btnPublisherAdd_Click;
            // 
            // dgvNotificationList
            // 
            dgvNotificationList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvNotificationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotificationList.Location = new Point(12, 337);
            dgvNotificationList.Name = "dgvNotificationList";
            dgvNotificationList.Size = new Size(776, 238);
            dgvNotificationList.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 302);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 9;
            label1.Text = "Bildirimler";
            // 
            // dgvAllReports
            // 
            dgvAllReports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAllReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllReports.Location = new Point(12, 653);
            dgvAllReports.Name = "dgvAllReports";
            dgvAllReports.Size = new Size(776, 233);
            dgvAllReports.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 618);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 11;
            label2.Text = "Raporlar";
            // 
            // btnLoanBook
            // 
            btnLoanBook.Location = new Point(270, 12);
            btnLoanBook.Name = "btnLoanBook";
            btnLoanBook.Size = new Size(123, 38);
            btnLoanBook.TabIndex = 12;
            btnLoanBook.Text = "Ödünç Ver";
            btnLoanBook.UseVisualStyleBackColor = true;
            btnLoanBook.Click += btnLoanBook_Click;
            // 
            // btnBackBook
            // 
            btnBackBook.Location = new Point(399, 12);
            btnBackBook.Name = "btnBackBook";
            btnBackBook.Size = new Size(123, 38);
            btnBackBook.TabIndex = 13;
            btnBackBook.Text = "Ödünç Al";
            btnBackBook.UseVisualStyleBackColor = true;
            btnBackBook.Click += btnBackBook_Click;
            // 
            // EmployeeSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 898);
            Controls.Add(btnBackBook);
            Controls.Add(btnLoanBook);
            Controls.Add(label2);
            Controls.Add(dgvAllReports);
            Controls.Add(label1);
            Controls.Add(dgvNotificationList);
            Controls.Add(btnPublisherAdd);
            Controls.Add(btnExitEmployeeSystem);
            Controls.Add(btnAddBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnReservationTracking);
            Controls.Add(btnLoanTracking);
            Controls.Add(dgvBookList);
            Name = "EmployeeSystem";
            Text = "Personel Sistemi";
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotificationList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBookList;
        private Button btnLoanTracking;
        private Button btnReservationTracking;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnAddBook;
        private Button btnExitEmployeeSystem;
        private Button btnPublisherAdd;
        private DataGridView dgvNotificationList;
        private Label label1;
        private DataGridView dgvAllReports;
        private Label label2;
        private Button btnLoanBook;
        private Button btnBackBook;
    }
}