using Repository.Models;
using Repository;
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
    public partial class ListReaders : Form
    {
        public static string idReader = "";
        public ListReaders()
        {
            InitializeComponent();

            var Repo = new RepositoryBase<Docgium>();
            var listUser = Repo.GetAll().Select(p => new
            {
                Madocgia = p.Id,
                TenDocgia = p.TenDocGia,
                DiaChi = p.DiaChi

            }).ToList();
            dgvListReader.DataSource = listUser;


        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (idReader != "")
            {

                this.Hide();
                BorrowBook listBookForm = new BorrowBook();
                listBookForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bất kỳ đôi tượng nào cả");
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return returnForm = new Return();
            returnForm.ShowDialog();
        }

        private void dgvListReader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListReader_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (idReader != null)
            {
                DataGridViewRow row = dgvListReader.Rows[numrow];
                if (row != null)
                {
                    idReader = (string)row.Cells[0].Value;
                }

            }
        }

        private void btrnReturntoM_Click(object sender, EventArgs e)
        {
            ManageForm form = new ManageForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }

}


