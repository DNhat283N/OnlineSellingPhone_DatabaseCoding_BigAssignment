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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        //private Timer timer;
        //private int panelWidth;
        //private int slideSpeed = 10;
        int currentImageIndex = 0;


        string[] imagePaths = new string[]
        {
            @"D:\OnlineSellingPhone_DatabaseCoding_BigAssignment\OnlineSellingPhone\Image\0.PNG",
            "D:\\OnlineSellingPhone_DatabaseCoding_BigAssignment\\OnlineSellingPhone\\Image\\1.PNG",
            "D:\\OnlineSellingPhone_DatabaseCoding_BigAssignment\\OnlineSellingPhone\\Image\\2.PNG",
            "D:\\OnlineSellingPhone_DatabaseCoding_BigAssignment\\OnlineSellingPhone\\Image\\3.PNG"
        };
        
        private void LoadImage()
        {
            pcbImageBanner2.Image = Image.FromFile(imagePaths[currentImageIndex]);

        }

        private void btnBanner2Previous_Click(object sender, EventArgs e)
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
            }
            else
            {
                currentImageIndex = imagePaths.Length - 1;
            }
            LoadImage();

        }
        private void btnBanner2Next_Click(object sender, EventArgs e)
        {
            if (currentImageIndex < imagePaths.Length - 1)
            {
                currentImageIndex++;
            }
            else
            {
                currentImageIndex = 0;
            }
            LoadImage();
        }

    }
}
