﻿using System.Drawing;
using System.Windows.Forms;

namespace QLQuanAn
{
    partial class fAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.txbIndexPageBill = new System.Windows.Forms.TextBox();
            this.btnNextBillPage = new System.Windows.Forms.Button();
            this.btnPrevioursBillPage = new System.Windows.Forms.Button();
            this.btnLastBillPage = new System.Windows.Forms.Button();
            this.btnFirstBillPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txbNameCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel20 = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.txbTableStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txbTableID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel27 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btnRessetPasword = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.nmAccountType = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tpFood.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.tpCategory.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tpCategory);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(10, 10);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(705, 465);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.txbIndexPageBill);
            this.tpBill.Controls.Add(this.btnNextBillPage);
            this.tpBill.Controls.Add(this.btnPrevioursBillPage);
            this.tpBill.Controls.Add(this.btnLastBillPage);
            this.tpBill.Controls.Add(this.btnFirstBillPage);
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(697, 439);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Danh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // txbIndexPageBill
            // 
            this.txbIndexPageBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIndexPageBill.Location = new System.Drawing.Point(291, 413);
            this.txbIndexPageBill.Name = "txbIndexPageBill";
            this.txbIndexPageBill.Size = new System.Drawing.Size(80, 29);
            this.txbIndexPageBill.TabIndex = 6;
            this.txbIndexPageBill.Text = "1";
            this.txbIndexPageBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbIndexPageBill.TextChanged += new System.EventHandler(this.txbIndexPageBill_TextChanged);
            // 
            // btnNextBillPage
            // 
            this.btnNextBillPage.Location = new System.Drawing.Point(559, 416);
            this.btnNextBillPage.Name = "btnNextBillPage";
            this.btnNextBillPage.Size = new System.Drawing.Size(64, 20);
            this.btnNextBillPage.TabIndex = 5;
            this.btnNextBillPage.Text = "Next";
            this.btnNextBillPage.UseVisualStyleBackColor = true;
            this.btnNextBillPage.Click += new System.EventHandler(this.btnNextBillPage_Click);
            // 
            // btnPrevioursBillPage
            // 
            this.btnPrevioursBillPage.Location = new System.Drawing.Point(75, 416);
            this.btnPrevioursBillPage.Name = "btnPrevioursBillPage";
            this.btnPrevioursBillPage.Size = new System.Drawing.Size(64, 20);
            this.btnPrevioursBillPage.TabIndex = 4;
            this.btnPrevioursBillPage.Text = "Previours";
            this.btnPrevioursBillPage.UseVisualStyleBackColor = true;
            this.btnPrevioursBillPage.Click += new System.EventHandler(this.btnPrevioursBillPage_Click);
            // 
            // btnLastBillPage
            // 
            this.btnLastBillPage.Location = new System.Drawing.Point(628, 416);
            this.btnLastBillPage.Name = "btnLastBillPage";
            this.btnLastBillPage.Size = new System.Drawing.Size(64, 20);
            this.btnLastBillPage.TabIndex = 3;
            this.btnLastBillPage.Text = "Last";
            this.btnLastBillPage.UseVisualStyleBackColor = true;
            this.btnLastBillPage.Click += new System.EventHandler(this.btnLastBillPage_Click);
            // 
            // btnFirstBillPage
            // 
            this.btnFirstBillPage.Location = new System.Drawing.Point(5, 416);
            this.btnFirstBillPage.Name = "btnFirstBillPage";
            this.btnFirstBillPage.Size = new System.Drawing.Size(64, 20);
            this.btnFirstBillPage.TabIndex = 2;
            this.btnFirstBillPage.Text = "First";
            this.btnFirstBillPage.UseVisualStyleBackColor = true;
            this.btnFirstBillPage.Click += new System.EventHandler(this.btnFirstBillPage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Location = new System.Drawing.Point(8, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 42);
            this.panel2.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(297, 3);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(81, 37);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CustomFormat = "yyyy-mm-dd";
            this.dtpkToDate.Location = new System.Drawing.Point(511, 10);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(172, 20);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CustomFormat = "yyyy-mm-dd";
            this.dtpkFromDate.Location = new System.Drawing.Point(10, 10);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(172, 20);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Location = new System.Drawing.Point(5, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 360);
            this.panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(687, 357);
            this.dtgvBill.TabIndex = 0;
            this.dtgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellContentClick);
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 22);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(697, 439);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(406, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(289, 354);
            this.panel6.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFoodPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 146);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(284, 42);
            this.panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(87, 13);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(194, 20);
            this.nmFoodPrice.TabIndex = 1;
            this.nmFoodPrice.ValueChanged += new System.EventHandler(this.nmFoodPrice_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbFoodCategory);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 98);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(284, 42);
            this.panel9.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(87, 9);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(194, 21);
            this.cbFoodCategory.TabIndex = 1;
            this.cbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cbFoodCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbFoodName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 42);
            this.panel8.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(87, 9);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(194, 20);
            this.txbFoodName.TabIndex = 1;
            this.txbFoodName.TextChanged += new System.EventHandler(this.txbFoodName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbFoodID);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(284, 42);
            this.panel7.TabIndex = 1;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(87, 9);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(194, 20);
            this.txbFoodID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbSearchFoodName);
            this.panel5.Controls.Add(this.btnSearchFood);
            this.panel5.Location = new System.Drawing.Point(406, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(286, 39);
            this.panel5.TabIndex = 2;
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Location = new System.Drawing.Point(3, 10);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(212, 20);
            this.txbSearchFoodName.TabIndex = 5;
            this.txbSearchFoodName.TextChanged += new System.EventHandler(this.txbSearchFoodName_TextChanged);
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(219, 3);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(64, 34);
            this.btnSearchFood.TabIndex = 4;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShowFood);
            this.panel4.Controls.Add(this.btnEditFood);
            this.panel4.Controls.Add(this.btnDeleteFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(5, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 39);
            this.panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(215, 3);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(64, 34);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(146, 3);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(64, 34);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(76, 3);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(64, 34);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(7, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(64, 34);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Location = new System.Drawing.Point(5, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 357);
            this.panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFood.Location = new System.Drawing.Point(0, 0);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(396, 357);
            this.dtgvFood.TabIndex = 0;
            this.dtgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellContentClick);
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.panel17);
            this.tpCategory.Controls.Add(this.panel12);
            this.tpCategory.Controls.Add(this.panel11);
            this.tpCategory.Location = new System.Drawing.Point(4, 22);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(697, 439);
            this.tpCategory.TabIndex = 2;
            this.tpCategory.Text = "Danh mục";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.dtgvCategory);
            this.panel17.Location = new System.Drawing.Point(5, 47);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(396, 358);
            this.panel17.TabIndex = 5;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.Size = new System.Drawing.Size(396, 358);
            this.dtgvCategory.TabIndex = 0;
            this.dtgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategory_CellContentClick);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Controls.Add(this.panel16);
            this.panel12.Location = new System.Drawing.Point(404, 47);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(291, 358);
            this.panel12.TabIndex = 4;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txbNameCategory);
            this.panel15.Controls.Add(this.label7);
            this.panel15.Location = new System.Drawing.Point(3, 50);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(284, 42);
            this.panel15.TabIndex = 2;
            // 
            // txbNameCategory
            // 
            this.txbNameCategory.Location = new System.Drawing.Point(126, 13);
            this.txbNameCategory.Name = "txbNameCategory";
            this.txbNameCategory.Size = new System.Drawing.Size(155, 20);
            this.txbNameCategory.TabIndex = 1;
            this.txbNameCategory.TextChanged += new System.EventHandler(this.txbNameCategory_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên danh mục:";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txbCategoryID);
            this.panel16.Controls.Add(this.label8);
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(284, 42);
            this.panel16.TabIndex = 1;
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.Location = new System.Drawing.Point(126, 9);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.ReadOnly = true;
            this.txbCategoryID.Size = new System.Drawing.Size(156, 20);
            this.txbCategoryID.TabIndex = 1;
            this.txbCategoryID.TextChanged += new System.EventHandler(this.txbCategoryID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnShowCategory);
            this.panel11.Controls.Add(this.btnEditCategory);
            this.panel11.Controls.Add(this.btnDeleteCategory);
            this.panel11.Controls.Add(this.btnAddCategory);
            this.panel11.Location = new System.Drawing.Point(5, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(396, 39);
            this.panel11.TabIndex = 2;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Location = new System.Drawing.Point(215, 3);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(64, 34);
            this.btnShowCategory.TabIndex = 3;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(146, 3);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(64, 34);
            this.btnEditCategory.TabIndex = 2;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(76, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(64, 34);
            this.btnDeleteCategory.TabIndex = 1;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(7, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(64, 34);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel20);
            this.tpTable.Controls.Add(this.panel14);
            this.tpTable.Controls.Add(this.panel13);
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(697, 439);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.dtgvTable);
            this.panel20.Location = new System.Drawing.Point(5, 49);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(393, 355);
            this.panel20.TabIndex = 6;
            // 
            // dtgvTable
            // 
            this.dtgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(3, 3);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.Size = new System.Drawing.Size(388, 350);
            this.dtgvTable.TabIndex = 0;
            this.dtgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTable_CellContentClick);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel21);
            this.panel14.Controls.Add(this.panel18);
            this.panel14.Controls.Add(this.panel19);
            this.panel14.Location = new System.Drawing.Point(404, 47);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(291, 358);
            this.panel14.TabIndex = 5;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.txbTableStatus);
            this.panel21.Controls.Add(this.label9);
            this.panel21.Location = new System.Drawing.Point(3, 98);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(284, 42);
            this.panel21.TabIndex = 3;
            // 
            // txbTableStatus
            // 
            this.txbTableStatus.Location = new System.Drawing.Point(114, 9);
            this.txbTableStatus.Name = "txbTableStatus";
            this.txbTableStatus.Size = new System.Drawing.Size(168, 20);
            this.txbTableStatus.TabIndex = 2;
            this.txbTableStatus.TextChanged += new System.EventHandler(this.txbTableStatus_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Trạng thái:";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.txbTableName);
            this.panel18.Controls.Add(this.label5);
            this.panel18.Location = new System.Drawing.Point(3, 50);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(284, 42);
            this.panel18.TabIndex = 2;
            // 
            // txbTableName
            // 
            this.txbTableName.Location = new System.Drawing.Point(114, 9);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(168, 20);
            this.txbTableName.TabIndex = 1;
            this.txbTableName.TextChanged += new System.EventHandler(this.txbTableName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên bàn:";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txbTableID);
            this.panel19.Controls.Add(this.label6);
            this.panel19.Location = new System.Drawing.Point(3, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(284, 42);
            this.panel19.TabIndex = 1;
            // 
            // txbTableID
            // 
            this.txbTableID.Location = new System.Drawing.Point(114, 9);
            this.txbTableID.Name = "txbTableID";
            this.txbTableID.ReadOnly = true;
            this.txbTableID.Size = new System.Drawing.Size(168, 20);
            this.txbTableID.TabIndex = 1;
            this.txbTableID.TextChanged += new System.EventHandler(this.txbTableID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnShowTable);
            this.panel13.Controls.Add(this.btnEditTable);
            this.panel13.Controls.Add(this.btnDeleteTable);
            this.panel13.Controls.Add(this.btnAddTable);
            this.panel13.Location = new System.Drawing.Point(5, 5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(396, 39);
            this.panel13.TabIndex = 3;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(215, 3);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(64, 34);
            this.btnShowTable.TabIndex = 3;
            this.btnShowTable.Text = "Xem";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(146, 3);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(64, 34);
            this.btnEditTable.TabIndex = 2;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(76, 3);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(64, 34);
            this.btnDeleteTable.TabIndex = 1;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(7, 3);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(64, 34);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel27);
            this.tpAccount.Controls.Add(this.panel23);
            this.tpAccount.Controls.Add(this.panel22);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(697, 439);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.dtgvAccount);
            this.panel27.Location = new System.Drawing.Point(5, 49);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(391, 355);
            this.panel27.TabIndex = 7;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(386, 350);
            this.dtgvAccount.TabIndex = 0;
            this.dtgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellContentClick);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.btnRessetPasword);
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Controls.Add(this.panel25);
            this.panel23.Controls.Add(this.panel26);
            this.panel23.Location = new System.Drawing.Point(401, 47);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(291, 358);
            this.panel23.TabIndex = 6;
            // 
            // btnRessetPasword
            // 
            this.btnRessetPasword.Location = new System.Drawing.Point(193, 146);
            this.btnRessetPasword.Name = "btnRessetPasword";
            this.btnRessetPasword.Size = new System.Drawing.Size(91, 41);
            this.btnRessetPasword.TabIndex = 4;
            this.btnRessetPasword.Text = "Đặt lại mật khẩu";
            this.btnRessetPasword.UseVisualStyleBackColor = true;
            this.btnRessetPasword.Click += new System.EventHandler(this.btnRessetPasword_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.nmAccountType);
            this.panel24.Controls.Add(this.label10);
            this.panel24.Location = new System.Drawing.Point(3, 98);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(284, 42);
            this.panel24.TabIndex = 3;
            // 
            // nmAccountType
            // 
            this.nmAccountType.Location = new System.Drawing.Point(127, 11);
            this.nmAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(51, 20);
            this.nmAccountType.TabIndex = 2;
            this.nmAccountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmAccountType.ValueChanged += new System.EventHandler(this.nmAccountType_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại tài khoản:";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txbDisplayName);
            this.panel25.Controls.Add(this.label11);
            this.panel25.Location = new System.Drawing.Point(3, 50);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(284, 42);
            this.panel25.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(127, 9);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(155, 20);
            this.txbDisplayName.TabIndex = 1;
            this.txbDisplayName.TextChanged += new System.EventHandler(this.txbDisplayName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên hiểm thị:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txbUserName);
            this.panel26.Controls.Add(this.label12);
            this.panel26.Location = new System.Drawing.Point(3, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(284, 42);
            this.panel26.TabIndex = 1;
            this.panel26.Paint += new System.Windows.Forms.PaintEventHandler(this.panel26_Paint);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(127, 9);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(155, 20);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.TextChanged += new System.EventHandler(this.txbUserName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên tài khoản:";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.btnShowAccount);
            this.panel22.Controls.Add(this.btnEditAccount);
            this.panel22.Controls.Add(this.btnDeleteAccount);
            this.panel22.Controls.Add(this.btnAddAccount);
            this.panel22.Location = new System.Drawing.Point(5, 5);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(396, 39);
            this.panel22.TabIndex = 4;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(215, 3);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(64, 34);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(146, 3);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(64, 34);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(76, 3);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(64, 34);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(7, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(64, 34);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(QLQuanAn.DTO.Table);
            this.tableBindingSource.CurrentChanged += new System.EventHandler(this.tableBindingSource_CurrentChanged);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 486);
            this.Controls.Add(this.tcAdmin);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tcAdmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.tpBill.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.tpCategory.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpCategory;
        private TabPage tpTable;
        private Panel panel2;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel1;
        private DataGridView dtgvBill;
        private TabPage tpAccount;
        private Button btnViewBill;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnAddFood;
        private Panel panel3;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private DataGridView dtgvFood;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Panel panel7;
        private TextBox txbFoodID;
        private Label label1;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel9;
        private Label label3;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private ComboBox cbFoodCategory;
        private Panel panel17;
        private DataGridView dtgvCategory;
        private Panel panel12;
        private Panel panel15;
        private TextBox txbNameCategory;
        private Label label7;
        private Panel panel16;
        private TextBox txbCategoryID;
        private Label label8;
        private Panel panel11;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Panel panel20;
        private DataGridView dtgvTable;
        private Panel panel14;
        private Panel panel21;
        private Label label9;
        private Panel panel18;
        private TextBox txbTableName;
        private Label label5;
        private Panel panel19;
        private TextBox txbTableID;
        private Label label6;
        private Panel panel13;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private Panel panel27;
        private DataGridView dtgvAccount;
        private Panel panel23;
        private Panel panel24;
        private ComboBox cbAccountType;
        private Label label10;
        private Panel panel25;
        private TextBox txbDisplayName;
        private Label label11;
        private Panel panel26;
        private TextBox txbUserName;
        private Label label12;
        private Panel panel22;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private Button btnRessetPasword;
        private BindingSource tableBindingSource;
        private TextBox txbTableStatus;
        private NumericUpDown nmAccountType;
        private TextBox txbIndexPageBill;
        private Button btnNextBillPage;
        private Button btnPrevioursBillPage;
        private Button btnLastBillPage;
        private Button btnFirstBillPage;
    }
}