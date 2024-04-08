using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();

            txtStaff.Text = (string)Login._STAFF.HoTenNv;
            RepositoryBase<Muontra> RepoReturn = new RepositoryBase<Muontra>();
            txtDate.Text = DateTime.Now.ToString();
            var listReturnBook = RepoReturn.GetAll().Include(p => p.Docgia).Include(p => p.Phat).Include(p => p.Nhanvien).Include(p => p.Quyensach).ToList();
            var newListBook = listReturnBook.Where(p=> p.TinhTrangMuon == true).Select(p => new
            {
                ID = p.Id,
                IDDocGia = p.Docgiaid,
                DocGia = p.Docgia.TenDocGia,
                NgayMuon = p.NgayMuon,
                NgayTra = "",
                HanTra = p.HanTra,
                TinhTrangMuon = p.TinhTrangTra,
                TinhTrangTra = p.TinhTrangMuon,
                QuyenSach = p.Quyensach.TenSach,
                NhanVien = p.Nhanvien.HoTenNv,
                IDQuyenSach = p.Quyensach.Id,
                IDNhanVien = p.Nhanvien.Id,


            }).ToList();


            dataGridView1.DataSource = newListBook;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void Return_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //    RepositoryBase<Quyensach> RepoBook = new RepositoryBase<Quyensach>();
            //    RepositoryBase<Muontra> RepoReturn = new RepositoryBase<Muontra>();
            //    RepositoryBase<Phat> RepoPhat = new RepositoryBase<Phat>();


            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {

            //        if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
            //        {
            //            if (txtDate.Value >= DateTime.Today)
            //            {
            //                Muontra muontra = new Muontra();
            //                muontra.Id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
            //                muontra.Docgiaid = row.Cells["IDDocGia"].Value.ToString();
            //                muontra.NgayMuon = Convert.ToDateTime(row.Cells["NgayMuon"].Value.ToString());
            //                muontra.NgayTra = txtDate.Value;
            //                muontra.HanTra = Convert.ToDateTime(row.Cells["HanTra"].Value.ToString());
            //                muontra.TinhTrangMuon = false;
            //                muontra.TinhTrangTra = true;
            //                muontra.Quyensachid = Convert.ToInt32(row.Cells["IDQuyenSach"].Value.ToString());
            //                muontra.Nhanvienid = row.Cells["IDNhanVien"].Value.ToString();
            //                if (muontra.NgayTra > muontra.HanTra)
            //                {

            //                    Phat phat = new Phat();
            //                    phat.NguyenNhan = "Trễ hạn trả sách";
            //                    RepoPhat.Create(phat);
            //                    muontra.Phatid = phat.Id;
            //                }
            //                RepoReturn.Update(muontra);

            //            }
            //            else
            //            {
            //                MessageBox.Show("Không thể chọn ngày nhỏ hơn ngày hiện tại", "ERROR: Choose paymntdate invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                return;
            //            }

            //            foreach (DataGridViewRow row1 in dataGridView1.Rows)
            //            {
            //                if (Convert.ToBoolean(row1.Cells["Select"].Value) == true)
            //                {


            //                    int chekid = Convert.ToInt32(row1.Cells["IDQuyenSach"].Value.ToString());
            //                    var listBook = RepoBook.GetAll().Where(p => p.Id == chekid).FirstOrDefault();
            //                    if (listBook != null)
            //                    {
            //                        listBook.TenSach = listBook.TenSach;
            //                        listBook.SoLuong = listBook.SoLuong + 1;
            //                        listBook.TenTacGia = listBook.TenTacGia;
            //                        listBook.Nhaxuatbanid = listBook.Nhaxuatbanid;
            //                        listBook.Loaisachid = listBook.Loaisachid;
            //                        txtSearch.Text = listBook.Id.ToString();
            //                        RepoBook.Update(listBook);
            //                    }
            //                }

            //            }
            //        }
            //    }

            //    var listReturnBook = RepoReturn.GetAll().Include(p => p.Docgia).Include(p => p.Phat).Include(p => p.Nhanvien).Include(p => p.Quyensach).Where(p => p.TinhTrangTra == false).ToList();
            //    var newListBook = listReturnBook.Select(p => new
            //    {
            //        ID = p.Id,
            //        IDDocGia = p.Docgiaid,
            //        DocGia = p.Docgia.TenDocGia,
            //        NgayMuon = p.NgayMuon,
            //        NgayTra = p.NgayTra,
            //        HanTra = p.HanTra,
            //        TinhTrangMuon = p.TinhTrangTra,
            //        TinhTrangTra = p.TinhTrangMuon,
            //        QuyenSach = p.Quyensach.TenSach,
            //        NhanVien = p.Nhanvien.HoTenNv,
            //        IDQuyenSach = p.Quyensach.Id,
            //        IDNhanVien = p.Nhanvien.Id,


            //    }).ToList();

            //    dataGridView1.DataSource = newListBook;
            //    dataGridView1.Columns[1].Visible = false;
            //    dataGridView1.Columns[2].Visible = false;
            //    dataGridView1.Columns[10].Visible = false;
            //    dataGridView1.Columns[9].Visible = false;

            RepositoryBase<Quyensach> RepoBook = new RepositoryBase<Quyensach>();
            RepositoryBase<Muontra> RepoReturn = new RepositoryBase<Muontra>();
            RepositoryBase<Phat> RepoPhat = new RepositoryBase<Phat>();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    Muontra muontra = new Muontra();
                    muontra.Id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    muontra.Docgiaid = row.Cells["IDDocGia"].Value.ToString();
                    muontra.NgayMuon = Convert.ToDateTime(row.Cells["NgayMuon"].Value.ToString());
                    muontra.NgayTra = Convert.ToDateTime(txtDate.Text);
                    muontra.HanTra = Convert.ToDateTime(row.Cells["HanTra"].Value.ToString());
                    muontra.TinhTrangMuon = false;
                    muontra.TinhTrangTra = true;
                    muontra.Quyensachid = Convert.ToInt32(row.Cells["IDQuyenSach"].Value.ToString());
                    muontra.Nhanvienid = row.Cells["IDNhanVien"].Value.ToString();
                    if (muontra.NgayTra > muontra.HanTra)
                    {
                        Phat phat = new Phat();
                        phat.NguyenNhan = "Trễ hạn trả sách";
                        RepoPhat.Create(phat);
                        muontra.Phatid = phat.Id;
                    }
                    else
                    {
                        Phat phat = new Phat();
                        phat.NguyenNhan = "Không có phạt";
                        RepoPhat.Create(phat);
                        muontra.Phatid = phat.Id;
                    }
                    RepoReturn.Update(muontra);
                    //if (txtDate.Value >= DateTime.Today)
                    //{
                        

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Không thể chọn ngày nhỏ hơn ngày hiện tại", "ERROR: Choose paymntdate invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return;
                    //}


                }
            }
            foreach (DataGridViewRow row1 in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row1.Cells["Select"].Value) == true)
                {


                    int chekid = Convert.ToInt32(row1.Cells["IDQuyenSach"].Value.ToString());
                    var listBook = RepoBook.GetAll().Where(p => p.Id == chekid).FirstOrDefault();
                    if (listBook != null)
                    {
                        listBook.TenSach = listBook.TenSach;
                        listBook.SoLuong = listBook.SoLuong + 1;
                        listBook.TenTacGia = listBook.TenTacGia;
                        listBook.Nhaxuatbanid = listBook.Nhaxuatbanid;
                        listBook.Loaisachid = listBook.Loaisachid;
                        //txtSearch.Text = listBook.Id.ToString();
                        RepoBook.Update(listBook);
                    }

                }
            }
            MessageBox.Show("Tra thanh cong");
            var listReturnBook = RepoReturn.GetAll().Include(p => p.Docgia).Include(p => p.Phat).Include(p => p.Nhanvien).Include(p => p.Quyensach).ToList();
            var newListBook = listReturnBook.Where(p => p.TinhTrangMuon == true).Select(p => new
            {
                ID = p.Id,
                IDDocGia = p.Docgiaid,
                DocGia = p.Docgia.TenDocGia,
                NgayMuon = p.NgayMuon,
                NgayTra = "",
                HanTra = p.HanTra,
                TinhTrangMuon = p.TinhTrangMuon,
                TinhTrangTra = p.TinhTrangTra,
                QuyenSach = p.Quyensach.TenSach,
                NhanVien = p.Nhanvien.HoTenNv,
                IDQuyenSach = p.Quyensach.Id,
                IDNhanVien = p.Nhanvien.Id,


            }).ToList();
            dataGridView1.DataSource = newListBook;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[9].Visible = false;

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
                    RepositoryBase<Muontra> RepoReturn = new RepositoryBase<Muontra>();

                    var listReturnBook = RepoReturn.GetAll().Include(p => p.Docgia).Include(p => p.Phat).Include(p => p.Nhanvien).Include(p => p.Quyensach).Where(p => p.Docgia.TenDocGia.Contains(Sname)).ToList();
                    dataGridView1.DataSource = listReturnBook.Select(p => new
                    {
                        ID = p.Id,
                        IDDocGia = p.Docgiaid,
                        DocGia = p.Docgia.TenDocGia,
                        NgayMuon = p.NgayMuon,
                        NgayTra = "",
                        HanTra = p.HanTra,
                        TinhTrangMuon = p.TinhTrangTra,
                        TinhTrangTra = p.TinhTrangMuon,
                        QuyenSach = p.Quyensach.TenSach,
                        NhanVien = p.Nhanvien.HoTenNv,
                        IDQuyenSach = p.Quyensach.Id,
                        IDNhanVien = p.Nhanvien.Id,


                    }).ToList();
                    //dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    txtSearch.Text = "";
                }
            }
            btnSearch.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListReaders form = new ListReaders();
            form.ShowDialog();
            this.Close();
                    
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            txtDate.Text = (DateTime.Now.AddDays(365)).ToString();
        }
    }
}
