namespace FastmanApp
{
    partial class InventoryLog
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.lblAddButton = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fastManAppDataSet = new FastmanApp.FastManAppDataSet();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new FastmanApp.FastManAppDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new FastmanApp.FastManAppDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter1 = new FastmanApp.FastManAppDataSetTableAdapters.ProductsTableAdapter();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastManAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTitle.Controls.Add(this.lblRefresh);
            this.pnlTitle.Controls.Add(this.lblAddButton);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(946, 57);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblRefresh
            // 
            this.lblRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRefresh.Location = new System.Drawing.Point(851, 6);
            this.lblRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(32, 42);
            this.lblRefresh.TabIndex = 2;
            this.lblRefresh.Text = "-";
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // lblAddButton
            // 
            this.lblAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddButton.AutoSize = true;
            this.lblAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddButton.Location = new System.Drawing.Point(891, 9);
            this.lblAddButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddButton.Name = "lblAddButton";
            this.lblAddButton.Size = new System.Drawing.Size(42, 42);
            this.lblAddButton.TabIndex = 1;
            this.lblAddButton.Text = "+";
            this.lblAddButton.Click += new System.EventHandler(this.lblAddButton_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(13, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventory";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // fastManAppDataSet
            // 
            this.fastManAppDataSet.DataSetName = "FastManAppDataSet";
            this.fastManAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.fastManAppDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = FastmanApp.FastManAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // flpItems
            // 
            this.flpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItems.Location = new System.Drawing.Point(0, 57);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(946, 457);
            this.flpItems.TabIndex = 1;
            // 
            // InventoryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 514);
            this.Controls.Add(this.flpItems);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "InventoryLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryLog_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastManAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAddButton;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private FastManAppDataSet fastManAppDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private FastManAppDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private FastManAppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblRefresh;
        private FastManAppDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
    }
}

