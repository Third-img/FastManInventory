namespace FastmanApp.UserControls
{
    partial class EditItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.tpSelect = new System.Windows.Forms.ToolTip(this.components);
            this.pbEditButton = new System.Windows.Forms.PictureBox();
            this.pbDeleteButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(19, 284);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(263, 25);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "Name";
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Enabled = false;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(19, 370);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(263, 25);
            this.tbPrice.TabIndex = 1;
            this.tbPrice.Text = "Price";
            // 
            // nmQuantity
            // 
            this.nmQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.nmQuantity.Enabled = false;
            this.nmQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.nmQuantity.InterceptArrowKeys = false;
            this.nmQuantity.Location = new System.Drawing.Point(19, 325);
            this.nmQuantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(101, 32);
            this.nmQuantity.TabIndex = 3;
            // 
            // pbEditButton
            // 
            this.pbEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditButton.Image = global::FastmanApp.Properties.Resources.trash__1_;
            this.pbEditButton.Location = new System.Drawing.Point(208, 548);
            this.pbEditButton.Name = "pbEditButton";
            this.pbEditButton.Size = new System.Drawing.Size(34, 36);
            this.pbEditButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditButton.TabIndex = 5;
            this.pbEditButton.TabStop = false;
            this.pbEditButton.Click += new System.EventHandler(this._editButton);
            this.pbEditButton.MouseHover += new System.EventHandler(this._editToolTip);
            // 
            // pbDeleteButton
            // 
            this.pbDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeleteButton.Image = global::FastmanApp.Properties.Resources.edit;
            this.pbDeleteButton.Location = new System.Drawing.Point(248, 548);
            this.pbDeleteButton.Name = "pbDeleteButton";
            this.pbDeleteButton.Size = new System.Drawing.Size(34, 36);
            this.pbDeleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeleteButton.TabIndex = 4;
            this.pbDeleteButton.TabStop = false;
            this.pbDeleteButton.Click += new System.EventHandler(this._deleteButton);
            this.pbDeleteButton.MouseHover += new System.EventHandler(this._deleteToolTip);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // EditItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.pbEditButton);
            this.Controls.Add(this.pbDeleteButton);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.MinimumSize = new System.Drawing.Size(300, 600);
            this.Name = "EditItem";
            this.Size = new System.Drawing.Size(300, 600);
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.PictureBox pbDeleteButton;
        private System.Windows.Forms.ToolTip tpSelect;
        private System.Windows.Forms.PictureBox pbEditButton;
    }
}
