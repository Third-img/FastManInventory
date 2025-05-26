using System.Drawing;

namespace FastmanApp.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pbHeaderText = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFR = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.s2 = new FastmanApp.CustomControls.Separator();
            this.s3 = new FastmanApp.CustomControls.Separator();
            this.s1 = new FastmanApp.CustomControls.Separator();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlTools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.pbHeaderText);
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1264, 47);
            this.pnlHeader.TabIndex = 0;
            // 
            // pbHeaderText
            // 
            this.pbHeaderText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHeaderText.Image = ((System.Drawing.Image)(resources.GetObject("pbHeaderText.Image")));
            this.pbHeaderText.Location = new System.Drawing.Point(66, 0);
            this.pbHeaderText.Name = "pbHeaderText";
            this.pbHeaderText.Size = new System.Drawing.Size(1198, 47);
            this.pbHeaderText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeaderText.TabIndex = 1;
            this.pbHeaderText.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.ImageLocation = "R:\\3DY_Codes\\C#\\FastmanApp\\Images\\small_icon.png";
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(66, 47);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTools.Controls.Add(this.button2);
            this.pnlTools.Controls.Add(this.s1);
            this.pnlTools.Controls.Add(this.tbSearch);
            this.pnlTools.Controls.Add(this.label1);
            this.pnlTools.Controls.Add(this.button1);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(0, 47);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(1264, 51);
            this.pnlTools.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this._searchFunction);
            // 
            // tbSearch
            // 
            this.tbSearch.AllowDrop = true;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(216, 13);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(202, 24);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.Text = "Look";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(1177, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this._openAddForm);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnFR);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 589);
            this.panel1.TabIndex = 5;
            // 
            // btnFR
            // 
            this.btnFR.Location = new System.Drawing.Point(12, 105);
            this.btnFR.Name = "btnFR";
            this.btnFR.Size = new System.Drawing.Size(98, 23);
            this.btnFR.TabIndex = 2;
            this.btnFR.Text = "Financial Reports";
            this.btnFR.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(26, 76);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this._openInventory);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(26, 47);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this._openDashboard);
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.pnlInventory);
            this.pnlMainContainer.Controls.Add(this.s3);
            this.pnlMainContainer.Controls.Add(this.panel1);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 98);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1264, 589);
            this.pnlMainContainer.TabIndex = 6;
            // 
            // pnlInventory
            // 
            this.pnlInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInventory.Location = new System.Drawing.Point(210, 0);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(1054, 589);
            this.pnlInventory.TabIndex = 7;
            // 
            // s2
            // 
            this.s2.Dock = System.Windows.Forms.DockStyle.Top;
            this.s2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.s2.isVertical = false;
            this.s2.Location = new System.Drawing.Point(0, 98);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(1264, 2);
            this.s2.TabIndex = 7;
            this.s2.Text = "s2";
            this.s2.thickness = 2;
            // 
            // s3
            // 
            this.s3.Dock = System.Windows.Forms.DockStyle.Left;
            this.s3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.s3.isVertical = true;
            this.s3.Location = new System.Drawing.Point(208, 0);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(2, 589);
            this.s3.TabIndex = 6;
            this.s3.Text = "separator1";
            this.s3.thickness = 2;
            // 
            // s1
            // 
            this.s1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.s1.isVertical = true;
            this.s1.Location = new System.Drawing.Point(208, 2);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(2, 49);
            this.s1.TabIndex = 4;
            this.s1.Text = "separator1";
            this.s1.thickness = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 687);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.pnlHeader);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainMenu";
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbHeaderText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMainContainer;
        private CustomControls.Separator s1;
        private CustomControls.Separator s2;
        private CustomControls.Separator s3;
        private System.Windows.Forms.Button btnFR;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlInventory;
    }
}