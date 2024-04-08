using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Models;
using System;
using System.Collections;
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
    public partial class BorrowBook : Form
    {

        public static List<Quyensach> listBookSelected = new List<Quyensach>();
        public BorrowBook()
        {
            InitializeComponent();

            var Repo = new RepositoryBase<Loaisach>();
            var listcombo = Repo.GetAll().Select(p => new
            {
                p.Id,
                p.LoaiSach1
            }).ToList();
            var BookRepo = new RepositoryBase<Quyensach>();

            var listBook = BookRepo.GetAll().Include(p => p.Loaisach).Include(p => p.Nhaxuatban).ToList();
            var newListBook = listBook.Select(p => new
            {
                MaSach = p.Id,
                TenSach = p.TenSach,
                SoLuong = p.SoLuong,
                TenTacGia = p.TenTacGia,
                LoaiSach = p.Loaisach.LoaiSach1,
                NhaXuatBan = p.Nhaxuatban.TenNxb
            }).ToList();
            dgvReaderList.DataSource = newListBook;
        }

        

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReaderList.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {

                    var book = new Quyensach();
                    book.Id = Convert.ToInt32(row.Cells["MaSach"].Value.ToString());

                    listBookSelected.Add(book);


                }
                else
                {
                }
            }
            this.Hide();
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.ShowDialog();
            this.Close();
        }

        private void btnReturnListReader_Click(object sender, EventArgs e)
        {
            ManageForm form = new ManageForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }

}
