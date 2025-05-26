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
using System.Xml.Linq;
using System.IO;
using System.Net;

namespace FastmanApp
{
    public partial class InventoryLog : Form
    {
        //Fields
        Microsoft.Data.SqlClient.SqlConnection con;
        Microsoft.Data.SqlClient.SqlCommand cmd;
        int col = 0;

        public InventoryLog()
        {
            InitializeComponent();
        }

        private void loadPanel()
        {
            string server = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FastManApp;Integrated Security=True;Trust Server Certificate=True";
            con = new SqlConnection(server);
            cmd = new SqlCommand();
            cmd.Connection = con;

            using (con)
            {
                string query = @"SELECT * FROM INVENTORY";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Product Size
                    FlowLayoutPanel itemPanel = new FlowLayoutPanel();
                    itemPanel.Height = 100;
                    itemPanel.Width = this.ClientSize.Width - 10;
                    itemPanel.WrapContents = true;
                    itemPanel.FlowDirection = FlowDirection.TopDown;
                    itemPanel.Margin = new Padding(2);
                    itemPanel.Padding = new Padding(10, 5, 10, 5);
                    itemPanel.BorderStyle = BorderStyle.FixedSingle;

                    // Product Name
                    Label productName = new Label();
                    productName.Text = reader["ItemName"].ToString();
                    productName.AutoSize = true;
                    productName.TextAlign = ContentAlignment.MiddleCenter;


                    // Product Price
                    Label productPrice = new Label();
                    productPrice.Text = "₱" + reader["ItemPrice"].ToString();
                    productPrice.AutoSize = true;
                    productPrice.TextAlign = ContentAlignment.MiddleCenter;

                    //Alter Product Image URL
                    PictureBox image = new PictureBox();
                    string imagePath = reader["ItemImage"].ToString();
                    image.SizeMode = PictureBoxSizeMode.Zoom;
                    image.Height = 80;
                    image.Width = 80;


                    string imageUrl = reader["ItemImage"].ToString();
                    try
                    {
                        using (WebClient wc = new WebClient())
                        {
                            byte[] imageBytes = wc.DownloadData(imageUrl);
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    catch
                    {
                        image.BackColor = Color.Black;
                    }
                   


                    // Product Quantity
                    Label productQuantity = new Label();
                    productQuantity.Text = reader["ItemQuantity"].ToString();

                    itemPanel.Controls.Add(image);
                    itemPanel.Controls.Add(productName);
                    itemPanel.Controls.Add(productPrice);

                    flpItems.Controls.Add(itemPanel);

                }
            }
        }

        private void lblAddButton_Click(object sender, EventArgs e)
        {
            Form window = new Forms.AddForm();
            window.Show();
            window.ActiveControl = null;
        }


        private void InventoryLog_Load(object sender, EventArgs e)
        {
            flpItems.Controls.Clear();
            loadPanel();
        }
        private void lblRefresh_Click(object sender, EventArgs e)
        {
            flpItems.Controls.Clear();
            loadPanel();
        }
    }
}
