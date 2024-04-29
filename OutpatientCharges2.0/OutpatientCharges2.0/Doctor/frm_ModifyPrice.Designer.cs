namespace OutpatientCharges2._0.Doctor
{
    partial class frm_ModifyPrice
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
            this.tp_Drug = new System.Windows.Forms.TabPage();
            this.btn_SaveDrug = new System.Windows.Forms.Button();
            this.dgv_Drug = new System.Windows.Forms.DataGridView();
            this.tp_Examine = new System.Windows.Forms.TabPage();
            this.btn_SaveExamine = new System.Windows.Forms.Button();
            this.dgv_Exmaine = new System.Windows.Forms.DataGridView();
            this.tc_PriceSearch.SuspendLayout();
            this.tp_Drug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).BeginInit();
            this.tp_Examine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exmaine)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_PriceSearch
            // 
            this.tc_PriceSearch.Controls.Add(this.tp_Drug);
            this.tc_PriceSearch.Controls.Add(this.tp_Examine);
            this.tc_PriceSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tc_PriceSearch.Location = new System.Drawing.Point(2, 2);
            this.tc_PriceSearch.Name = "tc_PriceSearch";
            this.tc_PriceSearch.SelectedIndex = 0;
            this.tc_PriceSearch.Size = new System.Drawing.Size(1427, 826);
            this.tc_PriceSearch.TabIndex = 1;
            // 
            // tp_Drug
            // 
            this.tp_Drug.Controls.Add(this.btn_SaveDrug);
            this.tp_Drug.Controls.Add(this.dgv_Drug);
            this.tp_Drug.Location = new System.Drawing.Point(4, 37);
            this.tp_Drug.Name = "tp_Drug";
            this.tp_Drug.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Drug.Size = new System.Drawing.Size(1419, 785);
            this.tp_Drug.TabIndex = 0;
            this.tp_Drug.Text = "药品";
            this.tp_Drug.UseVisualStyleBackColor = true;
            // 
            // btn_SaveDrug
            // 
            this.btn_SaveDrug.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SaveDrug.Location = new System.Drawing.Point(619, 692);
            this.btn_SaveDrug.Name = "btn_SaveDrug";
            this.btn_SaveDrug.Size = new System.Drawing.Size(126, 60);
            this.btn_SaveDrug.TabIndex = 33;
            this.btn_SaveDrug.Text = "保存";
            this.btn_SaveDrug.UseVisualStyleBackColor = true;
            this.btn_SaveDrug.Click += new System.EventHandler(this.btn_SaveDrug_Click);
            // 
            // dgv_Drug
            // 
            this.dgv_Drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Drug.Location = new System.Drawing.Point(8, 8);
            this.dgv_Drug.Name = "dgv_Drug";
            this.dgv_Drug.RowHeadersWidth = 62;
            this.dgv_Drug.RowTemplate.Height = 30;
            this.dgv_Drug.Size = new System.Drawing.Size(1408, 678);
            this.dgv_Drug.TabIndex = 0;
            // 
            // tp_Examine
            // 
            this.tp_Examine.Controls.Add(this.btn_SaveExamine);
            this.tp_Examine.Controls.Add(this.dgv_Exmaine);
            this.tp_Examine.Location = new System.Drawing.Point(4, 37);
            this.tp_Examine.Name = "tp_Examine";
            this.tp_Examine.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Examine.Size = new System.Drawing.Size(1419, 785);
            this.tp_Examine.TabIndex = 1;
            this.tp_Examine.Text = "检查项目";
            this.tp_Examine.UseVisualStyleBackColor = true;
            // 
            // btn_SaveExamine
            // 
            this.btn_SaveExamine.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SaveExamine.Location = new System.Drawing.Point(658, 692);
            this.btn_SaveExamine.Name = "btn_SaveExamine";
            this.btn_SaveExamine.Size = new System.Drawing.Size(126, 60);
            this.btn_SaveExamine.TabIndex = 34;
            this.btn_SaveExamine.Text = "保存";
            this.btn_SaveExamine.UseVisualStyleBackColor = true;
            this.btn_SaveExamine.Click += new System.EventHandler(this.btn_SaveExamine_Click);
            // 
            // dgv_Exmaine
            // 
            this.dgv_Exmaine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exmaine.Location = new System.Drawing.Point(3, 3);
            this.dgv_Exmaine.Name = "dgv_Exmaine";
            this.dgv_Exmaine.RowHeadersWidth = 62;
            this.dgv_Exmaine.RowTemplate.Height = 30;
            this.dgv_Exmaine.Size = new System.Drawing.Size(1413, 683);
            this.dgv_Exmaine.TabIndex = 0;
            // 
            // frm_ModifyPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.tc_PriceSearch);
            this.Name = "frm_ModifyPrice";
            this.Text = "修改价目";
            this.tc_PriceSearch.ResumeLayout(false);
            this.tp_Drug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).EndInit();
            this.tp_Examine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exmaine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_PriceSearch;
        private System.Windows.Forms.TabPage tp_Drug;
        private System.Windows.Forms.DataGridView dgv_Drug;
        private System.Windows.Forms.TabPage tp_Examine;
        private System.Windows.Forms.DataGridView dgv_Exmaine;
        private System.Windows.Forms.Button btn_SaveDrug;
        private System.Windows.Forms.Button btn_SaveExamine;
    }
}