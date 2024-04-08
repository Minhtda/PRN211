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

namespace PRN211PE_Assigment
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var _tk = txtUsername.Text.ToString().Trim();
            var _mk = txtPassword.Text.ToString().Trim();
            var Repo = new RepositoryBase<Taikhoan>();
            var _User = Repo.GetAll().Where(o => o.TenTK.Contains(_tk) && o.MatKhau.Contains(_mk)).FirstOrDefault();
            if (_User != null)
            {
                MessageBox.Show("login success");
            }
            else
            {
                MessageBox.Show("your are not allowed to access this function", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
