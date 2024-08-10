namespace LibraryAutomation.UI
{
    partial class ShowAllUsersForm
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
            btnCloseAllUsersForm = new Button();
            dgvShowAllUsers = new DataGridView();
            txtSearchUser = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvShowAllUsers).BeginInit();
            SuspendLayout();
            // 
            // btnCloseAllUsersForm
            // 
            btnCloseAllUsersForm.Location = new Point(1013, 37);
            btnCloseAllUsersForm.Name = "btnCloseAllUsersForm";
            btnCloseAllUsersForm.Size = new Size(117, 31);
            btnCloseAllUsersForm.TabIndex = 1;
            btnCloseAllUsersForm.Text = "Çıkış";
            btnCloseAllUsersForm.UseVisualStyleBackColor = true;
            btnCloseAllUsersForm.Click += btnCloseAllUsersForm_Click;
            // 
            // dgvShowAllUsers
            // 
            dgvShowAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowAllUsers.Dock = DockStyle.Bottom;
            dgvShowAllUsers.Location = new Point(0, 74);
            dgvShowAllUsers.Name = "dgvShowAllUsers";
            dgvShowAllUsers.Size = new Size(1142, 389);
            dgvShowAllUsers.TabIndex = 2;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(0, 45);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.PlaceholderText = "Ara";
            txtSearchUser.Size = new Size(234, 23);
            txtSearchUser.TabIndex = 3;
            txtSearchUser.TextChanged += txtSearchUser_TextChanged;
            // 
            // ShowAllUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 463);
            Controls.Add(txtSearchUser);
            Controls.Add(dgvShowAllUsers);
            Controls.Add(btnCloseAllUsersForm);
            Name = "ShowAllUsersForm";
            Text = "Bütün Kullanıcılar";
            ((System.ComponentModel.ISupportInitialize)dgvShowAllUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCloseAllUsersForm;
        private DataGridView dgvShowAllUsers;
        private TextBox txtSearchUser;
    }
}