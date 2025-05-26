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
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaming = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbUOM = new System.Windows.Forms.ComboBox();
            this.nudRQ = new System.Windows.Forms.NumericUpDown();
            this.nudRL = new System.Windows.Forms.NumericUpDown();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbSP = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlAddForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.pnlAddForm.Controls.Add(this.panel3);
            this.pnlAddForm.Controls.Add(this.panel2);
            this.pnlAddForm.Controls.Add(this.panel1);
            this.pnlAddForm.Controls.Add(this.label6);
            this.pnlAddForm.Controls.Add(this.btnLog);
            this.pnlAddForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddForm.Location = new System.Drawing.Point(0, 0);
            this.pnlAddForm.Name = "pnlAddForm";
            this.pnlAddForm.Size = new System.Drawing.Size(569, 368);
            this.pnlAddForm.TabIndex = 13;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(9, 63);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(245, 124);
            this.tbDescription.TabIndex = 15;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pricing";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stock Management";
            // 
            // lblNaming
            // 
            this.lblNaming.AutoSize = true;
            this.lblNaming.BackColor = System.Drawing.Color.Transparent;
            this.lblNaming.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaming.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNaming.Location = new System.Drawing.Point(32, 5);
            this.lblNaming.Name = "lblNaming";
            this.lblNaming.Size = new System.Drawing.Size(128, 26);
            this.lblNaming.TabIndex = 14;
            this.lblNaming.Text = "Item Details";
            // 
            // cbCategory
            // 
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(112, 162);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(140, 25);
            this.cbCategory.TabIndex = 13;
            this.cbCategory.Text = "Category";
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
            this.nudRQ.Location = new System.Drawing.Point(112, 80);
            this.nudRQ.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudRQ.Name = "nudRQ";
            this.nudRQ.Size = new System.Drawing.Size(140, 24);
            this.nudRQ.TabIndex = 12;
            // 
            // nudRL
            // 
            this.nudRL.Location = new System.Drawing.Point(112, 118);
            this.nudRL.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudRL.Name = "nudRL";
            this.nudRL.Size = new System.Drawing.Size(140, 24);
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
            // tbSP
            // 
            this.tbSP.Location = new System.Drawing.Point(10, 64);
            this.tbSP.Name = "tbSP";
            this.tbSP.Size = new System.Drawing.Size(136, 24);
            this.tbSP.TabIndex = 6;
            this.tbSP.Tag = "Selling Price";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(112, 194);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(75, 24);
            this.tbWeight.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FastmanApp.Properties.Resources.list;
            this.pictureBox3.Location = new System.Drawing.Point(10, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FastmanApp.Properties.Resources.shipping;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FastmanApp.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.lblNaming);
            this.panel1.Controls.Add(this.tbURL);
            this.panel1.Controls.Add(this.pbItemImage);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Location = new System.Drawing.Point(13, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 241);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Controls.Add(this.cbUOM);
            this.panel2.Controls.Add(this.nudRQ);
            this.panel2.Controls.Add(this.nudRL);
            this.panel2.Controls.Add(this.nudQuantity);
            this.panel2.Controls.Add(this.tbWeight);
            this.panel2.Location = new System.Drawing.Point(285, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 240);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbPrice);
            this.panel3.Controls.Add(this.tbSP);
            this.panel3.Location = new System.Drawing.Point(15, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 99);
            this.panel3.TabIndex = 19;
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
            ((System.ComponentModel.ISupportInitialize)(this.nudRQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label lblNaming;
        private System.Windows.Forms.NumericUpDown nudRQ;
        private System.Windows.Forms.NumericUpDown nudRL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}