﻿
namespace WindowsFormsApp1
{
    partial class Product_add_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_add_admin));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblForm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblNoName = new System.Windows.Forms.Label();
            this.lblNoManufacturer = new System.Windows.Forms.Label();
            this.lblNoColor = new System.Windows.Forms.Label();
            this.lblNoPrice = new System.Windows.Forms.Label();
            this.lblNoQuantity = new System.Windows.Forms.Label();
            this.cbbManufacturer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLinkImage1 = new System.Windows.Forms.TextBox();
            this.txtLinkImage2 = new System.Windows.Forms.TextBox();
            this.lblNoLinkImage2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtROM = new System.Windows.Forms.TextBox();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.txtBattery = new System.Windows.Forms.TextBox();
            this.lblNoRAM = new System.Windows.Forms.Label();
            this.lblNoROM = new System.Windows.Forms.Label();
            this.lblNoStorage = new System.Windows.Forms.Label();
            this.lblNoBattery = new System.Windows.Forms.Label();
            this.btnClearLinkImage2 = new System.Windows.Forms.Button();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.lblNoLinkImage1 = new System.Windows.Forms.Label();
            this.btnAddLinkImage = new System.Windows.Forms.Button();
            this.btnCancel = new WindowsFormsApp1.DSButton();
            this.btnAdd = new WindowsFormsApp1.DSButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sản phẩm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblForm
            // 
            this.lblForm.BackColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(0, 128);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(1150, 461);
            this.lblForm.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 162);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(366, 32);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhà sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Màu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giá";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(203, 352);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(366, 32);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số lượng";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(203, 410);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 32);
            this.nudQuantity.TabIndex = 12;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // lblNoName
            // 
            this.lblNoName.AutoSize = true;
            this.lblNoName.BackColor = System.Drawing.Color.White;
            this.lblNoName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoName.ForeColor = System.Drawing.Color.Red;
            this.lblNoName.Location = new System.Drawing.Point(226, 197);
            this.lblNoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoName.Name = "lblNoName";
            this.lblNoName.Size = new System.Drawing.Size(211, 17);
            this.lblNoName.TabIndex = 41;
            this.lblNoName.Text = "* Vui lòng nhập tên sản phẩm";
            // 
            // lblNoManufacturer
            // 
            this.lblNoManufacturer.AutoSize = true;
            this.lblNoManufacturer.BackColor = System.Drawing.Color.White;
            this.lblNoManufacturer.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoManufacturer.ForeColor = System.Drawing.Color.Red;
            this.lblNoManufacturer.Location = new System.Drawing.Point(226, 261);
            this.lblNoManufacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoManufacturer.Name = "lblNoManufacturer";
            this.lblNoManufacturer.Size = new System.Drawing.Size(203, 17);
            this.lblNoManufacturer.TabIndex = 42;
            this.lblNoManufacturer.Text = "* Vui lòng nhập nhà sản xuất";
            // 
            // lblNoColor
            // 
            this.lblNoColor.AutoSize = true;
            this.lblNoColor.BackColor = System.Drawing.Color.White;
            this.lblNoColor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoColor.ForeColor = System.Drawing.Color.Red;
            this.lblNoColor.Location = new System.Drawing.Point(226, 323);
            this.lblNoColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoColor.Name = "lblNoColor";
            this.lblNoColor.Size = new System.Drawing.Size(177, 17);
            this.lblNoColor.TabIndex = 43;
            this.lblNoColor.Text = "* Vui lòng nhập mã màu";
            // 
            // lblNoPrice
            // 
            this.lblNoPrice.AutoSize = true;
            this.lblNoPrice.BackColor = System.Drawing.Color.White;
            this.lblNoPrice.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPrice.ForeColor = System.Drawing.Color.Red;
            this.lblNoPrice.Location = new System.Drawing.Point(226, 387);
            this.lblNoPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoPrice.Name = "lblNoPrice";
            this.lblNoPrice.Size = new System.Drawing.Size(139, 17);
            this.lblNoPrice.TabIndex = 44;
            this.lblNoPrice.Text = "* Vui lòng nhập giá";
            // 
            // lblNoQuantity
            // 
            this.lblNoQuantity.AutoSize = true;
            this.lblNoQuantity.BackColor = System.Drawing.Color.White;
            this.lblNoQuantity.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblNoQuantity.Location = new System.Drawing.Point(226, 444);
            this.lblNoQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoQuantity.Name = "lblNoQuantity";
            this.lblNoQuantity.Size = new System.Drawing.Size(245, 17);
            this.lblNoQuantity.TabIndex = 45;
            this.lblNoQuantity.Text = "* Vui lòng chỉnh số lượng sản phẩm";
            // 
            // cbbManufacturer
            // 
            this.cbbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbManufacturer.FormattingEnabled = true;
            this.cbbManufacturer.Items.AddRange(new object[] {
            "Samsung",
            "Apple",
            "Oppo",
            "Xiaomi",
            "Realme"});
            this.cbbManufacturer.Location = new System.Drawing.Point(203, 229);
            this.cbbManufacturer.Name = "cbbManufacturer";
            this.cbbManufacturer.Size = new System.Drawing.Size(366, 31);
            this.cbbManufacturer.TabIndex = 46;
            this.cbbManufacturer.SelectedIndexChanged += new System.EventHandler(this.cbbManufacturer_SelectedIndexChanged);
            this.cbbManufacturer.TextChanged += new System.EventHandler(this.cbbManufacturer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Hình ảnh";
            // 
            // txtLinkImage1
            // 
            this.txtLinkImage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkImage1.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLinkImage1.Location = new System.Drawing.Point(203, 473);
            this.txtLinkImage1.Name = "txtLinkImage1";
            this.txtLinkImage1.Size = new System.Drawing.Size(366, 32);
            this.txtLinkImage1.TabIndex = 48;
            this.txtLinkImage1.Text = "Link URL hình ảnh 1";
            // 
            // txtLinkImage2
            // 
            this.txtLinkImage2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkImage2.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLinkImage2.Location = new System.Drawing.Point(202, 528);
            this.txtLinkImage2.Name = "txtLinkImage2";
            this.txtLinkImage2.Size = new System.Drawing.Size(366, 32);
            this.txtLinkImage2.TabIndex = 50;
            this.txtLinkImage2.Text = "Link URL hình ảnh 2";
            this.txtLinkImage2.Visible = false;
            // 
            // lblNoLinkImage2
            // 
            this.lblNoLinkImage2.AutoSize = true;
            this.lblNoLinkImage2.BackColor = System.Drawing.Color.White;
            this.lblNoLinkImage2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLinkImage2.ForeColor = System.Drawing.Color.Red;
            this.lblNoLinkImage2.Location = new System.Drawing.Point(226, 563);
            this.lblNoLinkImage2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoLinkImage2.Name = "lblNoLinkImage2";
            this.lblNoLinkImage2.Size = new System.Drawing.Size(203, 17);
            this.lblNoLinkImage2.TabIndex = 51;
            this.lblNoLinkImage2.Text = "* Vui lòng nhập link hình ảnh";
            this.lblNoLinkImage2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(658, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "RAM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(658, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 23);
            this.label10.TabIndex = 53;
            this.label10.Text = "ROM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(658, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 23);
            this.label11.TabIndex = 54;
            this.label11.Text = "Dung lượng lưu trữ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(658, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 23);
            this.label12.TabIndex = 55;
            this.label12.Text = "Pin";
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(747, 162);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(366, 32);
            this.txtRAM.TabIndex = 56;
            this.txtRAM.TextChanged += new System.EventHandler(this.txtRAM_TextChanged);
            // 
            // txtROM
            // 
            this.txtROM.Location = new System.Drawing.Point(747, 226);
            this.txtROM.Name = "txtROM";
            this.txtROM.Size = new System.Drawing.Size(366, 32);
            this.txtROM.TabIndex = 57;
            this.txtROM.TextChanged += new System.EventHandler(this.txtROM_TextChanged);
            // 
            // txtStorage
            // 
            this.txtStorage.Location = new System.Drawing.Point(865, 288);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.Size = new System.Drawing.Size(248, 32);
            this.txtStorage.TabIndex = 58;
            this.txtStorage.TextChanged += new System.EventHandler(this.txtStorage_TextChanged);
            // 
            // txtBattery
            // 
            this.txtBattery.Location = new System.Drawing.Point(747, 346);
            this.txtBattery.Name = "txtBattery";
            this.txtBattery.Size = new System.Drawing.Size(366, 32);
            this.txtBattery.TabIndex = 59;
            this.txtBattery.TextChanged += new System.EventHandler(this.txtBattery_TextChanged);
            // 
            // lblNoRAM
            // 
            this.lblNoRAM.AutoSize = true;
            this.lblNoRAM.BackColor = System.Drawing.Color.White;
            this.lblNoRAM.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRAM.ForeColor = System.Drawing.Color.Red;
            this.lblNoRAM.Location = new System.Drawing.Point(797, 197);
            this.lblNoRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoRAM.Name = "lblNoRAM";
            this.lblNoRAM.Size = new System.Drawing.Size(149, 17);
            this.lblNoRAM.TabIndex = 60;
            this.lblNoRAM.Text = "* Vui lòng nhập RAM";
            // 
            // lblNoROM
            // 
            this.lblNoROM.AutoSize = true;
            this.lblNoROM.BackColor = System.Drawing.Color.White;
            this.lblNoROM.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoROM.ForeColor = System.Drawing.Color.Red;
            this.lblNoROM.Location = new System.Drawing.Point(797, 261);
            this.lblNoROM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoROM.Name = "lblNoROM";
            this.lblNoROM.Size = new System.Drawing.Size(151, 17);
            this.lblNoROM.TabIndex = 61;
            this.lblNoROM.Text = "* Vui lòng nhập ROM";
            // 
            // lblNoStorage
            // 
            this.lblNoStorage.AutoSize = true;
            this.lblNoStorage.BackColor = System.Drawing.Color.White;
            this.lblNoStorage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoStorage.ForeColor = System.Drawing.Color.Red;
            this.lblNoStorage.Location = new System.Drawing.Point(868, 326);
            this.lblNoStorage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoStorage.Name = "lblNoStorage";
            this.lblNoStorage.Size = new System.Drawing.Size(194, 17);
            this.lblNoStorage.TabIndex = 62;
            this.lblNoStorage.Text = "* Vui lòng nhập dung lượng";
            // 
            // lblNoBattery
            // 
            this.lblNoBattery.AutoSize = true;
            this.lblNoBattery.BackColor = System.Drawing.Color.White;
            this.lblNoBattery.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBattery.ForeColor = System.Drawing.Color.Red;
            this.lblNoBattery.Location = new System.Drawing.Point(797, 387);
            this.lblNoBattery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoBattery.Name = "lblNoBattery";
            this.lblNoBattery.Size = new System.Drawing.Size(139, 17);
            this.lblNoBattery.TabIndex = 63;
            this.lblNoBattery.Text = "* Vui lòng nhập pin";
            // 
            // btnClearLinkImage2
            // 
            this.btnClearLinkImage2.BackColor = System.Drawing.Color.White;
            this.btnClearLinkImage2.FlatAppearance.BorderSize = 0;
            this.btnClearLinkImage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLinkImage2.Image = ((System.Drawing.Image)(resources.GetObject("btnClearLinkImage2.Image")));
            this.btnClearLinkImage2.Location = new System.Drawing.Point(575, 528);
            this.btnClearLinkImage2.Name = "btnClearLinkImage2";
            this.btnClearLinkImage2.Size = new System.Drawing.Size(37, 33);
            this.btnClearLinkImage2.TabIndex = 65;
            this.btnClearLinkImage2.UseVisualStyleBackColor = false;
            this.btnClearLinkImage2.Visible = false;
            this.btnClearLinkImage2.Click += new System.EventHandler(this.btnClearLinkImage2_Click);
            // 
            // cbbColor
            // 
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Items.AddRange(new object[] {
            "Đen",
            "Trắng",
            "Xanh lá",
            "Thêm màu khác..."});
            this.cbbColor.Location = new System.Drawing.Point(202, 289);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(367, 31);
            this.cbbColor.TabIndex = 66;
            this.cbbColor.TextChanged += new System.EventHandler(this.cbbColor_TextChanged);
            // 
            // lblNoLinkImage1
            // 
            this.lblNoLinkImage1.AutoSize = true;
            this.lblNoLinkImage1.BackColor = System.Drawing.Color.White;
            this.lblNoLinkImage1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLinkImage1.ForeColor = System.Drawing.Color.Red;
            this.lblNoLinkImage1.Location = new System.Drawing.Point(226, 508);
            this.lblNoLinkImage1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoLinkImage1.Name = "lblNoLinkImage1";
            this.lblNoLinkImage1.Size = new System.Drawing.Size(203, 17);
            this.lblNoLinkImage1.TabIndex = 67;
            this.lblNoLinkImage1.Text = "* Vui lòng nhập link hình ảnh";
            // 
            // btnAddLinkImage
            // 
            this.btnAddLinkImage.BackColor = System.Drawing.Color.White;
            this.btnAddLinkImage.FlatAppearance.BorderSize = 0;
            this.btnAddLinkImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLinkImage.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLinkImage.Image")));
            this.btnAddLinkImage.Location = new System.Drawing.Point(575, 473);
            this.btnAddLinkImage.Name = "btnAddLinkImage";
            this.btnAddLinkImage.Size = new System.Drawing.Size(37, 33);
            this.btnAddLinkImage.TabIndex = 68;
            this.btnAddLinkImage.UseVisualStyleBackColor = false;
            this.btnAddLinkImage.Click += new System.EventHandler(this.btnAddLinkImage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(334, 604);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 51);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Salmon;
            this.btnAdd.BackgroundColor = System.Drawing.Color.Salmon;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(142, 604);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 51);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Product_add_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnAddLinkImage);
            this.Controls.Add(this.lblNoLinkImage1);
            this.Controls.Add(this.cbbColor);
            this.Controls.Add(this.btnClearLinkImage2);
            this.Controls.Add(this.lblNoBattery);
            this.Controls.Add(this.lblNoStorage);
            this.Controls.Add(this.lblNoROM);
            this.Controls.Add(this.lblNoRAM);
            this.Controls.Add(this.txtBattery);
            this.Controls.Add(this.txtStorage);
            this.Controls.Add(this.txtROM);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNoLinkImage2);
            this.Controls.Add(this.txtLinkImage2);
            this.Controls.Add(this.txtLinkImage1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbManufacturer);
            this.Controls.Add(this.lblNoQuantity);
            this.Controls.Add(this.lblNoPrice);
            this.Controls.Add(this.lblNoColor);
            this.Controls.Add(this.lblNoManufacturer);
            this.Controls.Add(this.lblNoName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblForm);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_add_admin";
            this.Size = new System.Drawing.Size(1087, 533);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private DSButton btnAdd;
        private DSButton btnCancel;
        private System.Windows.Forms.Label lblNoName;
        private System.Windows.Forms.Label lblNoManufacturer;
        private System.Windows.Forms.Label lblNoColor;
        private System.Windows.Forms.Label lblNoPrice;
        private System.Windows.Forms.Label lblNoQuantity;
        private System.Windows.Forms.ComboBox cbbManufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLinkImage1;
        private System.Windows.Forms.TextBox txtLinkImage2;
        private System.Windows.Forms.Label lblNoLinkImage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtROM;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.TextBox txtBattery;
        private System.Windows.Forms.Label lblNoRAM;
        private System.Windows.Forms.Label lblNoROM;
        private System.Windows.Forms.Label lblNoStorage;
        private System.Windows.Forms.Label lblNoBattery;
        private System.Windows.Forms.Button btnClearLinkImage2;
        private System.Windows.Forms.ComboBox cbbColor;
        private System.Windows.Forms.Label lblNoLinkImage1;
        private System.Windows.Forms.Button btnAddLinkImage;
    }
}
