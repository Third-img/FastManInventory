namespace FastmanApp.Forms
{
    partial class Inventory
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
            this.pnlItemInventory = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.pnlMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlItemInventory
            // 
            this.pnlItemInventory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlItemInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItemInventory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlItemInventory.Location = new System.Drawing.Point(0, 0);
            this.pnlItemInventory.Name = "pnlItemInventory";
            this.pnlItemInventory.Size = new System.Drawing.Size(995, 634);
            this.pnlItemInventory.TabIndex = 0;
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Controls.Add(this.pnlItemInventory);
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(995, 634);
            this.pnlMainPanel.TabIndex = 1;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 634);
            this.Controls.Add(this.pnlMainPanel);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.pnlMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlItemInventory;
        private System.Windows.Forms.Panel pnlMainPanel;
    }
}