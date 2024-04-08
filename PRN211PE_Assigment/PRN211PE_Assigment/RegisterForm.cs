using Microsoft.Data.SqlClient;
using Repository.Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PRN211PE_Assigment
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6.30}$");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            Taikhoan newTk = new Taikhoan();
            newTk.TenTK = reUsername.Text.ToString().Trim();
            newTk.Ten = reName.Text.ToString().Trim();
            newTk.MatKhau = rePassword.Text.ToString().Trim();
            if (CheckAccount(newTk.TenTK))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-30 ký tự chữ và số, chữ hoa");
            }
            if (CheckAccount(newTk.MatKhau))
            {
                MessageBox.Show("Vui lòng nhập tên mật khẩu dài 6-30 ký tự chữ và số, chữ hoa");
            }
            else
            {
                var repo = new RepositoryBase<Taikhoan>();
                repo.Create(newTk);
                MessageBox.Show("Đăng Ký Thành Công");


            }
            
            btnRegister.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
