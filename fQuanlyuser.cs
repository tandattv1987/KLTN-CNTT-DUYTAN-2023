using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYBANHANG.DAO;
using System.Text.RegularExpressions;

namespace QUANLYBANHANG
{
    public partial class fQuanlyuser : Form
    {
        bool them = false;
        int _userID;
        public fQuanlyuser()
        {
            InitializeComponent();
        }

        private void fQuanlyuser_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            //this.panel1.Enabled = false;
            textbox_edit_off();
            LoadUserList();
            this.DgvDangnhap.AllowUserToAddRows = false;
            //focus
            this.DgvDangnhap.Focus();
            this.DgvDangnhap.ReadOnly = true;

            string columnName = this.DgvDangnhap.Columns["UserID"].Name;

            // Đặt thuộc tính Visible của cột thành false
            this.DgvDangnhap.Columns[columnName].Visible = false;

        }

        public DataTable SelectUserToDataTable()
        {
            string query = "SELECT userID, username, password, fullname, email  FROM dbo.tblDangnhap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        void LoadUserList()
        {
            //dua data len gridview
            DgvDangnhap.DataSource = SelectUserToDataTable();
            DgvDangnhap.AutoResizeColumns();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadUserList();
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
            //this.txtUserID.ResetText();
            this.txtUsername.ResetText();
            this.txtFullname.ResetText();
            this.txtPassword.ResetText();
            this.txtEmail.ResetText();
            this.DgvDangnhap.Enabled = false;
            //focus 
            this.txtUsername.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //kiem tra co record không, nếu không có thì thoát
            if (this.DgvDangnhap == null || this.DgvDangnhap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }
            them = false;
            //this.panel1.Enabled = true;
            textbox_edit_on();
            //lay ra Row Index
            int r = DgvDangnhap.CurrentCell.RowIndex;
            //Chuyen thong tin len panel Acc
            //this.txtUserID.Text = DgvDangnhap.Rows[r].Cells["UserID"].Value.ToString();
            this.txtUsername.Text = DgvDangnhap.Rows[r].Cells["username"].Value.ToString();
            this.txtFullname.Text = DgvDangnhap.Rows[r].Cells["fullname"].Value.ToString();
            this.txtPassword.Text = DgvDangnhap.Rows[r].Cells["password"].Value.ToString();
            this.txtEmail.Text = DgvDangnhap.Rows[r].Cells["email"].Value.ToString();

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
            this.DgvDangnhap.Enabled = false;
            //focus 
            this.txtUsername.Focus();
        }

        public bool InsertUser(string xusername, string xfullname, string xpassword, string xemail)
        {
            string query = "INSERT INTO dbo.tblDangnhap (userName,password,fullname,email) VALUES ( N'" + xusername + "',N'";
            query = query + xpassword + "',N'";
            query = query + xfullname + "',N'";
            query = query + xemail + "')";
            int kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool UpdateUser(int xUserID, string xusername, string xpassword, string xfullname, string xemail)
        {
            string query = "UPDATE dbo.tblDangnhap SET  userName = N'" + xusername + "', password = N'";
            query = query + xpassword + "', fullname = N'";
            query = query + xfullname + "', email = N'";
            query = query + xemail + "'";
            query = query + " WHERE userID = " + xUserID;
            int kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string m_username = this.txtUsername.Text.Trim();
            string m_fullname = this.txtFullname.Text.Trim();
            string m_password = this.txtPassword.Text.Trim();
            string m_email = this.txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(m_username))
            {
                MessageBox.Show("Chưa nhập Username", "Error");
                return; // break event handler 
            };
            if (string.IsNullOrEmpty(m_password))
            {
                MessageBox.Show("Chưa nhập Password", "Error");
                return; // break event handler 
            }
            else 
            {
                int length = m_password.Length;
                bool isValid = length >= 8;

                if (!isValid)
                {
                    MessageBox.Show("Password phải từ 8 ký tự trở lên", "Error");
                    return; // break event handler 
                }
            }
            if (string.IsNullOrEmpty(m_fullname))
            {
                MessageBox.Show("Chưa nhập Fullname", "Error");
                return; // break event handler 
            };
            if (string.IsNullOrEmpty(m_email))
            {
                MessageBox.Show("Chưa nhập Email", "Error");
                return; // break event handler 
            }
            else
            {
                string regex = @"^[a-zA-Z0-9_\-\.]+@[a-zA-Z0-9\-]+\.[a-zA-Z]{2,4}$";

                // Kiểm tra chuỗi email
                bool isValid = Regex.Matches(m_email, regex).Any();
                if (!isValid)
                {
                    MessageBox.Show("Email không hợp lệ", "Error");
                    return; // break event handler 
                }

            }

            if (them)
            {
                //Phan nay cua Add
                if (InsertUser(m_username, m_fullname, m_password, m_email))
                {
                    MessageBox.Show("Đã thêm 1 User: " + m_username);
                    this.btnReload.PerformClick();
                    foreach (DataGridViewRow row in DgvDangnhap.Rows)
                    {
                        if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == m_username)
                        {
                            int rowIndex = row.Index; // Chỉ số hàng chứa giá trị
                            DgvDangnhap.CurrentCell = DgvDangnhap.Rows[rowIndex].Cells[1];
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa thêm được User " + m_username + " này!", "Error");
                }
                //this.DgvDangnhap.Focus();
            }
            else
            {
                //Phan nay cua Edit: luu chinh sua (UPDATE)
              
                int r = this.DgvDangnhap.CurrentCell.RowIndex;
                int m_UserID;
                m_UserID = Convert.ToInt16(DgvDangnhap.Rows[r].Cells[0].Value);
                if (UpdateUser(m_UserID, m_username, m_password, m_fullname, m_email))
                {
                    MessageBox.Show("Đã UPDATE User " + m_username);
                    this.btnReload.PerformClick();
                    foreach (DataGridViewRow row in DgvDangnhap.Rows)
                    {
                        if (row.Cells["username"].Value != null && row.Cells["username"].Value.ToString() == m_username)
                        {
                            int rowIndex = row.Index; // Chỉ số hàng chứa giá trị
                            DgvDangnhap.CurrentCell = DgvDangnhap.Rows[rowIndex].Cells[1];
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa UPDATE được User " + m_username, "Error");
                }
                //this.DgvDangnhap.Focus();
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
            this.DgvDangnhap.Enabled = true;
            //focus 
            this.DgvDangnhap.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            them = false;
            //xoa trong cac control trong panel acc
            //this.txtUserID.ResetText();
            this.txtUsername.ResetText();
            this.txtFullname.ResetText();
            this.txtPassword.ResetText();
            this.txtEmail.ResetText();
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
            this.DgvDangnhap.Enabled = true;
            //focus 
            this.DgvDangnhap.Focus();
        }

        public bool DeleteUserByUserID(int xUserID)
        {
            string query = "DELETE FROM dbo.tblDangnhap WHERE UserID = " + xUserID;
            int kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //kiem tra co record không, nếu không có thì thoát
            if (this.DgvDangnhap == null || this.DgvDangnhap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.", "Error");
                return;
            }
            //index row
            int r = this.DgvDangnhap.CurrentCell.RowIndex;
            //reccord hiện hành trong datagridview
            int m_UserID = Convert.ToInt16(DgvDangnhap.Rows[r].Cells[0].Value);
            string m_username = this.DgvDangnhap.Rows[r].Cells[1].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Chắc không ?", "Xóa " + m_username, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (DeleteUserByUserID(m_UserID))
                {
                    MessageBox.Show("Đã XÓA User " + m_username);
                    //this.btnReload.PerformClick();
                    DgvDangnhap.Rows.RemoveAt(r);
                }
                else
                {
                    MessageBox.Show("Chưa XÓA được User " + m_username, "Error");
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
            this.DgvDangnhap.Focus();

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
            string query = "SELECT UserID, username, password, fullname, email  FROM dbo.tblDangnhap";
            query = query + " WHERE fullname LIKE N'%" + m_txtSearch + "%'";
            DgvDangnhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
            DgvDangnhap.AutoResizeColumns();
            this.DgvDangnhap.Focus();
            if (DgvDangnhap.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy!", "Waning");
                btnReload.PerformClick();
            }
        }

        private void DgvDangnhap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //mask column Password '*****'
            if (e.ColumnIndex == 2 && e.Value != null) //cot Password
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void DgvDangnhap_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //kiem tra co record không, nếu không có thì thoát
            if (this.DgvDangnhap == null || this.DgvDangnhap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }
            else
            //if (DgvDangnhap.Rows.Count > 1)
            {
                int r = e.RowIndex;
                //Chuyen thong tin len panel Acc                
                //if (DgvDangnhap.Rows[r].Cells[0].Value != null)
                //   this.txtUserID.Text = DgvDangnhap.Rows[r].Cells["userID"].Value.ToString();
                if (DgvDangnhap.Rows[r].Cells[1].Value != null)
                    this.txtUsername.Text = DgvDangnhap.Rows[r].Cells["username"].Value.ToString();
                if (DgvDangnhap.Rows[r].Cells[2].Value != null)
                    this.txtPassword.Text = DgvDangnhap.Rows[r].Cells["password"].Value.ToString();
                if (DgvDangnhap.Rows[r].Cells[3].Value != null)
                    this.txtFullname.Text = DgvDangnhap.Rows[r].Cells["fullname"].Value.ToString();
                if (DgvDangnhap.Rows[r].Cells[4].Value != null)
                    this.txtEmail.Text = DgvDangnhap.Rows[r].Cells["email"].Value.ToString();
            }
        }

        private void textbox_edit_off()
        {
            //this.txtUserID.ReadOnly = true;
            this.txtUsername.ReadOnly = true;
            this.txtPassword.ReadOnly = true;
            this.txtFullname.ReadOnly = true;
            this.txtEmail.ReadOnly = true;

            //this.txtUserID.BackColor = SystemColors.Window;
            this.txtUsername.BackColor = SystemColors.Window;
            this.txtPassword.BackColor = SystemColors.Window;
            this.txtFullname.BackColor = SystemColors.Window;
            this.txtEmail.BackColor = SystemColors.Window;
        }

        private void textbox_edit_on()
        {
            //this.txtUserID.ReadOnly = false;
            this.txtUsername.ReadOnly = false;
            this.txtPassword.ReadOnly = false;
            this.txtFullname.ReadOnly = false;
            this.txtEmail.ReadOnly = false;
        }
    }
}
