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
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
            var empRepo = new RepositoryBase<Nhanvien>();
            var empList = empRepo.GetAll().Select(p => new { p.Id, p.HoTenNv, p.NgaySinhNv, p.NgayVaoLam }).ToList();
            dataGridView1.DataSource = empList;
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void RegisterEmployee_Load(object sender, EventArgs e)
        {

        }
        public bool checkInput(string ac)
        {
            return Regex.IsMatch(ac, "^.{1,50}$");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = IDtxt.Text;
            if (!checkInput(id))
            {
                MessageBox.Show("ID co tu 1 den 50 ky tu");
                return;
            }
            var nvRepo = new RepositoryBase<Nhanvien>();
            var checkID = nvRepo.GetAll().Where(p => p.Id.Equals(id)).FirstOrDefault();
            if (checkID != null)
            {
                MessageBox.Show("ID trung lap");
                return;
            }
            var name = txtName1.Text;
            if (!checkInput(name))
            {
                MessageBox.Show("ten co tu 1 den 50 ky tu");
                return;
            }
            var bday = txtBDay.Value;
            var tele = txtPhoneNumber.Text;
            var date = txtDate.Value;
            int age = date.Year - bday.Year;
            if (age <18)
            {
                MessageBox.Show("nhan vien chua du 18");
                return;
            }
            if (tele.Length != 10)
            {
                MessageBox.Show("A phone numbers must be 10 numbers");
            }
            Nhanvien nv = new Nhanvien();
            nv.Id = IDtxt.Text;
            nv.HoTenNv = txtName1.Text;
            nv.NgaySinhNv = bday;
            nv.NgayVaoLam = date;
            nvRepo.Create(nv);
            var empList = nvRepo.GetAll().Select(p => new { p.Id, p.HoTenNv, p.NgaySinhNv, p.NgayVaoLam }).ToList();
            dataGridView1.DataSource = empList;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error, A phone number cannot contain letters");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            IDtxt.Text = row.ToString();
            IDtxt.Enabled = false;
            var repo = new RepositoryBase<Nhanvien>();
            var nv = repo.GetAll()
                .Where(p => p.Id.Equals(IDtxt.Text))
                .FirstOrDefault();
            if (nv != null)
            {
                txtName1.Text = nv.HoTenNv.Trim();
                txtPhoneNumber.Text = nv.DienThoaiNv.Trim();
                txtDate.Value = Convert.ToDateTime(nv.NgayVaoLam);
                txtBDay.Value = Convert.ToDateTime(nv.NgaySinhNv);
            }
            btnCreate.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            var nvID = IDtxt.Text;
            var nvRepo = new RepositoryBase<Quyensach>();
            var obj = nvRepo.GetAll().Where(p => p.Id.Equals(nvID)).FirstOrDefault();
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you wan to Delete?", "Delete Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    nvRepo.Delete(obj);
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do nothing
                }

                btnCreate.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                IDtxt.Text = "";
                IDtxt.Enabled = true;
                txtName1.Text = "";
                txtPhoneNumber.Text = "";
                txtBDay.Value = DateTime.Now;
                txtDate.Value = DateTime.Now;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            char[] charsToTrim = { ' ' };
            var Sname = txtName2.Text.Trim(charsToTrim);
            if (Sname != null)
            {
                if (Sname != "")
                {
                    var repo = new RepositoryBase<Nhanvien>();
                    var listQuyenSach = repo.GetAll().
                        Select(p => new { p.Id, p.HoTenNv, p.NgaySinhNv, p.NgayVaoLam })
                        .Where(p => p.HoTenNv.Contains(txtName2.Text))
                        .ToList();
                    var empList = repo.GetAll().Select(p => new { p.Id, p.HoTenNv, p.NgaySinhNv, p.NgayVaoLam }).ToList();
                    dataGridView1.DataSource = empList;
                    dataGridView1.DataSource = listQuyenSach;
                    txtName2.Text = "";
                }
            }
            btnSearch.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<Nhanvien>();
            DataGridViewRow row = dataGridView1.CurrentRow;
            btnUpdate.Enabled = false;
            var id = IDtxt.Text;
            var name = txtName1.Text;
            if (!checkInput(name))
            {
                MessageBox.Show("ten co tu 1 den 50 ky tu");
                btnUpdate.Enabled = true;
                return;
            }
            var bday = txtBDay.Value;
            var tele = txtPhoneNumber.Text;
            var date = txtDate.Value;
            int age = date.Year - bday.Year;
            if (age < 18)
            {
                MessageBox.Show("nhan vien chua du 18");
                btnUpdate.Enabled = true;
                return;
            }
            if (tele.Length != 10)
            {
                MessageBox.Show("A phone numbers must be 10 numbers");
                btnUpdate.Enabled = true;
                return; 
            }
            Nhanvien nv = new Nhanvien();
            nv.Id = IDtxt.Text;
            nv.HoTenNv = txtName1.Text;
            nv.NgaySinhNv = bday;
            nv.NgayVaoLam = date;
            repo.Update(nv);
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            IDtxt.Text = "";
            IDtxt.Enabled = true;
            txtName1.Text = "";
            txtPhoneNumber.Text = "";
            txtBDay.Value = DateTime.Now;
            txtDate.Value = DateTime.Now;
        }
    }
}
