#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastmanApp.UserControls;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
#endregion

namespace FastmanApp.Forms
{
    public partial class MainMenu : Form
    {
        #region Fields
        private AddForm addItem;
        private Panel flow;
        private Inventory inventory;
        private Items _currentItem = null;
        #endregion
        #region SQL Template
        string server = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FastManApp;Integrated Security=True;Trust Server Certificate=True";
        Microsoft.Data.SqlClient.SqlConnection con;
        Microsoft.Data.SqlClient.SqlCommand cmd;

        public Color SystemColo { get; private set; }
        #endregion

        public MainMenu()
        {
            InitializeComponent();
            this.Load += _mainTabSettings;
            this.Load += _openInventory;
            this.Load += _uiSettings;
        }

        private void _uiSettings(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#121212");
        }

        #region Tabs
        private void _mainTabSettings(object sender, EventArgs e)
        {
            panel1.Select();

            #region Search Button Settings
            tbSearch.ForeColor = SystemColors.GrayText;
            tbSearch.Font = new Font(tbSearch.Font, FontStyle.Italic);
            tbSearch.Text = "Look Up";
            tbSearch.GotFocus += (s, eventArgs) =>
            {
                if (tbSearch.Text == "Look Up")
                {
                    tbSearch.Clear();
                }
            };
            tbSearch.LostFocus += (s, eventArgs) =>
            {
                if (string.IsNullOrEmpty(tbSearch.Text))
                {
                    if (!button2.Focused && !tbSearch.Focused)
                    {
                        tbSearch.ForeColor = SystemColors.GrayText;
                        tbSearch.Font = new Font(tbSearch.Font, FontStyle.Italic);
                        tbSearch.Text = "Look Up";
                    }
                }
            };
            tbSearch.TextChanged += (s, eventArgs) =>
            {
                if (!string.IsNullOrEmpty(tbSearch.Text) && tbSearch.Text != "Look Up")
                {
                    tbSearch.Font = new Font(tbSearch.Font, FontStyle.Regular);
                    tbSearch.ForeColor = Color.Black;
                }
            };
            tbSearch.KeyPress += (s, eventArgs) =>
            {
                if (eventArgs.KeyChar == (char)Keys.Enter)
                {
                    eventArgs.Handled = true;
                    inventory._useSearch(s, eventArgs);
                    
                }
            };
            #endregion
        }

        private void _openDashboard(object sender, EventArgs e)
        {
            inventory?.Hide();
        }

        private void _openInventory(object sender, EventArgs e)
        {
            if (inventory == null)
            {
                inventory = new Inventory(this);
                inventory.Dock = DockStyle.Fill;
                inventory.TopLevel = false;
            }

            if (inventory != null)
            {
                inventory.Show();
                pnlInventory.Controls.Add(inventory);
                inventory.BringToFront();
                inventory._refreshItems(sender, e);
            }
        }

        private void _openAddForm(object sender, EventArgs e)
        {
            if (addItem != null) return;

            if (addItem == null)
            {
                addItem = new AddForm(inventory);
                addItem.Show();
                addItem.ActiveControl = null;
            }

            addItem.FormClosed += (s, eventArgs) =>
            {
                addItem.Dispose();
                addItem = null;
                return;
            };
        }
        #endregion
        public Panel inventoryPanel
        {
            get => pnlInventory;
            set => pnlInventory = value;
        }

        private void _searchFunction(object sender, EventArgs e)
        {
            inventory._useSearch(sender, e);
        }

        public Panel menuPanel
        {
            get => panel1;
            set => panel1 = value;
        }

        public System.Windows.Forms.TextBox searchInput
        {
            get => tbSearch;
            set => tbSearch = value;
        }
    }
}
