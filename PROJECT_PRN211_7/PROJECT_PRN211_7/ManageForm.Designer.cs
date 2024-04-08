
namespace PROJECT_PRN211_7
{
    partial class ManageForm
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
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBorrowReturn = new System.Windows.Forms.Button();
            this.btnRegisterReader = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnRegEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(111, 79);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(153, 61);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnBorrowReturn
            // 
            this.btnBorrowReturn.Location = new System.Drawing.Point(426, 79);
            this.btnBorrowReturn.Name = "btnBorrowReturn";
            this.btnBorrowReturn.Size = new System.Drawing.Size(153, 61);
            this.btnBorrowReturn.TabIndex = 2;
            this.btnBorrowReturn.Text = "Borrow and Return";
            this.btnBorrowReturn.UseVisualStyleBackColor = true;
            this.btnBorrowReturn.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnRegisterReader
            // 
            this.btnRegisterReader.Location = new System.Drawing.Point(111, 271);
            this.btnRegisterReader.Name = "btnRegisterReader";
            this.btnRegisterReader.Size = new System.Drawing.Size(153, 61);
            this.btnRegisterReader.TabIndex = 4;
            this.btnRegisterReader.Text = "Register Reader";
            this.btnRegisterReader.UseVisualStyleBackColor = true;
            this.btnRegisterReader.Click += new System.EventHandler(this.btnRegisterReader_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(103, 25);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(111, 178);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(153, 61);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRegEmp
            // 
            this.btnRegEmp.Location = new System.Drawing.Point(426, 178);
            this.btnRegEmp.Name = "btnRegEmp";
            this.btnRegEmp.Size = new System.Drawing.Size(153, 61);
            this.btnRegEmp.TabIndex = 7;
            this.btnRegEmp.Text = "Register Employee";
            this.btnRegEmp.UseVisualStyleBackColor = true;
            this.btnRegEmp.Click += new System.EventHandler(this.btnRegEmp_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegEmp);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnRegisterReader);
            this.Controls.Add(this.btnBorrowReturn);
            this.Controls.Add(this.btnBook);
            this.Name = "ManageForm";
            this.Text = "ManageForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnBorrowReturn;
        private System.Windows.Forms.Button btnRegisterReader;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnRegEmp;
    }
}