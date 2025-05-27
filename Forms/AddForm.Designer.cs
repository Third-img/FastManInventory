namespace FastmanApp.Forms
{
    partial class AddForm
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
            this.btnLog = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.pnlAddForm = new System.Windows.Forms.Panel();
            this.pnlPricing = new System.Windows.Forms.Panel();
            this.lblPricing = new System.Windows.Forms.Label();
            this.tbSP = new System.Windows.Forms.TextBox();
            this.pnlSM = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSM = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbUOM = new System.Windows.Forms.ComboBox();
            this.nudRQ = new System.Windows.Forms.NumericUpDown();
            this.nudRL = new System.Windows.Forms.NumericUpDown();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.pnlID = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbChecklist = new System.Windows.Forms.PictureBox();
            this.pbEdit1 = new System.Windows.Forms.PictureBox();
            this.pbEdit2 = new System.Windows.Forms.PictureBox();
            this.pbStock = new System.Windows.Forms.PictureBox();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlAddForm.SuspendLayout();
            this.pnlPricing.SuspendLayout();
            this.pnlSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.pnlID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChecklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(472, 322);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(82, 34);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Save";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(245, 24);
            this.tbName.TabIndex = 6;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(10, 34);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(136, 24);
            this.tbPrice.TabIndex = 10;
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(70, 193);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(184, 24);
            this.tbURL.TabIndex = 11;
            // 
            // pnlAddForm
            // 
            this.pnlAddForm.Controls.Add(this.pnlPricing);
            this.pnlAddForm.Controls.Add(this.pnlSM);
            this.pnlAddForm.Controls.Add(this.pnlID);
            this.pnlAddForm.Controls.Add(this.label6);
            this.pnlAddForm.Controls.Add(this.btnLog);
            this.pnlAddForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddForm.Location = new System.Drawing.Point(0, 0);
            this.pnlAddForm.Margin = new System.Windows.Forms.Padding(10);
            this.pnlAddForm.Name = "pnlAddForm";
            this.pnlAddForm.Size = new System.Drawing.Size(569, 368);
            this.pnlAddForm.TabIndex = 13;
            // 
            // pnlPricing
            // 
            this.pnlPricing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPricing.Controls.Add(this.pbChecklist);
            this.pnlPricing.Controls.Add(this.lblPricing);
            this.pnlPricing.Controls.Add(this.tbPrice);
            this.pnlPricing.Controls.Add(this.tbSP);
            this.pnlPricing.Location = new System.Drawing.Point(13, 256);
            this.pnlPricing.Name = "pnlPricing";
            this.pnlPricing.Size = new System.Drawing.Size(265, 99);
            this.pnlPricing.TabIndex = 19;
            // 
            // lblPricing
            // 
            this.lblPricing.AutoSize = true;
            this.lblPricing.BackColor = System.Drawing.Color.Transparent;
            this.lblPricing.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricing.Location = new System.Drawing.Point(37, 6);
            this.lblPricing.Name = "lblPricing";
            this.lblPricing.Size = new System.Drawing.Size(79, 26);
            this.lblPricing.TabIndex = 14;
            this.lblPricing.Text = "Pricing";
            // 
            // tbSP
            // 
            this.tbSP.Location = new System.Drawing.Point(10, 64);
            this.tbSP.Name = "tbSP";
            this.tbSP.Size = new System.Drawing.Size(136, 24);
            this.tbSP.TabIndex = 6;
            this.tbSP.Tag = "Selling Price";
            // 
            // pnlSM
            // 
            this.pnlSM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSM.Controls.Add(this.pbEdit1);
            this.pnlSM.Controls.Add(this.pbEdit2);
            this.pnlSM.Controls.Add(this.pbStock);
            this.pnlSM.Controls.Add(this.label5);
            this.pnlSM.Controls.Add(this.label4);
            this.pnlSM.Controls.Add(this.label3);
            this.pnlSM.Controls.Add(this.lblSM);
            this.pnlSM.Controls.Add(this.cbCategory);
            this.pnlSM.Controls.Add(this.cbUOM);
            this.pnlSM.Controls.Add(this.nudRQ);
            this.pnlSM.Controls.Add(this.nudRL);
            this.pnlSM.Controls.Add(this.nudQuantity);
            this.pnlSM.Controls.Add(this.tbWeight);
            this.pnlSM.Location = new System.Drawing.Point(285, 9);
            this.pnlSM.Name = "pnlSM";
            this.pnlSM.Size = new System.Drawing.Size(269, 240);
            this.pnlSM.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Reorder Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Reorder Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantity";
            // 
            // lblSM
            // 
            this.lblSM.AutoSize = true;
            this.lblSM.BackColor = System.Drawing.Color.Transparent;
            this.lblSM.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSM.Location = new System.Drawing.Point(34, 5);
            this.lblSM.Name = "lblSM";
            this.lblSM.Size = new System.Drawing.Size(198, 26);
            this.lblSM.TabIndex = 14;
            this.lblSM.Text = "Stock Management";
            // 
            // cbCategory
            // 
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCategory.Location = new System.Drawing.Point(112, 162);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(140, 25);
            this.cbCategory.TabIndex = 13;
            // 
            // cbUOM
            // 
            this.cbUOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUOM.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUOM.FormattingEnabled = true;
            this.cbUOM.Location = new System.Drawing.Point(189, 193);
            this.cbUOM.Name = "cbUOM";
            this.cbUOM.Size = new System.Drawing.Size(63, 25);
            this.cbUOM.TabIndex = 13;
            // 
            // nudRQ
            // 
            this.nudRQ.Enabled = false;
            this.nudRQ.Location = new System.Drawing.Point(112, 80);
            this.nudRQ.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudRQ.Name = "nudRQ";
            this.nudRQ.Size = new System.Drawing.Size(111, 24);
            this.nudRQ.TabIndex = 12;
            // 
            // nudRL
            // 
            this.nudRL.Enabled = false;
            this.nudRL.Location = new System.Drawing.Point(112, 118);
            this.nudRL.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudRL.Name = "nudRL";
            this.nudRL.Size = new System.Drawing.Size(111, 24);
            this.nudRL.TabIndex = 12;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(112, 42);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(140, 24);
            this.nudQuantity.TabIndex = 12;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(112, 194);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(75, 24);
            this.tbWeight.TabIndex = 6;
            // 
            // pnlID
            // 
            this.pnlID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlID.Controls.Add(this.pbInfo);
            this.pnlID.Controls.Add(this.tbDescription);
            this.pnlID.Controls.Add(this.lblID);
            this.pnlID.Controls.Add(this.tbURL);
            this.pnlID.Controls.Add(this.pbItemImage);
            this.pnlID.Controls.Add(this.tbName);
            this.pnlID.Location = new System.Drawing.Point(13, 9);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(265, 241);
            this.pnlID.TabIndex = 17;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(9, 63);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(245, 124);
            this.tbDescription.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.Location = new System.Drawing.Point(38, 5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(128, 26);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "Item Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(639, -240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pricing Information";
            // 
            // pbChecklist
            // 
            this.pbChecklist.Image = global::FastmanApp.Properties.Resources.list;
            this.pbChecklist.Location = new System.Drawing.Point(10, 3);
            this.pbChecklist.Name = "pbChecklist";
            this.pbChecklist.Size = new System.Drawing.Size(24, 28);
            this.pbChecklist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChecklist.TabIndex = 16;
            this.pbChecklist.TabStop = false;
            // 
            // pbEdit1
            // 
            this.pbEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdit1.Image = global::FastmanApp.Properties.Resources.penedit;
            this.pbEdit1.Location = new System.Drawing.Point(229, 119);
            this.pbEdit1.Name = "pbEdit1";
            this.pbEdit1.Size = new System.Drawing.Size(22, 23);
            this.pbEdit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit1.TabIndex = 18;
            this.pbEdit1.TabStop = false;
            // 
            // pbEdit2
            // 
            this.pbEdit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdit2.Image = global::FastmanApp.Properties.Resources.penedit;
            this.pbEdit2.Location = new System.Drawing.Point(229, 80);
            this.pbEdit2.Name = "pbEdit2";
            this.pbEdit2.Size = new System.Drawing.Size(22, 23);
            this.pbEdit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit2.TabIndex = 17;
            this.pbEdit2.TabStop = false;
            // 
            // pbStock
            // 
            this.pbStock.Image = global::FastmanApp.Properties.Resources.shipping;
            this.pbStock.Location = new System.Drawing.Point(5, 5);
            this.pbStock.Name = "pbStock";
            this.pbStock.Size = new System.Drawing.Size(25, 26);
            this.pbStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStock.TabIndex = 16;
            this.pbStock.TabStop = false;
            // 
            // pbInfo
            // 
            this.pbInfo.Image = global::FastmanApp.Properties.Resources.info;
            this.pbInfo.Location = new System.Drawing.Point(9, 5);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(25, 26);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfo.TabIndex = 16;
            this.pbInfo.TabStop = false;
            // 
            // pbItemImage
            // 
            this.pbItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbItemImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbItemImage.Image = global::FastmanApp.Properties.Resources._imagepicker2;
            this.pbItemImage.Location = new System.Drawing.Point(9, 193);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(55, 40);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 2;
            this.pbItemImage.TabStop = false;
            this.pbItemImage.Click += new System.EventHandler(this.btnBrowse_Click);
            this.pbItemImage.MouseHover += new System.EventHandler(this._imageTP);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 368);
            this.Controls.Add(this.pnlAddForm);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "Add Item";
            this.pnlAddForm.ResumeLayout(false);
            this.pnlAddForm.PerformLayout();
            this.pnlPricing.ResumeLayout(false);
            this.pnlPricing.PerformLayout();
            this.pnlSM.ResumeLayout(false);
            this.pnlSM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChecklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Panel pnlAddForm;
        private System.Windows.Forms.TextBox tbSP;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbUOM;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown nudRQ;
        private System.Windows.Forms.NumericUpDown nudRL;
        private System.Windows.Forms.Label lblSM;
        private System.Windows.Forms.Label lblPricing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.PictureBox pbChecklist;
        private System.Windows.Forms.PictureBox pbStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlPricing;
        private System.Windows.Forms.Panel pnlSM;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.PictureBox pbEdit2;
        private System.Windows.Forms.PictureBox pbEdit1;
    }
}