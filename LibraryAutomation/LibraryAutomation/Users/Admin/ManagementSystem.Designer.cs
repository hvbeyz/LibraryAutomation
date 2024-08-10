namespace LibraryAutomation.UI
{
    partial class ManagementSystem
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
            btnEmployeeCreateAndUpdate = new Button();
            btnCreateReport = new Button();
            btnMemberRegisterUpdate = new Button();
            btnManagementSystemExit = new Button();
            btnShowAllUsers = new Button();
            SuspendLayout();
            // 
            // btnEmployeeCreateAndUpdate
            // 
            btnEmployeeCreateAndUpdate.Location = new Point(72, 118);
            btnEmployeeCreateAndUpdate.Name = "btnEmployeeCreateAndUpdate";
            btnEmployeeCreateAndUpdate.Size = new Size(156, 35);
            btnEmployeeCreateAndUpdate.TabIndex = 1;
            btnEmployeeCreateAndUpdate.Text = "Personel İşlemleri";
            btnEmployeeCreateAndUpdate.UseVisualStyleBackColor = true;
            btnEmployeeCreateAndUpdate.Click += btnEmployeeCreateAndUpdate_Click;
            // 
            // btnCreateReport
            // 
            btnCreateReport.Location = new Point(72, 200);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(156, 35);
            btnCreateReport.TabIndex = 2;
            btnCreateReport.Text = "Rapor Oluştur";
            btnCreateReport.UseVisualStyleBackColor = true;
            btnCreateReport.Click += btnCreateReport_Click;
            // 
            // btnMemberRegisterUpdate
            // 
            btnMemberRegisterUpdate.Location = new Point(72, 77);
            btnMemberRegisterUpdate.Name = "btnMemberRegisterUpdate";
            btnMemberRegisterUpdate.Size = new Size(156, 35);
            btnMemberRegisterUpdate.TabIndex = 6;
            btnMemberRegisterUpdate.Text = "Üye İşlemleri";
            btnMemberRegisterUpdate.UseVisualStyleBackColor = true;
            btnMemberRegisterUpdate.Click += btnMemberRegisterUpdate_Click;
            // 
            // btnManagementSystemExit
            // 
            btnManagementSystemExit.Location = new Point(72, 241);
            btnManagementSystemExit.Name = "btnManagementSystemExit";
            btnManagementSystemExit.Size = new Size(156, 35);
            btnManagementSystemExit.TabIndex = 8;
            btnManagementSystemExit.Text = "Çıkış Yap";
            btnManagementSystemExit.UseVisualStyleBackColor = true;
            btnManagementSystemExit.Click += btnManagementSystemExit_Click;
            // 
            // btnShowAllUsers
            // 
            btnShowAllUsers.Location = new Point(72, 159);
            btnShowAllUsers.Name = "btnShowAllUsers";
            btnShowAllUsers.Size = new Size(156, 35);
            btnShowAllUsers.TabIndex = 11;
            btnShowAllUsers.Text = "Tüm Kullanıcıları Göster";
            btnShowAllUsers.UseVisualStyleBackColor = true;
            btnShowAllUsers.Click += btnShowAllUsers_Click;
            // 
            // ManagementSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 347);
            Controls.Add(btnShowAllUsers);
            Controls.Add(btnManagementSystemExit);
            Controls.Add(btnMemberRegisterUpdate);
            Controls.Add(btnCreateReport);
            Controls.Add(btnEmployeeCreateAndUpdate);
            Name = "ManagementSystem";
            Text = "Yönetim Sistemi";
            ResumeLayout(false);
        }

        #endregion
        private Button btnEmployeeCreateAndUpdate;
        private Button btnCreateReport;
        private Button btnMemberRegisterUpdate;
        private Button btnManagementSystemExit;
        private Button btnShowAllUsers;
    }
}