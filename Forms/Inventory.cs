using FastmanApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FastmanApp.Forms
{
    public partial class Inventory : Form
    {
        #region Fields
        private Panel flow;
        private Items _currentItem = null;
        #endregion
        #region SQL Template
        string server = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FastManApp;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;
        SqlCommand cmd;
        #endregion

        private MainMenu _main;

        public Inventory(MainMenu main = null)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += _mainPanelSettings;
            _main = main;
        }

        #region Inventory
        private void _mainPanelSettings(object sender, EventArgs e)
        {
            this.pnlItemInventory.BackColor = ColorTranslator.FromHtml("#121212");
            this.pnlItemInventory.Padding = new Padding(2, 5, 2, 2);
            this.Load += _LoadItems;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Resize += _inventoryResize;
        }

        private void _loadList(SqlDataReader list) //List Loader
        {
            while (list.Read())
            {
                Items item = new Items();
                item.mainFrame.BackColor = SystemColors.ControlDarkDark;
                item.Width = pnlItemInventory.ClientSize.Width - 10;
                item.Margin = new Padding(2);
                item.Anchor = AnchorStyles.Top;

                // Tag
                item.Tag = list["ItemName"].ToString();

                // Item Name
                item.productName = list["ItemName"].ToString();

                // Item Quantity
                item.ProductQuantity = Convert.ToInt32(list["ItemQuantity"]).ToString();

                // Item Price
                item.ProductPrice = Convert.ToDecimal(list["ItemCP"])
                    .ToString("C", CultureInfo.CreateSpecificCulture("en-PH"));

                // Image from URL
                string imageUrl = list["ItemImage"].ToString();

                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        byte[] imageBytes = wc.DownloadData(imageUrl);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            item.ProductImage = Image.FromStream(ms);
                        }
                    }
                }
                catch (Exception)
                {
                    item.ProductImage = null;
                }

                #region Quantity Color Loop
                if (Convert.ToInt32(item.ProductQuantity) <= 10)
                {
                    item.resultPanel.BackColor = Color.IndianRed;
                    item._showResult.SetToolTip(item.resultPanel, "Low");
                }
                else if (Convert.ToInt32(item.ProductQuantity) <= 30)
                {
                    item.resultPanel.BackColor = Color.Orange;
                    item._showResult.SetToolTip(item.resultPanel, "Decent");
                }
                else
                {
                    item.resultPanel.BackColor = Color.Green;
                    item._showResult.SetToolTip(item.resultPanel, "Safe");
                }
                #endregion
                #region Event Handlers
                pnlItemInventory.Controls.Add(item); // Adds the Frame
                item.mainFrame.Click += new EventHandler(_itemClick);
                item.mainFrame.MouseEnter += new EventHandler(_selectedItemFocus);
                item.mainFrame.MouseLeave += new EventHandler(_selectedItemUnfocus);
                item.resultPanel.Cursor = Cursors.Default;
                #endregion
            }
            
        }

        private void _LoadItems(object sender, EventArgs e)
        {
            pnlItemInventory.Controls.Clear();

            using (con = new SqlConnection(server))
            {
                string query = @"SELECT * FROM ItemInventory";
                cmd = new SqlCommand(query, con);
                cmd.Connection = con;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                _loadList(reader);
                con.Close();
            }
            _inventoryResize(sender, e);
        }

        public void _refreshItems(object sender, EventArgs e)
        {
            _LoadItems(sender, e);
        }

        public void _hideForm(object sender, EventArgs e)
        {
            if (flow != null)
            {
                flow.Visible = false;
            }
            _inventoryResize(sender, e);
        }

        public void _deletedItem(object sender, EventArgs e)
        {
            pnlMainPanel.Controls.Remove(flow);
            flow.Dispose();
        }

        private void _selectedItemFocus(object sender, EventArgs e)
        {
            Control hover = sender as Control;
            Items item = hover.Parent as Items;

            item.mainFrame.BackColor = ColorTranslator.FromHtml("#7D7D7D");
        }

        private void _selectedItemUnfocus(object sender, EventArgs e)
        {
            Control leave = sender as Control;
            Items item = leave.Parent as Items;

            item.mainFrame.BackColor = SystemColors.ControlDarkDark;
        }

        private void _maximizeSize(object sender, EventArgs e)
        {
            FormWindowState window = this.WindowState; // Current Window called using "this"

            if (window == FormWindowState.Maximized)
            {
                _inventoryResize(sender, e);
            }
            else if (window == FormWindowState.Normal)
            {
                _inventoryResize(sender, e);
            }
        }

        private void _inventoryResize(object sender, EventArgs e)
        {
            foreach (Control control in pnlItemInventory.Controls)
            {
                control.Width = pnlItemInventory.ClientSize.Width - 10;
            }
        }

        private async Task _loadSidebar(Items item = null) // If it is null you can "not" pass an object, if it has a reference than you are able to get any reference from any other method by passing this in
        {
            EditItem edit = null; // supposedly null for reference, if it's a local variable then there is no need for the "null"

            if (item == null) return; // fast kill rule

            pnlItemInventory.SuspendLayout();
            if (flow != null && item.productName == _currentItem.productName)
            {
                flow.Visible = !flow.Visible;
                pnlItemInventory.ResumeLayout();
                Thread.Sleep(25);
                _inventoryResize(this, null);
                return;
            }

            if (flow != null)
            {
                pnlMainPanel.Controls.Remove(flow);
                flow.Dispose();
                flow = null;
            }

            if (flow == null)
            {
                edit = new EditItem(this);

                flow = new Panel();
                flow.BringToFront();
                flow.Dock = DockStyle.Right;
                flow.BackColor = Color.Black;
                flow.Size = new Size(edit.ClientSize.Width, pnlItemInventory.ClientSize.Height);

                edit.Width = flow.ClientSize.Width - 10;
                edit.Dock = DockStyle.Fill;

                edit._itemName = item.productName;
                edit._itemQuantity = item.ProductQuantity;
                edit._itemPrice = item.ProductPrice;
                edit._itemImage = item.ProductImage;

                flow.Controls.Add(edit);
                _currentItem = item;
            }

            await Task.Delay(5);
            flow.Visible = true;

            pnlMainPanel.Controls.Add(pnlItemInventory);
            pnlMainPanel.Controls.Add(flow);
            //pnlMainPanel.Controls.SetChildIndex(flow, 1);

            pnlItemInventory.ResumeLayout();
            _inventoryResize(this, null);
        }

        private void _itemClick(object sender, EventArgs e)
        {
            #region Control Configuration
            Control clickedPanel = sender as Control;
            Items item = clickedPanel.Parent as Items;
            #endregion

            _ = _loadSidebar(item);

            #region Fields
            string itemTag = item.Tag.ToString();
            // Change this for what Tag you want to call e.g., item.Product.Tag.ToString();
            #endregion

            #region New Instances
            EditItem sideBar = new EditItem(this);
            #endregion

            #region Commands
            #endregion
        }

        private void _searchFunction(object sender, EventArgs e)
        {
            pnlItemInventory.Controls.Clear();

            if (string.IsNullOrEmpty(_main.searchInput.Text))
            {
                _refreshItems(sender, e);
                return;
            }

            try
            {
                using (con = new SqlConnection(server))
                {
                    string query = $"SELECT * FROM ItemInventory WHERE ItemName LIKE '%" + _main.searchInput.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        _loadList(reader);
                    }
                    else
                    {
                        reader.Close();
                        cmd.CommandText = @"SELECT * FROM ItemInventory";
                        reader = cmd.ExecuteReader();
                        MessageBox.Show($"Item {_main.searchInput.Text} does not exist.");
                        _main.searchInput.Clear();
                        _loadList(reader);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void _useSearch(object sender, EventArgs e)
        {
            _searchFunction(sender, e);
        }

        private void _buttonOpenAddForm(object sender, EventArgs e)
        {
            AddForm page = new AddForm(this);
            page.StartPosition = FormStartPosition.CenterParent;
            page.Show();
            page.ActiveControl = null;
        }
    }
    #endregion Inventory
}

