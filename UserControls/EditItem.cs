using FastmanApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Channels;

namespace FastmanApp.UserControls
{
    public partial class EditItem : UserControl
    {
        #region Fields
        private Inventory _inventoryForm;
        #endregion
        #region SQL Template
        string server = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FastManApp;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection conn;
        SqlCommand cmd;
        #endregion


        public EditItem(Inventory inventoryForm = null)
        {
            this.Load += _uiSettings;
            InitializeComponent();
            _inventoryForm = inventoryForm;
        }

        private void _uiSettings(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1d1f20");
            foreach (Control control in this.Controls)
            {
                if (control is TextBox tb)
                {
                    tb.BackColor = this.BackColor;
                    tb.ForeColor = ColorTranslator.FromHtml("#f4f5f7");
                }
            }
        }

        private void _deleteToolTip(object sender, EventArgs e)
        {
            tpSelect.SetToolTip(pbDeleteButton, "Delete");
        }

        private void _editToolTip(object sender, EventArgs e)
        {
            tpSelect.SetToolTip(pbEditButton, "Edit");
        }

        private void _editButton(object sender, EventArgs e)
        {
            if (!tbName.Enabled)
            {
                var query = MessageBox.Show(
                "Are you sure you want to edit?", // Body
                "Confirmation", // Title
                MessageBoxButtons.YesNo);


                if (query == DialogResult.Yes)
                {
                    tbName.Enabled = !tbName.Enabled;
                    tbPrice.Enabled = !tbPrice.Enabled;
                    nmQuantity.Enabled = !nmQuantity.Enabled;
                    tbSync.Enabled = !tbSync.Enabled;
                }
            }
            else if (tbName.Enabled)
            {
                var query = MessageBox.Show(
                "Are you done editing?", // Body
                "Confirmation", // Title
                MessageBoxButtons.YesNo);

                if (query == DialogResult.Yes)
                {
                    tbName.Enabled = !tbName.Enabled;
                    tbPrice.Enabled = !tbPrice.Enabled;
                    nmQuantity.Enabled = !nmQuantity.Enabled;
                    tbSync.Enabled = !tbSync.Enabled;
                }
            }
        }

        private void _deleteButton(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete?", 
                "Confirm", 
                MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                using (conn = new SqlConnection(server))
                {
                    using (cmd = new SqlCommand("DELETE FROM ItemInventory WHERE ItemName = @Name", conn))
                    {
                        cmd.Connection = conn;


                        cmd.Parameters.AddWithValue("@Name", tbName.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        _inventoryForm._refreshItems(sender, e);
                        _inventoryForm._hideForm(sender, e);
                        MessageBox.Show($"{tbName.Text} has been deleted.");
                    }
                }
                _inventoryForm._deletedItem(sender, e);
            } // End of if
        }

        #region Getters and Setters
        public string _itemName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        public string _itemPrice
        {
            get { return tbPrice.Text; }
            set { tbPrice.Text = value; }
        }

        public string _itemQuantity
        {
            get { return nmQuantity.ToString(); }
            set { nmQuantity.Text = value; }
        }

        public Image _itemImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }
        #endregion

    }
}
