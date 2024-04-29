namespace OutpatientCharges2._0.Doctor
{
    partial class frm_Home
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
            this.btn_ModifyPrice = new System.Windows.Forms.Button();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Telephone1 = new System.Windows.Forms.Label();
            this.lbl_Name1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ModifyPrice
            // 
            this.btn_ModifyPrice.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_ModifyPrice.Location = new System.Drawing.Point(700, 141);
            this.btn_ModifyPrice.Name = "btn_ModifyPrice";
            this.btn_ModifyPrice.Size = new System.Drawing.Size(186, 92);
            this.btn_ModifyPrice.TabIndex = 133;
            this.btn_ModifyPrice.Text = "修改价目";
            this.btn_ModifyPrice.UseVisualStyleBackColor = true;
            this.btn_ModifyPrice.Click += new System.EventHandler(this.btn_ModifyPrice_Click);
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Telephone.Location = new System.Drawing.Point(43, 578);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(0, 39);
            this.lbl_Telephone.TabIndex = 137;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Name.Location = new System.Drawing.Point(43, 460);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(0, 39);
            this.lbl_Name.TabIndex = 136;
            // 
            // lbl_Telephone1
            // 
            this.lbl_Telephone1.AutoSize = true;
            this.lbl_Telephone1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Telephone1.Location = new System.Drawing.Point(43, 518);
            this.lbl_Telephone1.Name = "lbl_Telephone1";
            this.lbl_Telephone1.Size = new System.Drawing.Size(137, 39);
            this.lbl_Telephone1.TabIndex = 135;
            this.lbl_Telephone1.Text = "电话号码";
            // 
            // lbl_Name1
            // 
            this.lbl_Name1.AutoSize = true;
            this.lbl_Name1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Name1.Location = new System.Drawing.Point(43, 405);
            this.lbl_Name1.Name = "lbl_Name1";
            this.lbl_Name1.Size = new System.Drawing.Size(77, 39);
            this.lbl_Name1.TabIndex = 134;
            this.lbl_Name1.Text = "姓名";
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Telephone1);
            this.Controls.Add(this.lbl_Name1);
            this.Controls.Add(this.btn_ModifyPrice);
            this.Name = "frm_Home";
            this.Text = "首页";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ModifyPrice;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Telephone1;
        private System.Windows.Forms.Label lbl_Name1;
    }
}