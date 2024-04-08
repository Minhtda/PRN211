using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRN211_7
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            txtRegister.Text = "Return to login";
            txtRegister.ForeColor = Color.Blue;
            var nvList = new RepositoryBase<Nhanvien>();
            var listAccountName = nvList.GetAll().Select(p => new { Value = p.Id, Text = p.HoTenNv}).ToList(); ;
            cbEmp.ValueMember = "Value";
            cbEmp.DisplayMember = "Text";
            cbEmp.DataSource = (listAccountName.ToArray());
        }
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,30}$");
        }
        public bool checkPassword(string ac)
        {
            return Regex.IsMatch(ac, "^.{6,30}$");
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            Taikhoan newTk = new Taikhoan();
            newTk.TenTk = txtUsername.Text.ToString().Trim();
            newTk.Ten = txtName.Text.ToString().Trim();
            newTk.MatKhau = txtPassword.Text.ToString().Trim();
            var reMatkharu = txtConfirm.Text.ToString().Trim();
            var repo = new RepositoryBase<Taikhoan>();
            var account = repo.GetAll().Where(p => p.TenTk.Equals(txtUsername.Text.ToString())).FirstOrDefault();
            if (!CheckAccount(newTk.TenTk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản từ 6 đến 30 ký tự chữ và số, chữ hoa. Không được viết dấu");
                btnRegister.Enabled = true;
                return;
            }
            if (!checkPassword(newTk.MatKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu từ 6 đến 30 ký tự chữ và số, chữ hoa. Không được viết dấu");
                btnRegister.Enabled = true;
                return;
            }
            if (newTk.Ten==null)
            {
                MessageBox.Show("Vui lòng nhập tên");
                btnRegister.Enabled = true;
                return;
            }
            if (newTk.MatKhau !=reMatkharu)
            {
                MessageBox.Show("xác nhận mật khẩu sai");
                btnRegister.Enabled = true;
                return;
            }
            if (account != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
            else
            {
                repo.Create(newTk);
                txtRegister.Text = "Đăng Ký Thành Công, bấm vào để login";
            }
            btnRegister.Enabled = true;
        }

        private void txtRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void cbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
