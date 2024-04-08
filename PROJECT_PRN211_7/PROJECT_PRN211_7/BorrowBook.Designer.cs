
namespace PROJECT_PRN211_7
{
    partial class BorrowBook
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
            this.dgvReaderList = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnReturnListReader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReaderList
            // 
            this.dgvReaderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dgvReaderList.Location = new System.Drawing.Point(57, 75);
            this.dgvReaderList.Name = "dgvReaderList";
            this.dgvReaderList.RowTemplate.Height = 25;
            this.dgvReaderList.Size = new System.Drawing.Size(606, 150);
            this.dgvReaderList.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sách";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(331, 284);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnReturnListReader
            // 
            this.btnReturnListReader.Location = new System.Drawing.Point(12, 12);
            this.btnReturnListReader.Name = "btnReturnListReader";
            this.btnReturnListReader.Size = new System.Drawing.Size(136, 23);
            this.btnReturnListReader.TabIndex = 10;
            this.btnReturnListReader.Text = "Return to list reader";
            this.btnReturnListReader.UseVisualStyleBackColor = true;
            this.btnReturnListReader.Click += new System.EventHandler(this.btnReturnListReader_Click);
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnListReader);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReaderList);
            this.Name = "BorrowBook";
            this.Text = "Borrow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReaderList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Button btnReturnListReader;
    }
}