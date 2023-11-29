namespace QUANLYBANHANG
{
    partial class frmDMHangHoa
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
            DgvHangHoa = new DataGridView();
            panel1 = new Panel();
            txtSoluong = new TextBox();
            txtGhichu = new TextBox();
            label9 = new Label();
            txtAnh = new TextBox();
            label8 = new Label();
            txtMachatlieu = new TextBox();
            label7 = new Label();
            txtDongiaban = new TextBox();
            label5 = new Label();
            txtDongianhap = new TextBox();
            txtTenhang = new TextBox();
            label4 = new Label();
            txtMahang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            btnImport = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnReload = new Button();
            panel4 = new Panel();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DgvHangHoa).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DgvHangHoa
            // 
            DgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvHangHoa.Location = new Point(20, 309);
            DgvHangHoa.Margin = new Padding(5, 6, 5, 6);
            DgvHangHoa.Name = "DgvHangHoa";
            DgvHangHoa.RowHeadersWidth = 62;
            DgvHangHoa.Size = new Size(1280, 272);
            DgvHangHoa.TabIndex = 16;
            DgvHangHoa.CellEnter += DgvHangHoa_CellEnter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtSoluong);
            panel1.Controls.Add(txtGhichu);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtAnh);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtMachatlieu);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtDongiaban);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDongianhap);
            panel1.Controls.Add(txtTenhang);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMahang);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 29);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 268);
            panel1.TabIndex = 1;
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(306, 100);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(150, 31);
            txtSoluong.TabIndex = 5;
            txtSoluong.KeyPress += txtSoluong_KeyPress;
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(309, 229);
            txtGhichu.Margin = new Padding(5, 6, 5, 6);
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(743, 31);
            txtGhichu.TabIndex = 15;
            txtGhichu.KeyPress += txtGhichu_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(170, 232);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 14;
            label9.Text = "Ghi chú";
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(306, 184);
            txtAnh.Margin = new Padding(5, 6, 5, 6);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(743, 31);
            txtAnh.TabIndex = 13;
            txtAnh.KeyPress += txtAnh_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(169, 187);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 25);
            label8.TabIndex = 12;
            label8.Text = "Ảnh";
            // 
            // txtMachatlieu
            // 
            txtMachatlieu.Location = new Point(678, 94);
            txtMachatlieu.Margin = new Padding(5, 6, 5, 6);
            txtMachatlieu.Name = "txtMachatlieu";
            txtMachatlieu.Size = new Size(150, 31);
            txtMachatlieu.TabIndex = 7;
            txtMachatlieu.KeyPress += txtMachatlieu_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(551, 100);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 6;
            label7.Text = "Mã chất liệu";
            // 
            // txtDongiaban
            // 
            txtDongiaban.Location = new Point(678, 138);
            txtDongiaban.Margin = new Padding(5, 6, 5, 6);
            txtDongiaban.Name = "txtDongiaban";
            txtDongiaban.Size = new Size(150, 31);
            txtDongiaban.TabIndex = 11;
            txtDongiaban.KeyPress += txtDongiaban_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(551, 144);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 10;
            label5.Text = "Đơn giá bán";
            // 
            // txtDongianhap
            // 
            txtDongianhap.Location = new Point(306, 141);
            txtDongianhap.Margin = new Padding(5, 6, 5, 6);
            txtDongianhap.Name = "txtDongianhap";
            txtDongianhap.Size = new Size(150, 31);
            txtDongianhap.TabIndex = 9;
            txtDongianhap.KeyPress += txtDongianhap_KeyPress;
            // 
            // txtTenhang
            // 
            txtTenhang.Location = new Point(305, 55);
            txtTenhang.Margin = new Padding(5, 6, 5, 6);
            txtTenhang.Name = "txtTenhang";
            txtTenhang.Size = new Size(744, 31);
            txtTenhang.TabIndex = 3;
            txtTenhang.KeyPress += txtTenhang_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(168, 100);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 4;
            label4.Text = "Số lượng";
            // 
            // txtMahang
            // 
            txtMahang.Location = new Point(305, 12);
            txtMahang.Margin = new Padding(5, 6, 5, 6);
            txtMahang.Name = "txtMahang";
            txtMahang.Size = new Size(150, 31);
            txtMahang.TabIndex = 1;
            txtMahang.KeyPress += txtMahang_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(170, 144);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 8;
            label3.Text = "Đơn giá nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(169, 58);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã hàng";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(20, 593);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1280, 72);
            panel2.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(1055, 15);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(138, 44);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(231, 20);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(770, 31);
            txtSearch.TabIndex = 18;
            txtSearch.KeyPress += txtSearch_KeyPress;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(119, 23);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 17;
            label6.Text = "Tên Hàng";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnImport);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnReload);
            panel3.Location = new Point(20, 677);
            panel3.Margin = new Padding(5, 6, 5, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1090, 92);
            panel3.TabIndex = 3;
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnImport.Location = new Point(923, 23);
            btnImport.Margin = new Padding(5, 6, 5, 6);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(138, 44);
            btnImport.TabIndex = 26;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(775, 23);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 44);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(627, 23);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 44);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(478, 23);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 44);
            btnSave.TabIndex = 23;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(330, 23);
            btnEdit.Margin = new Padding(5, 6, 5, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 44);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(182, 23);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 44);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReload
            // 
            btnReload.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReload.Location = new Point(33, 23);
            btnReload.Margin = new Padding(5, 6, 5, 6);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(138, 44);
            btnReload.TabIndex = 20;
            btnReload.Text = "Danh mục";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnClose);
            panel4.Location = new Point(1120, 677);
            panel4.Margin = new Padding(5, 6, 5, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 92);
            panel4.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(20, 23);
            btnClose.Margin = new Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 44);
            btnClose.TabIndex = 27;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1099, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 225);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // frmDMHangHoa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 796);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DgvHangHoa);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmDMHangHoa";
            Text = "Danh mục hàng hóa";
            Load += frmDMHangHoa_Load;
            ((System.ComponentModel.ISupportInitialize)DgvHangHoa).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvHangHoa;
        private Panel panel1;
        private Label label1;
        private TextBox txtMahang;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtDongianhap;
        private TextBox txtTenhang;
        private TextBox txtDongiaban;
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
        private Panel panel4;
        private Button btnClose;
        private TextBox txtAnh;
        private Label label8;
        private TextBox txtMachatlieu;
        private Label label7;
        private TextBox txtGhichu;
        private Label label9;
        private Button btnImport;
        private Button btnDelete;
        private TextBox txtSoluong;
        private PictureBox pictureBox1;
    }
}