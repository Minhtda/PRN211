
namespace PROJECT_PRN211_7
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtRegister = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.lbEmp = new System.Windows.Forms.Label();
            this.cbEmp = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(171, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(188, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(188, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(171, 279);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 24);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Location = new System.Drawing.Point(57, 195);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(104, 15);
            this.confirm.TabIndex = 7;
            this.confirm.Text = "Confirm Password";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(171, 192);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(188, 23);
            this.txtConfirm.TabIndex = 8;
            // 
            // txtRegister
            // 
            this.txtRegister.AutoSize = true;
            this.txtRegister.Location = new System.Drawing.Point(171, 306);
            this.txtRegister.Name = "txtRegister";
            this.txtRegister.Size = new System.Drawing.Size(34, 15);
            this.txtRegister.TabIndex = 9;
            this.txtRegister.Text = "login";
            this.txtRegister.Click += new System.EventHandler(this.txtRegister_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 23);
            this.txtName.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(57, 117);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 15);
            this.label.TabIndex = 11;
            this.label.Text = "Name";
            // 
            // lbEmp
            // 
            this.lbEmp.AutoSize = true;
            this.lbEmp.Location = new System.Drawing.Point(57, 235);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(59, 15);
            this.lbEmp.TabIndex = 12;
            this.lbEmp.Text = "Employee";
            // 
            // cbEmp
            // 
            this.cbEmp.FormattingEnabled = true;
            this.cbEmp.Location = new System.Drawing.Point(171, 235);
            this.cbEmp.Name = "cbEmp";
            this.cbEmp.Size = new System.Drawing.Size(188, 23);
            this.cbEmp.TabIndex = 13;
            this.cbEmp.SelectedIndexChanged += new System.EventHandler(this.cbEmp_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(171, 325);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 23);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Return Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbEmp);
            this.Controls.Add(this.lbEmp);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRegister);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label txtRegister;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbEmp;
        private System.Windows.Forms.ComboBox cbEmp;
        private System.Windows.Forms.Button btnLogin;
    }
}