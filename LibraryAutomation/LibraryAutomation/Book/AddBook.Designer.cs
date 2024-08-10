namespace LibraryAutomation.UI
{
    partial class AddBook
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAddBookTitle = new TextBox();
            txtAddBookISBN = new TextBox();
            txtAddBookAuthorName = new TextBox();
            txtAddBookGenre = new TextBox();
            txtAddBookCategory = new TextBox();
            btnAddBook = new Button();
            btnCancelAddBook = new Button();
            dtPublishYear = new DateTimePicker();
            cmbPublisherChoose = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(136, 27);
            label1.Name = "label1";
            label1.Size = new Size(174, 37);
            label1.TabIndex = 0;
            label1.Text = "Kitap Ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.Location = new Point(42, 133);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.Location = new Point(45, 340);
            label3.Name = "label3";
            label3.Size = new Size(108, 22);
            label3.TabIndex = 2;
            label3.Text = "Yazar Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.Location = new Point(42, 269);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 3;
            label4.Text = "Yayın Yılı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.Location = new Point(45, 206);
            label5.Name = "label5";
            label5.Size = new Size(72, 22);
            label5.TabIndex = 4;
            label5.Text = "ISBN : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label6.Location = new Point(45, 490);
            label6.Name = "label6";
            label6.Size = new Size(89, 22);
            label6.TabIndex = 5;
            label6.Text = "Yayıncı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label7.Location = new Point(45, 415);
            label7.Name = "label7";
            label7.Size = new Size(55, 22);
            label7.TabIndex = 6;
            label7.Text = "Tür :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label8.Location = new Point(47, 562);
            label8.Name = "label8";
            label8.Size = new Size(106, 22);
            label8.TabIndex = 7;
            label8.Text = "Kategori : ";
            // 
            // txtAddBookTitle
            // 
            txtAddBookTitle.Location = new Point(45, 167);
            txtAddBookTitle.Name = "txtAddBookTitle";
            txtAddBookTitle.Size = new Size(238, 23);
            txtAddBookTitle.TabIndex = 8;
            // 
            // txtAddBookISBN
            // 
            txtAddBookISBN.Location = new Point(47, 231);
            txtAddBookISBN.Name = "txtAddBookISBN";
            txtAddBookISBN.Size = new Size(238, 23);
            txtAddBookISBN.TabIndex = 9;
            // 
            // txtAddBookAuthorName
            // 
            txtAddBookAuthorName.Location = new Point(49, 376);
            txtAddBookAuthorName.Name = "txtAddBookAuthorName";
            txtAddBookAuthorName.Size = new Size(238, 23);
            txtAddBookAuthorName.TabIndex = 10;
            // 
            // txtAddBookGenre
            // 
            txtAddBookGenre.Location = new Point(47, 451);
            txtAddBookGenre.Name = "txtAddBookGenre";
            txtAddBookGenre.Size = new Size(238, 23);
            txtAddBookGenre.TabIndex = 11;
            // 
            // txtAddBookCategory
            // 
            txtAddBookCategory.Location = new Point(49, 597);
            txtAddBookCategory.Name = "txtAddBookCategory";
            txtAddBookCategory.Size = new Size(238, 23);
            txtAddBookCategory.TabIndex = 13;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(293, 657);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(115, 44);
            btnAddBook.TabIndex = 15;
            btnAddBook.Text = "Ekle";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnCancelAddBook
            // 
            btnCancelAddBook.Location = new Point(172, 657);
            btnCancelAddBook.Name = "btnCancelAddBook";
            btnCancelAddBook.Size = new Size(115, 44);
            btnCancelAddBook.TabIndex = 16;
            btnCancelAddBook.Text = "İptal";
            btnCancelAddBook.UseVisualStyleBackColor = true;
            btnCancelAddBook.Click += btnCancelAddBook_Click;
            // 
            // dtPublishYear
            // 
            dtPublishYear.Location = new Point(45, 303);
            dtPublishYear.Name = "dtPublishYear";
            dtPublishYear.Size = new Size(240, 23);
            dtPublishYear.TabIndex = 17;
            // 
            // cmbPublisherChoose
            // 
            cmbPublisherChoose.FormattingEnabled = true;
            cmbPublisherChoose.Location = new Point(49, 526);
            cmbPublisherChoose.Name = "cmbPublisherChoose";
            cmbPublisherChoose.Size = new Size(234, 23);
            cmbPublisherChoose.TabIndex = 18;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 739);
            Controls.Add(cmbPublisherChoose);
            Controls.Add(dtPublishYear);
            Controls.Add(btnCancelAddBook);
            Controls.Add(btnAddBook);
            Controls.Add(txtAddBookCategory);
            Controls.Add(txtAddBookGenre);
            Controls.Add(txtAddBookAuthorName);
            Controls.Add(txtAddBookISBN);
            Controls.Add(txtAddBookTitle);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBook";
            Text = "Kitap Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtAddBookTitle;
        private TextBox txtAddBookISBN;
        private TextBox txtAddBookAuthorName;
        private TextBox txtAddBookGenre;
        private TextBox txtAddBookCategory;
        private Button btnAddBook;
        private Button btnCancelAddBook;
        private DateTimePicker dtPublishYear;
        private ComboBox cmbPublisherChoose;
    }
}