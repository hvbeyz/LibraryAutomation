namespace LibraryAutomation.UI
{
    partial class MemberSystem
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
            dgvMemberSysBookList = new DataGridView();
            btnMemberReservation = new Button();
            btnMemberExit = new Button();
            btnMemberNotification = new Button();
            lnklblUserName = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvMemberSysBookList).BeginInit();
            SuspendLayout();
            // 
            // dgvMemberSysBookList
            // 
            dgvMemberSysBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberSysBookList.Location = new Point(12, 219);
            dgvMemberSysBookList.Name = "dgvMemberSysBookList";
            dgvMemberSysBookList.Size = new Size(1015, 304);
            dgvMemberSysBookList.TabIndex = 0;
            // 
            // btnMemberReservation
            // 
            btnMemberReservation.Location = new Point(871, 529);
            btnMemberReservation.Name = "btnMemberReservation";
            btnMemberReservation.Size = new Size(156, 35);
            btnMemberReservation.TabIndex = 11;
            btnMemberReservation.Text = "Rezervasyon Yap";
            btnMemberReservation.UseVisualStyleBackColor = true;
            btnMemberReservation.Click += btnMemberReservation_Click;
            // 
            // btnMemberExit
            // 
            btnMemberExit.Location = new Point(929, 12);
            btnMemberExit.Name = "btnMemberExit";
            btnMemberExit.Size = new Size(98, 47);
            btnMemberExit.TabIndex = 12;
            btnMemberExit.Text = "Çıkış Yap";
            btnMemberExit.UseVisualStyleBackColor = true;
            btnMemberExit.Click += btnMemberExit_Click;
            // 
            // btnMemberNotification
            // 
            btnMemberNotification.Location = new Point(12, 564);
            btnMemberNotification.Name = "btnMemberNotification";
            btnMemberNotification.Size = new Size(103, 35);
            btnMemberNotification.TabIndex = 13;
            btnMemberNotification.Text = "Bildirim Oluştur";
            btnMemberNotification.UseVisualStyleBackColor = true;
            btnMemberNotification.Click += btnMemberNotification_Click;
            // 
            // lnklblUserName
            // 
            lnklblUserName.AutoSize = true;
            lnklblUserName.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lnklblUserName.Location = new Point(12, 12);
            lnklblUserName.Name = "lnklblUserName";
            lnklblUserName.Size = new Size(149, 37);
            lnklblUserName.TabIndex = 14;
            lnklblUserName.TabStop = true;
            lnklblUserName.Text = "linkLabel1";
            lnklblUserName.LinkClicked += lnklblUserName_LinkClicked;
            // 
            // MemberSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 611);
            Controls.Add(lnklblUserName);
            Controls.Add(btnMemberNotification);
            Controls.Add(btnMemberExit);
            Controls.Add(btnMemberReservation);
            Controls.Add(dgvMemberSysBookList);
            Name = "MemberSystem";
            Text = "Üye Sistemi";
            ((System.ComponentModel.ISupportInitialize)dgvMemberSysBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberSysBookList;
        private Button btnMemberReservation;
        private Button btnMemberExit;
        private Button btnMemberNotification;
        private LinkLabel lnklblUserName;
    }
}