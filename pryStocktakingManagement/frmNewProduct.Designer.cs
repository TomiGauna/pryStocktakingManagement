namespace pryStocktakingManagement
{
    partial class frmNewProduct
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCreateTitle = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblChangeCode = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtChangeCode = new System.Windows.Forms.TextBox();
            this.lblField = new System.Windows.Forms.Label();
            this.lblNewData = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.cboNewData = new System.Windows.Forms.ComboBox();
            this.txtNewData = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.btnSearchForm = new System.Windows.Forms.Button();
            this.btnReportForm = new System.Windows.Forms.Button();
            this.lblSearchForm = new System.Windows.Forms.Label();
            this.lblReportBtn = new System.Windows.Forms.Label();
            this.lblRemovalTitle = new System.Windows.Forms.Label();
            this.txtDeleteCode = new System.Windows.Forms.TextBox();
            this.lblRemovalCode = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateTitle
            // 
            this.lblCreateTitle.AutoSize = true;
            this.lblCreateTitle.Location = new System.Drawing.Point(64, 28);
            this.lblCreateTitle.Name = "lblCreateTitle";
            this.lblCreateTitle.Size = new System.Drawing.Size(35, 13);
            this.lblCreateTitle.TabIndex = 0;
            this.lblCreateTitle.Text = "label1";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(42, 60);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "label2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label3";
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(373, 28);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateTitle.TabIndex = 3;
            this.lblUpdateTitle.Text = "label4";
            // 
            // lblChangeCode
            // 
            this.lblChangeCode.AutoSize = true;
            this.lblChangeCode.Location = new System.Drawing.Point(358, 60);
            this.lblChangeCode.Name = "lblChangeCode";
            this.lblChangeCode.Size = new System.Drawing.Size(35, 13);
            this.lblChangeCode.TabIndex = 4;
            this.lblChangeCode.Text = "label5";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(42, 320);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(35, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "label6";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(42, 376);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "label7";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(42, 434);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "label8";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(36, 77);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 20);
            this.txtCode.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(36, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 9;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(36, 336);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 21);
            this.cboCategory.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(36, 392);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // txtChangeCode
            // 
            this.txtChangeCode.Location = new System.Drawing.Point(358, 76);
            this.txtChangeCode.Name = "txtChangeCode";
            this.txtChangeCode.Size = new System.Drawing.Size(209, 20);
            this.txtChangeCode.TabIndex = 13;
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(358, 112);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(35, 13);
            this.lblField.TabIndex = 14;
            this.lblField.Text = "label9";
            // 
            // lblNewData
            // 
            this.lblNewData.AutoSize = true;
            this.lblNewData.Location = new System.Drawing.Point(358, 166);
            this.lblNewData.Name = "lblNewData";
            this.lblNewData.Size = new System.Drawing.Size(41, 13);
            this.lblNewData.TabIndex = 15;
            this.lblNewData.Text = "label10";
            // 
            // cboField
            // 
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(358, 128);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(209, 21);
            this.cboField.TabIndex = 16;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // cboNewData
            // 
            this.cboNewData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewData.FormattingEnabled = true;
            this.cboNewData.Location = new System.Drawing.Point(358, 212);
            this.cboNewData.Name = "cboNewData";
            this.cboNewData.Size = new System.Drawing.Size(209, 21);
            this.cboNewData.TabIndex = 17;
            // 
            // txtNewData
            // 
            this.txtNewData.Location = new System.Drawing.Point(358, 182);
            this.txtNewData.Name = "txtNewData";
            this.txtNewData.Size = new System.Drawing.Size(209, 20);
            this.txtNewData.TabIndex = 18;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(161, 484);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "button1";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(492, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "button2";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(42, 166);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(41, 13);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "label11";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(36, 182);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(200, 121);
            this.rtxtDescription.TabIndex = 22;
            this.rtxtDescription.Text = "";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(36, 450);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(200, 20);
            this.nudStock.TabIndex = 23;
            // 
            // btnSearchForm
            // 
            this.btnSearchForm.Location = new System.Drawing.Point(358, 424);
            this.btnSearchForm.Name = "btnSearchForm";
            this.btnSearchForm.Size = new System.Drawing.Size(209, 23);
            this.btnSearchForm.TabIndex = 24;
            this.btnSearchForm.Text = "button1";
            this.btnSearchForm.UseVisualStyleBackColor = true;
            this.btnSearchForm.Click += new System.EventHandler(this.btnSearchForm_Click);
            // 
            // btnReportForm
            // 
            this.btnReportForm.Location = new System.Drawing.Point(358, 484);
            this.btnReportForm.Name = "btnReportForm";
            this.btnReportForm.Size = new System.Drawing.Size(209, 23);
            this.btnReportForm.TabIndex = 25;
            this.btnReportForm.Text = "button2";
            this.btnReportForm.UseVisualStyleBackColor = true;
            this.btnReportForm.Click += new System.EventHandler(this.btnReportForm_Click);
            // 
            // lblSearchForm
            // 
            this.lblSearchForm.AutoSize = true;
            this.lblSearchForm.Location = new System.Drawing.Point(355, 408);
            this.lblSearchForm.Name = "lblSearchForm";
            this.lblSearchForm.Size = new System.Drawing.Size(35, 13);
            this.lblSearchForm.TabIndex = 26;
            this.lblSearchForm.Text = "label1";
            // 
            // lblReportBtn
            // 
            this.lblReportBtn.AutoSize = true;
            this.lblReportBtn.Location = new System.Drawing.Point(355, 468);
            this.lblReportBtn.Name = "lblReportBtn";
            this.lblReportBtn.Size = new System.Drawing.Size(35, 13);
            this.lblReportBtn.TabIndex = 27;
            this.lblReportBtn.Text = "label2";
            // 
            // lblRemovalTitle
            // 
            this.lblRemovalTitle.AutoSize = true;
            this.lblRemovalTitle.Location = new System.Drawing.Point(412, 290);
            this.lblRemovalTitle.Name = "lblRemovalTitle";
            this.lblRemovalTitle.Size = new System.Drawing.Size(35, 13);
            this.lblRemovalTitle.TabIndex = 28;
            this.lblRemovalTitle.Text = "label1";
            // 
            // txtDeleteCode
            // 
            this.txtDeleteCode.Location = new System.Drawing.Point(358, 336);
            this.txtDeleteCode.Name = "txtDeleteCode";
            this.txtDeleteCode.Size = new System.Drawing.Size(209, 20);
            this.txtDeleteCode.TabIndex = 29;
            // 
            // lblRemovalCode
            // 
            this.lblRemovalCode.AutoSize = true;
            this.lblRemovalCode.Location = new System.Drawing.Point(358, 320);
            this.lblRemovalCode.Name = "lblRemovalCode";
            this.lblRemovalCode.Size = new System.Drawing.Size(35, 13);
            this.lblRemovalCode.TabIndex = 30;
            this.lblRemovalCode.Text = "label2";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(492, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "button1";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 525);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblRemovalCode);
            this.Controls.Add(this.txtDeleteCode);
            this.Controls.Add(this.lblRemovalTitle);
            this.Controls.Add(this.lblReportBtn);
            this.Controls.Add(this.lblSearchForm);
            this.Controls.Add(this.btnReportForm);
            this.Controls.Add(this.btnSearchForm);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtNewData);
            this.Controls.Add(this.cboNewData);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.lblNewData);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.txtChangeCode);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblChangeCode);
            this.Controls.Add(this.lblUpdateTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblCreateTitle);
            this.Name = "frmNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmNewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateTitle;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblChangeCode;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtChangeCode;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblNewData;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.ComboBox cboNewData;
        private System.Windows.Forms.TextBox txtNewData;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button btnSearchForm;
        private System.Windows.Forms.Button btnReportForm;
        private System.Windows.Forms.Label lblSearchForm;
        private System.Windows.Forms.Label lblReportBtn;
        private System.Windows.Forms.Label lblRemovalTitle;
        private System.Windows.Forms.TextBox txtDeleteCode;
        private System.Windows.Forms.Label lblRemovalCode;
        private System.Windows.Forms.Button btnDelete;
    }
}

