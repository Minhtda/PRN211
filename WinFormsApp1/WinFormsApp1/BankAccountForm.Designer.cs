namespace WinFormsApp1
{
    partial class BankAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBankAccount = new System.Windows.Forms.DataGridView();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.btnCreate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.AccountId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dtpOpenDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBankAccount
            // 
            this.dgvBankAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccount.Location = new System.Drawing.Point(12, 232);
            this.dgvBankAccount.Name = "dgvBankAccount";
            this.dgvBankAccount.RowTemplate.Height = 25;
            this.dgvBankAccount.Size = new System.Drawing.Size(437, 206);
            this.dgvBankAccount.TabIndex = 0;
            this.dgvBankAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBankAccount_CellDoubleClick);
            // 
            // txtAccountId
            // 
            this.txtAccountId.Location = new System.Drawing.Point(107, 34);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(187, 23);
            this.txtAccountId.TabIndex = 1;
            this.txtAccountId.TextChanged += new System.EventHandler(this.txtTypeID_TextChanged);
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(107, 63);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(187, 23);
            this.txtAccountName.TabIndex = 2;
            this.txtAccountName.TextChanged += new System.EventHandler(this.txtTypeName_TextChanged);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(107, 92);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(187, 23);
            this.txtBrandName.TabIndex = 3;
            this.txtBrandName.TextChanged += new System.EventHandler(this.txtTypeDesc_TextChanged);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(57, 190);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(138, 190);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(349, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            this.txtSearch.TabIndex = 7;
            // 
            // AccountId
            // 
            this.AccountId.AutoSize = true;
            this.AccountId.Location = new System.Drawing.Point(12, 37);
            this.AccountId.Name = "AccountId";
            this.AccountId.Size = new System.Drawing.Size(62, 15);
            this.AccountId.TabIndex = 8;
            this.AccountId.Text = "AccountId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "AccountName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "BranchName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "OpenDate";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(107, 121);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(187, 23);
            this.cbType.TabIndex = 14;
            // 
            // dtpOpenDate
            // 
            this.dtpOpenDate.Location = new System.Drawing.Point(107, 150);
            this.dtpOpenDate.Name = "dtpOpenDate";
            this.dtpOpenDate.Size = new System.Drawing.Size(187, 23);
            this.dtpOpenDate.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpOpenDate);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccountId);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtAccountId);
            this.Controls.Add(this.dgvBankAccount);
            this.Name = "BankAccountForm";
            this.Text = "BankAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBankAccount;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtBrandName;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label AccountId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DateTimePicker dtpOpenDate;
        private System.Windows.Forms.Button btnSearch;
    }
}