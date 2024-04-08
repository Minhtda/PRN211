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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRN211_7
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            var repo = new RepositoryBase<Muontra>();
            var listHistory = repo.GetAll().Where(p => p.TinhTrangTra!=null).Where(p => p.TinhTrangMuon != null).Where(p => p.NgayTra !=null).Where(p => p.Phatid!= null)
                .Include(p => p.Docgia)
                .Include(p => p.Nhanvien)
                .Include(p => p.Quyensach)
                .Include(p => p.Phat)
                .ToList();
            var listHistory1 = listHistory.Select(p => new
            {
                p.Id,
                p.TinhTrangMuon,
                p.NgayMuon,
                p.TinhTrangTra,
                p.NgayTra,
                p.Docgia.TenDocGia,
                p.Phat.NguyenNhan,
                p.Quyensach.TenSach,
                p.Nhanvien.HoTenNv,
            }).ToList();
            dataGridView1.DataSource = listHistory1;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ManageForm form = new ManageForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            char[] charsToTrim = { ' ' };
            var Sname = txtSearch.Text.Trim(charsToTrim);
            if (Sname != null)
            {
                if (Sname != "")
                {
                    var repo = new RepositoryBase<Muontra>();
                    var listHistory = repo.GetAll().Where(p => p.TinhTrangTra != null).Where(p => p.TinhTrangMuon != null).Where(p => p.NgayTra != null).Where(p => p.Phatid != null)
                    .Where(p => p.Docgia.TenDocGia.Contains(txtSearch.Text))
                    .Include(p => p.Docgia)
                    .Include(p => p.Nhanvien)
                    .Include(p => p.Quyensach)
                    .Include(p => p.Phat)
                    .ToList();
                    dataGridView1.DataSource = listHistory.Select(p => new
                    {
                        p.Id,
                        p.TinhTrangMuon,
                        p.NgayMuon,
                        p.TinhTrangTra,
                        p.NgayTra,
                        p.Docgia.TenDocGia,
                        p.Phat.NguyenNhan,
                        p.Quyensach.TenSach,
                        p.Nhanvien.HoTenNv,
                    }).ToList();
                    txtSearch.Text = "";
                }
            }
            btnSearch.Enabled = true;
        }
    }
}
