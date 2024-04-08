using Repository;
using Repository.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ListReaders
{
    public partial class ManagementForm : Form
    {
        public static string idReader = "";
        public ManagementForm()
        {
            InitializeComponent();
            var Repo = new RepositoryBase<Docgium>();
            var listUser = Repo.GetAll()
                .Select(p => new
                {
                    Madocgia = p.Id,
                    tendocgia = p.TenDocGia,
                    diachi = p.DiaChi

                }).ToList();
            dataGridView1.DataSource = listUser;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (idReader != null)
            {
                DataGridViewRow row = dataGridView1.Rows[numrow];
                if (row != null)
                {
                    idReader = (string)row.Cells[0].Value;
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idReader != "")
            {

                this.Hide();
                ListBook listBookForm = new ListBook();
                listBookForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bất kỳ đôi tượng nào cả");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idReader != "")
            {

                this.Hide();
                ReturnForm returnForm = new ReturnForm();
                returnForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bất kỳ đôi tượng nào cả");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
