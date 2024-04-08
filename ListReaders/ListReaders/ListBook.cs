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


namespace ListReaders
{
    public partial class ListBook : Form
    {

        public static List<Quyensach> listBookSelected = new List<Quyensach>();
        public ListBook()
        {
            InitializeComponent();

            var Repo = new RepositoryBase<Loaisach>();
            var listcombo = Repo.GetAll().Select(p => new
            {
                p.Id,
                p.LoaiSach1
            }).ToList();
            var BookRepo = new RepositoryBase<Quyensach>();

            var listBook = BookRepo.GetAll().Include(p => p.MaLoaiSachNavigation).Include(p => p.MsnxbNavigation).ToList();
            dataGridView1.DataSource = listBook.Select(p => new
            {
                MaSach = p.MaSach,
                TenSach = p.TenSach,
                SoLuong = p.SoLuong,
                TenTacGia = p.TenTacGia,
                LoaiSach = p.MaLoaiSachNavigation.LoaiSach1,
                NhaXuatBan = p.MsnxbNavigation.TenNxb
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean check = false;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Selected"].Value) == true)
                {
                    check = true;
                    Quyensach book = new Quyensach();
                    book.MaSach = (string)row.Cells["MaSach"].Value;
                    book.TenSach = row.Cells["TenSach"].Value.ToString();
                    //book.SoLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    book.TenTacGia = (string)row.Cells["TenTacGia"].Value;

                    //book.MaLoaiSachNavigation.LoaiSach1 = (string)row.Cells["LoaiSach"].Value;

                    //book.MsnxbNavigation.TenNxb = (string)row.Cells["NhaXuatBan"].Value;
                    listBookSelected.Add(book);

                    this.Hide();
                    BorrowForm borrowBook = new BorrowForm();
                    borrowBook.ShowDialog();
                }
                else
                {
                }
            }


        }


    }
}




