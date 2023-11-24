namespace QUANLYBANHANG
{
    partial class fDangnhap
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtMaxacthuc = new TextBox();
            label4 = new Label();
            btnLaymaxacthuc = new Button();
            btnThoat = new Button();
            btnDangnhap = new Button();
            pictureBox1 = new PictureBox();
            labelOTP = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 70);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 97);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(187, 97);
            txtUsername.Margin = new Padding(2, 2, 2, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(106, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(187, 129);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(106, 23);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(69, 129);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtMaxacthuc
            // 
            txtMaxacthuc.Location = new Point(187, 197);
            txtMaxacthuc.Margin = new Padding(2, 2, 2, 2);
            txtMaxacthuc.Name = "txtMaxacthuc";
            txtMaxacthuc.Size = new Size(106, 23);
            txtMaxacthuc.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(69, 197);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 5;
            label4.Text = "Mã xác thực";
            // 
            // btnLaymaxacthuc
            // 
            btnLaymaxacthuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLaymaxacthuc.Location = new Point(177, 164);
            btnLaymaxacthuc.Margin = new Padding(2, 2, 2, 2);
            btnLaymaxacthuc.Name = "btnLaymaxacthuc";
            btnLaymaxacthuc.Size = new Size(115, 20);
            btnLaymaxacthuc.TabIndex = 8;
            btnLaymaxacthuc.Text = "Lấy mã xác thực";
            btnLaymaxacthuc.UseVisualStyleBackColor = true;
            btnLaymaxacthuc.Click += btnLaymaxacthuc_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(187, 241);
            btnThoat.Margin = new Padding(2, 2, 2, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(115, 20);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.Location = new Point(69, 241);
            btnDangnhap.Margin = new Padding(2, 2, 2, 2);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(93, 20);
            btnDangnhap.TabIndex = 9;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FigJam_basics;
            pictureBox1.Location = new Point(129, 8);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // labelOTP
            // 
            labelOTP.AutoSize = true;
            labelOTP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelOTP.ForeColor = SystemColors.HotTrack;
            labelOTP.Location = new Point(69, 167);
            labelOTP.Margin = new Padding(2, 0, 2, 0);
            labelOTP.Name = "labelOTP";
            labelOTP.Size = new Size(30, 15);
            labelOTP.TabIndex = 12;
            labelOTP.Text = "OTP";
            // 
            // fDangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 280);
            Controls.Add(labelOTP);
            Controls.Add(pictureBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnDangnhap);
            Controls.Add(btnLaymaxacthuc);
            Controls.Add(txtMaxacthuc);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "fDangnhap";
            Text = "Đăng nhập";
            Load += fDangnhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtMaxacthuc;
        private Label label4;
        private Button btnMaxacthuc;
        private Button btnLaymaxacthuc;
        private Button btnThoat;
        private Button btnDangnhap;
        private PictureBox pictureBox1;
        private Label labelOTP;
    }
}