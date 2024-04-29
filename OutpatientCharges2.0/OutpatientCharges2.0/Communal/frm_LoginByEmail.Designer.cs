namespace OutpatientCharges2._0.Communal
{
    partial class frm_LoginByEmail
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
            this.components = new System.ComponentModel.Container();
            this.btn_LoginByPassword = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_VerificationCode = new System.Windows.Forms.Label();
            this.txb_VerificationCode = new System.Windows.Forms.TextBox();
            this.lbl_QQEmail = new System.Windows.Forms.Label();
            this.txb_QQEmail = new System.Windows.Forms.TextBox();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.btn_SendEmail = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_LoginByPassword
            // 
            this.btn_LoginByPassword.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_LoginByPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_LoginByPassword.Location = new System.Drawing.Point(502, 534);
            this.btn_LoginByPassword.Name = "btn_LoginByPassword";
            this.btn_LoginByPassword.Size = new System.Drawing.Size(181, 66);
            this.btn_LoginByPassword.TabIndex = 33;
            this.btn_LoginByPassword.Text = "密码登录";
            this.btn_LoginByPassword.UseVisualStyleBackColor = true;
            this.btn_LoginByPassword.Click += new System.EventHandler(this.btn_LoginByPassword_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.Location = new System.Drawing.Point(771, 534);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(121, 66);
            this.btn_Login.TabIndex = 32;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_VerificationCode
            // 
            this.lbl_VerificationCode.AutoSize = true;
            this.lbl_VerificationCode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_VerificationCode.Location = new System.Drawing.Point(471, 381);
            this.lbl_VerificationCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VerificationCode.Name = "lbl_VerificationCode";
            this.lbl_VerificationCode.Size = new System.Drawing.Size(137, 39);
            this.lbl_VerificationCode.TabIndex = 31;
            this.lbl_VerificationCode.Text = "验证码：";
            // 
            // txb_VerificationCode
            // 
            this.txb_VerificationCode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_VerificationCode.Location = new System.Drawing.Point(608, 373);
            this.txb_VerificationCode.Margin = new System.Windows.Forms.Padding(4);
            this.txb_VerificationCode.Name = "txb_VerificationCode";
            this.txb_VerificationCode.PasswordChar = '*';
            this.txb_VerificationCode.Size = new System.Drawing.Size(320, 47);
            this.txb_VerificationCode.TabIndex = 29;
            // 
            // lbl_QQEmail
            // 
            this.lbl_QQEmail.AutoSize = true;
            this.lbl_QQEmail.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_QQEmail.Location = new System.Drawing.Point(437, 280);
            this.lbl_QQEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QQEmail.Name = "lbl_QQEmail";
            this.lbl_QQEmail.Size = new System.Drawing.Size(155, 39);
            this.lbl_QQEmail.TabIndex = 37;
            this.lbl_QQEmail.Text = "QQ邮箱：";
            // 
            // txb_QQEmail
            // 
            this.txb_QQEmail.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_QQEmail.Location = new System.Drawing.Point(608, 275);
            this.txb_QQEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txb_QQEmail.Name = "txb_QQEmail";
            this.txb_QQEmail.Size = new System.Drawing.Size(320, 47);
            this.txb_QQEmail.TabIndex = 36;
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Telephone.Location = new System.Drawing.Point(437, 177);
            this.lbl_Telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(167, 39);
            this.lbl_Telephone.TabIndex = 35;
            this.lbl_Telephone.Text = "电话号码：";
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_Telephone.Location = new System.Drawing.Point(608, 172);
            this.txb_Telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(320, 47);
            this.txb_Telephone.TabIndex = 34;
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btn_SendEmail.Location = new System.Drawing.Point(794, 427);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(134, 40);
            this.btn_SendEmail.TabIndex = 39;
            this.btn_SendEmail.Text = "发送验证码";
            this.btn_SendEmail.UseVisualStyleBackColor = true;
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // frm_LoginByEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.btn_SendEmail);
            this.Controls.Add(this.lbl_QQEmail);
            this.Controls.Add(this.txb_QQEmail);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.txb_Telephone);
            this.Controls.Add(this.btn_LoginByPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_VerificationCode);
            this.Controls.Add(this.txb_VerificationCode);
            this.Name = "frm_LoginByEmail";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_LoginByPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_VerificationCode;
        private System.Windows.Forms.TextBox txb_VerificationCode;
        private System.Windows.Forms.Label lbl_QQEmail;
        private System.Windows.Forms.TextBox txb_QQEmail;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.TextBox txb_Telephone;
        private System.Windows.Forms.Button btn_SendEmail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}