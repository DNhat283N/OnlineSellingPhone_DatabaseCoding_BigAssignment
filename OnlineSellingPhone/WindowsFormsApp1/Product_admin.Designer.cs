﻿
namespace WindowsFormsApp1
{
    partial class Product_admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.btnEdit = new WindowsFormsApp1.DSButton();
            this.btnDelete = new WindowsFormsApp1.DSButton();
            this.btnAdd = new WindowsFormsApp1.DSButton();
            this.btnRealme = new WindowsFormsApp1.DSButton();
            this.btnSearch = new WindowsFormsApp1.DSButton();
            this.btnOppo = new WindowsFormsApp1.DSButton();
            this.btnIphone = new WindowsFormsApp1.DSButton();
            this.btnSamsung = new WindowsFormsApp1.DSButton();
            this.btnPricefilter = new WindowsFormsApp1.DSButton();
            this.btnXiaomi = new WindowsFormsApp1.DSButton();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(23, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 36);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.Text = " Tìm kiếm";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pnlProduct
            // 
            this.pnlProduct.AutoScroll = true;
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProduct.Location = new System.Drawing.Point(0, 153);
            this.pnlProduct.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(1171, 443);
            this.pnlProduct.TabIndex = 43;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Salmon;
            this.btnEdit.BackgroundColor = System.Drawing.Color.Salmon;
            this.btnEdit.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderSize = 1;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(988, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 50);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Sửa SP";
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Salmon;
            this.btnDelete.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(814, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 50);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Xóa SP";
            this.btnDelete.TextColor = System.Drawing.Color.Black;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Salmon;
            this.btnAdd.BackgroundColor = System.Drawing.Color.Salmon;
            this.btnAdd.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(637, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 50);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Thêm SP";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRealme
            // 
            this.btnRealme.BackColor = System.Drawing.Color.White;
            this.btnRealme.BackgroundColor = System.Drawing.Color.White;
            this.btnRealme.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRealme.BorderRadius = 20;
            this.btnRealme.BorderSize = 1;
            this.btnRealme.FlatAppearance.BorderSize = 0;
            this.btnRealme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealme.ForeColor = System.Drawing.Color.Black;
            this.btnRealme.Location = new System.Drawing.Point(846, 90);
            this.btnRealme.Name = "btnRealme";
            this.btnRealme.Size = new System.Drawing.Size(159, 50);
            this.btnRealme.TabIndex = 48;
            this.btnRealme.Text = "realme";
            this.btnRealme.TextColor = System.Drawing.Color.Black;
            this.btnRealme.UseVisualStyleBackColor = false;
            this.btnRealme.Click += new System.EventHandler(this.btnRealme_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundColor = System.Drawing.Color.White;
            this.btnSearch.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.BorderSize = 1;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(416, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 50);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnOppo
            // 
            this.btnOppo.BackColor = System.Drawing.Color.White;
            this.btnOppo.BackgroundColor = System.Drawing.Color.White;
            this.btnOppo.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOppo.BorderRadius = 20;
            this.btnOppo.BorderSize = 1;
            this.btnOppo.FlatAppearance.BorderSize = 0;
            this.btnOppo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOppo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOppo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOppo.Location = new System.Drawing.Point(479, 90);
            this.btnOppo.Name = "btnOppo";
            this.btnOppo.Size = new System.Drawing.Size(159, 50);
            this.btnOppo.TabIndex = 46;
            this.btnOppo.Tag = "Product";
            this.btnOppo.Text = "oppo";
            this.btnOppo.TextColor = System.Drawing.Color.SeaGreen;
            this.btnOppo.UseVisualStyleBackColor = false;
            this.btnOppo.Click += new System.EventHandler(this.btnOppo_Click);
            // 
            // btnIphone
            // 
            this.btnIphone.BackColor = System.Drawing.Color.White;
            this.btnIphone.BackgroundColor = System.Drawing.Color.White;
            this.btnIphone.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIphone.BorderRadius = 20;
            this.btnIphone.BorderSize = 1;
            this.btnIphone.FlatAppearance.BorderSize = 0;
            this.btnIphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIphone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIphone.ForeColor = System.Drawing.Color.Black;
            this.btnIphone.Location = new System.Drawing.Point(303, 90);
            this.btnIphone.Name = "btnIphone";
            this.btnIphone.Size = new System.Drawing.Size(159, 50);
            this.btnIphone.TabIndex = 45;
            this.btnIphone.Tag = "Product";
            this.btnIphone.Text = "iPhone";
            this.btnIphone.TextColor = System.Drawing.Color.Black;
            this.btnIphone.UseVisualStyleBackColor = false;
            this.btnIphone.Click += new System.EventHandler(this.btnIphone_Click);
            // 
            // btnSamsung
            // 
            this.btnSamsung.BackColor = System.Drawing.Color.White;
            this.btnSamsung.BackgroundColor = System.Drawing.Color.White;
            this.btnSamsung.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSamsung.BorderRadius = 20;
            this.btnSamsung.BorderSize = 1;
            this.btnSamsung.FlatAppearance.BorderSize = 0;
            this.btnSamsung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSamsung.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSamsung.ForeColor = System.Drawing.Color.Black;
            this.btnSamsung.Location = new System.Drawing.Point(124, 90);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.Size = new System.Drawing.Size(159, 50);
            this.btnSamsung.TabIndex = 44;
            this.btnSamsung.Tag = "Product";
            this.btnSamsung.Text = "SAMSUNG";
            this.btnSamsung.TextColor = System.Drawing.Color.Black;
            this.btnSamsung.UseVisualStyleBackColor = false;
            this.btnSamsung.Click += new System.EventHandler(this.btnSamsung_Click);
            // 
            // btnPricefilter
            // 
            this.btnPricefilter.BackColor = System.Drawing.Color.White;
            this.btnPricefilter.BackgroundColor = System.Drawing.Color.White;
            this.btnPricefilter.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPricefilter.BorderRadius = 20;
            this.btnPricefilter.BorderSize = 1;
            this.btnPricefilter.FlatAppearance.BorderSize = 0;
            this.btnPricefilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPricefilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPricefilter.ForeColor = System.Drawing.Color.Black;
            this.btnPricefilter.Location = new System.Drawing.Point(1052, 94);
            this.btnPricefilter.Name = "btnPricefilter";
            this.btnPricefilter.Size = new System.Drawing.Size(81, 46);
            this.btnPricefilter.TabIndex = 50;
            this.btnPricefilter.Text = "Giá ↑↓";
            this.btnPricefilter.TextColor = System.Drawing.Color.Black;
            this.btnPricefilter.UseVisualStyleBackColor = false;
            this.btnPricefilter.Click += new System.EventHandler(this.btnPricefilter_Click);
            // 
            // btnXiaomi
            // 
            this.btnXiaomi.BackColor = System.Drawing.Color.White;
            this.btnXiaomi.BackgroundColor = System.Drawing.Color.White;
            this.btnXiaomi.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXiaomi.BorderRadius = 20;
            this.btnXiaomi.BorderSize = 1;
            this.btnXiaomi.FlatAppearance.BorderSize = 0;
            this.btnXiaomi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXiaomi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXiaomi.ForeColor = System.Drawing.Color.Black;
            this.btnXiaomi.Location = new System.Drawing.Point(663, 90);
            this.btnXiaomi.Name = "btnXiaomi";
            this.btnXiaomi.Size = new System.Drawing.Size(159, 50);
            this.btnXiaomi.TabIndex = 47;
            this.btnXiaomi.Tag = "Product";
            this.btnXiaomi.Text = "xiaomi";
            this.btnXiaomi.TextColor = System.Drawing.Color.Black;
            this.btnXiaomi.UseVisualStyleBackColor = false;
            this.btnXiaomi.Click += new System.EventHandler(this.btnXiaomi_Click);
            // 
            // Product_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRealme);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOppo);
            this.Controls.Add(this.btnIphone);
            this.Controls.Add(this.btnSamsung);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPricefilter);
            this.Controls.Add(this.btnXiaomi);
            this.Controls.Add(this.pnlProduct);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_admin";
            this.Size = new System.Drawing.Size(1171, 596);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSButton btnRealme;
        private DSButton btnSearch;
        private DSButton btnOppo;
        private DSButton btnIphone;
        private DSButton btnSamsung;
        private System.Windows.Forms.TextBox txtSearch;
        private DSButton btnPricefilter;
        private DSButton btnXiaomi;
        private System.Windows.Forms.Panel pnlProduct;
        private DSButton btnAdd;
        private DSButton btnDelete;
        private DSButton btnEdit;
    }
}
