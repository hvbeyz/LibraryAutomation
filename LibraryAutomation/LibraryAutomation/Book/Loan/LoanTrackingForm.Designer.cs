namespace LibraryAutomation.UI
{
    partial class LoanTrackingForm
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
            lvReservationsList = new ListView();
            LoanID = new ColumnHeader();
            LoanDate = new ColumnHeader();
            ReturnDate = new ColumnHeader();
            Penalty = new ColumnHeader();
            MemberName = new ColumnHeader();
            BookName = new ColumnHeader();
            MemberPhone = new ColumnHeader();
            MemberEmail = new ColumnHeader();
            txtSearchReservationsList = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtUserNameLoans = new TextBox();
            txtPenaltyLoans = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            btnLoanExit = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // lvReservationsList
            // 
            lvReservationsList.Columns.AddRange(new ColumnHeader[] { LoanID, LoanDate, ReturnDate, Penalty, MemberName, BookName, MemberPhone, MemberEmail });
            lvReservationsList.Dock = DockStyle.Bottom;
            lvReservationsList.FullRowSelect = true;
            lvReservationsList.GridLines = true;
            lvReservationsList.Location = new Point(0, 254);
            lvReservationsList.Name = "lvReservationsList";
            lvReservationsList.Size = new Size(1030, 256);
            lvReservationsList.TabIndex = 0;
            lvReservationsList.UseCompatibleStateImageBehavior = false;
            lvReservationsList.View = View.Details;
            lvReservationsList.MouseDoubleClick += lvReservationsList_MouseDoubleClick;
            // 
            // LoanID
            // 
            LoanID.Text = "Ödünç ID";
            LoanID.Width = 120;
            // 
            // LoanDate
            // 
            LoanDate.Text = "Ödünç Tarihi";
            LoanDate.Width = 120;
            // 
            // ReturnDate
            // 
            ReturnDate.Text = "Teslim Tarihi";
            ReturnDate.Width = 120;
            // 
            // Penalty
            // 
            Penalty.Text = "Ceza Puanı";
            Penalty.Width = 120;
            // 
            // MemberName
            // 
            MemberName.Text = "Üye Adı";
            MemberName.Width = 120;
            // 
            // BookName
            // 
            BookName.DisplayIndex = 7;
            BookName.Text = "Kitap Adı";
            BookName.Width = 120;
            // 
            // MemberPhone
            // 
            MemberPhone.DisplayIndex = 5;
            MemberPhone.Text = "Üye Telefon Numarası";
            MemberPhone.Width = 120;
            // 
            // MemberEmail
            // 
            MemberEmail.DisplayIndex = 6;
            MemberEmail.Text = "Üye E-Mail ";
            MemberEmail.Width = 120;
            // 
            // txtSearchReservationsList
            // 
            txtSearchReservationsList.Location = new Point(783, 227);
            txtSearchReservationsList.Name = "txtSearchReservationsList";
            txtSearchReservationsList.PlaceholderText = "Ara";
            txtSearchReservationsList.Size = new Size(235, 23);
            txtSearchReservationsList.TabIndex = 1;
            txtSearchReservationsList.TextChanged += txtSearchReservationsList_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(43, 59);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Üye Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(43, 91);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 3;
            label2.Text = "Ceza Puanı : ";
            // 
            // txtUserNameLoans
            // 
            txtUserNameLoans.Location = new Point(135, 56);
            txtUserNameLoans.Name = "txtUserNameLoans";
            txtUserNameLoans.Size = new Size(216, 23);
            txtUserNameLoans.TabIndex = 4;
            // 
            // txtPenaltyLoans
            // 
            txtPenaltyLoans.Location = new Point(137, 91);
            txtPenaltyLoans.Name = "txtPenaltyLoans";
            txtPenaltyLoans.Size = new Size(214, 23);
            txtPenaltyLoans.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(139, 132);
            button1.Name = "button1";
            button1.Size = new Size(88, 37);
            button1.TabIndex = 6;
            button1.Text = "Ceza Sıfırla";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(253, 132);
            button2.Name = "button2";
            button2.Size = new Size(88, 37);
            button2.TabIndex = 7;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(414, 25);
            label3.TabIndex = 8;
            label3.Text = "Geciken gün başına eklenen ceza puanı : ";
            // 
            // btnLoanExit
            // 
            btnLoanExit.Location = new Point(930, 12);
            btnLoanExit.Name = "btnLoanExit";
            btnLoanExit.Size = new Size(88, 37);
            btnLoanExit.TabIndex = 9;
            btnLoanExit.Text = "Çıkış";
            btnLoanExit.UseVisualStyleBackColor = true;
            btnLoanExit.Click += btnLoanExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F);
            label4.Location = new Point(417, 10);
            label4.Name = "label4";
            label4.Size = new Size(36, 25);
            label4.TabIndex = 10;
            label4.Text = "10";
            // 
            // LoanTrackingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 510);
            Controls.Add(label4);
            Controls.Add(btnLoanExit);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPenaltyLoans);
            Controls.Add(txtUserNameLoans);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearchReservationsList);
            Controls.Add(lvReservationsList);
            Name = "LoanTrackingForm";
            Text = "Ödünç Takip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvReservationsList;
        private ColumnHeader LoanID;
        private ColumnHeader LoanDate;
        private ColumnHeader ReturnDate;
        private ColumnHeader Penalty;
        private ColumnHeader MemberName;
        private ColumnHeader BookName;
        private ColumnHeader MemberPhone;
        private ColumnHeader MemberEmail;
        private TextBox txtSearchReservationsList;
        private Label label1;
        private Label label2;
        private TextBox txtUserNameLoans;
        private TextBox txtPenaltyLoans;
        private Button button1;
        private Button button2;
        private Label label3;
        private Button btnLoanExit;
        private Label label4;
    }
}