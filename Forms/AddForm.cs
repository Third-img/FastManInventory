using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastmanApp.Properties;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens; //SQL

namespace FastmanApp.Forms
{
    public partial class AddForm : Form
    {
        #region Fields
        Inventory _inventoryForm;
        private int _uID;
        private string SKU;
        private string imagePath;
        #endregion
        #region SQL Template
        string server = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FastManApp;Integrated Security=True;Trust Server Certificate=True";
        Microsoft.Data.SqlClient.SqlConnection con;
        Microsoft.Data.SqlClient.SqlCommand cmd;
        #endregion

        public AddForm(Inventory inventoryForm = null)
        {
            InitializeComponent();
            this.Load += _comboBoxSettings;
            this.Load += EditButtons;
            this.Load += btnBrowse_Click;
            _selectAllControls(this);
            _inventoryForm = inventoryForm;
        }

        private void _imageTP(object sender, EventArgs e)
        {
            ToolTip tp = null;

            if (tp != null) { return; }

            if (tp == null)
            {
                tp = new ToolTip();
                tp.SetToolTip(pbItemImage, "Browse Image");
            }
        }

        #region SKU Generator
        private string GenerateSKU(int uid)
        {
            string fixedCategory = "";
            switch (cbCategory.Text)
            {
                case "Chemicals":
                    fixedCategory = "CHM";
                    break;
                case "Pool Accessories":
                    fixedCategory = "PAC";
                    break;
                case "Pool Pumps":
                    fixedCategory = "PUM";
                    break;
                case "Pool Filters":
                    fixedCategory = "FIL";
                    break;
                case "Others":
                    fixedCategory = "OTH";
                    break;
            }
            var generatedSKU = tbName.Text.Substring(0, 4).ToUpper() + uniqueID + fixedCategory.Substring(0,3).ToUpper() + DateTime.Now.Year.ToString().Substring(2);
            return generatedSKU;
        }
        #endregion

        #region Combo Box Settings
        private void _comboBoxSettings(object sender, EventArgs e)
        {
            string[] category = {"Chemicals", "Pool Accessories", "Pool Pumps",  "Pool Filters", "Others"};
            string[] unitOfMeasure = {"Each", "Case", "KG", "Liter"};

            #region Category
            cbCategory.Text = "Category";
            cbCategory.Items.AddRange(category);
            cbCategory.ForeColor = SystemColors.GrayText;
            cbCategory.Font = new Font(cbUOM.Font, FontStyle.Bold);
            cbCategory.TextChanged += (s, eventArgs) =>
            {
                cbCategory.ForeColor = SystemColors.ControlText;
                cbCategory.Font = new Font(cbCategory.Font, FontStyle.Regular);
            };
            cbCategory.KeyDown += (s, eventArgs) => { eventArgs.SuppressKeyPress = true; };
            #endregion

            #region Unit Of Measure
            cbUOM.Items.AddRange(unitOfMeasure);
            cbUOM.SelectedText = "KG";
            cbUOM.Text = cbUOM.SelectedText.ToString();
            cbUOM.ForeColor = SystemColors.GrayText;
            cbUOM.Font = new Font(cbUOM.Font, FontStyle.Bold);
            cbUOM.TextChanged += (s, eventArgs) =>
            {
                cbUOM.ForeColor = SystemColors.ControlText;
                cbUOM.Font = new Font(cbUOM.Font, FontStyle.Regular);
            };
            cbUOM.KeyDown += (s, eventArgs) => { eventArgs.SuppressKeyPress = true; };
            cbUOM.SelectionLength = 0;
            #endregion

            #region Quantity
            nudQuantity.ValueChanged += (s, eventArgs) =>
            {
                nudQuantity.ForeColor = SystemColors.ControlText;
            };
            
            #endregion
        }
        #endregion

        #region Textbox Settings
        private void _textSettings(TextBox holder)
        {
            string placeHolder = "";
            placeHolder = holder.Name.ToString().Substring(2);
            holder.Text = placeHolder;

            holder.Font = new Font(holder.Font, FontStyle.Bold);
            holder.ForeColor = SystemColors.GrayText;

            holder.TextChanged += (sender, e) =>
            {
                holder.Font = new Font(holder.Font, FontStyle.Regular);
            };
            holder.LostFocus += (sender, e) =>
            {
                if (holder.Text == "".Trim())
                {
                    holder.Text = placeHolder;
                    holder.ForeColor = SystemColors.GrayText;
                    holder.Font = new Font(holder.Font, FontStyle.Bold);
                }
            };
            holder.GotFocus += (sender, e) => _removePlaceholder(holder, placeHolder);
        }

        private void _selectAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox tb)
                {
                    _textSettings(tb);
                    
                }

                if (control is NumericUpDown qty)
                {
                    qty.ForeColor = SystemColors.GrayText;
                    continue;
                }

                if (control.HasChildren)
                {
                    _selectAllControls(control);
                }
            }

        }
        #endregion

        #region Edit Settings
        private void EditButtons(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();

            pbEdit2.Click += (s, eventArgs) => 
            {
                nudRQ.Enabled = !nudRQ.Enabled;
            };

            pbEdit1.Click += (s, eventArgs) =>
            {
                nudRL.Enabled = !nudRL.Enabled;

            };
        }
        #endregion

        private void _removePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.ControlText;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            pbItemImage.MouseClick += (s, eventArgs) =>
            {
                if (eventArgs.Button == MouseButtons.Right)
                {
                    imagePath = "";
                    pbItemImage.Image = Resources._imagepicker2;
                }
                if (eventArgs.Button == MouseButtons.Left)
                {
                    using (OpenFileDialog ofd = new OpenFileDialog())
                    {
                        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            pbItemImage.Image = Image.FromFile(ofd.FileName);
                            imagePath = ofd.FileName;
                        }
                    }
                }
            };
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            bool noError = true; // Error Checker

            #region Clear for Null Return
            if (tbDescription.Text.ToLower() == "description")
            {
                tbDescription.Clear();
            }

            if (tbURL.Text.ToLower() == "url")
            {
                tbURL.Clear();
            }
            #endregion

            #region Connection Settings
            con = new SqlConnection(server);
            cmd = new SqlCommand();
            cmd.Connection = con;
            #endregion

            #region Image Data
            byte[] imageData = { };
            try
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image is null.");
            }
            #endregion

            using (con)
            {
                try
                {
                    con.Open();
                    string query = @"INSERT INTO ItemInventory(ItemName,ItemImage,ItemQuantity,ItemCategory,ItemUOM,ItemDesc,ItemWeight,ItemRL,ItemRQ) 
                                    VALUES(@Name,@Img,@Quantity,@ItemCategory,@UOM,@Description,@Weight,@RLevel,@RQuantity);
                                    SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name", tbName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", nudQuantity.Value);
                    cmd.Parameters.AddWithValue("@Img", tbURL.Text);
                    if (cbCategory.Text.ToLower() == "category")
                    {
                        con.Close(); // Close before throwin an exception
                        throw new Exception($"Please select a {cbCategory.Text}.");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ItemCategory", cbCategory.Text);
                    }
                    cmd.Parameters.AddWithValue("@UOM", cbUOM.Text);
                    cmd.Parameters.AddWithValue("@Description", tbDescription.Text);
                    cmd.Parameters.AddWithValue("@Weight", tbWeight.Text);
                    cmd.Parameters.AddWithValue("@RLevel", (int)nudRL.Value);
                    cmd.Parameters.AddWithValue("@RQuantity", (int)nudRQ.Value);

                    uniqueID = Convert.ToInt32(cmd.ExecuteScalar());

                    string updateQuery = "UPDATE ItemInventory SET ItemCode = @SKU WHERE ID = @ID";
                    using (SqlCommand update = new SqlCommand(updateQuery, con))
                    {
                        update.Parameters.AddWithValue("@SKU", GenerateSKU(uniqueID));
                        update.Parameters.AddWithValue("@ID", uniqueID);
                        update.ExecuteNonQuery();
                    }

                    string imageQuery = "UPDATE ItemInventory SET ImageBlob = @FileImage WHERE ID = @ID";
                    using (SqlCommand imageUpdate = new SqlCommand(imageQuery, con))
                    {
                        imageUpdate.Parameters.AddWithValue("@FileImage", imageData);
                        imageUpdate.Parameters.AddWithValue("@ID", uniqueID);
                    }

                    MessageBox.Show($"Item: {tbName.Text},\n ID: {uniqueID}.", "Item created.");


                    if (noError)
                    {
                        foreach (Control control in pnlAddForm.Controls)
                        {
                            if (control is TextBox tb)
                            {
                                tb.Text = tb.Name.ToString().Substring(2);
                                tb.ForeColor = SystemColors.GrayText;
                            }

                            if (control is NumericUpDown qty)
                            {
                                qty.Value = 0;
                                qty.ForeColor = SystemColors.GrayText;
                            }
                        }
                        _inventoryForm._refreshItems(sender, e);
                    }
                    con.Close();
                }
                catch (SqlException error)
                {
                    if (error.Number == 2627) // PK & Unique Key Violation
                    {
                        MessageBox.Show($"{tbName.Text} already exists.");
                        tbName.Clear();
                    }
                    if (error.Number == 8114)
                    {
                        MessageBox.Show($"Must be an integer.");
                    }
                    //MessageBox.Show(error.Number.ToString());
                    noError = false;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            } // End of using

            #region Controls Setting
            foreach (Control control in pnlAddForm.Controls)
            {
                if (control is TextBox tb)
                {
                    tb.Font = new Font(tb.Font, FontStyle.Bold);
                    tb.ForeColor = SystemColors.GrayText;
                }
            }
            _comboBoxSettings(sender, e);
            _selectAllControls(this);
            #endregion
        }

        public int uniqueID
        {
            get { return _uID; }
            set { _uID = value; }
        }
    }
}
