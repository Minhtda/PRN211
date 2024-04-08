using Repository_3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository_3;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class BankAccountForm : Form
    {
        public static User _User = new User();
        public BankAccountForm(User user)
        {
            _User = user;

            //if (user.UserRole == 1)
            //{
            InitializeComponent();
            var BankAccountRepo = new RepositoryBase<BankAccount>();

            var listBankAccount = BankAccountRepo.GetAll().ToList();
            dgvBankAccount.DataSource = listBankAccount;

            var AccountTypeRepo = new RepositoryBase<AccountType>();
            var listAccountType = AccountTypeRepo.GetAll().ToList().Select(p => new { Value = p.TypeId, Text = p.TypeName }).ToList();
            cbType.ValueMember = "Value";
            cbType.DisplayMember = "Text";
            cbType.DataSource = (listAccountType.ToArray());

            BtnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            dtpOpenDate.MinDate = new DateTime(2000, 1, 1);
            dtpOpenDate.MaxDate = new DateTime(2022, 12, 31);
            //}
        }

        private void dgvBankAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //get list accountType to combobox
            var AccountTypeRepo = new RepositoryBase<AccountType>();

            var rowSelected = this.dgvBankAccount.Rows[e.RowIndex];

            var item = AccountTypeRepo.GetAll()
                .Where(p => p.TypeId.Equals(rowSelected.Cells["TypeId"].Value.ToString()))
                .ToList();

            var item2 = AccountTypeRepo.GetAll().Include(p=>p.BankAccounts)
                .Where(p => p.TypeId.Equals(rowSelected.Cells["TypeId"].Value.ToString()))
                .ToList();

            var BankAccountRepo = new RepositoryBase<BankAccount>();
            var item3 = BankAccountRepo.GetAll().Include(p => p.Type);

            var listAccountType = AccountTypeRepo.GetAll().ToList().Select(p => new { Value = p.TypeId, Text = p.TypeName }).ToList();
            cbType.ValueMember = "Value";
            cbType.DisplayMember = "Text";
            cbType.DataSource = (listAccountType.ToArray());

            //e.RowIndex; // dong duoc select
            if (e.RowIndex >= 0)
            {
                txtAccountId.Enabled = false;
                txtAccountId.Text = rowSelected.Cells["AccountId"].Value.ToString();
                txtAccountName.Text = rowSelected.Cells["AccountName"].Value.ToString();
                txtBrandName.Text = rowSelected.Cells["BranchName"].Value.ToString();

                dtpOpenDate.Value = Convert.ToDateTime(rowSelected.Cells["OpenDate"].Value.ToString());

                cbType.SelectedValue = rowSelected.Cells["TypeId"].Value.ToString();
            }
            btnCreate.Enabled = false;
            btnDelete.Enabled = true;
            BtnUpdate.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!CheckNull())
            {
                return;
            }
            btnCreate.Enabled = false;
            var BankAccountRepo = new RepositoryBase<BankAccount>();

            var AccountId = txtAccountId.Text;
            var BranchName = txtBrandName.Text;
            var AccountName = txtAccountName.Text;
            var OpenDate = dtpOpenDate.Value;
            var TypeId = cbType.SelectedValue.ToString();

            var CheckId = BankAccountRepo.GetAll().Where(p => p.AccountId.Equals(AccountId)).FirstOrDefault();
            if (AccountId == "")
            {
                MessageBox.Show("Please Input AccountId", "Error", MessageBoxButtons.OK);
                btnCreate.Enabled = true;
                return;
            }
            if (CheckId != null)
            {
                MessageBox.Show("Duplicate Id, Please try another Id", "Error", MessageBoxButtons.OK);
                btnCreate.Enabled = true;
                return;
            }
            var _bankAccount = new BankAccount();
            _bankAccount.AccountId = AccountId;
            _bankAccount.BranchName = BranchName;
            _bankAccount.AccountName = AccountName;
            _bankAccount.OpenDate = OpenDate.Date;
            _bankAccount.TypeId = TypeId;

            BankAccountRepo.Create(_bankAccount);

            var listBankAccount = BankAccountRepo.GetAll().ToList();
            dgvBankAccount.DataSource = listBankAccount;
            btnCreate.Enabled = true;
            ResetForm();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckNull())
            {
                return;
            }
            BtnUpdate.Enabled = false;
            var AccountId = txtAccountId.Text;
            var BranchName = txtBrandName.Text;
            var AccountName = txtAccountName.Text;
            var OpenDate = dtpOpenDate.Value;
            var TypeId = cbType.SelectedValue.ToString();

            var BankAccountRepo = new RepositoryBase<BankAccount>();
            var _bankAccount = BankAccountRepo.GetAll().Where(p => p.AccountId.Equals(AccountId)).FirstOrDefault();

            if (_bankAccount != null)
            {
                _bankAccount.BranchName = BranchName;
                _bankAccount.AccountName = AccountName;
                _bankAccount.OpenDate = OpenDate.Date;
                _bankAccount.TypeId = TypeId;
                BankAccountRepo.Update(_bankAccount);
            }

            var listBankAccount = BankAccountRepo.GetAll().ToList();
            dgvBankAccount.DataSource = listBankAccount;

            txtAccountId.Enabled = true;
            BtnUpdate.Enabled = true;
            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            var AccountId = txtAccountId.Text;
            var BankAccountRepo = new RepositoryBase<BankAccount>();
            var obj = BankAccountRepo.GetAll().Where(p => p.AccountId.Equals(AccountId)).FirstOrDefault();
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Delete ", "Delete Item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    BankAccountRepo.Delete(obj);
                }
                else if (dialogResult == DialogResult.No)
                {
                    ResetForm();
                    return;
                }
            }

            var listBankAccount = BankAccountRepo.GetAll().ToList();
            dgvBankAccount.DataSource = listBankAccount;

            btnDelete.Enabled = true;
            txtAccountId.Enabled = true;
            ResetForm();
        }

        private void txtTypeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTypeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTypeDesc_TextChanged(object sender, EventArgs e)
        {

        }
        private void ResetForm()
        {
            txtAccountId.Text = "";
            txtAccountName.Text = "";
            txtBrandName.Text = "";
            dtpOpenDate.Value = DateTime.Now.Date;
            cbType.SelectedIndex = 0;

            btnCreate.Enabled = true;
            BtnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private bool CheckNull()
        {
            if (txtAccountId.Text == "" || txtAccountName.Text == "" || txtBrandName.Text == "")
            {
                MessageBox.Show("All Input is not Null, please try again", "Notification", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var BankAccountRepo = new RepositoryBase<BankAccount>();
            var list = BankAccountRepo.GetAll().Where(p => p.BranchName.Contains(txtSearch.Text)).OrderBy(p => p.BranchName).ToList();
            if (list != null)
            {
                dgvBankAccount.DataSource = list;
            }
            else
            {
                MessageBox.Show("Cannot Find Any Account. Please Try again !", "Notification", MessageBoxButtons.OK);
            }
        }
    }
}
