namespace LibraryAutomation.UI
{
    partial class BookUpdate
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
            cmbUpdatePublisherChoose = new ComboBox();
            dtUpdatePublishYear = new DateTimePicker();
            btnCancelAddBook = new Button();
            btnAddBook = new Button();
            txtUpdateBookCategory = new TextBox();
            txtUpdateBookGenre = new TextBox();
            txtUpdateBookAuthorName = new TextBox();
            txtUpdateBookISBN = new TextBox();
            txtUpdateBookTitle = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbUpdatePublisherChoose
            // 
            cmbUpdatePublisherChoose.FormattingEnabled = true;
            cmbUpdatePublisherChoose.Location = new Point(40, 508);
            cmbUpdatePublisherChoose.Name = "cmbUpdatePublisherChoose";
            cmbUpdatePublisherChoose.Size = new Size(234, 23);
            cmbUpdatePublisherChoose.TabIndex = 35;
            // 
            // dtUpdatePublishYear
            // 
            dtUpdatePublishYear.Location = new Point(36, 285);
            dtUpdatePublishYear.Name = "dtUpdatePublishYear";
            dtUpdatePublishYear.Size = new Size(240, 23);
            dtUpdatePublishYear.TabIndex = 34;
            // 
            // btnCancelAddBook
            // 
            btnCancelAddBook.Location = new Point(163, 639);
            btnCancelAddBook.Name = "btnCancelAddBook";
            btnCancelAddBook.Size = new Size(115, 44);
            btnCancelAddBook.TabIndex = 33;
            btnCancelAddBook.Text = "İptal";
            btnCancelAddBook.UseVisualStyleBackColor = true;
            btnCancelAddBook.Click += btnCancelAddBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(284, 639);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(115, 44);
            btnAddBook.TabIndex = 32;
            btnAddBook.Text = "Güncelle";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtUpdateBookCategory
            // 
            txtUpdateBookCategory.Location = new Point(40, 579);
            txtUpdateBookCategory.Name = "txtUpdateBookCategory";
            txtUpdateBookCategory.Size = new Size(238, 23);
            txtUpdateBookCategory.TabIndex = 31;
            // 
            // txtUpdateBookGenre
            // 
            txtUpdateBookGenre.Location = new Point(38, 433);
            txtUpdateBookGenre.Name = "txtUpdateBookGenre";
            txtUpdateBookGenre.Size = new Size(238, 23);
            txtUpdateBookGenre.TabIndex = 30;
            // 
            // txtUpdateBookAuthorName
            // 
            txtUpdateBookAuthorName.Location = new Point(40, 358);
            txtUpdateBookAuthorName.Name = "txtUpdateBookAuthorName";
            txtUpdateBookAuthorName.Size = new Size(238, 23);
            txtUpdateBookAuthorName.TabIndex = 29;
            // 
            // txtUpdateBookISBN
            // 
            txtUpdateBookISBN.Location = new Point(38, 213);
            txtUpdateBookISBN.Name = "txtUpdateBookISBN";
            txtUpdateBookISBN.Size = new Size(238, 23);
            txtUpdateBookISBN.TabIndex = 28;
            // 
            // txtUpdateBookTitle
            // 
            txtUpdateBookTitle.Location = new Point(36, 149);
            txtUpdateBookTitle.Name = "txtUpdateBookTitle";
            txtUpdateBookTitle.Size = new Size(238, 23);
            txtUpdateBookTitle.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label8.Location = new Point(38, 544);
            label8.Name = "label8";
            label8.Size = new Size(106, 22);
            label8.TabIndex = 26;
            label8.Text = "Kategori : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label7.Location = new Point(36, 397);
            label7.Name = "label7";
            label7.Size = new Size(55, 22);
            label7.TabIndex = 25;
            label7.Text = "Tür :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label6.Location = new Point(36, 472);
            label6.Name = "label6";
            label6.Size = new Size(89, 22);
            label6.TabIndex = 24;
            label6.Text = "Yayıncı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.Location = new Point(36, 188);
            label5.Name = "label5";
            label5.Size = new Size(72, 22);
            label5.TabIndex = 23;
            label5.Text = "ISBN : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.Location = new Point(33, 251);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 22;
            label4.Text = "Yayın Yılı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.Location = new Point(36, 322);
            label3.Name = "label3";
            label3.Size = new Size(108, 22);
            label3.TabIndex = 21;
            label3.Text = "Yazar Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.Location = new Point(33, 115);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 20;
            label2.Text = "Kitap Adı : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 37);
            label1.TabIndex = 19;
            label1.Text = "Kitap Güncelle";
            // 
            // BookUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 713);
            Controls.Add(cmbUpdatePublisherChoose);
            Controls.Add(dtUpdatePublishYear);
            Controls.Add(btnCancelAddBook);
            Controls.Add(btnAddBook);
            Controls.Add(txtUpdateBookCategory);
            Controls.Add(txtUpdateBookGenre);
            Controls.Add(txtUpdateBookAuthorName);
            Controls.Add(txtUpdateBookISBN);
            Controls.Add(txtUpdateBookTitle);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookUpdate";
            Text = "Kitap Güncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUpdatePublisherChoose;
        private DateTimePicker dtUpdatePublishYear;
        private Button btnCancelAddBook;
        private Button btnAddBook;
        private TextBox txtUpdateBookCategory;
        private TextBox txtUpdateBookGenre;
        private TextBox txtUpdateBookAuthorName;
        private TextBox txtUpdateBookISBN;
        private TextBox txtUpdateBookTitle;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}