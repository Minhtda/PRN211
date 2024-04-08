using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository_3.Models;
using Repository_3;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var _username = txtUsername.Text;
            var _password = txtPassword.Text;
            btnLogin.Enabled = false;

            var Repo = new RepositoryBase<User>(); //implement CRUD cho Table User

            var _check = Repo.GetAll().Where(p => p.UserId.Equals(_username) && p.Password.Equals(_password) && p.UserRole == 1).FirstOrDefault();

            if (_check != null)//ton tai user co role la administrator
            {
                var NewForm = new BankAccountForm(_check);
                this.Hide();
                NewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not allow to access this function", "Login Failed", MessageBoxButtons.OK);
                btnLogin.Enabled = true;
            }

        }
    }
}
