namespace OutpatientCharges2._0.Communal
{
    partial class frm_LoginByPassword
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
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_LoginByEmail = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.gpb_Role = new System.Windows.Forms.GroupBox();
            this.rdb_Patient = new System.Windows.Forms.RadioButton();
            this.rdb_Doctor = new System.Windows.Forms.RadioButton();
            this.gpb_Role.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Tip.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tip.Location = new System.Drawing.Point(571, 381);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(136, 24);
            this.lbl_Tip.TabIndex = 27;
            this.lbl_Tip.Text = "请输入电话号码";
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Register.Location = new System.Drawing.Point(739, 621);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(121, 66);
            this.btn_Register.TabIndex = 26;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_LoginByEmail
            // 
            this.btn_LoginByEmail.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LoginByEmail.Location = new System.Drawing.Point(739, 515);
            this.btn_LoginByEmail.Name = "btn_LoginByEmail";
            this.btn_LoginByEmail.Size = new System.Drawing.Size(147, 40);
            this.btn_LoginByEmail.TabIndex = 25;
            this.btn_LoginByEmail.Text = "短信登录";
            this.btn_LoginByEmail.UseVisualStyleBackColor = true;
            this.btn_LoginByEmail.Click += new System.EventHandler(this.btn_LoginByEmail_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.Location = new System.Drawing.Point(494, 621);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(121, 66);
            this.btn_Login.TabIndex = 24;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(459, 469);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(107, 39);
            this.lbl_Password.TabIndex = 23;
            this.lbl_Password.Text = "密码：";
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Account.Location = new System.Drawing.Point(459, 338);
            this.lbl_Account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(107, 39);
            this.lbl_Account.TabIndex = 22;
            this.lbl_Account.Text = "用户：";
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Password.Location = new System.Drawing.Point(566, 461);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(320, 47);
            this.txb_Password.TabIndex = 21;
            // 
            // txb_Account
            // 
            this.txb_Account.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Account.Location = new System.Drawing.Point(566, 330);
            this.txb_Account.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Account.Name = "txb_Account";
            this.txb_Account.Size = new System.Drawing.Size(320, 47);
            this.txb_Account.TabIndex = 20;
            // 
            // gpb_Role
            // 
            this.gpb_Role.Controls.Add(this.rdb_Patient);
            this.gpb_Role.Controls.Add(this.rdb_Doctor);
            this.gpb_Role.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.gpb_Role.Location = new System.Drawing.Point(466, 188);
            this.gpb_Role.Name = "gpb_Role";
            this.gpb_Role.Size = new System.Drawing.Size(420, 94);
            this.gpb_Role.TabIndex = 123;
            this.gpb_Role.TabStop = false;
            this.gpb_Role.Text = "身份";
            // 
            // rdb_Patient
            // 
            this.rdb_Patient.AutoSize = true;
            this.rdb_Patient.Location = new System.Drawing.Point(273, 34);
            this.rdb_Patient.Name = "rdb_Patient";
            this.rdb_Patient.Size = new System.Drawing.Size(102, 43);
            this.rdb_Patient.TabIndex = 1;
            this.rdb_Patient.TabStop = true;
            this.rdb_Patient.Text = "患者";
            this.rdb_Patient.UseVisualStyleBackColor = true;
            // 
            // rdb_Doctor
            // 
            this.rdb_Doctor.AutoSize = true;
            this.rdb_Doctor.Location = new System.Drawing.Point(109, 34);
            this.rdb_Doctor.Name = "rdb_Doctor";
            this.rdb_Doctor.Size = new System.Drawing.Size(102, 43);
            this.rdb_Doctor.TabIndex = 0;
            this.rdb_Doctor.TabStop = true;
            this.rdb_Doctor.Text = "医生";
            this.rdb_Doctor.UseVisualStyleBackColor = true;
            // 
            // frm_LoginByPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.gpb_Role);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_LoginByEmail);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Account);
            this.Name = "frm_LoginByPassword";
            this.Text = "frm_LoginByPassword";
            this.gpb_Role.ResumeLayout(false);
            this.gpb_Role.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_LoginByEmail;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Account;
        private System.Windows.Forms.GroupBox gpb_Role;
        private System.Windows.Forms.RadioButton rdb_Patient;
        private System.Windows.Forms.RadioButton rdb_Doctor;
    }
}