namespace PROJECT_PRN211_7
{
    partial class ListReaders
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
            this.dgvListReader = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btrnReturntoM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListReader)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListReader
            // 
            this.dgvListReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListReader.Location = new System.Drawing.Point(126, 108);
            this.dgvListReader.Name = "dgvListReader";
            this.dgvListReader.RowTemplate.Height = 25;
            this.dgvListReader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListReader.Size = new System.Drawing.Size(528, 217);
            this.dgvListReader.TabIndex = 0;
            this.dgvListReader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListReader_CellClick_1);
            this.dgvListReader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListReader_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách độc giả";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(219, 380);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(449, 380);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btrnReturntoM
            // 
            this.btrnReturntoM.Location = new System.Drawing.Point(21, 12);
            this.btrnReturntoM.Name = "btrnReturntoM";
            this.btrnReturntoM.Size = new System.Drawing.Size(153, 23);
            this.btrnReturntoM.TabIndex = 5;
            this.btrnReturntoM.Text = "Return to manage form";
            this.btrnReturntoM.UseVisualStyleBackColor = true;
            this.btrnReturntoM.Click += new System.EventHandler(this.btrnReturntoM_Click);
            // 
            // ListReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btrnReturntoM);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListReader);
            this.Name = "ListReaders";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListReader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btrnReturntoM;
    }
}