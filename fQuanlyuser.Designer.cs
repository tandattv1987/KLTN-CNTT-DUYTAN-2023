namespace QUANLYBANHANG
{
    partial class fQuanlyuser
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
            DgvDangnhap = new DataGridView();
            panel1 = new Panel();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnReload = new Button();
            panel4 = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvDangnhap).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // DgvDangnhap
            // 
            DgvDangnhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDangnhap.Location = new Point(14, 127);
            DgvDangnhap.Margin = new Padding(4);
            DgvDangnhap.Name = "DgvDangnhap";
            DgvDangnhap.RowHeadersWidth = 62;
            DgvDangnhap.Size = new Size(896, 198);
            DgvDangnhap.TabIndex = 10;
            DgvDangnhap.CellEnter += DgvDangnhap_CellEnter;
            DgvDangnhap.CellFormatting += DgvDangnhap_CellFormatting;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtFullname);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 17);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 102);
            panel1.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 65);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(540, 23);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(82, 68);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(514, 13);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(187, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(161, 39);
            txtFullname.Margin = new Padding(4);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(540, 23);
            txtFullname.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(161, 13);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(187, 23);
            txtUsername.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(414, 13);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(83, 41);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(83, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(14, 336);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(897, 64);
            panel2.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(738, 17);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 26);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(162, 20);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(540, 23);
            txtSearch.TabIndex = 12;
            txtSearch.KeyPress += txtSearch_KeyPress;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(83, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 11;
            label6.Text = "fullname";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnReload);
            panel3.Location = new Point(14, 406);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(660, 56);
            panel3.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(542, 14);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 26);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(439, 14);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 26);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(335, 14);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 26);
            btnSave.TabIndex = 17;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(231, 14);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(97, 26);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(127, 14);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 26);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReload
            // 
            btnReload.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReload.Location = new Point(23, 14);
            btnReload.Margin = new Padding(4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(97, 26);
            btnReload.TabIndex = 14;
            btnReload.Text = "User List";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnClose);
            panel4.Location = new Point(691, 406);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 56);
            panel4.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(62, 15);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 26);
            btnClose.TabIndex = 20;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fQuanlyuser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 453);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DgvDangnhap);
            Margin = new Padding(4);
            Name = "fQuanlyuser";
            Text = "Quản lý User";
            Load += fQuanlyuser_Load;
            ((System.ComponentModel.ISupportInitialize)DgvDangnhap).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvDangnhap;
        private Panel panel1;
        private Label label1;
        private TextBox txtUserID;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Label label5;
        private Panel panel2;
        private TextBox txtSearch;
        private Label label6;
        private Button btnSearch;
        private Panel panel3;
        private Button btnReload;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDelete;
        private Panel panel4;
        private Button btnClose;
    }
}