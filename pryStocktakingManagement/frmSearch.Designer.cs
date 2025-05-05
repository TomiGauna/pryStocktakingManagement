namespace pryStocktakingManagement
{
    partial class frmSearch
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
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCodeOrName = new System.Windows.Forms.TextBox();
            this.cboCategoryOptions = new System.Windows.Forms.ComboBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.cboSearchField = new System.Windows.Forms.ComboBox();
            this.lblSearchField = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.txtCodeOrName);
            this.grbSearch.Controls.Add(this.cboCategoryOptions);
            this.grbSearch.Controls.Add(this.lblOptions);
            this.grbSearch.Controls.Add(this.cboSearchField);
            this.grbSearch.Controls.Add(this.lblSearchField);
            this.grbSearch.Location = new System.Drawing.Point(12, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(642, 153);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "groupBox1";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(426, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCodeOrName
            // 
            this.txtCodeOrName.Location = new System.Drawing.Point(292, 72);
            this.txtCodeOrName.Name = "txtCodeOrName";
            this.txtCodeOrName.Size = new System.Drawing.Size(209, 20);
            this.txtCodeOrName.TabIndex = 5;
            // 
            // cboCategoryOptions
            // 
            this.cboCategoryOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoryOptions.FormattingEnabled = true;
            this.cboCategoryOptions.Location = new System.Drawing.Point(292, 45);
            this.cboCategoryOptions.Name = "cboCategoryOptions";
            this.cboCategoryOptions.Size = new System.Drawing.Size(209, 21);
            this.cboCategoryOptions.TabIndex = 4;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(289, 29);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(35, 13);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "label2";
            // 
            // cboSearchField
            // 
            this.cboSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchField.FormattingEnabled = true;
            this.cboSearchField.Location = new System.Drawing.Point(6, 45);
            this.cboSearchField.Name = "cboSearchField";
            this.cboSearchField.Size = new System.Drawing.Size(213, 21);
            this.cboSearchField.TabIndex = 1;
            this.cboSearchField.SelectedIndexChanged += new System.EventHandler(this.cboSearchField_SelectedIndexChanged);
            // 
            // lblSearchField
            // 
            this.lblSearchField.AutoSize = true;
            this.lblSearchField.Location = new System.Drawing.Point(6, 29);
            this.lblSearchField.Name = "lblSearchField";
            this.lblSearchField.Size = new System.Drawing.Size(35, 13);
            this.lblSearchField.TabIndex = 0;
            this.lblSearchField.Text = "label1";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 171);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(642, 378);
            this.dgvProducts.TabIndex = 1;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 561);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.grbSearch);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.ComboBox cboSearchField;
        private System.Windows.Forms.Label lblSearchField;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCodeOrName;
        private System.Windows.Forms.ComboBox cboCategoryOptions;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}