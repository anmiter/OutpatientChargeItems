namespace OutpatientCharges2._0.Communal
{
    partial class frm_Register
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
            this.lbl_QQEmail = new System.Windows.Forms.Label();
            this.txb_QQEmail = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_QQEmail
            // 
            this.lbl_QQEmail.AutoSize = true;
            this.lbl_QQEmail.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_QQEmail.Location = new System.Drawing.Point(469, 326);
            this.lbl_QQEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QQEmail.Name = "lbl_QQEmail";
            this.lbl_QQEmail.Size = new System.Drawing.Size(155, 39);
            this.lbl_QQEmail.TabIndex = 27;
            this.lbl_QQEmail.Text = "QQ邮箱：";
            // 
            // txb_QQEmail
            // 
            this.txb_QQEmail.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_QQEmail.Location = new System.Drawing.Point(640, 321);
            this.txb_QQEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txb_QQEmail.Name = "txb_QQEmail";
            this.txb_QQEmail.Size = new System.Drawing.Size(320, 47);
            this.txb_QQEmail.TabIndex = 26;
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Register.Location = new System.Drawing.Point(734, 556);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(121, 66);
            this.btn_Register.TabIndex = 25;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Password.Location = new System.Drawing.Point(525, 441);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(107, 39);
            this.lbl_Password.TabIndex = 24;
            this.lbl_Password.Text = "密码：";
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Telephone.Location = new System.Drawing.Point(469, 223);
            this.lbl_Telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(167, 39);
            this.lbl_Telephone.TabIndex = 23;
            this.lbl_Telephone.Text = "电话号码：";
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_Password.Location = new System.Drawing.Point(640, 436);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(320, 47);
            this.txb_Password.TabIndex = 22;
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_Telephone.Location = new System.Drawing.Point(640, 218);
            this.txb_Telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(320, 47);
            this.txb_Telephone.TabIndex = 21;
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.lbl_QQEmail);
            this.Controls.Add(this.txb_QQEmail);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Telephone);
            this.Name = "frm_Register";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QQEmail;
        private System.Windows.Forms.TextBox txb_QQEmail;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Telephone;
    }
}