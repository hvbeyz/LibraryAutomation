namespace LibraryAutomation
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoginLibrary = new Button();
            btnCancelLibrary = new Button();
            btnMemberRegister = new Button();
            ptrBoxMember = new PictureBox();
            txtUserNameLogin = new TextBox();
            txtUserPasswordLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lnklblForgetMyPassword = new LinkLabel();
            cbShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ptrBoxMember).BeginInit();
            SuspendLayout();
            // 
            // btnLoginLibrary
            // 
            btnLoginLibrary.Location = new Point(115, 426);
            btnLoginLibrary.Name = "btnLoginLibrary";
            btnLoginLibrary.Size = new Size(138, 33);
            btnLoginLibrary.TabIndex = 0;
            btnLoginLibrary.Text = "Giriş";
            btnLoginLibrary.UseVisualStyleBackColor = true;
            btnLoginLibrary.Click += btnLoginLibrary_Click;
            // 
            // btnCancelLibrary
            // 
            btnCancelLibrary.Location = new Point(115, 465);
            btnCancelLibrary.Name = "btnCancelLibrary";
            btnCancelLibrary.Size = new Size(138, 33);
            btnCancelLibrary.TabIndex = 1;
            btnCancelLibrary.Text = "İptal";
            btnCancelLibrary.UseVisualStyleBackColor = true;
            btnCancelLibrary.Click += btnCancelLibrary_Click;
            // 
            // btnMemberRegister
            // 
            btnMemberRegister.Location = new Point(115, 504);
            btnMemberRegister.Name = "btnMemberRegister";
            btnMemberRegister.Size = new Size(138, 33);
            btnMemberRegister.TabIndex = 2;
            btnMemberRegister.Text = "Üye Ol";
            btnMemberRegister.UseVisualStyleBackColor = true;
            btnMemberRegister.Click += btnMemberRegister_Click;
            // 
            // ptrBoxMember
            // 
            ptrBoxMember.Location = new Point(12, 12);
            ptrBoxMember.Name = "ptrBoxMember";
            ptrBoxMember.Size = new Size(123, 89);
            ptrBoxMember.TabIndex = 4;
            ptrBoxMember.TabStop = false;
            //ptrBoxMember.Click += ptrBoxMember_Click;
            // 
            // txtUserNameLogin
            // 
            txtUserNameLogin.Location = new Point(68, 245);
            txtUserNameLogin.Name = "txtUserNameLogin";
            txtUserNameLogin.Size = new Size(212, 23);
            txtUserNameLogin.TabIndex = 5;
            // 
            // txtUserPasswordLogin
            // 
            txtUserPasswordLogin.Location = new Point(68, 308);
            txtUserPasswordLogin.Name = "txtUserPasswordLogin";
            txtUserPasswordLogin.PasswordChar = '*';
            txtUserPasswordLogin.Size = new Size(212, 23);
            txtUserPasswordLogin.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(68, 222);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 285);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 9;
            label2.Text = "Şifre : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20F);
            label3.Location = new Point(68, 117);
            label3.Name = "label3";
            label3.Size = new Size(241, 31);
            label3.TabIndex = 10;
            label3.Text = "Kütüphane Sistemi";
            // 
            // lnklblForgetMyPassword
            // 
            lnklblForgetMyPassword.AutoSize = true;
            lnklblForgetMyPassword.Location = new Point(67, 378);
            lnklblForgetMyPassword.Name = "lnklblForgetMyPassword";
            lnklblForgetMyPassword.Size = new Size(104, 15);
            lnklblForgetMyPassword.TabIndex = 11;
            lnklblForgetMyPassword.TabStop = true;
            lnklblForgetMyPassword.Text = "Şifremi Unuttum...";
            lnklblForgetMyPassword.LinkClicked += lnklblForgetMyPassword_LinkClicked;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(68, 337);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(105, 19);
            cbShowPassword.TabIndex = 12;
            cbShowPassword.Text = "Parolayı Göster";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 552);
            Controls.Add(cbShowPassword);
            Controls.Add(lnklblForgetMyPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserPasswordLogin);
            Controls.Add(txtUserNameLogin);
            Controls.Add(ptrBoxMember);
            Controls.Add(btnMemberRegister);
            Controls.Add(btnCancelLibrary);
            Controls.Add(btnLoginLibrary);
            Name = "Login";
            Text = "Kütüphane Sistemi";
            
            ((System.ComponentModel.ISupportInitialize)ptrBoxMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginLibrary;
        private Button btnCancelLibrary;
        private Button btnMemberRegister;
        private PictureBox ptrBoxMember;
        private TextBox txtUserNameLogin;
        private TextBox txtUserPasswordLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel lnklblForgetMyPassword;
        private CheckBox cbShowPassword;
    }
}
