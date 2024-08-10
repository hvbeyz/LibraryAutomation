namespace LibraryAutomation.UI
{
    partial class AddReportType
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
            lvShowAllReportTypes = new ListView();
            ID = new ColumnHeader();
            ReportType = new ColumnHeader();
            btnAddReportType = new Button();
            btnDeleteReportType = new Button();
            btnReportTypeUpdate = new Button();
            btnReportTypeExit = new Button();
            label1 = new Label();
            label2 = new Label();
            txtAddReportType = new TextBox();
            txtReportTypesSearch = new TextBox();
            SuspendLayout();
            // 
            // lvShowAllReportTypes
            // 
            lvShowAllReportTypes.Columns.AddRange(new ColumnHeader[] { ID, ReportType });
            lvShowAllReportTypes.Dock = DockStyle.Bottom;
            lvShowAllReportTypes.FullRowSelect = true;
            lvShowAllReportTypes.GridLines = true;
            lvShowAllReportTypes.Location = new Point(0, 275);
            lvShowAllReportTypes.Name = "lvShowAllReportTypes";
            lvShowAllReportTypes.Size = new Size(496, 188);
            lvShowAllReportTypes.TabIndex = 0;
            lvShowAllReportTypes.UseCompatibleStateImageBehavior = false;
            lvShowAllReportTypes.View = View.Details;
            lvShowAllReportTypes.DoubleClick += lvShowAllReportTypes_DoubleClick;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 120;
            // 
            // ReportType
            // 
            ReportType.Text = "Rapor Tip";
            ReportType.Width = 120;
            // 
            // btnAddReportType
            // 
            btnAddReportType.Location = new Point(410, 191);
            btnAddReportType.Name = "btnAddReportType";
            btnAddReportType.Size = new Size(74, 32);
            btnAddReportType.TabIndex = 1;
            btnAddReportType.Text = "Ekle";
            btnAddReportType.UseVisualStyleBackColor = true;
            btnAddReportType.Click += btnAddReportType_Click;
            // 
            // btnDeleteReportType
            // 
            btnDeleteReportType.Location = new Point(321, 191);
            btnDeleteReportType.Name = "btnDeleteReportType";
            btnDeleteReportType.Size = new Size(74, 32);
            btnDeleteReportType.TabIndex = 2;
            btnDeleteReportType.Text = "Sil";
            btnDeleteReportType.UseVisualStyleBackColor = true;
            btnDeleteReportType.Click += btnDeleteReportType_Click;
            // 
            // btnReportTypeUpdate
            // 
            btnReportTypeUpdate.Location = new Point(232, 191);
            btnReportTypeUpdate.Name = "btnReportTypeUpdate";
            btnReportTypeUpdate.Size = new Size(74, 32);
            btnReportTypeUpdate.TabIndex = 3;
            btnReportTypeUpdate.Text = "Düzenle";
            btnReportTypeUpdate.UseVisualStyleBackColor = true;
            btnReportTypeUpdate.Click += btnReportTypeUpdate_Click;
            // 
            // btnReportTypeExit
            // 
            btnReportTypeExit.Location = new Point(401, 12);
            btnReportTypeExit.Name = "btnReportTypeExit";
            btnReportTypeExit.Size = new Size(83, 42);
            btnReportTypeExit.TabIndex = 4;
            btnReportTypeExit.Text = "Çıkış";
            btnReportTypeExit.UseVisualStyleBackColor = true;
            btnReportTypeExit.Click += btnReportTypeExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(131, 8);
            label1.Name = "label1";
            label1.Size = new Size(234, 38);
            label1.TabIndex = 5;
            label1.Text = "Rapor Tip Ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(126, 24);
            label2.TabIndex = 6;
            label2.Text = "Rapor Tipi :";
            // 
            // txtAddReportType
            // 
            txtAddReportType.Location = new Point(12, 132);
            txtAddReportType.Name = "txtAddReportType";
            txtAddReportType.Size = new Size(221, 23);
            txtAddReportType.TabIndex = 7;
            // 
            // txtReportTypesSearch
            // 
            txtReportTypesSearch.Location = new Point(272, 246);
            txtReportTypesSearch.Name = "txtReportTypesSearch";
            txtReportTypesSearch.PlaceholderText = "Ara";
            txtReportTypesSearch.Size = new Size(212, 23);
            txtReportTypesSearch.TabIndex = 8;
            txtReportTypesSearch.TextChanged += txtReportTypesSearch_TextChanged;
            // 
            // AddReportType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 463);
            Controls.Add(txtReportTypesSearch);
            Controls.Add(txtAddReportType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReportTypeExit);
            Controls.Add(btnReportTypeUpdate);
            Controls.Add(btnDeleteReportType);
            Controls.Add(btnAddReportType);
            Controls.Add(lvShowAllReportTypes);
            Name = "AddReportType";
            Text = "Rapor Tip Ekle";
            Load += AddReportType_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvShowAllReportTypes;
        private ColumnHeader ID;
        private ColumnHeader ReportType;
        private Button btnAddReportType;
        private Button btnDeleteReportType;
        private Button btnReportTypeUpdate;
        private Button btnReportTypeExit;
        private Label label1;
        private Label label2;
        private TextBox txtAddReportType;
        private TextBox txtReportTypesSearch;
    }
}