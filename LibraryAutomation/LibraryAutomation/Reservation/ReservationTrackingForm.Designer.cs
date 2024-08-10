namespace LibraryAutomation.UI
{
    partial class ReservationTrackingForm
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
            dgvReservationTrakingList = new DataGridView();
            btnAddReservationEmployee = new Button();
            btnUpdateReservations = new Button();
            btnDeleteReservation = new Button();
            txtSearchReservation = new TextBox();
            dtEmployeeReservationDate = new DateTimePicker();
            txtEmployeeReservationBookName = new TextBox();
            txtEmployeeReservationUserName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnReservationTrackingExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservationTrakingList).BeginInit();
            SuspendLayout();
            // 
            // dgvReservationTrakingList
            // 
            dgvReservationTrakingList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservationTrakingList.Dock = DockStyle.Bottom;
            dgvReservationTrakingList.Location = new Point(0, 213);
            dgvReservationTrakingList.Name = "dgvReservationTrakingList";
            dgvReservationTrakingList.Size = new Size(800, 237);
            dgvReservationTrakingList.TabIndex = 0;
            // 
            // btnAddReservationEmployee
            // 
            btnAddReservationEmployee.Location = new Point(713, 142);
            btnAddReservationEmployee.Name = "btnAddReservationEmployee";
            btnAddReservationEmployee.Size = new Size(75, 23);
            btnAddReservationEmployee.TabIndex = 1;
            btnAddReservationEmployee.Text = "Ekle";
            btnAddReservationEmployee.UseVisualStyleBackColor = true;
            btnAddReservationEmployee.Click += btnAddReservationEmployee_Click;
            // 
            // btnUpdateReservations
            // 
            btnUpdateReservations.Location = new Point(632, 142);
            btnUpdateReservations.Name = "btnUpdateReservations";
            btnUpdateReservations.Size = new Size(75, 23);
            btnUpdateReservations.TabIndex = 2;
            btnUpdateReservations.Text = "Düzenle";
            btnUpdateReservations.UseVisualStyleBackColor = true;
            btnUpdateReservations.Click += btnUpdateReservations_Click;
            // 
            // btnDeleteReservation
            // 
            btnDeleteReservation.Location = new Point(551, 142);
            btnDeleteReservation.Name = "btnDeleteReservation";
            btnDeleteReservation.Size = new Size(75, 23);
            btnDeleteReservation.TabIndex = 3;
            btnDeleteReservation.Text = "Sil";
            btnDeleteReservation.UseVisualStyleBackColor = true;
            btnDeleteReservation.Click += btnDeleteReservation_Click;
            // 
            // txtSearchReservation
            // 
            txtSearchReservation.Location = new Point(554, 184);
            txtSearchReservation.Name = "txtSearchReservation";
            txtSearchReservation.PlaceholderText = "Ara";
            txtSearchReservation.Size = new Size(234, 23);
            txtSearchReservation.TabIndex = 4;
            txtSearchReservation.TextChanged += txtSearchReservation_TextChanged;
            // 
            // dtEmployeeReservationDate
            // 
            dtEmployeeReservationDate.Location = new Point(16, 165);
            dtEmployeeReservationDate.Name = "dtEmployeeReservationDate";
            dtEmployeeReservationDate.Size = new Size(240, 23);
            dtEmployeeReservationDate.TabIndex = 12;
            // 
            // txtEmployeeReservationBookName
            // 
            txtEmployeeReservationBookName.Location = new Point(16, 97);
            txtEmployeeReservationBookName.Name = "txtEmployeeReservationBookName";
            txtEmployeeReservationBookName.Size = new Size(240, 23);
            txtEmployeeReservationBookName.TabIndex = 11;
            // 
            // txtEmployeeReservationUserName
            // 
            txtEmployeeReservationUserName.Location = new Point(16, 34);
            txtEmployeeReservationUserName.Name = "txtEmployeeReservationUserName";
            txtEmployeeReservationUserName.Size = new Size(240, 23);
            txtEmployeeReservationUserName.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(201, 22);
            label4.TabIndex = 9;
            label4.Text = "Rezervasyon Tarihi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(136, 22);
            label3.TabIndex = 8;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 7;
            label2.Text = "Kitap Adı :";
            // 
            // btnReservationTrackingExit
            // 
            btnReservationTrackingExit.Location = new Point(713, 12);
            btnReservationTrackingExit.Name = "btnReservationTrackingExit";
            btnReservationTrackingExit.Size = new Size(75, 23);
            btnReservationTrackingExit.TabIndex = 13;
            btnReservationTrackingExit.Text = "Çıkış";
            btnReservationTrackingExit.UseVisualStyleBackColor = true;
            btnReservationTrackingExit.Click += btnReservationTrackingExit_Click;
            // 
            // ReservationTrackingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReservationTrackingExit);
            Controls.Add(dtEmployeeReservationDate);
            Controls.Add(txtEmployeeReservationBookName);
            Controls.Add(txtEmployeeReservationUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSearchReservation);
            Controls.Add(btnDeleteReservation);
            Controls.Add(btnUpdateReservations);
            Controls.Add(btnAddReservationEmployee);
            Controls.Add(dgvReservationTrakingList);
            Name = "ReservationTrackingForm";
            Text = "Rezervasyon Takip";
            ((System.ComponentModel.ISupportInitialize)dgvReservationTrakingList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReservationTrakingList;
        private Button btnAddReservationEmployee;
        private Button btnUpdateReservations;
        private Button btnDeleteReservation;
        private TextBox txtSearchReservation;
        private DateTimePicker dtEmployeeReservationDate;
        private TextBox txtEmployeeReservationBookName;
        private TextBox txtEmployeeReservationUserName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnReservationTrackingExit;
    }
}