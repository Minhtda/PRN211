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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
            var repo = new RepositoryBase<Quyensach>();
            var repo1 = new RepositoryBase<Loaisach>();
            var repo2 = new RepositoryBase<Nhaxuatban>();
            var listloai = repo1.GetAll().Select(p => new { p.Id, p.LoaiSach1 }).ToList();
            var listnxb = repo2.GetAll().Select(p => new { p.Id, p.TenNxb }).ToList();
            cbLoaisach.DisplayMember = "LoaiSach1";
            cbLoaisach.ValueMember = "Id";
            cbLoaisach.DataSource = listloai;
            cbNxb.DisplayMember = "TenNxb";
            cbNxb.ValueMember = "Id";
            cbNxb.DataSource = listnxb;
            loadData();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        public bool checkInput(string ac)
        {
            return Regex.IsMatch(ac, "^.{1,50}$");
        }
        void loadData()
        {
            var quyenSachRepo = new RepositoryBase<Quyensach>();
            var listQuyenSach = quyenSachRepo.GetAll()
                .Include(p => p.Nhaxuatban)
                .Include(p => p.Loaisach)
                .ToList();
            dgvBookList.DataSource = listQuyenSach.Select(p => new
            {
                p.Id,
                p.TenSach,
                p.SoLuong,
                p.TenTacGia,
                p.Nhaxuatban.TenNxb,
                p.Loaisach.LoaiSach1,
            }).ToList();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            if (!checkInput(txtName1.Text.Trim()))
            {
                MessageBox.Show("tên sách từ 1-50 ký tự không ghi dấu");
                btnCreate.Enabled = true;
                return;

            }
            if (!checkInput(txtTenTG.Text.Trim()))
            {
                MessageBox.Show("tên tác giả từ 1-50 ký tự không ghi dấu");
                btnCreate.Enabled = true;
                return;
            }
            Quyensach book = new Quyensach();
            book.TenSach = txtName1.Text;
            book.SoLuong = int.Parse(txtsl.Text);
            book.TenTacGia = txtTenTG.Text;
            book.Nhaxuatbanid = cbNxb.SelectedValue.ToString();
            book.Loaisachid = cbLoaisach.SelectedValue.ToString();
            var repo = new RepositoryBase<Quyensach>();
            char[] charsToTrim = { ' ' };


            int check;
            bool parseSuccess = int.TryParse(txtsl.Text, out check);
            if (parseSuccess)
            {
                repo.Create(book);
            }
            else
            {
                MessageBox.Show("So luong khonn hop le");
            }
            btnCreate.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            loadData();

            txtID.Text = "";
            txtName1.Text = "";
            txtsl.Text = "";
            txtTenTG.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            var bookId = txtID.Text;
            var bookRepo = new RepositoryBase<Quyensach>();
            var obj = bookRepo.GetAll().Where(p => p.Id.Equals(int.Parse(bookId))).FirstOrDefault();
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you wan to Delete?", "Delete Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bookRepo.Delete(obj);
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do nothing
                }

                btnDelete.Enabled = true;
                btnCreate.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                loadData();

                txtID.Text = "";
                txtName1.Text = "";
                txtsl.Text = "";
                txtTenTG.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryBase<Quyensach>();
            DataGridViewRow row = dgvBookList.CurrentRow;
            btnUpdate.Enabled = false;
            if (!checkInput(txtName1.Text.Trim()))
            {
                MessageBox.Show("tên sách từ 1-50 ký tự không ghi dấu");
                btnCreate.Enabled = true;
                return;
            }
            if (!checkInput(txtTenTG.Text.Trim()))
            {
                MessageBox.Show("tên tác giả từ 1-50 ký tự không ghi dấu");
                btnCreate.Enabled = true;
                return;
            }
            int check;
            bool parseSuccess = int.TryParse(txtsl.Text, out check);
            if (parseSuccess)
            {
                Quyensach book = new Quyensach();
                book.Id = int.Parse(txtID.Text);
                book.TenSach = txtName1.Text;
                book.SoLuong = int.Parse(txtsl.Text);
                book.TenTacGia = txtTenTG.Text;
                book.Nhaxuatbanid = cbNxb.SelectedValue.ToString();
                book.Loaisachid = cbLoaisach.SelectedValue.ToString();
                repo.Update(book);
                btnUpdate.Enabled = true;
                btnCreate.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                loadData();

                txtID.Text = "";
                txtName1.Text = "";
                txtsl.Text = "";
                txtTenTG.Text = "";
            }
            else
            {
                MessageBox.Show("So luong khonn hop le");
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
                    var repo = new RepositoryBase<Quyensach>();
                    var listQuyenSach = repo.GetAll()
                        .Include(p => p.Nhaxuatban)
                        .Include(p => p.Loaisach)
                        .Where(p => p.TenSach.Contains(txtName2.Text))
                        .ToList();
                    dgvBookList.DataSource = listQuyenSach.Select(p => new
                    {
                        p.Id,
                        p.TenSach,
                        p.SoLuong,
                        p.TenTacGia,
                        p.Nhaxuatban.TenNxb,
                        p.Loaisach.LoaiSach1,
                    }).ToList();
                    txtName2.Text = "";
                }
            }
            btnSearch.Enabled = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageForm form = new ManageForm();
            form.ShowDialog();
            this.Close();
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void dgvBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBookList.Rows[e.RowIndex].Cells[0].Value;
            txtID.Text = row.ToString();

            var repo = new RepositoryBase<Quyensach>();
            var book = repo.GetAll()
                .Include(p => p.Nhaxuatban)
                .Include(p => p.Loaisach)
                .Where(p => p.Id.Equals(int.Parse(txtID.Text)))
                .FirstOrDefault();
            if (book != null)
            {
                txtName1.Text = book.TenSach;
                txtsl.Text = book.SoLuong.ToString();
                txtTenTG.Text = book.TenTacGia;
                cbNxb.Text = book.Nhaxuatban.TenNxb.ToString();
                cbLoaisach.Text = book.Loaisach.LoaiSach1.ToString();
            }
            btnCreate.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
