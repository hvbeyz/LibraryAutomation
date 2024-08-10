namespace LibraryAutomation.UI
{
    partial class AddReservation
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
            txtAddReservationUserName = new TextBox();
            dtAddReservationDate = new DateTimePicker();
            btnAddReservation = new Button();
            btnCancelReservation = new Button();
            cmbBookName = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 38);
            label1.TabIndex = 0;
            label1.Text = "Rezervasyon Yap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.Location = new Point(33, 188);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(33, 125);
            label3.Name = "label3";
            label3.Size = new Size(136, 22);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.Location = new Point(33, 259);
            label4.Name = "label4";
            label4.Size = new Size(201, 22);
            label4.TabIndex = 3;
            label4.Text = "Rezervasyon Tarihi :";
            // 
            // txtAddReservationUserName
            // 
            txtAddReservationUserName.Location = new Point(37, 150);
            txtAddReservationUserName.Name = "txtAddReservationUserName";
            txtAddReservationUserName.Size = new Size(240, 23);
            txtAddReservationUserName.TabIndex = 4;
            // 
            // dtAddReservationDate
            // 
            dtAddReservationDate.Location = new Point(37, 284);
            dtAddReservationDate.Name = "dtAddReservationDate";
            dtAddReservationDate.Size = new Size(240, 23);
            dtAddReservationDate.TabIndex = 6;
            // 
            // btnAddReservation
            // 
            btnAddReservation.Location = new Point(270, 366);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(103, 42);
            btnAddReservation.TabIndex = 7;
            btnAddReservation.Text = "Rezervasyon Yap ";
            btnAddReservation.UseVisualStyleBackColor = true;
            btnAddReservation.Click += btnAddReservation_Click;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.Location = new Point(161, 366);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(103, 42);
            btnCancelReservation.TabIndex = 8;
            btnCancelReservation.Text = "İptal";
            btnCancelReservation.UseVisualStyleBackColor = true;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // cmbBookName
            // 
            cmbBookName.FormattingEnabled = true;
            cmbBookName.Location = new Point(37, 223);
            cmbBookName.Name = "cmbBookName";
            cmbBookName.Size = new Size(240, 23);
            cmbBookName.TabIndex = 9;
            // 
            // AddReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 496);
            Controls.Add(cmbBookName);
            Controls.Add(btnCancelReservation);
            Controls.Add(btnAddReservation);
            Controls.Add(dtAddReservationDate);
            Controls.Add(txtAddReservationUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddReservation";
            Text = "Rezervasyon Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAddReservationUserName;
        private DateTimePicker dtAddReservationDate;
        private Button btnAddReservation;
        private Button btnCancelReservation;
        private ComboBox cmbBookName;
    }
}