namespace LibraryAutomation.UI
{
    partial class LoanBook
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
            label5 = new Label();
            dtLoanDate = new DateTimePicker();
            dtReturnDate = new DateTimePicker();
            btnLoanBookExit = new Button();
            btnLoanBook = new Button();
            btnLoanBookCancel = new Button();
            cmbUserNameLoan = new ComboBox();
            cmbBookNameLoan = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 131);
            label1.Name = "label1";
            label1.Size = new Size(147, 26);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold);
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(114, 26);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold);
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(130, 26);
            label3.TabIndex = 2;
            label3.Text = "Alım Tarihi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold);
            label4.Location = new Point(12, 243);
            label4.Name = "label4";
            label4.Size = new Size(150, 26);
            label4.TabIndex = 3;
            label4.Text = "Teslim Tarihi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(150, 9);
            label5.Name = "label5";
            label5.Size = new Size(181, 41);
            label5.TabIndex = 4;
            label5.Text = "Ödünç Ver";
            // 
            // dtLoanDate
            // 
            dtLoanDate.Location = new Point(181, 207);
            dtLoanDate.Name = "dtLoanDate";
            dtLoanDate.Size = new Size(200, 23);
            dtLoanDate.TabIndex = 7;
            // 
            // dtReturnDate
            // 
            dtReturnDate.Location = new Point(181, 246);
            dtReturnDate.Name = "dtReturnDate";
            dtReturnDate.Size = new Size(200, 23);
            dtReturnDate.TabIndex = 8;
            // 
            // btnLoanBookExit
            // 
            btnLoanBookExit.Location = new Point(373, 12);
            btnLoanBookExit.Name = "btnLoanBookExit";
            btnLoanBookExit.Size = new Size(92, 40);
            btnLoanBookExit.TabIndex = 9;
            btnLoanBookExit.Text = "Çıkış";
            btnLoanBookExit.UseVisualStyleBackColor = true;
            btnLoanBookExit.Click += btnLoanBookExit_Click;
            // 
            // btnLoanBook
            // 
            btnLoanBook.Location = new Point(359, 284);
            btnLoanBook.Name = "btnLoanBook";
            btnLoanBook.Size = new Size(92, 40);
            btnLoanBook.TabIndex = 10;
            btnLoanBook.Text = "Ödünç Ver";
            btnLoanBook.UseVisualStyleBackColor = true;
            btnLoanBook.Click += btnLoanBook_Click;
            // 
            // btnLoanBookCancel
            // 
            btnLoanBookCancel.Location = new Point(261, 284);
            btnLoanBookCancel.Name = "btnLoanBookCancel";
            btnLoanBookCancel.Size = new Size(92, 40);
            btnLoanBookCancel.TabIndex = 11;
            btnLoanBookCancel.Text = "İptal";
            btnLoanBookCancel.UseVisualStyleBackColor = true;
            btnLoanBookCancel.Click += btnLoanBookCancel_Click;
            // 
            // cmbUserNameLoan
            // 
            cmbUserNameLoan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUserNameLoan.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUserNameLoan.FormattingEnabled = true;
            cmbUserNameLoan.Location = new Point(181, 131);
            cmbUserNameLoan.Name = "cmbUserNameLoan";
            cmbUserNameLoan.Size = new Size(198, 23);
            cmbUserNameLoan.TabIndex = 12;
            cmbUserNameLoan.TextChanged += cmbUserNameLoan_TextChanged;
            // 
            // cmbBookNameLoan
            // 
            cmbBookNameLoan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBookNameLoan.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBookNameLoan.FormattingEnabled = true;
            cmbBookNameLoan.Location = new Point(181, 171);
            cmbBookNameLoan.Name = "cmbBookNameLoan";
            cmbBookNameLoan.Size = new Size(200, 23);
            cmbBookNameLoan.TabIndex = 13;
            // 
            // LoanBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 382);
            Controls.Add(cmbBookNameLoan);
            Controls.Add(cmbUserNameLoan);
            Controls.Add(btnLoanBookCancel);
            Controls.Add(btnLoanBook);
            Controls.Add(btnLoanBookExit);
            Controls.Add(dtReturnDate);
            Controls.Add(dtLoanDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoanBook";
            Text = "Ödünç Ver";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtLoanDate;
        private DateTimePicker dtReturnDate;
        private Button btnLoanBookExit;
        private Button btnLoanBook;
        private Button btnLoanBookCancel;
        private ComboBox cmbUserNameLoan;
        private ComboBox cmbBookNameLoan;
    }
}