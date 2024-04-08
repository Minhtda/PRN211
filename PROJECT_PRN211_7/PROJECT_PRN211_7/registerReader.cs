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
    public partial class registerReader : Form
    {
        public registerReader()
        {
            InitializeComponent();
            var repo = new RepositoryBase<Docgium>();
            var readerList = repo.GetAll().Select(p => new {p.Id, p.DiaChi, p.TenDocGia }).ToList();
            dataGridView1.DataSource = readerList;

            btnDelete.Enabled = false;
            
        }

        private void registerReader_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //var AccountId = txtAccountId.Text;
            //var CheckId = BankAccountRepo.GetAll().Where(p => p.AccountId.Equals(AccountId)).FirstOrDefault();
                btnCreate.Enabled = false;
            var repo = new RepositoryBase<Docgium>();
            var ID = txtID.Text;
            var reader = repo.GetAll().Where(p => p.Id.Equals(ID)).FirstOrDefault();
            if (reader != null)
            {
                MessageBox.Show("Id đã tồn tại");
                btnCreate.Enabled = true;
                return;
            }
            Docgium read = new Docgium();
            read.Id = txtID.Text;
            read.TenDocGia = txtName.Text;
            read.DiaChi = txtAddress.Text;
            repo.Create(read);
            var readerList = repo.GetAll().Select(p => new { p.Id, p.DiaChi, p.TenDocGia }).ToList();
            dataGridView1.DataSource = readerList;

            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            btnCreate.Enabled = true;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            txtID.Text = row.ToString();

            var repo = new RepositoryBase<Docgium>();
            var Reader = repo.GetAll().Where(p => p.Id.Equals(txtID)).FirstOrDefault();
            if (Reader != null)
            {
                txtID.Text = Reader.Id;
            }
            txtAddress.Enabled = false;
            txtName.Enabled = false;
            txtID.Enabled = false;
            btnDelete.Enabled = true;
            btnCreate.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            var repo = new RepositoryBase<Docgium>();
            var reader = repo.GetAll().Where(p => p.TenDocGia.Contains(txtName1.Text)).ToList();
            dataGridView1.DataSource = reader;
            txtName1.Text ="";
            btnSearch.Enabled = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            var ID = txtID.Text;
            var repo = new RepositoryBase<Docgium>();
            var obj = repo.GetAll().Where(p => p.Id.Equals(ID)).FirstOrDefault();
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Delete ", "Delete Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    repo.Delete(obj);
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                    return;
                }
            }

            var readerList = repo.GetAll().Select(p => new { p.Id, p.DiaChi, p.TenDocGia }).ToList();
            dataGridView1.DataSource = readerList;

            btnDelete.Enabled = false;
            btnCreate.Enabled = true;
            btnSearch.Enabled = true;

            txtID.Enabled = true;
            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ManageForm form = new ManageForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
