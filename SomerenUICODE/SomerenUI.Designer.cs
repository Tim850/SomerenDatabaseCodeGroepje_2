namespace SomerenUI
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
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.listViewDrinksCO = new System.Windows.Forms.ListView();
            this.listViewStudentsCO = new System.Windows.Forms.ListView();
            this.lbl_SelectDrinks = new System.Windows.Forms.Label();
            this.lbl_SelectStudent = new System.Windows.Forms.Label();
            this.lbl_checkOut = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_CalcTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Teachers.SuspendLayout();
            this.pnl_Rooms.SuspendLayout();
            this.pnl_StockDrinks.SuspendLayout();
            this.pnl_CheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Dashboard
            // 
            this.img_Dashboard.Location = new System.Drawing.Point(836, 0);
            this.img_Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.img_Dashboard.Name = "img_Dashboard";
            this.img_Dashboard.Size = new System.Drawing.Size(415, 332);
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
            this.checkOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 28);
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
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.lecturersToolStripMenuItem.Text = "Teachers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.LecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.RoomsToolStripMenuItem_Click);
            // 
            // stockDrinksToolStripMenuItem
            // 
            this.stockDrinksToolStripMenuItem.Name = "stockDrinksToolStripMenuItem";
            this.stockDrinksToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.stockDrinksToolStripMenuItem.Text = "Stock (Drinks)";
            this.stockDrinksToolStripMenuItem.Click += new System.EventHandler(this.StockDrinksToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.checkOutToolStripMenuItem.Text = "CheckOut";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.CheckOutToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.img_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(16, 33);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1251, 576);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(17, 16);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(243, 17);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.pictureBox1);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(16, 32);
            this.pnl_Students.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(1251, 573);
            this.pnl_Students.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(21, 52);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1020, 377);
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
            this.pictureBox1.Location = new System.Drawing.Point(1073, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(13, 12);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(129, 33);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnl_Teachers
            // 
            this.pnl_Teachers.Controls.Add(this.lblTeacher);
            this.pnl_Teachers.Controls.Add(this.listViewTeachers);
            this.pnl_Teachers.Location = new System.Drawing.Point(6, 32);
            this.pnl_Teachers.Name = "pnl_Teachers";
            this.pnl_Teachers.Size = new System.Drawing.Size(1261, 570);
            this.pnl_Teachers.TabIndex = 5;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(6, 3);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(202, 51);
            this.lblTeacher.TabIndex = 0;
            this.lblTeacher.Text = "Teachers";
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(10, 76);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(731, 333);
            this.listViewTeachers.TabIndex = 1;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // pnl_Rooms
            // 
            this.pnl_Rooms.Controls.Add(this.listViewRooms);
            this.pnl_Rooms.Controls.Add(this.lbl_rooms);
            this.pnl_Rooms.Location = new System.Drawing.Point(6, 31);
            this.pnl_Rooms.Name = "pnl_Rooms";
            this.pnl_Rooms.Size = new System.Drawing.Size(1154, 536);
            this.pnl_Rooms.TabIndex = 2;
            // 
            // listViewRooms
            // 
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(13, 70);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(701, 323);
            this.listViewRooms.TabIndex = 3;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_rooms
            // 
            this.lbl_rooms.AutoSize = true;
            this.lbl_rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rooms.Location = new System.Drawing.Point(4, 3);
            this.lbl_rooms.Name = "lbl_rooms";
            this.lbl_rooms.Size = new System.Drawing.Size(159, 51);
            this.lbl_rooms.TabIndex = 2;
            this.lbl_rooms.Text = "Rooms";
            // 
            // pnl_StockDrinks
            // 
            this.pnl_StockDrinks.Controls.Add(this.listViewStockDrinks);
            this.pnl_StockDrinks.Controls.Add(this.lbl_StockDrinks);
            this.pnl_StockDrinks.Location = new System.Drawing.Point(3, 31);
            this.pnl_StockDrinks.Name = "pnl_StockDrinks";
            this.pnl_StockDrinks.Size = new System.Drawing.Size(1154, 568);
            this.pnl_StockDrinks.TabIndex = 6;
            // 
            // listViewStockDrinks
            // 
            this.listViewStockDrinks.HideSelection = false;
            this.listViewStockDrinks.Location = new System.Drawing.Point(18, 82);
            this.listViewStockDrinks.Name = "listViewStockDrinks";
            this.listViewStockDrinks.Size = new System.Drawing.Size(901, 346);
            this.listViewStockDrinks.TabIndex = 1;
            this.listViewStockDrinks.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_StockDrinks
            // 
            this.lbl_StockDrinks.AutoSize = true;
            this.lbl_StockDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockDrinks.Location = new System.Drawing.Point(17, 15);
            this.lbl_StockDrinks.Name = "lbl_StockDrinks";
            this.lbl_StockDrinks.Size = new System.Drawing.Size(293, 51);
            this.lbl_StockDrinks.TabIndex = 0;
            this.lbl_StockDrinks.Text = "Stock (Drinks)";
            // 
            // pnl_CheckOut
            // 
            this.pnl_CheckOut.Controls.Add(this.lbl_CalcTotal);
            this.pnl_CheckOut.Controls.Add(this.lbl_Total);
            this.pnl_CheckOut.Controls.Add(this.btn_Calculate);
            this.pnl_CheckOut.Controls.Add(this.listViewDrinksCO);
            this.pnl_CheckOut.Controls.Add(this.listViewStudentsCO);
            this.pnl_CheckOut.Controls.Add(this.lbl_SelectDrinks);
            this.pnl_CheckOut.Controls.Add(this.lbl_SelectStudent);
            this.pnl_CheckOut.Controls.Add(this.lbl_checkOut);
            this.pnl_CheckOut.Location = new System.Drawing.Point(0, 31);
            this.pnl_CheckOut.Name = "pnl_CheckOut";
            this.pnl_CheckOut.Size = new System.Drawing.Size(1154, 498);
            this.pnl_CheckOut.TabIndex = 7;
            // 
            // listViewDrinksCO
            // 
            this.listViewDrinksCO.HideSelection = false;
            this.listViewDrinksCO.Location = new System.Drawing.Point(516, 114);
            this.listViewDrinksCO.Name = "listViewDrinksCO";
            this.listViewDrinksCO.Size = new System.Drawing.Size(336, 221);
            this.listViewDrinksCO.TabIndex = 6;
            this.listViewDrinksCO.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStudentsCO
            // 
            this.listViewStudentsCO.HideSelection = false;
            this.listViewStudentsCO.Location = new System.Drawing.Point(38, 114);
            this.listViewStudentsCO.Name = "listViewStudentsCO";
            this.listViewStudentsCO.Size = new System.Drawing.Size(334, 220);
            this.listViewStudentsCO.TabIndex = 5;
            this.listViewStudentsCO.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_SelectDrinks
            // 
            this.lbl_SelectDrinks.AutoSize = true;
            this.lbl_SelectDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectDrinks.Location = new System.Drawing.Point(511, 66);
            this.lbl_SelectDrinks.Name = "lbl_SelectDrinks";
            this.lbl_SelectDrinks.Size = new System.Drawing.Size(87, 29);
            this.lbl_SelectDrinks.TabIndex = 4;
            this.lbl_SelectDrinks.Text = "Drinks:";
            // 
            // lbl_SelectStudent
            // 
            this.lbl_SelectStudent.AutoSize = true;
            this.lbl_SelectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectStudent.Location = new System.Drawing.Point(33, 66);
            this.lbl_SelectStudent.Name = "lbl_SelectStudent";
            this.lbl_SelectStudent.Size = new System.Drawing.Size(101, 29);
            this.lbl_SelectStudent.TabIndex = 1;
            this.lbl_SelectStudent.Text = "Student:";
            // 
            // lbl_checkOut
            // 
            this.lbl_checkOut.AutoSize = true;
            this.lbl_checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkOut.Location = new System.Drawing.Point(30, 11);
            this.lbl_checkOut.Name = "lbl_checkOut";
            this.lbl_checkOut.Size = new System.Drawing.Size(209, 46);
            this.lbl_checkOut.TabIndex = 0;
            this.lbl_checkOut.Text = "Check Out";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(84, 362);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(229, 48);
            this.btn_Calculate.TabIndex = 7;
            this.btn_Calculate.Text = "Calculate Price";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(80, 434);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(61, 24);
            this.lbl_Total.TabIndex = 8;
            this.lbl_Total.Text = "Total: ";
            // 
            // lbl_CalcTotal
            // 
            this.lbl_CalcTotal.AutoSize = true;
            this.lbl_CalcTotal.Location = new System.Drawing.Point(232, 436);
            this.lbl_CalcTotal.Name = "lbl_CalcTotal";
            this.lbl_CalcTotal.Size = new System.Drawing.Size(20, 17);
            this.lbl_CalcTotal.TabIndex = 9;
            this.lbl_CalcTotal.Text = "...";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 560);
            this.Controls.Add(this.pnl_CheckOut);
            this.Controls.Add(this.pnl_StockDrinks);
            this.Controls.Add(this.pnl_Rooms);
            this.Controls.Add(this.pnl_Teachers);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_CheckOut;
        private System.Windows.Forms.Label lbl_checkOut;
        private System.Windows.Forms.Label lbl_SelectStudent;
        private System.Windows.Forms.Label lbl_SelectDrinks;
        private System.Windows.Forms.ListView listViewDrinksCO;
        private System.Windows.Forms.ListView listViewStudentsCO;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_CalcTotal;
    }
}

