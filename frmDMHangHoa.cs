using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExcelDataReader;
//using Microsoft.Office.Interop.Excel;
using QUANLYBANHANG.DAO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;
using Image = System.Drawing.Image;

namespace QUANLYBANHANG
{
    public partial class frmDMHangHoa : Form
    {
        bool them = false;
        public frmDMHangHoa()
        {
            InitializeComponent();
        }

        private void frmDMHangHoa_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            //this.panel1.Enabled = false;
            textbox_edit_off();
            LoadDMHH();
            this.DgvHangHoa.AllowUserToAddRows = false;

            //Align textbox sotien,dongianhap,dongiaban
            this.txtSoluong.TextAlign = HorizontalAlignment.Right;
            this.txtDongianhap.TextAlign = HorizontalAlignment.Right;
            this.txtDongiaban.TextAlign = HorizontalAlignment.Right;
            //focus
            this.DgvHangHoa.Focus();
            this.DgvHangHoa.ReadOnly = true;

        }

        public DataTable SelectHangHoaToDataTable()
        {
            string query = "SELECT mahang AS [Mã hàng], tenhang AS [Tên hàng], soluong AS [Số lượng],";
            query = query + "dongianhap AS [Đơn giá nhập], dongiaban AS [Đơn giá bán],";
            query = query + "machatlieu AS [Mã chất liệu], anh AS [Ảnh], ghichu AS [Ghi chú]";
            query = query + "FROM [dbo].[tblHang]";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        void LoadDMHH()
        {
            //dua data len gridview
            DgvHangHoa.DataSource = SelectHangHoaToDataTable();
            DgvHangHoa.AutoResizeColumns();
            Set_DgvDMHangHoa_col_format();
        }

        void Set_DgvDMHangHoa_col_format() //Grid width: 1120
        {
            this.DgvHangHoa.Columns["Mã hàng"].Width = 120;
            this.DgvHangHoa.Columns["Tên hàng"].Width = 400;
            this.DgvHangHoa.Columns["Số lượng"].Width = 150;
            this.DgvHangHoa.Columns["Đơn giá nhập"].Width = 180;
            this.DgvHangHoa.Columns["Đơn giá bán"].Width = 180;
            this.DgvHangHoa.Columns["Mã chất liệu"].Width = 150;

            this.DgvHangHoa.Columns["Số lượng"].DefaultCellStyle.Format = "N0"; // N0: format nhom 3 digit, khong lay so le
            this.DgvHangHoa.Columns["Đơn giá nhập"].DefaultCellStyle.Format = "N0";
            this.DgvHangHoa.Columns["Đơn giá bán"].DefaultCellStyle.Format = "N0";

            this.DgvHangHoa.Columns["Số lượng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.DgvHangHoa.Columns["Đơn giá nhập"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.DgvHangHoa.Columns["Đơn giá bán"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDMHH();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            them = true;
            //Tắt các nút Add, Edit, Delete, Close
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnClose.Enabled = false;
            //Bật các nút Save, Cancel và các text box nhập liệu
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            //this.panel1.Enabled = true;
            textbox_edit_on();
            //xoa trong cac control trong panel acc
            this.txtMahang.ResetText();
            this.txtTenhang.ResetText();
            this.txtSoluong.ResetText();
            this.txtDongianhap.ResetText();
            this.txtDongiaban.ResetText();
            this.txtMachatlieu.ResetText();
            this.txtAnh.ResetText();
            this.txtGhichu.ResetText();
            this.DgvHangHoa.Enabled = false;
            //focus 
            this.txtMahang.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //kiem tra co record không, nếu không có thì thoát
            if (this.DgvHangHoa == null || this.DgvHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }
            them = false;
            //this.panel1.Enabled = true;
            textbox_edit_on();
            //Không cho sửa mahang
            this.txtMahang.ReadOnly = true;
            //lay ra Row Index
            int r = DgvHangHoa.CurrentCell.RowIndex;
            //Chuyen thong tin len panel Acc
            this.txtMahang.Text = DgvHangHoa.Rows[r].Cells["Mã hàng"].Value.ToString();
            this.txtTenhang.Text = DgvHangHoa.Rows[r].Cells["Tên hàng"].Value.ToString();
            decimal s_soluong = Convert.ToDecimal(DgvHangHoa.Rows[r].Cells["Số lượng"].Value);
            this.txtSoluong.Text = s_soluong.ToString("#,##0");
            decimal s_dongianhap = Convert.ToDecimal(DgvHangHoa.Rows[r].Cells["Đơn giá nhập"].Value);
            this.txtDongianhap.Text = s_dongianhap.ToString("#,##0");
            decimal s_dongiaban = Convert.ToDecimal(DgvHangHoa.Rows[r].Cells["Đơn giá bán"].Value);
            this.txtDongiaban.Text = s_dongiaban.ToString("#,##0");
            this.txtMachatlieu.Text = DgvHangHoa.Rows[r].Cells["Mã chất liệu"].Value.ToString();
            this.txtAnh.Text = DgvHangHoa.Rows[r].Cells["Ảnh"].Value.ToString();
            this.txtGhichu.Text = DgvHangHoa.Rows[r].Cells["Ghi chú"].Value.ToString();
            //Hinh anh
            this.pictureBox1.Image = Image.FromFile(this.txtAnh.Text);

            //Bật các nút Save, Cancel và panel text box nhập liệu
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            //this.panel1.Enabled = true;
            textbox_edit_on();
            //Tắt các nút Add, Edit, Delete, Close
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnClose.Enabled = false;
            this.DgvHangHoa.Enabled = false;
            //focus 
            this.txtTenhang.Focus();
        }

        public bool InsertHangHoa(string xmahang, string xtenhang, decimal xsoluong, decimal xdongianhap, decimal xdongiaban, string xmachatlieu, string xanh, string xghichu)
        {
            string query = "INSERT INTO [dbo].[tblHang] (mahang,tenhang,soluong,dongianhap,dongiaban,machatlieu,anh,ghichu) VALUES ( N'";
            query = query + xmahang + "', N'";
            query = query + xtenhang + "',";
            query = query + xsoluong + ",";
            query = query + xdongianhap + ",";
            query = query + xdongiaban + ",N'";
            query = query + xmachatlieu + "',N'";
            query = query + xanh + "',N'";
            query = query + xghichu + "')";
            int kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool UpdateHangHoa(string xmahang, string xtenhang, decimal xsoluong, decimal xdongianhap, decimal xdongiaban, string xmachatlieu, string xanh, string xghichu)
        {
            string query = "UPDATE [dbo].[tblHang] SET ";
            query = query + "tenhang = N'" + xtenhang + "',";
            query = query + "soluong = " + xsoluong + ",";
            query = query + "dongianhap = " + xdongianhap + ",";
            query = query + "dongiaban = " + xdongiaban + ",";
            query = query + "machatlieu = N'" + xmachatlieu + "',";
            query = query + "anh = N'" + xanh + "',";
            query = query + "ghichu = N'" + xghichu + "'";
            query = query + " WHERE mahang = '" + xmahang + "'";
            int kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string m_mahang = this.txtMahang.Text.Trim();
            string m_tenhang = this.txtTenhang.Text.Trim();
            decimal m_soluong = Convert.ToDecimal(this.txtSoluong.Text);
            decimal m_dongianhap = Convert.ToDecimal(this.txtDongianhap.Text);
            decimal m_dongiaban = Convert.ToDecimal(this.txtDongiaban.Text);
            string m_machatlieu = this.txtMachatlieu.Text.Trim();
            string m_anh = this.txtAnh.Text.Trim();
            string m_ghichu = this.txtGhichu.Text.Trim();

            if (string.IsNullOrEmpty(m_tenhang))
            {
                MessageBox.Show("Chưa nhập Tên hàng", "Error");
                return; // break event handler 
            };
            if (m_soluong == 0)
            {
                MessageBox.Show("Chưa nhập Số lượng", "Error");
                return; // break event handler 
            };
            if (m_dongianhap == 0)
            {
                MessageBox.Show("Chưa nhập Đơn giá nhập", "Error");
                return; // break event handler 
            };
            if (m_dongiaban == 0)
            {
                MessageBox.Show("Chưa nhập Đơn giá bán", "Error");
                return; // break event handler 
            };

            if (them)
            {
                //Phan nay cua Add
                if (InsertHangHoa(m_mahang, m_tenhang, m_soluong, m_dongianhap, m_dongiaban, m_machatlieu, m_anh, m_ghichu))
                {
                    MessageBox.Show("Đã thêm 1 hàng hóa: " + m_tenhang);
                    this.btnReload.PerformClick();
                    foreach (DataGridViewRow row in DgvHangHoa.Rows)
                    {
                        if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == m_tenhang)
                        {
                            int rowIndex = row.Index; // Chỉ số hàng chứa giá trị
                            DgvHangHoa.CurrentCell = DgvHangHoa.Rows[rowIndex].Cells[0];
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa thêm được hàng hóa " + m_tenhang + " này!", "Error");
                }
                //this.DgvHangHoa.Focus();
            }
            else
            {
                //Phan nay cua Edit: luu chinh sua (UPDATE)                
                int r = this.DgvHangHoa.CurrentCell.RowIndex;
                //m_mahang = DgvHangHoa.Rows[r].Cells["Mã hàng"].Value.ToString().Trim();
                //m_tenhang = DgvHangHoa.Rows[r].Cells["Tên hàng"].Value.ToString().Trim();
                if (UpdateHangHoa(m_mahang, m_tenhang, m_soluong, m_dongianhap, m_dongiaban, m_machatlieu, m_anh, m_ghichu))
                {
                    MessageBox.Show("Đã UPDATE hàng hóa " + m_tenhang);
                    this.btnReload.PerformClick();
                    foreach (DataGridViewRow row in DgvHangHoa.Rows)
                    {
                        if (row.Cells["Tên hàng"].Value != null && row.Cells["Tên hàng"].Value.ToString() == m_tenhang)
                        {
                            int rowIndex = row.Index; // Chỉ số hàng chứa giá trị
                            DgvHangHoa.CurrentCell = DgvHangHoa.Rows[rowIndex].Cells[0];
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa UPDATE được hàng hóa " + m_tenhang, "Error");
                }
                //this.DgvHangHoa.Focus();
            }
            // Tắt Save, Cancel và panel text box nhập liệu
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            //this.panel1.Enabled = false;
            textbox_edit_off();
            //Bật Add, Edit, Delete, Close
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnClose.Enabled = true;
            this.DgvHangHoa.Enabled = true;
            //focus 
            this.DgvHangHoa.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            them = false;
            //xoa trong cac control trong panel acc
            this.txtMahang.ResetText();
            this.txtTenhang.ResetText();
            this.txtSoluong.ResetText();
            this.txtDongianhap.ResetText();
            this.txtDongiaban.ResetText();
            this.txtSearch.ResetText();
            // Tắt Save, Cancel và panel text box nhập liệu
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            //this.panel1.Enabled = false;
            textbox_edit_off();
            //Bật Add, Edit, Delete, Close
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnClose.Enabled = true;
            this.DgvHangHoa.Enabled = true;
            //focus 
            this.DgvHangHoa.Focus();
        }

        public bool DeleteHangHoaBymahang(string xmahang)
        {
            string query = "DELETE FROM [dbo].[tblHang] WHERE mahang = '" + xmahang + "'";
            int kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //kiem tra co record không, nếu không có thì thoát
            if (this.DgvHangHoa == null || this.DgvHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.", "Error");
                return;
            }
            //index row
            int r = this.DgvHangHoa.CurrentCell.RowIndex;
            //reccord hiện hành trong datagridview
            string m_mahang = DgvHangHoa.Rows[r].Cells["Mã hàng"].Value.ToString();
            string m_tenhang = DgvHangHoa.Rows[r].Cells["Tên hàng"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Chắc không ?", "Xóa " + m_tenhang, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (DeleteHangHoaBymahang(m_mahang))
                {
                    MessageBox.Show("Đã XÓA hàng hóa " + m_tenhang);
                    //this.btnReload.PerformClick();
                    DgvHangHoa.Rows.RemoveAt(r);
                }
                else
                {
                    MessageBox.Show("Chưa XÓA được hàng hóa " + m_tenhang, "Error");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else: exit
                return;
            }

            //sau khi DELETE OK
            // Tắt Save, Cancel và panel text box nhập liệu
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            //this.panel1.Enabled = false;
            textbox_edit_off();
            //Bật Add, Edit, Delete, Close
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnClose.Enabled = true;
            this.DgvHangHoa.Focus();

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.btnSearch.PerformClick();
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            this.btnSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string m_txtSearch = this.txtSearch.Text.Trim().ToUpper();
            //string query = "SELECT mahang, tenhang, soluong, dongianhap, dongiaban, machatlieu, anh, ghichu  FROM [dbo].[tblHang]";
            string query = "SELECT mahang AS [Mã hàng], tenhang AS [Tên hàng], soluong AS [Số lượng],";
            query = query + "dongianhap AS [Đơn giá nhập], dongiaban AS [Đơn giá bán],";
            query = query + "machatlieu AS [Mã chất liệu], anh AS [Ảnh], ghichu AS [Ghi chú]";
            query = query + "FROM [dbo].[tblHang]";
            query = query + " WHERE tenhang LIKE N'%" + m_txtSearch + "%'";
            DgvHangHoa.DataSource = DataProvider.Instance.ExecuteQuery(query);
            DgvHangHoa.AutoResizeColumns();
            Set_DgvDMHangHoa_col_format();
            this.DgvHangHoa.Focus();
            if (DgvHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy!", "Waning");
                btnReload.PerformClick();
            }
        }

        /*
         * private void DgvHangHoa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //mask column soluong '*****'
            if (e.ColumnIndex == 2 && e.Value != null) //cot soluong
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
        */

        private void DgvHangHoa_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //kiem tra co record không, nếu không có thì thoát
            if (this.DgvHangHoa == null || this.DgvHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }
            else
            //if (DgvHangHoa.Rows.Count > 1)
            {
                int r = e.RowIndex;
                //Chuyen thong tin len panel Acc                
                if (DgvHangHoa.Rows[r].Cells["Mã hàng"].Value != null)
                    this.txtMahang.Text = DgvHangHoa.Rows[r].Cells["Mã hàng"].Value.ToString();
                if (DgvHangHoa.Rows[r].Cells["Tên hàng"].Value != null)
                    this.txtTenhang.Text = DgvHangHoa.Rows[r].Cells["Tên hàng"].Value.ToString();
                if (DgvHangHoa.Rows[r].Cells["Số lượng"].Value != null)
                {
                    //this.txtSoluong.Text = DgvHangHoa.Rows[r].Cells["Số lượng"].Value.ToString();
                    decimal s_soluong = Convert.ToDecimal(DgvHangHoa.Rows[r].Cells["Số lượng"].Value);
                    this.txtSoluong.Text = s_soluong.ToString("#,##0");
                }
                if (DgvHangHoa.Rows[r].Cells["Đơn giá nhập"].Value != null)
                {
                    //this.txtDongianhap.Text = DgvHangHoa.Rows[r].Cells["Đơn giá nhập"].Value.ToString();
                    decimal s_dongianhap = Convert.ToDecimal(DgvHangHoa.Rows[r].Cells["Đơn giá nhập"].Value);
                    this.txtDongianhap.Text = s_dongianhap.ToString("#,##0");
                }
                if (DgvHangHoa.Rows[r].Cells["Đơn giá bán"].Value != null)
                {
                    //this.txtDongiaban.Text = DgvHangHoa.Rows[r].Cells["Đơn giá bán"].Value.ToString();
                    decimal s_dongiaban = Convert.ToDecimal(DgvHangHoa.Rows[r].Cells["Đơn giá bán"].Value);
                    this.txtDongiaban.Text = s_dongiaban.ToString("#,##0");
                }
                if (DgvHangHoa.Rows[r].Cells["Mã chất liệu"].Value != null)
                    this.txtMachatlieu.Text = DgvHangHoa.Rows[r].Cells["Mã chất liệu"].Value.ToString();
                if (DgvHangHoa.Rows[r].Cells["Ảnh"].Value != null) {
                    this.txtAnh.Text = DgvHangHoa.Rows[r].Cells["Ảnh"].Value.ToString();
         

                    string imageName;
                    if (DgvHangHoa.Rows[r].Cells["Ảnh"].Value != null)
                    {
                        imageName = DgvHangHoa.Rows[r].Cells["Ảnh"].Value.ToString();
                    }
                    else
                    {
                        imageName = @"d:\chuot.jpg"; // Replace with your default image path
                    }

                    if (imageName.Trim() != "")
                    {
                        this.pictureBox1.Image = Image.FromFile(imageName);
                        this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }    

                    else
                    {
                        //defaul hinh anh
                        imageName = @"d:\default.jpg";
                        this.pictureBox1.Image = Image.FromFile(imageName);
                        this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                    
                   
                if (DgvHangHoa.Rows[r].Cells["Ghi chú"].Value != null)
                    this.txtGhichu.Text = DgvHangHoa.Rows[r].Cells["Ghi chú"].Value.ToString();
            }
        }

        private void textbox_edit_off()
        {
            this.txtMahang.ReadOnly = true;
            this.txtTenhang.ReadOnly = true;
            this.txtSoluong.ReadOnly = true;
            this.txtDongianhap.ReadOnly = true;
            this.txtDongiaban.ReadOnly = true;
            this.txtMachatlieu.ReadOnly = true;
            this.txtAnh.ReadOnly = true;
            this.txtGhichu.ReadOnly = true;

            this.txtMahang.BackColor = SystemColors.Window;
            this.txtTenhang.BackColor = SystemColors.Window;
            this.txtSoluong.BackColor = SystemColors.Window;
            this.txtDongianhap.BackColor = SystemColors.Window;
            this.txtDongiaban.BackColor = SystemColors.Window;
            this.txtMachatlieu.BackColor = SystemColors.Window;
            this.txtAnh.BackColor = SystemColors.Window;
            this.txtGhichu.BackColor = SystemColors.Window;
        }

        private void textbox_edit_on()
        {
            this.txtMahang.ReadOnly = false;
            this.txtTenhang.ReadOnly = false;
            this.txtSoluong.ReadOnly = false;
            this.txtDongianhap.ReadOnly = false;
            this.txtDongiaban.ReadOnly = false;
            this.txtMachatlieu.ReadOnly = false;
            this.txtAnh.ReadOnly = false;
            this.txtGhichu.ReadOnly = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int m_count = 0;
            int r = this.DgvHangHoa.CurrentCell.RowIndex;
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Excel files (*.xlsx, *.xls)|*.xlsx;*.xls";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = fileDialog.FileName;
                    using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                    {
                        IExcelDataReader reader;


                        reader = ExcelDataReader.ExcelReaderFactory.CreateReader(stream);

                        //// reader.IsFirstRowAsColumnNames
                        var conf = new ExcelDataSetConfiguration
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration
                            {
                                UseHeaderRow = true
                            }
                        };

                        var dataSet = reader.AsDataSet(conf);

                        // Now you can get data from each sheet by its index or its "name"
                        var dataTable = dataSet.Tables[0];

                        //dataGridView1.DataSource = dataTable;

                        // Dua datatable vao DB
                        try
                        {
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                //ADD vao
                                string m_mahang = dataTable.Rows[i][0].ToString();
                                string m_tenhang = dataTable.Rows[i][1].ToString();
                                decimal m_soluong = Convert.ToDecimal(dataTable.Rows[i][2].ToString());
                                decimal m_dongianhap = Convert.ToDecimal(dataTable.Rows[i][3].ToString());
                                decimal m_dongiaban = Convert.ToDecimal(dataTable.Rows[i][4].ToString());
                                string m_machatlieu = dataTable.Rows[i][5].ToString();
                                string m_ghichu = dataTable.Rows[i][6].ToString();
                                string m_anh = dataTable.Rows[i][7].ToString();
                                if (SelectHangHoabyMahang(m_mahang, m_tenhang))
                                {
                                    InsertHangHoa(m_mahang, m_tenhang, m_soluong, m_dongianhap, m_dongiaban, m_machatlieu, m_anh, m_ghichu);
                                    m_count++;
                                }
                                
                            }
                            btnReload.PerformClick();
                            DgvHangHoa.CurrentCell = DgvHangHoa.Rows[r].Cells["Mã hàng"];
                            MessageBox.Show("Import thành công "+m_count.ToString().Trim() + " Mã hàng!");
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Import thất bại!");
                        }


                    }

                }
            }
        }

        private bool SelectHangHoabyMahang(string xmahang, string xtenhang)
        {
            bool kq;
            string query = "SELECT mahang FROM [dbo].[tblHang] WHERE mahang = '" + xmahang + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Trùng mã hàng " + xmahang.Trim() + " - " + xtenhang.Trim() +". Không Import!", "Waning");
                kq = false;
            }
            else
                kq = true;

            return kq;
        }

        private void txtMahang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtTenhang.Focus();
            }
        }
        private void txtTenhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtSoluong.Focus();
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // chi nhap Number, not Alphabet digit
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtMachatlieu.Focus();
            }
        }

        private void txtMachatlieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtDongianhap.Focus();
            }
        }

        private void txtDongianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // chi nhap Number, not Alphabet digit
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtDongiaban.Focus();
            }
        }

        private void txtDongiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // chi nhap Number, not Alphabet digit
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtAnh.Focus();
            }
        }

        private void txtAnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtGhichu.Focus();
            }
        }

        private void txtGhichu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnSave.Focus();
            }
        }

        private void txtTenhang_KeyDown(object sender, KeyEventArgs e)
        {
            // Chuyển đổi chữ cái thành chữ in hoa nếu cần thiết

            if (e.KeyValue != ' ')
            {
                e.Handled = true;
                txtTenhang.Text += Char.ToUpper((char)e.KeyData);
            }

        }

    }
}
