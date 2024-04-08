using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ListReaders
{
    public partial class BorrowForm : Form
    {
        string idReader = ManagementForm.idReader;

        List<string> listIDBook = new List<string>();

        public BorrowForm()
        {
            InitializeComponent();

            
             
            var Repo = new RepositoryBase<Docgium>();
            var Reader = Repo.GetAll().Where(c => c.Id == idReader).FirstOrDefault();
            if (Reader != null)
            {
                textBox1.Text = Reader.Id.ToString();
                textBox2.Text = Reader.TenDocGia.ToString();
                textBox3.Text = Reader.DiaChi.ToString();

                var RepoMuonTra = new RepositoryBase<Docgium>();
            }
            else
            {

            }
            var listBookSelected  = ListBook.listBookSelected;
            
            

            dataGridView1.DataSource = listBookSelected; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
