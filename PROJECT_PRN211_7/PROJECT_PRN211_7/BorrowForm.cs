using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Models;
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace PROJECT_PRN211_7
{
    
    public partial class BorrowForm : Form
    {

        string idReader = ListReaders.idReader;
        public static DateTime deadline = new DateTime();
        public static DateTime dateBorrowCheck = new DateTime();

        public BorrowForm()
        {

            InitializeComponent();


            var BookRepo = new RepositoryBase<Quyensach>();
            var Repo = new RepositoryBase<Docgium>();
            txtDate.Text = DateTime.Now.ToString();

            txtStaff.Text = Login._USER.Ten;
            var Reader = Repo.GetAll().Where(c => c.Id == idReader).FirstOrDefault();
            if (Reader != null)
            {

                txtName.Text = Reader.TenDocGia.ToString();
                txtAddress.Text = Reader.DiaChi.ToString();


            }
            else
            {

            }
            var listBookSelected = BorrowBook.listBookSelected;
            ArrayList arrayList = new ArrayList();
            foreach (var item in listBookSelected)
            {
                var listBook = BookRepo.GetAll().Include(p => p.Loaisach).Include(p => p.Nhaxuatban).ToList();
                var newListBook = listBook.Where(p => p.Id == item.Id).Select(p => new
                {
                    MaSach = p.Id,
                    TenSach = p.TenSach,
                    SoLuong = p.SoLuong,
                    TenTacGia = p.TenTacGia,
                    LoaiSach = p.Loaisach.LoaiSach1,
                    NhaXuatBan = p.Nhaxuatban.TenNxb
                }).FirstOrDefault();

                arrayList.Add(newListBook);

            }

            dataGridView1.DataSource = arrayList;
        }



        private void btnBorrow_Click(object sender, EventArgs e)
        {
            RepositoryBase<Quyensach> RepoBook = new RepositoryBase<Quyensach>();
            RepositoryBase<Muontra> BorrowReturn = new RepositoryBase<Muontra>();
            RepositoryBase<Phat> Phatrepo = new RepositoryBase<Phat>();
            foreach (var bBook in BorrowBook.listBookSelected)
            {
                Muontra muontra = new Muontra();
                muontra.Docgiaid = idReader;
                muontra.NgayMuon = DateTime.Now;
                dateBorrowCheck = Convert.ToDateTime(muontra.NgayMuon);
                muontra.HanTra = DateTime.Today.AddDays(14);
                deadline = DateTime.Today.AddDays(14);
                muontra.TinhTrangMuon = true;
                muontra.TinhTrangTra = false;
                muontra.Quyensachid = bBook.Id;
                muontra.Nhanvienid = Login._USER.Nhanvienid;

                BorrowReturn.Create(muontra);
                Phat phat = new Phat();
                phat.NguyenNhan = "Không có phạt";
                Phatrepo.Create(phat);
                muontra.Phatid = phat.Id;
                BorrowReturn.Update(muontra);
            }

            foreach (DataGridViewRow row1 in dataGridView1.Rows)
            {



                int checkid = Convert.ToInt32(row1.Cells["MaSach"].Value.ToString());
                var listBook = RepoBook.GetAll().Where(p => p.Id == checkid).FirstOrDefault();
                if (listBook != null)
                {

                    listBook.TenSach = listBook.TenSach;
                    listBook.SoLuong = listBook.SoLuong - 1;
                    listBook.TenTacGia = listBook.TenTacGia;
                    listBook.Nhaxuatbanid = listBook.Nhaxuatbanid;
                    listBook.Loaisachid = listBook.Loaisachid;

                    RepoBook.Update(listBook);
                    
                }


            }
            MessageBox.Show("Mượn Thành công");
            this.Hide();
            ManageForm form = new ManageForm();
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
                    var BookRepo = new RepositoryBase<Quyensach>();

                    var listBook = BookRepo.GetAll().Include(p => p.Loaisach).Include(p => p.Nhaxuatban).ToList();
                    var newListBook = listBook.Where(p => p.TenSach.Contains(Sname)).Select(p => new
                    {
                        MaSach = p.Id,
                        TenSach = p.TenSach,
                        SoLuong = p.SoLuong,
                        TenTacGia = p.TenTacGia,
                        LoaiSach = p.Loaisach.LoaiSach1,
                        NhaXuatBan = p.Nhaxuatban.TenNxb
                    }).ToList();
                    txtSearch.Text = "";
                }
            }
            btnSearch.Enabled = true;

        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }
    }
}

