using FastmanApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace FastmanApp.UserControls
{
    public partial class Items : UserControl
    {

        //Fields
        public Items()
        {
            InitializeComponent();
            pbItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
            _frameSetting(this);
            this.DoubleBuffered = true;
        }

        private void _frameSetting(Control container)
        {
            #region Label Settings
            foreach (Control control in panel1.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            #endregion
        }

        public ToolTip _showResult
        {
            get { return tInformation; }
        }

        public PictureBox _clickImage
        {
            get { return pbItemImage; }
        }

        public Panel resultPanel
        {
            get { return panel2; }
            set { panel2 = value; }
        }

        public Panel mainFrame
        {
            get { return panel1; }
            set { panel1 = value; }
        }

        public string productName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        public string ProductQuantity
        {
            get { return lblQuantity.Text; }
            set { lblQuantity.Text = value; }
        }
        public string ProductPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public Image ProductImage
        {
            get { return pbItemImage.Image; }
            set { pbItemImage.Image = value; }
        }

    }

}
