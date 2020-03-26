
﻿namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.img_Dashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guidesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnl_Teachers = new System.Windows.Forms.Panel();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.pnl_Rooms = new System.Windows.Forms.Panel();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.lbl_rooms = new System.Windows.Forms.Label();
            this.pnl_StockDrinks = new System.Windows.Forms.Panel();
            this.listViewStockDrinks = new System.Windows.Forms.ListView();
            this.lbl_StockDrinks = new System.Windows.Forms.Label();
            this.pnl_CheckOut = new System.Windows.Forms.Panel();
            this.lbl_vouchers = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.lbl_CalcTotal = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.listViewDrinksCO = new System.Windows.Forms.ListView();
            this.listViewStudentsCO = new System.Windows.Forms.ListView();
            this.lbl_SelectDrinks = new System.Windows.Forms.Label();
            this.lbl_SelectStudent = new System.Windows.Forms.Label();
            this.lbl_checkOut = new System.Windows.Forms.Label();
            this.pnl_Sales = new System.Windows.Forms.Panel();
            this.btn_ShowSales = new System.Windows.Forms.Button();
            this.listViewSales = new System.Windows.Forms.ListView();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_SalesReport = new System.Windows.Forms.Label();
            this.monthCalendarEnd = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarStart = new System.Windows.Forms.MonthCalendar();
            this.pnl_Activities = new System.Windows.Forms.Panel();
            this.btn_DeleteActivity = new System.Windows.Forms.Button();
            this.btn_AddActivity = new System.Windows.Forms.Button();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EditActivity = new System.Windows.Forms.Button();
            this.pnl_Guides = new System.Windows.Forms.Panel();
            this.btn_DeleteGuide = new System.Windows.Forms.Button();
            this.cmb_Teachers = new System.Windows.Forms.ComboBox();
            this.btn_AddGuide = new System.Windows.Forms.Button();
            this.listViewGuides = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Teachers.SuspendLayout();
            this.pnl_Rooms.SuspendLayout();
            this.pnl_StockDrinks.SuspendLayout();
            this.pnl_CheckOut.SuspendLayout();
            this.pnl_Sales.SuspendLayout();
            this.pnl_Activities.SuspendLayout();
            this.pnl_Guides.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Dashboard
            // 
            this.img_Dashboard.Location = new System.Drawing.Point(627, 0);
            this.img_Dashboard.Name = "img_Dashboard";
            this.img_Dashboard.Size = new System.Drawing.Size(311, 270);
            this.img_Dashboard.TabIndex = 0;
            this.img_Dashboard.TabStop = false;
            this.img_Dashboard.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.stockDrinksToolStripMenuItem,
            this.financeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.lecturersToolStripMenuItem.Text = "Teachers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.LecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activitiesToolStripMenuItem1,
            this.guidesToolStripMenuItem});
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.ActivitiesToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem1
            // 
            this.activitiesToolStripMenuItem1.Name = "activitiesToolStripMenuItem1";
            this.activitiesToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.activitiesToolStripMenuItem1.Text = "Activities";
            this.activitiesToolStripMenuItem1.Click += new System.EventHandler(this.ActivitiesToolStripMenuItem1_Click);
            // 
            // guidesToolStripMenuItem
            // 
            this.guidesToolStripMenuItem.Name = "guidesToolStripMenuItem";
            this.guidesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.guidesToolStripMenuItem.Text = "Guides";
            this.guidesToolStripMenuItem.Click += new System.EventHandler(this.GuidesToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.RoomsToolStripMenuItem_Click);
            // 
            // stockDrinksToolStripMenuItem
            // 
            this.stockDrinksToolStripMenuItem.Name = "stockDrinksToolStripMenuItem";
            this.stockDrinksToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.stockDrinksToolStripMenuItem.Text = "Stock (Drinks)";
            this.stockDrinksToolStripMenuItem.Click += new System.EventHandler(this.StockDrinksToolStripMenuItem_Click);
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.financeToolStripMenuItem.Text = "Finance";
            this.financeToolStripMenuItem.Click += new System.EventHandler(this.FinanceToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.SalesToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.checkOutToolStripMenuItem.Text = "CheckOut";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.CheckOutToolStripMenuItem_Click_1);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.img_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(12, 27);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(938, 468);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(13, 13);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(185, 13);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.pictureBox1);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(12, 26);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(938, 466);
            this.pnl_Students.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(16, 42);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(766, 307);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(805, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(10, 10);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(107, 29);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnl_Teachers
            // 
            this.pnl_Teachers.Controls.Add(this.lblTeacher);
            this.pnl_Teachers.Controls.Add(this.listViewTeachers);
            this.pnl_Teachers.Location = new System.Drawing.Point(4, 26);
            this.pnl_Teachers.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Teachers.Name = "pnl_Teachers";
            this.pnl_Teachers.Size = new System.Drawing.Size(946, 463);
            this.pnl_Teachers.TabIndex = 5;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(4, 2);
            this.lblTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(162, 39);
            this.lblTeacher.TabIndex = 0;
            this.lblTeacher.Text = "Teachers";
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(8, 62);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(2);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(549, 271);
            this.listViewTeachers.TabIndex = 1;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // pnl_Rooms
            // 
            this.pnl_Rooms.Controls.Add(this.listViewRooms);
            this.pnl_Rooms.Controls.Add(this.lbl_rooms);
            this.pnl_Rooms.Location = new System.Drawing.Point(4, 25);
            this.pnl_Rooms.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Rooms.Name = "pnl_Rooms";
            this.pnl_Rooms.Size = new System.Drawing.Size(887, 418);
            this.pnl_Rooms.TabIndex = 2;
            // 
            // listViewRooms
            // 
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(10, 57);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(2);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(527, 263);
            this.listViewRooms.TabIndex = 3;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_rooms
            // 
            this.lbl_rooms.AutoSize = true;
            this.lbl_rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rooms.Location = new System.Drawing.Point(3, 2);
            this.lbl_rooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_rooms.Name = "lbl_rooms";
            this.lbl_rooms.Size = new System.Drawing.Size(128, 39);
            this.lbl_rooms.TabIndex = 2;
            this.lbl_rooms.Text = "Rooms";
            // 
            // pnl_StockDrinks
            // 
            this.pnl_StockDrinks.Controls.Add(this.listViewStockDrinks);
            this.pnl_StockDrinks.Controls.Add(this.lbl_StockDrinks);
            this.pnl_StockDrinks.Location = new System.Drawing.Point(2, 25);
            this.pnl_StockDrinks.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_StockDrinks.Name = "pnl_StockDrinks";
            this.pnl_StockDrinks.Size = new System.Drawing.Size(866, 462);
            this.pnl_StockDrinks.TabIndex = 6;
            // 
            // listViewStockDrinks
            // 
            this.listViewStockDrinks.HideSelection = false;
            this.listViewStockDrinks.Location = new System.Drawing.Point(14, 67);
            this.listViewStockDrinks.Margin = new System.Windows.Forms.Padding(2);
            this.listViewStockDrinks.Name = "listViewStockDrinks";
            this.listViewStockDrinks.Size = new System.Drawing.Size(677, 282);
            this.listViewStockDrinks.TabIndex = 1;
            this.listViewStockDrinks.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_StockDrinks
            // 
            this.lbl_StockDrinks.AutoSize = true;
            this.lbl_StockDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockDrinks.Location = new System.Drawing.Point(13, 12);
            this.lbl_StockDrinks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StockDrinks.Name = "lbl_StockDrinks";
            this.lbl_StockDrinks.Size = new System.Drawing.Size(238, 39);
            this.lbl_StockDrinks.TabIndex = 0;
            this.lbl_StockDrinks.Text = "Stock (Drinks)";
            // 
            // pnl_CheckOut
            // 
            this.pnl_CheckOut.Controls.Add(this.lbl_vouchers);
            this.pnl_CheckOut.Controls.Add(this.btn_Buy);
            this.pnl_CheckOut.Controls.Add(this.lbl_CalcTotal);
            this.pnl_CheckOut.Controls.Add(this.lbl_Total);
            this.pnl_CheckOut.Controls.Add(this.btn_Calculate);
            this.pnl_CheckOut.Controls.Add(this.listViewDrinksCO);
            this.pnl_CheckOut.Controls.Add(this.listViewStudentsCO);
            this.pnl_CheckOut.Controls.Add(this.lbl_SelectDrinks);
            this.pnl_CheckOut.Controls.Add(this.lbl_SelectStudent);
            this.pnl_CheckOut.Controls.Add(this.lbl_checkOut);
            this.pnl_CheckOut.Location = new System.Drawing.Point(0, 25);
            this.pnl_CheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_CheckOut.Name = "pnl_CheckOut";
            this.pnl_CheckOut.Size = new System.Drawing.Size(866, 420);
            this.pnl_CheckOut.TabIndex = 7;
            // 
            // lbl_vouchers
            // 
            this.lbl_vouchers.AutoSize = true;
            this.lbl_vouchers.Location = new System.Drawing.Point(180, 367);
            this.lbl_vouchers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_vouchers.Name = "lbl_vouchers";
            this.lbl_vouchers.Size = new System.Drawing.Size(52, 13);
            this.lbl_vouchers.TabIndex = 11;
            this.lbl_vouchers.Text = "Vouchers";
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Buy.Location = new System.Drawing.Point(387, 353);
            this.btn_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(156, 39);
            this.btn_Buy.TabIndex = 10;
            this.btn_Buy.Text = "Buy Drink(s)";
            this.btn_Buy.UseVisualStyleBackColor = false;
            this.btn_Buy.Click += new System.EventHandler(this.Btn_Buy_Click);
            // 
            // lbl_CalcTotal
            // 
            this.lbl_CalcTotal.AutoSize = true;
            this.lbl_CalcTotal.Location = new System.Drawing.Point(146, 367);
            this.lbl_CalcTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CalcTotal.Name = "lbl_CalcTotal";
            this.lbl_CalcTotal.Size = new System.Drawing.Size(16, 13);
            this.lbl_CalcTotal.TabIndex = 9;
            this.lbl_CalcTotal.Text = "...";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(60, 363);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(49, 18);
            this.lbl_Total.TabIndex = 8;
            this.lbl_Total.Text = "Total: ";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(63, 294);
            this.btn_Calculate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(172, 39);
            this.btn_Calculate.TabIndex = 7;
            this.btn_Calculate.Text = "Calculate Price";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // listViewDrinksCO
            // 
            this.listViewDrinksCO.HideSelection = false;
            this.listViewDrinksCO.Location = new System.Drawing.Point(387, 93);
            this.listViewDrinksCO.Margin = new System.Windows.Forms.Padding(2);
            this.listViewDrinksCO.Name = "listViewDrinksCO";
            this.listViewDrinksCO.Size = new System.Drawing.Size(287, 180);
            this.listViewDrinksCO.TabIndex = 6;
            this.listViewDrinksCO.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStudentsCO
            // 
            this.listViewStudentsCO.HideSelection = false;
            this.listViewStudentsCO.Location = new System.Drawing.Point(28, 93);
            this.listViewStudentsCO.Margin = new System.Windows.Forms.Padding(2);
            this.listViewStudentsCO.Name = "listViewStudentsCO";
            this.listViewStudentsCO.Size = new System.Drawing.Size(296, 180);
            this.listViewStudentsCO.TabIndex = 5;
            this.listViewStudentsCO.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_SelectDrinks
            // 
            this.lbl_SelectDrinks.AutoSize = true;
            this.lbl_SelectDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectDrinks.Location = new System.Drawing.Point(383, 54);
            this.lbl_SelectDrinks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SelectDrinks.Name = "lbl_SelectDrinks";
            this.lbl_SelectDrinks.Size = new System.Drawing.Size(67, 24);
            this.lbl_SelectDrinks.TabIndex = 4;
            this.lbl_SelectDrinks.Text = "Drinks:";
            // 
            // lbl_SelectStudent
            // 
            this.lbl_SelectStudent.AutoSize = true;
            this.lbl_SelectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectStudent.Location = new System.Drawing.Point(25, 54);
            this.lbl_SelectStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SelectStudent.Name = "lbl_SelectStudent";
            this.lbl_SelectStudent.Size = new System.Drawing.Size(79, 24);
            this.lbl_SelectStudent.TabIndex = 1;
            this.lbl_SelectStudent.Text = "Student:";
            // 
            // lbl_checkOut
            // 
            this.lbl_checkOut.AutoSize = true;
            this.lbl_checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkOut.Location = new System.Drawing.Point(22, 9);
            this.lbl_checkOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_checkOut.Name = "lbl_checkOut";
            this.lbl_checkOut.Size = new System.Drawing.Size(168, 37);
            this.lbl_checkOut.TabIndex = 0;
            this.lbl_checkOut.Text = "Check Out";
            // 
            // pnl_Sales
            // 
            this.pnl_Sales.Controls.Add(this.btn_ShowSales);
            this.pnl_Sales.Controls.Add(this.listViewSales);
            this.pnl_Sales.Controls.Add(this.lbl_EndDate);
            this.pnl_Sales.Controls.Add(this.lbl_StartDate);
            this.pnl_Sales.Controls.Add(this.lbl_SalesReport);
            this.pnl_Sales.Controls.Add(this.monthCalendarEnd);
            this.pnl_Sales.Controls.Add(this.monthCalendarStart);
            this.pnl_Sales.Location = new System.Drawing.Point(0, 28);
            this.pnl_Sales.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Sales.Name = "pnl_Sales";
            this.pnl_Sales.Size = new System.Drawing.Size(891, 417);
            this.pnl_Sales.TabIndex = 8;
            // 
            // btn_ShowSales
            // 
            this.btn_ShowSales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ShowSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowSales.Location = new System.Drawing.Point(171, 301);
            this.btn_ShowSales.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ShowSales.Name = "btn_ShowSales";
            this.btn_ShowSales.Size = new System.Drawing.Size(152, 44);
            this.btn_ShowSales.TabIndex = 6;
            this.btn_ShowSales.Text = "Show Sales";
            this.btn_ShowSales.UseVisualStyleBackColor = false;
            this.btn_ShowSales.Click += new System.EventHandler(this.Btn_ShowSales_Click);
            // 
            // listViewSales
            // 
            this.listViewSales.HideSelection = false;
            this.listViewSales.Location = new System.Drawing.Point(509, 90);
            this.listViewSales.Margin = new System.Windows.Forms.Padding(2);
            this.listViewSales.Name = "listViewSales";
            this.listViewSales.Size = new System.Drawing.Size(343, 261);
            this.listViewSales.TabIndex = 5;
            this.listViewSales.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndDate.Location = new System.Drawing.Point(259, 64);
            this.lbl_EndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(125, 20);
            this.lbl_EndDate.TabIndex = 4;
            this.lbl_EndDate.Text = "Select end date:";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartDate.Location = new System.Drawing.Point(25, 64);
            this.lbl_StartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(130, 20);
            this.lbl_StartDate.TabIndex = 3;
            this.lbl_StartDate.Text = "Select start date:";
            // 
            // lbl_SalesReport
            // 
            this.lbl_SalesReport.AutoSize = true;
            this.lbl_SalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesReport.Location = new System.Drawing.Point(22, 20);
            this.lbl_SalesReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SalesReport.Name = "lbl_SalesReport";
            this.lbl_SalesReport.Size = new System.Drawing.Size(200, 37);
            this.lbl_SalesReport.TabIndex = 2;
            this.lbl_SalesReport.Text = "Sales Report";
            // 
            // monthCalendarEnd
            // 
            this.monthCalendarEnd.Location = new System.Drawing.Point(262, 90);
            this.monthCalendarEnd.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendarEnd.MaxSelectionCount = 1;
            this.monthCalendarEnd.Name = "monthCalendarEnd";
            this.monthCalendarEnd.TabIndex = 1;
            // 
            // monthCalendarStart
            // 
            this.monthCalendarStart.Location = new System.Drawing.Point(28, 90);
            this.monthCalendarStart.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendarStart.MaxSelectionCount = 1;
            this.monthCalendarStart.Name = "monthCalendarStart";
            this.monthCalendarStart.TabIndex = 0;
            // 
            // pnl_Activities
            // 
            this.pnl_Activities.Controls.Add(this.btn_DeleteActivity);
            this.pnl_Activities.Controls.Add(this.btn_AddActivity);
            this.pnl_Activities.Controls.Add(this.listViewActivities);
            this.pnl_Activities.Controls.Add(this.label1);
            this.pnl_Activities.Controls.Add(this.btn_EditActivity);
            this.pnl_Activities.Location = new System.Drawing.Point(2, 23);
            this.pnl_Activities.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Activities.Name = "pnl_Activities";
            this.pnl_Activities.Size = new System.Drawing.Size(890, 422);
            this.pnl_Activities.TabIndex = 9;
            // 
            // btn_DeleteActivity
            // 
            this.btn_DeleteActivity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DeleteActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteActivity.Location = new System.Drawing.Point(658, 124);
            this.btn_DeleteActivity.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DeleteActivity.Name = "btn_DeleteActivity";
            this.btn_DeleteActivity.Size = new System.Drawing.Size(152, 44);
            this.btn_DeleteActivity.TabIndex = 8;
            this.btn_DeleteActivity.Text = "Delete activity";
            this.btn_DeleteActivity.UseVisualStyleBackColor = false;
            this.btn_DeleteActivity.Click += new System.EventHandler(this.Btn_DeleteActivity_Click);
            // 
            // btn_AddActivity
            // 
            this.btn_AddActivity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AddActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddActivity.Location = new System.Drawing.Point(658, 56);
            this.btn_AddActivity.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddActivity.Name = "btn_AddActivity";
            this.btn_AddActivity.Size = new System.Drawing.Size(152, 44);
            this.btn_AddActivity.TabIndex = 7;
            this.btn_AddActivity.Text = "Add activity";
            this.btn_AddActivity.UseVisualStyleBackColor = false;
            this.btn_AddActivity.Click += new System.EventHandler(this.btn_AddActivity_Click_1);
            // 
            // listViewActivities
            // 
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(10, 57);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(2);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(549, 263);
            this.listViewActivities.TabIndex = 3;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewActivities_ColumnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activities";
            // 
            // btn_EditActivity
            // 
            this.btn_EditActivity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_EditActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditActivity.Location = new System.Drawing.Point(658, 189);
            this.btn_EditActivity.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditActivity.Name = "btn_EditActivity";
            this.btn_EditActivity.Size = new System.Drawing.Size(152, 44);
            this.btn_EditActivity.TabIndex = 11;
            this.btn_EditActivity.Text = "Edit activity";
            this.btn_EditActivity.UseVisualStyleBackColor = false;
            this.btn_EditActivity.Click += new System.EventHandler(this.Btn_EditActivity_Click);
            // 
            // pnl_Guides
            // 
            this.pnl_Guides.Controls.Add(this.btn_DeleteGuide);
            this.pnl_Guides.Controls.Add(this.cmb_Teachers);
            this.pnl_Guides.Controls.Add(this.btn_AddGuide);
            this.pnl_Guides.Controls.Add(this.listViewGuides);
            this.pnl_Guides.Controls.Add(this.label2);
            this.pnl_Guides.Location = new System.Drawing.Point(1, 23);
            this.pnl_Guides.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Guides.Name = "pnl_Guides";
            this.pnl_Guides.Size = new System.Drawing.Size(592, 40);
            this.pnl_Guides.TabIndex = 10;
            // 
            // btn_DeleteGuide
            // 
            this.btn_DeleteGuide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DeleteGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteGuide.Location = new System.Drawing.Point(658, 151);
            this.btn_DeleteGuide.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DeleteGuide.Name = "btn_DeleteGuide";
            this.btn_DeleteGuide.Size = new System.Drawing.Size(152, 44);
            this.btn_DeleteGuide.TabIndex = 8;
            this.btn_DeleteGuide.Text = "Delete guide";
            this.btn_DeleteGuide.UseVisualStyleBackColor = false;
            this.btn_DeleteGuide.Click += new System.EventHandler(this.btn_DeleteGuide_Click);
            // 
            // cmb_Teachers
            // 
            this.cmb_Teachers.FormattingEnabled = true;
            this.cmb_Teachers.Location = new System.Drawing.Point(658, 57);
            this.cmb_Teachers.Name = "cmb_Teachers";
            this.cmb_Teachers.Size = new System.Drawing.Size(151, 21);
            this.cmb_Teachers.TabIndex = 9;
            // 
            // btn_AddGuide
            // 
            this.btn_AddGuide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AddGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddGuide.Location = new System.Drawing.Point(658, 83);
            this.btn_AddGuide.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddGuide.Name = "btn_AddGuide";
            this.btn_AddGuide.Size = new System.Drawing.Size(152, 44);
            this.btn_AddGuide.TabIndex = 7;
            this.btn_AddGuide.Text = "Add guide";
            this.btn_AddGuide.UseVisualStyleBackColor = false;
            this.btn_AddGuide.Click += new System.EventHandler(this.btn_AddGuide_Click);
            // 
            // listViewGuides
            // 
            this.listViewGuides.HideSelection = false;
            this.listViewGuides.Location = new System.Drawing.Point(10, 57);
            this.listViewGuides.Margin = new System.Windows.Forms.Padding(2);
            this.listViewGuides.Name = "listViewGuides";
            this.listViewGuides.Size = new System.Drawing.Size(549, 263);
            this.listViewGuides.TabIndex = 3;
            this.listViewGuides.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Guides";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 455);
            this.Controls.Add(this.pnl_Guides);
            this.Controls.Add(this.pnl_Activities);
            this.Controls.Add(this.pnl_Sales);
            this.Controls.Add(this.pnl_Rooms);
            this.Controls.Add(this.pnl_Teachers);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_CheckOut);
            this.Controls.Add(this.pnl_StockDrinks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Teachers.ResumeLayout(false);
            this.pnl_Teachers.PerformLayout();
            this.pnl_Rooms.ResumeLayout(false);
            this.pnl_Rooms.PerformLayout();
            this.pnl_StockDrinks.ResumeLayout(false);
            this.pnl_StockDrinks.PerformLayout();
            this.pnl_CheckOut.ResumeLayout(false);
            this.pnl_CheckOut.PerformLayout();
            this.pnl_Sales.ResumeLayout(false);
            this.pnl_Sales.PerformLayout();
            this.pnl_Activities.ResumeLayout(false);
            this.pnl_Activities.PerformLayout();
            this.pnl_Guides.ResumeLayout(false);
            this.pnl_Guides.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Dashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.Panel pnl_Teachers;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.Panel pnl_Rooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label lbl_rooms;
        private System.Windows.Forms.ToolStripMenuItem stockDrinksToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_StockDrinks;
        private System.Windows.Forms.Label lbl_StockDrinks;
        private System.Windows.Forms.ListView listViewStockDrinks;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_CheckOut;
        private System.Windows.Forms.Label lbl_checkOut;
        private System.Windows.Forms.Label lbl_SelectStudent;
        private System.Windows.Forms.Label lbl_SelectDrinks;
        private System.Windows.Forms.ListView listViewDrinksCO;
        private System.Windows.Forms.ListView listViewStudentsCO;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_CalcTotal;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.Label lbl_vouchers;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Sales;
        private System.Windows.Forms.Button btn_ShowSales;
        private System.Windows.Forms.ListView listViewSales;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_SalesReport;
        private System.Windows.Forms.MonthCalendar monthCalendarEnd;
        private System.Windows.Forms.MonthCalendar monthCalendarStart;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Activities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeleteActivity;
        private System.Windows.Forms.Button btn_AddActivity;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guidesToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Guides;
        private System.Windows.Forms.ComboBox cmb_Teachers;
        private System.Windows.Forms.Button btn_DeleteGuide;
        private System.Windows.Forms.Button btn_AddGuide;
        private System.Windows.Forms.ListView listViewGuides;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_EditActivity;
    }
}


