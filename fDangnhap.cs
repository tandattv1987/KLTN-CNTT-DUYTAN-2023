using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QUANLYBANHANG
{
    public partial class fDangnhap : Form
    {
        private bool loginOK = false;
        //private string fullname = "";

        public bool LoginOK
        {
            get
            {
                return this.loginOK;
            }
        }

        public string fullname
        {
            get { return this.fullname; }
            //set => fullname = value; 
        }
        public fDangnhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDangnhap_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.txtUsername.Focus();
        }

        private DataTable LoginReturnPermission(string userName, string passWord)
        {
            DataTable dt;
            //string query = "EXEC dbo.USP_Login @userName = '" + userName + "' , @passWord = '" + passWord + "'";
            string query = "SELECT * FROM dbo.tblDangnhap WHERE username = '" + @userName + "' AND password = '" + @passWord + "'";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord }); //co tham so
            //if (dt.Rows.Count == 1 && dt.Columns.Count == 1)
            //    kq = dt.Rows[0]["Permission"].ToString().Trim();
            return dt;
        }

        private DataTable LoginWithOTP(string userName, string passWord, string otp)
        {
            DataTable dt;
            //string query = "EXEC dbo.USP_Login @userName = '" + userName + "' , @passWord = '" + passWord + "'";
            string query = "SELECT * FROM dbo.tblDangnhap WHERE username = '" + @userName + "' AND password = '" + @passWord + "' AND otp = '" + @otp + "'";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord, otp }); //co tham so
            //if (dt.Rows.Count == 1 && dt.Columns.Count == 1)
            //    kq = dt.Rows[0]["Permission"].ToString().Trim();
            return dt;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username không được trống");
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password không được trống");
                return;
            }

            if (txtMaxacthuc.Text == "")
            {
                MessageBox.Show("OTP không được trống");
                return;
            }

            string userName = txtUsername.Text.Trim();
            string passWord = txtPassword.Text.Trim();
            string otp = txtMaxacthuc.Text.Trim();
            DataTable dt = LoginWithOTP(userName, passWord, otp);
            if (dt.Rows.Count <= 0)
                MessageBox.Show("OTP sai", "Đăng nhập");
            else
            {
                MessageBox.Show("Đăng nhập thành công!", "Đăng Nhập");
                btnThoat.PerformClick();
            }
        }

        private void btnLaymaxacthuc_Click(object sender, EventArgs e)
        {
            //1. Kiem tra username va password neu chua nhap se bao loi
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username và password không được trống");
                return;
            }

            //Tim trong DB tat ca cac usename co ten giong txtUser.text va pass trung voi txtPass.txt
            string xuserName = txtUsername.Text.Trim();
            string xpassWord = txtPassword.Text.Trim();
            DataTable dt = LoginReturnPermission(xuserName, xpassWord);
            //Neu khong ton tai thi  xuat thong bao loi
            if (dt.Rows.Count <= 0)
                MessageBox.Show("Username không tồn tại hoặc password sai");
            else  //Neu co ton tai, sinh ra ma otp random 6 ky tu... va luu otp vao DB va vao labelOTP
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[6];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                //Gan vao label OTP
                labelOTP.Text = finalString;

                //Gan vao DB otp voi username, password da luu tu dau
                string query = "UPDATE dbo.tblDangnhap SET  otp = N'" + finalString;
                query = query + "' WHERE username = '" + xuserName + "' AND password = '" + xpassWord + "'";

                int kq = DataProvider.Instance.ExecuteNonQuery(query);

            }


        }


    }
}
