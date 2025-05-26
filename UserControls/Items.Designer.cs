namespace FastmanApp.UserControls
{
    partial class Items
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.tInformation = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblCapacity);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.pbItemImage);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblPrice.Location = new System.Drawing.Point(591, 36);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 28);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(690, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 100);
            this.panel2.TabIndex = 12;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(463, 36);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 28);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCapacity.Location = new System.Drawing.Point(157, 55);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(65, 19);
            this.lblCapacity.TabIndex = 16;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblType.Location = new System.Drawing.Point(157, 36);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(41, 19);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductName.Location = new System.Drawing.Point(157, 14);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(100, 22);
            this.lblProductName.TabIndex = 14;
            this.lblProductName.Text = "Item Name";
            // 
            // pbItemImage
            // 
            this.pbItemImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbItemImage.Location = new System.Drawing.Point(0, 0);
            this.pbItemImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(139, 100);
            this.pbItemImage.TabIndex = 13;
            this.pbItemImage.TabStop = false;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Items";
            this.Size = new System.Drawing.Size(703, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.ToolTip tInformation;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
