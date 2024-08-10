namespace LibraryAutomation.UI
{
    partial class AddNotification
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
            txtUserNameNotification = new TextBox();
            rtbSendMessage = new RichTextBox();
            btnNotificationSend = new Button();
            btnNotificationCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(25, 110);
            label1.Name = "label1";
            label1.Size = new Size(146, 24);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label2.Location = new Point(25, 182);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 1;
            label2.Text = "Mesaj :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(76, 9);
            label3.Name = "label3";
            label3.Size = new Size(226, 32);
            label3.TabIndex = 2;
            label3.Text = "Bildirim Oluştur";
            // 
            // txtUserNameNotification
            // 
            txtUserNameNotification.Location = new Point(25, 137);
            txtUserNameNotification.Name = "txtUserNameNotification";
            txtUserNameNotification.Size = new Size(234, 23);
            txtUserNameNotification.TabIndex = 3;
            // 
            // rtbSendMessage
            // 
            rtbSendMessage.Location = new Point(25, 209);
            rtbSendMessage.Name = "rtbSendMessage";
            rtbSendMessage.Size = new Size(330, 155);
            rtbSendMessage.TabIndex = 4;
            rtbSendMessage.Text = "";
            // 
            // btnNotificationSend
            // 
            btnNotificationSend.Location = new Point(283, 393);
            btnNotificationSend.Name = "btnNotificationSend";
            btnNotificationSend.Size = new Size(75, 23);
            btnNotificationSend.TabIndex = 5;
            btnNotificationSend.Text = "Gönder";
            btnNotificationSend.UseVisualStyleBackColor = true;
            btnNotificationSend.Click += btnNotificationSend_Click;
            // 
            // btnNotificationCancel
            // 
            btnNotificationCancel.Location = new Point(202, 393);
            btnNotificationCancel.Name = "btnNotificationCancel";
            btnNotificationCancel.Size = new Size(75, 23);
            btnNotificationCancel.TabIndex = 6;
            btnNotificationCancel.Text = "İptal";
            btnNotificationCancel.UseVisualStyleBackColor = true;
            btnNotificationCancel.Click += btnNotificationCancel_Click;
            // 
            // AddNotification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(btnNotificationCancel);
            Controls.Add(btnNotificationSend);
            Controls.Add(rtbSendMessage);
            Controls.Add(txtUserNameNotification);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNotification";
            Text = "Bildirim Oluştur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserNameNotification;
        private RichTextBox rtbSendMessage;
        private Button btnNotificationSend;
        private Button btnNotificationCancel;
    }
}