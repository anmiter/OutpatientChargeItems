namespace OutpatientCharges2._0.Patient
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
            this.btn_PersonalCenter = new System.Windows.Forms.Button();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.lbl_PaitentID = new System.Windows.Forms.Label();
            this.lbl_Telephone1 = new System.Windows.Forms.Label();
            this.lbl_PaitentID1 = new System.Windows.Forms.Label();
            this.ptb_Avatar = new System.Windows.Forms.PictureBox();
            this.btn_ShowMedicalRecord = new System.Windows.Forms.Button();
            this.btn_PriceSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PersonalCenter
            // 
            this.btn_PersonalCenter.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_PersonalCenter.Location = new System.Drawing.Point(740, 134);
            this.btn_PersonalCenter.Name = "btn_PersonalCenter";
            this.btn_PersonalCenter.Size = new System.Drawing.Size(186, 92);
            this.btn_PersonalCenter.TabIndex = 1;
            this.btn_PersonalCenter.Text = "个人中心";
            this.btn_PersonalCenter.UseVisualStyleBackColor = true;
            this.btn_PersonalCenter.Click += new System.EventHandler(this.btn_PersonalCenter_Click);
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Telephone.Location = new System.Drawing.Point(79, 515);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(0, 39);
            this.lbl_Telephone.TabIndex = 9;
            // 
            // lbl_PaitentID
            // 
            this.lbl_PaitentID.AutoSize = true;
            this.lbl_PaitentID.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_PaitentID.Location = new System.Drawing.Point(79, 397);
            this.lbl_PaitentID.Name = "lbl_PaitentID";
            this.lbl_PaitentID.Size = new System.Drawing.Size(0, 39);
            this.lbl_PaitentID.TabIndex = 8;
            // 
            // lbl_Telephone1
            // 
            this.lbl_Telephone1.AutoSize = true;
            this.lbl_Telephone1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Telephone1.Location = new System.Drawing.Point(79, 455);
            this.lbl_Telephone1.Name = "lbl_Telephone1";
            this.lbl_Telephone1.Size = new System.Drawing.Size(137, 39);
            this.lbl_Telephone1.TabIndex = 7;
            this.lbl_Telephone1.Text = "电话号码";
            // 
            // lbl_PaitentID1
            // 
            this.lbl_PaitentID1.AutoSize = true;
            this.lbl_PaitentID1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_PaitentID1.Location = new System.Drawing.Point(79, 342);
            this.lbl_PaitentID1.Name = "lbl_PaitentID1";
            this.lbl_PaitentID1.Size = new System.Drawing.Size(137, 39);
            this.lbl_PaitentID1.TabIndex = 6;
            this.lbl_PaitentID1.Text = "身份证号";
            // 
            // ptb_Avatar
            // 
            this.ptb_Avatar.Location = new System.Drawing.Point(70, 45);
            this.ptb_Avatar.Name = "ptb_Avatar";
            this.ptb_Avatar.Size = new System.Drawing.Size(262, 268);
            this.ptb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Avatar.TabIndex = 130;
            this.ptb_Avatar.TabStop = false;
            // 
            // btn_ShowMedicalRecord
            // 
            this.btn_ShowMedicalRecord.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_ShowMedicalRecord.Location = new System.Drawing.Point(1094, 134);
            this.btn_ShowMedicalRecord.Name = "btn_ShowMedicalRecord";
            this.btn_ShowMedicalRecord.Size = new System.Drawing.Size(186, 92);
            this.btn_ShowMedicalRecord.TabIndex = 131;
            this.btn_ShowMedicalRecord.Text = "查看病例";
            this.btn_ShowMedicalRecord.UseVisualStyleBackColor = true;
            this.btn_ShowMedicalRecord.Click += new System.EventHandler(this.btn_ShowMedicalRecord_Click);
            // 
            // btn_PriceSearch
            // 
            this.btn_PriceSearch.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_PriceSearch.Location = new System.Drawing.Point(1094, 314);
            this.btn_PriceSearch.Name = "btn_PriceSearch";
            this.btn_PriceSearch.Size = new System.Drawing.Size(186, 92);
            this.btn_PriceSearch.TabIndex = 132;
            this.btn_PriceSearch.Text = "价目查询";
            this.btn_PriceSearch.UseVisualStyleBackColor = true;
            this.btn_PriceSearch.Click += new System.EventHandler(this.btn_PriceSearch_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.btn_PriceSearch);
            this.Controls.Add(this.btn_ShowMedicalRecord);
            this.Controls.Add(this.ptb_Avatar);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.lbl_PaitentID);
            this.Controls.Add(this.lbl_Telephone1);
            this.Controls.Add(this.lbl_PaitentID1);
            this.Controls.Add(this.btn_PersonalCenter);
            this.Name = "frm_Home";
            this.Text = "首页";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PersonalCenter;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.Label lbl_PaitentID;
        private System.Windows.Forms.Label lbl_Telephone1;
        private System.Windows.Forms.Label lbl_PaitentID1;
        private System.Windows.Forms.PictureBox ptb_Avatar;
        private System.Windows.Forms.Button btn_ShowMedicalRecord;
        private System.Windows.Forms.Button btn_PriceSearch;
    }
}