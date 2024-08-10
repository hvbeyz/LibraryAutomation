namespace LibraryAutomation.UI
{
    partial class BackBook
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
            cmbBookNameBackBook = new ComboBox();
            cmbUserNameBackBook = new ComboBox();
            btnLoanBookBackCancel = new Button();
            btnLoanBookBack = new Button();
            btnLoanBookBackExit = new Button();
            dtLoanDateBackBook = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbBookNameBackBook
            // 
            cmbBookNameBackBook.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBookNameBackBook.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBookNameBackBook.FormattingEnabled = true;
            cmbBookNameBackBook.Location = new Point(205, 171);
            cmbBookNameBackBook.Name = "cmbBookNameBackBook";
            cmbBookNameBackBook.Size = new Size(200, 23);
            cmbBookNameBackBook.TabIndex = 25;
            // 
            // cmbUserNameBackBook
            // 
            cmbUserNameBackBook.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUserNameBackBook.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUserNameBackBook.FormattingEnabled = true;
            cmbUserNameBackBook.Location = new Point(205, 131);
            cmbUserNameBackBook.Name = "cmbUserNameBackBook";
            cmbUserNameBackBook.Size = new Size(198, 23);
            cmbUserNameBackBook.TabIndex = 24;
            // 
            // btnLoanBookBackCancel
            // 
            btnLoanBookBackCancel.Location = new Point(285, 284);
            btnLoanBookBackCancel.Name = "btnLoanBookBackCancel";
            btnLoanBookBackCancel.Size = new Size(92, 40);
            btnLoanBookBackCancel.TabIndex = 23;
            btnLoanBookBackCancel.Text = "İptal";
            btnLoanBookBackCancel.UseVisualStyleBackColor = true;
            // 
            // btnLoanBookBack
            // 
            btnLoanBookBack.Location = new Point(383, 284);
            btnLoanBookBack.Name = "btnLoanBookBack";
            btnLoanBookBack.Size = new Size(92, 40);
            btnLoanBookBack.TabIndex = 22;
            btnLoanBookBack.Text = "Alındı";
            btnLoanBookBack.UseVisualStyleBackColor = true;
            btnLoanBookBack.Click += btnLoanBookBack_Click;
            // 
            // btnLoanBookBackExit
            // 
            btnLoanBookBackExit.Location = new Point(397, 12);
            btnLoanBookBackExit.Name = "btnLoanBookBackExit";
            btnLoanBookBackExit.Size = new Size(92, 40);
            btnLoanBookBackExit.TabIndex = 21;
            btnLoanBookBackExit.Text = "Çıkış";
            btnLoanBookBackExit.UseVisualStyleBackColor = true;
            btnLoanBookBackExit.Click += btnLoanBookBackExit_Click;
            // 
            // dtLoanDateBackBook
            // 
            dtLoanDateBackBook.Location = new Point(205, 207);
            dtLoanDateBackBook.Name = "dtLoanDateBackBook";
            dtLoanDateBackBook.Size = new Size(200, 23);
            dtLoanDateBackBook.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(145, 9);
            label5.Name = "label5";
            label5.Size = new Size(161, 41);
            label5.TabIndex = 18;
            label5.Text = "Ödünç Al";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold);
            label3.Location = new Point(36, 205);
            label3.Name = "label3";
            label3.Size = new Size(130, 26);
            label3.TabIndex = 16;
            label3.Text = "Alım Tarihi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold);
            label2.Location = new Point(36, 166);
            label2.Name = "label2";
            label2.Size = new Size(114, 26);
            label2.TabIndex = 15;
            label2.Text = "Kitap Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(36, 131);
            label1.Name = "label1";
            label1.Size = new Size(147, 26);
            label1.TabIndex = 14;
            label1.Text = "Kullanıcı Adı :";
            // 
            // BackBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 332);
            Controls.Add(cmbBookNameBackBook);
            Controls.Add(cmbUserNameBackBook);
            Controls.Add(btnLoanBookBackCancel);
            Controls.Add(btnLoanBookBack);
            Controls.Add(btnLoanBookBackExit);
            Controls.Add(dtLoanDateBackBook);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BackBook";
            Text = "Ödünç Al";
            Load += BackBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBookNameBackBook;
        private ComboBox cmbUserNameBackBook;
        private Button btnLoanBookBackCancel;
        private Button btnLoanBookBack;
        private Button btnLoanBookBackExit;
        private DateTimePicker dtLoanDateBackBook;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}