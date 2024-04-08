
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
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        public static Taikhoan _USER = new Taikhoan();
        public static Nhanvien _STAFF = new Nhanvien();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var _tk = txtName.Text.ToString().Trim();
            var _mk = txtPassword.Text.ToString().Trim();
            var Repo = new RepositoryBase<Taikhoan>();
            if(_tk!=null)
            {
                if(_mk!=null)
                {
                    
                    var _User = Repo.GetAll().Where(o => o.TenTk.Equals(_tk) && o.MatKhau.Equals(_mk)).FirstOrDefault();
                    //String id = _User.
                    if (_User != null)
                    {
                        _USER = _User;
                        var RepoStaff = new RepositoryBase<Nhanvien>();
                        var _Staff = RepoStaff.GetAll().Where(p => p.Id.Equals(Login._USER.Nhanvienid)).FirstOrDefault();
                        _USER = (Taikhoan)_User;
                        if (_Staff != null)
                        {
                            _STAFF = (Nhanvien)_Staff;
                        }
                        this.Hide();
                        ManageForm Form = new ManageForm();
                        Form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("your are not allowed to access this function", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("password must be 6-30 characters");
                }

            }
            else
            {
                MessageBox.Show("Username must be 6-30 characters");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
