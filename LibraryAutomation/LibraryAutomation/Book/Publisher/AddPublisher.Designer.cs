namespace LibraryAutomation.UI
{
    partial class AddPublisher
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
            dgvPublisherList = new DataGridView();
            btnPublisherAdded = new Button();
            btnPublisherDelete = new Button();
            btnPublisherUpdate = new Button();
            btnExitPublisherAdd = new Button();
            txtPublisherName = new TextBox();
            txtPublisherLongAddress = new TextBox();
            txtPublisherCity = new TextBox();
            txtPublisherCountry = new TextBox();
            txtPublisherPostalCode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPublisherList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 47);
            label1.TabIndex = 0;
            label1.Text = "Yayıncı Ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(43, 106);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 1;
            label2.Text = "Yayıncı Adı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(43, 143);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 2;
            label3.Text = "Yayıncı Adres :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(43, 180);
            label4.Name = "label4";
            label4.Size = new Size(75, 30);
            label4.TabIndex = 3;
            label4.Text = "Şehir :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(43, 217);
            label5.Name = "label5";
            label5.Size = new Size(69, 30);
            label5.TabIndex = 4;
            label5.Text = "Ülke :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(43, 254);
            label6.Name = "label6";
            label6.Size = new Size(124, 30);
            label6.TabIndex = 5;
            label6.Text = "Posta Kod :";
            // 
            // dgvPublisherList
            // 
            dgvPublisherList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublisherList.Dock = DockStyle.Bottom;
            dgvPublisherList.Location = new Point(0, 356);
            dgvPublisherList.Name = "dgvPublisherList";
            dgvPublisherList.Size = new Size(619, 239);
            dgvPublisherList.TabIndex = 6;
            dgvPublisherList.CellClick += dgvPublisherList_CellClick;
            // 
            // btnPublisherAdded
            // 
            btnPublisherAdded.Location = new Point(527, 312);
            btnPublisherAdded.Name = "btnPublisherAdded";
            btnPublisherAdded.Size = new Size(80, 38);
            btnPublisherAdded.TabIndex = 7;
            btnPublisherAdded.Text = "Ekle";
            btnPublisherAdded.UseVisualStyleBackColor = true;
            btnPublisherAdded.Click += btnPublisherAdded_Click;
            // 
            // btnPublisherDelete
            // 
            btnPublisherDelete.Location = new Point(441, 312);
            btnPublisherDelete.Name = "btnPublisherDelete";
            btnPublisherDelete.Size = new Size(80, 38);
            btnPublisherDelete.TabIndex = 8;
            btnPublisherDelete.Text = "Sil";
            btnPublisherDelete.UseVisualStyleBackColor = true;
            // 
            // btnPublisherUpdate
            // 
            btnPublisherUpdate.Location = new Point(355, 312);
            btnPublisherUpdate.Name = "btnPublisherUpdate";
            btnPublisherUpdate.Size = new Size(80, 38);
            btnPublisherUpdate.TabIndex = 9;
            btnPublisherUpdate.Text = "Güncelle";
            btnPublisherUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExitPublisherAdd
            // 
            btnExitPublisherAdd.Location = new Point(527, 9);
            btnExitPublisherAdd.Name = "btnExitPublisherAdd";
            btnExitPublisherAdd.Size = new Size(80, 38);
            btnExitPublisherAdd.TabIndex = 10;
            btnExitPublisherAdd.Text = "Çıkış";
            btnExitPublisherAdd.UseVisualStyleBackColor = true;
            btnExitPublisherAdd.Click += btnExitPublisherAdd_Click;
            // 
            // txtPublisherName
            // 
            txtPublisherName.Location = new Point(204, 113);
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.Size = new Size(233, 23);
            txtPublisherName.TabIndex = 11;
            // 
            // txtPublisherLongAddress
            // 
            txtPublisherLongAddress.Location = new Point(204, 150);
            txtPublisherLongAddress.Name = "txtPublisherLongAddress";
            txtPublisherLongAddress.Size = new Size(233, 23);
            txtPublisherLongAddress.TabIndex = 12;
            // 
            // txtPublisherCity
            // 
            txtPublisherCity.Location = new Point(204, 187);
            txtPublisherCity.Name = "txtPublisherCity";
            txtPublisherCity.Size = new Size(233, 23);
            txtPublisherCity.TabIndex = 13;
            // 
            // txtPublisherCountry
            // 
            txtPublisherCountry.Location = new Point(204, 224);
            txtPublisherCountry.Name = "txtPublisherCountry";
            txtPublisherCountry.Size = new Size(233, 23);
            txtPublisherCountry.TabIndex = 14;
            // 
            // txtPublisherPostalCode
            // 
            txtPublisherPostalCode.Location = new Point(204, 261);
            txtPublisherPostalCode.Name = "txtPublisherPostalCode";
            txtPublisherPostalCode.Size = new Size(233, 23);
            txtPublisherPostalCode.TabIndex = 15;
            // 
            // AddPublisher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 595);
            Controls.Add(txtPublisherPostalCode);
            Controls.Add(txtPublisherCountry);
            Controls.Add(txtPublisherCity);
            Controls.Add(txtPublisherLongAddress);
            Controls.Add(txtPublisherName);
            Controls.Add(btnExitPublisherAdd);
            Controls.Add(btnPublisherUpdate);
            Controls.Add(btnPublisherDelete);
            Controls.Add(btnPublisherAdded);
            Controls.Add(dgvPublisherList);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPublisher";
            Text = "Yayıncı Ekle";
            ((System.ComponentModel.ISupportInitialize)dgvPublisherList).EndInit();
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
        private DataGridView dgvPublisherList;
        private Button btnPublisherAdded;
        private Button btnPublisherDelete;
        private Button btnPublisherUpdate;
        private Button btnExitPublisherAdd;
        private TextBox txtPublisherName;
        private TextBox txtPublisherLongAddress;
        private TextBox txtPublisherCity;
        private TextBox txtPublisherCountry;
        private TextBox txtPublisherPostalCode;
    }
}