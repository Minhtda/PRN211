using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRN211_7
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Book form = new Book();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            ListReaders form = new ListReaders();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Return form = new Return();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnRegisterReader_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerReader form = new registerReader();
            form.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            History form = new History();
            form.ShowDialog();
            this.Close();
        }

        private void btnRegEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterEmployee form = new RegisterEmployee();
            form.ShowDialog();
            this.Close();
        }
    }
}
