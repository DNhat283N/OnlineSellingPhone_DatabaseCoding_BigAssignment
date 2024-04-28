﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Product_add_admin : UserControl
    {
        public Product_add_admin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        string filePath;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                pcbProductImage.Image = new Bitmap(filePath);
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Product_admin"))
            //{
                Product_admin Product_admin = new Product_admin();
                Product_admin.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Clear();
                Form1.Instance.PnlContainer.Controls.Add(Product_admin);
            //}
            Form1.Instance.PnlContainer.Controls["Product_admin"].BringToFront();
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            if (!txtColor.Text.StartsWith("#"))
            {
                txtColor.Text = "#";
                txtColor.SelectionStart = txtColor.Text.Length;
            }    
        }

     

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm sản phẩm thành công");
        }
    }
}
