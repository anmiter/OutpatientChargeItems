namespace OutpatientCharges2._0.Patient
{
    partial class frm_PriceSearch
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
            this.tc_PriceSearch = new System.Windows.Forms.TabControl();
            this.tp_DrugPrice = new System.Windows.Forms.TabPage();
            this.btn_SearchDrugByKeyword = new System.Windows.Forms.Button();
            this.txb_DrugKeyWord = new System.Windows.Forms.TextBox();
            this.btn_NewLoadDrug = new System.Windows.Forms.Button();
            this.btn_SearchDrugByName = new System.Windows.Forms.Button();
            this.txb_DrugName = new System.Windows.Forms.TextBox();
            this.btn_SearchDrugByNo = new System.Windows.Forms.Button();
            this.txb_DrugNo = new System.Windows.Forms.TextBox();
            this.dgv_Drug = new System.Windows.Forms.DataGridView();
            this.tp_ExaminePrice = new System.Windows.Forms.TabPage();
            this.btn_SearchExamineByKeyWord = new System.Windows.Forms.Button();
            this.txb_ExamineKeyWord = new System.Windows.Forms.TextBox();
            this.btn_newLoadExamine = new System.Windows.Forms.Button();
            this.btn_SearchExmaineByName = new System.Windows.Forms.Button();
            this.txb_ExamineName = new System.Windows.Forms.TextBox();
            this.btn_SearchExamineByNo = new System.Windows.Forms.Button();
            this.txb_ExamineNo = new System.Windows.Forms.TextBox();
            this.dgv_Exmaine = new System.Windows.Forms.DataGridView();
            this.tc_PriceSearch.SuspendLayout();
            this.tp_DrugPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).BeginInit();
            this.tp_ExaminePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exmaine)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_PriceSearch
            // 
            this.tc_PriceSearch.Controls.Add(this.tp_DrugPrice);
            this.tc_PriceSearch.Controls.Add(this.tp_ExaminePrice);
            this.tc_PriceSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tc_PriceSearch.Location = new System.Drawing.Point(0, 0);
            this.tc_PriceSearch.Name = "tc_PriceSearch";
            this.tc_PriceSearch.SelectedIndex = 0;
            this.tc_PriceSearch.Size = new System.Drawing.Size(1427, 843);
            this.tc_PriceSearch.TabIndex = 0;
            // 
            // tp_DrugPrice
            // 
            this.tp_DrugPrice.Controls.Add(this.btn_SearchDrugByKeyword);
            this.tp_DrugPrice.Controls.Add(this.txb_DrugKeyWord);
            this.tp_DrugPrice.Controls.Add(this.btn_NewLoadDrug);
            this.tp_DrugPrice.Controls.Add(this.btn_SearchDrugByName);
            this.tp_DrugPrice.Controls.Add(this.txb_DrugName);
            this.tp_DrugPrice.Controls.Add(this.btn_SearchDrugByNo);
            this.tp_DrugPrice.Controls.Add(this.txb_DrugNo);
            this.tp_DrugPrice.Controls.Add(this.dgv_Drug);
            this.tp_DrugPrice.Location = new System.Drawing.Point(4, 37);
            this.tp_DrugPrice.Name = "tp_DrugPrice";
            this.tp_DrugPrice.Padding = new System.Windows.Forms.Padding(3);
            this.tp_DrugPrice.Size = new System.Drawing.Size(1419, 802);
            this.tp_DrugPrice.TabIndex = 0;
            this.tp_DrugPrice.Text = "药品";
            this.tp_DrugPrice.UseVisualStyleBackColor = true;
            this.tp_DrugPrice.Click += new System.EventHandler(this.tp_DrugPrice_Click);
            // 
            // btn_SearchDrugByKeyword
            // 
            this.btn_SearchDrugByKeyword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchDrugByKeyword.Location = new System.Drawing.Point(1063, 618);
            this.btn_SearchDrugByKeyword.Name = "btn_SearchDrugByKeyword";
            this.btn_SearchDrugByKeyword.Size = new System.Drawing.Size(211, 43);
            this.btn_SearchDrugByKeyword.TabIndex = 40;
            this.btn_SearchDrugByKeyword.Text = "根据关键字搜索";
            this.btn_SearchDrugByKeyword.UseVisualStyleBackColor = true;
            this.btn_SearchDrugByKeyword.Click += new System.EventHandler(this.btn_SearchDrugByKeyword_Click);
            // 
            // txb_DrugKeyWord
            // 
            this.txb_DrugKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DrugKeyWord.Location = new System.Drawing.Point(716, 618);
            this.txb_DrugKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DrugKeyWord.Name = "txb_DrugKeyWord";
            this.txb_DrugKeyWord.Size = new System.Drawing.Size(340, 39);
            this.txb_DrugKeyWord.TabIndex = 39;
            // 
            // btn_NewLoadDrug
            // 
            this.btn_NewLoadDrug.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_NewLoadDrug.Location = new System.Drawing.Point(859, 696);
            this.btn_NewLoadDrug.Name = "btn_NewLoadDrug";
            this.btn_NewLoadDrug.Size = new System.Drawing.Size(137, 58);
            this.btn_NewLoadDrug.TabIndex = 38;
            this.btn_NewLoadDrug.Text = "重新载入";
            this.btn_NewLoadDrug.UseVisualStyleBackColor = true;
            this.btn_NewLoadDrug.Click += new System.EventHandler(this.btn_NewLoadDrug_Click);
            // 
            // btn_SearchDrugByName
            // 
            this.btn_SearchDrugByName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchDrugByName.Location = new System.Drawing.Point(454, 704);
            this.btn_SearchDrugByName.Name = "btn_SearchDrugByName";
            this.btn_SearchDrugByName.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchDrugByName.TabIndex = 37;
            this.btn_SearchDrugByName.Text = "根据名称搜索";
            this.btn_SearchDrugByName.UseVisualStyleBackColor = true;
            this.btn_SearchDrugByName.Click += new System.EventHandler(this.btn_SearchDrugByName_Click);
            // 
            // txb_DrugName
            // 
            this.txb_DrugName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DrugName.Location = new System.Drawing.Point(138, 709);
            this.txb_DrugName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DrugName.Name = "txb_DrugName";
            this.txb_DrugName.Size = new System.Drawing.Size(309, 39);
            this.txb_DrugName.TabIndex = 36;
            // 
            // btn_SearchDrugByNo
            // 
            this.btn_SearchDrugByNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchDrugByNo.Location = new System.Drawing.Point(454, 620);
            this.btn_SearchDrugByNo.Name = "btn_SearchDrugByNo";
            this.btn_SearchDrugByNo.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchDrugByNo.TabIndex = 35;
            this.btn_SearchDrugByNo.Text = "根据编号搜索";
            this.btn_SearchDrugByNo.UseVisualStyleBackColor = true;
            this.btn_SearchDrugByNo.Click += new System.EventHandler(this.btn_SearchDrugByNo_Click);
            // 
            // txb_DrugNo
            // 
            this.txb_DrugNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DrugNo.Location = new System.Drawing.Point(138, 620);
            this.txb_DrugNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DrugNo.Name = "txb_DrugNo";
            this.txb_DrugNo.Size = new System.Drawing.Size(309, 39);
            this.txb_DrugNo.TabIndex = 32;
            // 
            // dgv_Drug
            // 
            this.dgv_Drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Drug.Location = new System.Drawing.Point(8, 8);
            this.dgv_Drug.Name = "dgv_Drug";
            this.dgv_Drug.RowHeadersWidth = 62;
            this.dgv_Drug.RowTemplate.Height = 30;
            this.dgv_Drug.Size = new System.Drawing.Size(1408, 570);
            this.dgv_Drug.TabIndex = 0;
            // 
            // tp_ExaminePrice
            // 
            this.tp_ExaminePrice.Controls.Add(this.btn_SearchExamineByKeyWord);
            this.tp_ExaminePrice.Controls.Add(this.txb_ExamineKeyWord);
            this.tp_ExaminePrice.Controls.Add(this.btn_newLoadExamine);
            this.tp_ExaminePrice.Controls.Add(this.btn_SearchExmaineByName);
            this.tp_ExaminePrice.Controls.Add(this.txb_ExamineName);
            this.tp_ExaminePrice.Controls.Add(this.btn_SearchExamineByNo);
            this.tp_ExaminePrice.Controls.Add(this.txb_ExamineNo);
            this.tp_ExaminePrice.Controls.Add(this.dgv_Exmaine);
            this.tp_ExaminePrice.Location = new System.Drawing.Point(4, 37);
            this.tp_ExaminePrice.Name = "tp_ExaminePrice";
            this.tp_ExaminePrice.Padding = new System.Windows.Forms.Padding(3);
            this.tp_ExaminePrice.Size = new System.Drawing.Size(1419, 802);
            this.tp_ExaminePrice.TabIndex = 1;
            this.tp_ExaminePrice.Text = "检查项目";
            this.tp_ExaminePrice.UseVisualStyleBackColor = true;
            // 
            // btn_SearchExamineByKeyWord
            // 
            this.btn_SearchExamineByKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchExamineByKeyWord.Location = new System.Drawing.Point(1063, 615);
            this.btn_SearchExamineByKeyWord.Name = "btn_SearchExamineByKeyWord";
            this.btn_SearchExamineByKeyWord.Size = new System.Drawing.Size(198, 43);
            this.btn_SearchExamineByKeyWord.TabIndex = 42;
            this.btn_SearchExamineByKeyWord.Text = "根据关键字搜索";
            this.btn_SearchExamineByKeyWord.UseVisualStyleBackColor = true;
            this.btn_SearchExamineByKeyWord.Click += new System.EventHandler(this.btn_SearchExamineByKeyWord_Click);
            // 
            // txb_ExamineKeyWord
            // 
            this.txb_ExamineKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_ExamineKeyWord.Location = new System.Drawing.Point(716, 618);
            this.txb_ExamineKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ExamineKeyWord.Name = "txb_ExamineKeyWord";
            this.txb_ExamineKeyWord.Size = new System.Drawing.Size(340, 39);
            this.txb_ExamineKeyWord.TabIndex = 41;
            // 
            // btn_newLoadExamine
            // 
            this.btn_newLoadExamine.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_newLoadExamine.Location = new System.Drawing.Point(838, 691);
            this.btn_newLoadExamine.Name = "btn_newLoadExamine";
            this.btn_newLoadExamine.Size = new System.Drawing.Size(137, 58);
            this.btn_newLoadExamine.TabIndex = 40;
            this.btn_newLoadExamine.Text = "重新载入";
            this.btn_newLoadExamine.UseVisualStyleBackColor = true;
            this.btn_newLoadExamine.Click += new System.EventHandler(this.btn_newLoadExamine_Click);
            // 
            // btn_SearchExmaineByName
            // 
            this.btn_SearchExmaineByName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchExmaineByName.Location = new System.Drawing.Point(454, 706);
            this.btn_SearchExmaineByName.Name = "btn_SearchExmaineByName";
            this.btn_SearchExmaineByName.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchExmaineByName.TabIndex = 39;
            this.btn_SearchExmaineByName.Text = "根据名称搜索";
            this.btn_SearchExmaineByName.UseVisualStyleBackColor = true;
            this.btn_SearchExmaineByName.Click += new System.EventHandler(this.btn_SearchExmaineByName_Click);
            // 
            // txb_ExamineName
            // 
            this.txb_ExamineName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_ExamineName.Location = new System.Drawing.Point(138, 709);
            this.txb_ExamineName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ExamineName.Name = "txb_ExamineName";
            this.txb_ExamineName.Size = new System.Drawing.Size(309, 39);
            this.txb_ExamineName.TabIndex = 38;
            // 
            // btn_SearchExamineByNo
            // 
            this.btn_SearchExamineByNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchExamineByNo.Location = new System.Drawing.Point(454, 617);
            this.btn_SearchExamineByNo.Name = "btn_SearchExamineByNo";
            this.btn_SearchExamineByNo.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchExamineByNo.TabIndex = 37;
            this.btn_SearchExamineByNo.Text = "根据编号搜索";
            this.btn_SearchExamineByNo.UseVisualStyleBackColor = true;
            this.btn_SearchExamineByNo.Click += new System.EventHandler(this.btn_SearchExamineByNo_Click);
            // 
            // txb_ExamineNo
            // 
            this.txb_ExamineNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_ExamineNo.Location = new System.Drawing.Point(138, 620);
            this.txb_ExamineNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ExamineNo.Name = "txb_ExamineNo";
            this.txb_ExamineNo.Size = new System.Drawing.Size(309, 39);
            this.txb_ExamineNo.TabIndex = 36;
            // 
            // dgv_Exmaine
            // 
            this.dgv_Exmaine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exmaine.Location = new System.Drawing.Point(3, 3);
            this.dgv_Exmaine.Name = "dgv_Exmaine";
            this.dgv_Exmaine.RowHeadersWidth = 62;
            this.dgv_Exmaine.RowTemplate.Height = 30;
            this.dgv_Exmaine.Size = new System.Drawing.Size(1413, 575);
            this.dgv_Exmaine.TabIndex = 0;
            this.dgv_Exmaine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Exmaine_CellContentClick);
            // 
            // frm_PriceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.tc_PriceSearch);
            this.Name = "frm_PriceSearch";
            this.tc_PriceSearch.ResumeLayout(false);
            this.tp_DrugPrice.ResumeLayout(false);
            this.tp_DrugPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).EndInit();
            this.tp_ExaminePrice.ResumeLayout(false);
            this.tp_ExaminePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exmaine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_PriceSearch;
        private System.Windows.Forms.TabPage tp_DrugPrice;
        private System.Windows.Forms.TabPage tp_ExaminePrice;
        private System.Windows.Forms.DataGridView dgv_Exmaine;
        private System.Windows.Forms.DataGridView dgv_Drug;
        private System.Windows.Forms.TextBox txb_DrugNo;
        private System.Windows.Forms.Button btn_SearchDrugByNo;
        private System.Windows.Forms.Button btn_SearchExamineByNo;
        private System.Windows.Forms.TextBox txb_ExamineNo;
        private System.Windows.Forms.Button btn_SearchDrugByName;
        private System.Windows.Forms.TextBox txb_DrugName;
        private System.Windows.Forms.Button btn_SearchExmaineByName;
        private System.Windows.Forms.TextBox txb_ExamineName;
        private System.Windows.Forms.Button btn_NewLoadDrug;
        private System.Windows.Forms.Button btn_newLoadExamine;
        private System.Windows.Forms.Button btn_SearchDrugByKeyword;
        private System.Windows.Forms.TextBox txb_DrugKeyWord;
        private System.Windows.Forms.Button btn_SearchExamineByKeyWord;
        private System.Windows.Forms.TextBox txb_ExamineKeyWord;
    }
}