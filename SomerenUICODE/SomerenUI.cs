
﻿using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using SomerenUI.Properties;
using System.IO;
using System.Data.SqlTypes;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
        SomerenLogic.StockDrinks_Service stockDrinksService = new SomerenLogic.StockDrinks_Service();
        SomerenLogic.Order_Service orderService = new SomerenLogic.Order_Service();
        SomerenLogic.Activity_Service activityService = new SomerenLogic.Activity_Service();

        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {
            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnl_Students.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_StockDrinks.Hide();
                pnl_CheckOut.Hide();
                pnl_Sales.Hide();
                pnl_Activities.Hide();
                pnl_Activities.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_StockDrinks.Hide();
                pnl_CheckOut.Hide();
                pnl_Sales.Hide();
                pnl_Activities.Hide();

                // show students
                pnl_Students.Show();

                // fill the students listview within the students panel with a list of students

                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Clear();

                listViewStudents.View = View.Details;
                listViewStudents.GridLines = true;
                listViewStudents.FullRowSelect = true;

                // Aanmaken van kolommen
                listViewStudents.Columns.Add("Student Number", 100);
                listViewStudents.Columns.Add("First Name", 100);
                listViewStudents.Columns.Add("Last Name", 100);

                string[] students = new string[3];
                ListViewItem itm;

                foreach (SomerenModel.Student s in studentList)
                {
                    students[0] = s.Number.ToString();
                    students[1] = s.FirstName;
                    students[2] = s.LastName;

                    itm = new ListViewItem(students);
                    listViewStudents.Items.Add(itm);
                }
            }
            else if (panelName == "Teachers")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Rooms.Hide();
                pnl_StockDrinks.Hide();
                pnl_CheckOut.Hide();
                pnl_Sales.Hide();
                pnl_Activities.Hide();


                // show students
                pnl_Teachers.Show();

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Teacher_Service teachService = new SomerenLogic.Teacher_Service();
                List<Teacher> teacherList = teachService.GetTeachers();

                // clear the listview before filling it again
                listViewTeachers.Clear();

                listViewTeachers.View = View.Details;
                listViewTeachers.GridLines = true;
                listViewTeachers.FullRowSelect = true;

                // Aanmaken van kollomen
                listViewTeachers.Columns.Add("Teacher Number", 100);
                listViewTeachers.Columns.Add("First Name", 100);
                listViewTeachers.Columns.Add("Last Name", 100);
                listViewTeachers.Columns.Add("Guide", 50);

                string[] teachers = new string[4];
                ListViewItem itm;

                foreach (SomerenModel.Teacher t in teacherList)
                {
                    // Items toevoegen aan een lijst
                    teachers[0] = t.Number.ToString();
                    teachers[1] = t.FirstName;
                    teachers[2] = t.LastName;
                    teachers[3] = t.Guide;

                    itm = new ListViewItem(teachers);
                    listViewTeachers.Items.Add(itm);
                }
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Teachers.Hide();
                pnl_StockDrinks.Hide();
                pnl_CheckOut.Hide();
                pnl_Sales.Hide();
                pnl_Activities.Hide();


                // show rooms
                pnl_Rooms.Show();

                // fill the rooms listview within the rooms panel with a list of rooms
                SomerenLogic.Room_Service roomService = new SomerenLogic.Room_Service();
                List<Room> roomList = roomService.GetRooms();

                // clear the listview before filling it again
                listViewRooms.Clear();

                listViewRooms.View = View.Details;
                listViewRooms.GridLines = true;
                listViewRooms.FullRowSelect = true;

                // Aanmaken van kolommen
                listViewRooms.Columns.Add("Room Number", 80);
                listViewRooms.Columns.Add("Capacity", 80);
                listViewRooms.Columns.Add("Room Type", 80);

                string[] rooms = new string[3];
                ListViewItem itm;

                foreach (SomerenModel.Room r in roomList)
                {
                    rooms[0] = r.Number.ToString();
                    rooms[1] = r.Capacity.ToString();
                    rooms[2] = r.Type;

                    itm = new ListViewItem(rooms);
                    listViewRooms.Items.Add(itm);
                }

            }
            else if (panelName == "StockDrinks")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_CheckOut.Hide();
                pnl_Sales.Hide();
                pnl_Activities.Hide();


                // show stock
                pnl_StockDrinks.Show();

                // fill the listview with a list of the stock
                List<StockDrinks> stockList = stockDrinksService.GetStock();

                // clear the listview first before filling it again
                listViewStockDrinks.Clear();

                // laten zien van de tabel
                listViewStockDrinks.View = View.Details;
                listViewStockDrinks.GridLines = true;
                listViewStockDrinks.FullRowSelect = true;

                // Aanmaken van kollomen
                listViewStockDrinks.Columns.Add("ID");
                listViewStockDrinks.Columns.Add("Name of drink", 100);
                listViewStockDrinks.Columns.Add("Stock");
                listViewStockDrinks.Columns.Add("Voucher price", 80);

                string[] drinks = new string[4];

                ImageList imgs = new ImageList();
                imgs.ImageSize = new Size(20, 20);

                String[] paths = { };
                paths = Directory.GetFiles("..\\..\\Resources");

                foreach (String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }

                listViewStockDrinks.SmallImageList = imgs;


                foreach (SomerenModel.StockDrinks sd in stockList)
                {
                    drinks[0] = sd.DrinkID.ToString();
                    drinks[1] = sd.Name;
                    drinks[2] = sd.Stock.ToString();
                    drinks[3] = sd.Price.ToString();

                    if (sd.Stock <= 10)
                    {
                        listViewStockDrinks.Items.Add(new ListViewItem(drinks) { ImageIndex = 2 });
                    }
                    else
                    {
                        listViewStockDrinks.Items.Add(new ListViewItem(drinks) { ImageIndex = 1 });
                    }

                }

            }
            else if (panelName == "CheckOut")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_StockDrinks.Hide();
                btn_Buy.Hide();
                pnl_Sales.Hide();
                pnl_Activities.Hide();

                // show checkout
                pnl_CheckOut.Show();

                // lijsten
                List<Student> studentList = studService.GetStudents();
                List<StockDrinks> drinkList = stockDrinksService.GetStock();

                // listview students
                listViewStudentsCO.Clear();

                listViewStudentsCO.View = View.Details;
                listViewStudentsCO.GridLines = true;
                listViewStudentsCO.CheckBoxes = true;

                listViewStudentsCO.Columns.Add("Student Number", 80);
                listViewStudentsCO.Columns.Add("First Name", 80);
                listViewStudentsCO.Columns.Add("Last Name", 100);
                listViewStudentsCO.Columns.Add("Vouchers", 50);

                string[] students = new string[4];
                ListViewItem itm;

                foreach (SomerenModel.Student s in studentList)
                {
                    students[0] = s.Number.ToString();
                    students[1] = s.FirstName;
                    students[2] = s.LastName;
                    students[3] = s.Vouchers.ToString();

                    itm = new ListViewItem(students);
                    listViewStudentsCO.Items.Add(itm);
                }

                // listview drinks
                listViewDrinksCO.Clear();

                listViewDrinksCO.View = View.Details;
                listViewDrinksCO.GridLines = true;
                listViewDrinksCO.CheckBoxes = true;

                listViewDrinksCO.Columns.Add("Name", 100);
                listViewDrinksCO.Columns.Add("Price", 70);
                listViewDrinksCO.Columns.Add("Stock", 70);

                string[] drinks = new string[3];

                foreach (SomerenModel.StockDrinks d in drinkList)
                {
                    drinks[0] = d.Name;
                    drinks[1] = d.Price.ToString();
                    drinks[2] = d.Stock.ToString();

                    itm = new ListViewItem(drinks);
                    listViewDrinksCO.Items.Add(itm);
                }
            }
            else if (panelName == "Sales")
            {
                // Hide other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_StockDrinks.Hide();
                pnl_CheckOut.Hide();
                pnl_Students.Hide();
                pnl_Activities.Hide();

                //show panel
                pnl_Sales.Show();

                // Clear the listView first
                listViewSales.Clear();

                listViewSales.View = View.Details;

                // Aanmaken van kolommen
                listViewSales.Columns.Add("Total sold drinks", 100);
                listViewSales.Columns.Add("Revenue", 100);
                listViewSales.Columns.Add("Customer count", 100);
            }
            else if (panelName == "Activities")
            {
                // Hide other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_StockDrinks.Hide();
                pnl_CheckOut.Hide();
                pnl_Students.Hide();
                pnl_Sales.Hide();

                //show panel
                pnl_Activities.Show();

                //Vraag de activiteiten op uit de database
                List<Activity> activityList = activityService.GetActivities();

                // listview activities
                listViewActivities.Clear();

                listViewActivities.View = View.Details;
                listViewActivities.GridLines = true;
                listViewActivities.CheckBoxes = true;

                listViewActivities.Columns.Add("ID", 70);
                listViewActivities.Columns.Add("Description", 160);
                listViewActivities.Columns.Add("Guides", 70);
                listViewActivities.Columns.Add("Participants", 70);

                string[] activity = new string[4];
                ListViewItem itm;

                foreach (SomerenModel.Activity d in activityList)
                {
                    activity[0] = d.ActivityID.ToString();
                    activity[1] = d.Description;
                    activity[2] = d.NumberOfGuides.ToString();
                    activity[3] = d.NumberOfParticipants.ToString();

                    itm = new ListViewItem(activity);
                    listViewActivities.Items.Add(itm);
                }
            }
        }

        // Menu item clicks
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }
        private void LecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }
        private void RoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }
        private void StockDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("StockDrinks");
        }
        private void FinanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }
        private void CheckOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("CheckOut");
        }
        private void SalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Sales");

        }
        private void ActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }
        private void ActivitiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }


        // buttons clicks en methodes
        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            btn_Buy.Hide();

            int totalPrice = 0;
            List<StockDrinks> drinks = stockDrinksService.GetStock();

            // geselecteerde student en dranken checken
            if (CheckSelectedStudents() && CheckSelectedDrinks())
            {
                btn_Buy.Show();
            }

            // geselecteerde drankjes
            CalcTotalPrice(ref totalPrice, drinks);

            // totaal prijs laten zien
            lbl_CalcTotal.Text = totalPrice.ToString();

        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            List<StockDrinks> drinks = stockDrinksService.GetStock();

            // geselecteerde student en drankjes bepalen
            Student student = GetSelectedStudent();

            // gekochte drankjes wegschrijven naar de databse
            string drinkName = "";

            for (int i = 0; i < listViewDrinksCO.Items.Count; i++)
            {
                drinkName = listViewDrinksCO.Items[i].Text;

                if (listViewDrinksCO.Items[i].Checked == true)
                {
                    foreach (StockDrinks drink in drinks)
                    {
                        if (drinkName == drink.Name)
                        {
                            int newStock = drink.Stock - 1;
                            int drankId = drink.DrinkID;
                            int sold = drink.Stock - newStock;
                            DateTime today = DateTime.Now;

                            string queryUpdate = "UPDATE drink SET stock=" + newStock + " WHERE drinkID=" + drankId;

                            string queryAdd = "INSERT INTO [order] (drinkID, amount, date, studentnumber) VALUES (" + drankId + ", " + sold + ", '" + today.ToString("yyyy/MM/dd") + "', " + student.Number + ")";

                            stockDrinksService.UpdateDrinks(queryUpdate);
                            stockDrinksService.UpdateDrinks(queryAdd);
                        }
                    }
                }
            }

            // totale prijs berekenen
            int totalPrice = 0;
            CalcTotalPrice(ref totalPrice, drinks);

            // geselecteerde student wegschrijven naar de database            

            if (student.Vouchers < totalPrice)
            {
                MessageBox.Show("Selected student does not have enough vouchers to buy this");
                return;
            }
            else
            {
                int newVouchers = student.Vouchers - totalPrice;

                string queryUpdStud = "UPDATE student SET vouchers=" + newVouchers + "WHERE studentNumber=" + student.Number;
                studService.UpdateStudent(queryUpdStud);
            }

            showPanel("CheckOut");
        }

        private bool CheckSelectedStudents()
        {
            int count = 0;

            for (int i = 0; i < listViewStudentsCO.Items.Count; i++)
            {
                if (listViewStudentsCO.Items[i].Checked == true)
                {
                    count++;

                    if (count > 1)
                    {
                        MessageBox.Show("Only select 1 student!");
                        return false;
                    }
                }
            }

            return true;
        }

        private bool CheckSelectedDrinks()
        {
            int count = 0;

            for (int i = 0; i < listViewDrinksCO.Items.Count; i++)
            {
                if (listViewDrinksCO.Items[i].Checked == true)
                {
                    count++;
                }
            }

            if (count < 1)
            {
                MessageBox.Show("Please select a drink");
                return false;
            }

            return true;
        }

        private void CalcTotalPrice(ref int totalPrice, List<StockDrinks> drinks)
        {
            string drinkName = "";

            for (int i = 0; i < listViewDrinksCO.Items.Count; i++)
            {
                drinkName = listViewDrinksCO.Items[i].Text;

                if (listViewDrinksCO.Items[i].Checked == true)
                {
                    foreach (StockDrinks drink in drinks)
                    {
                        if (drinkName == drink.Name)
                        {
                            totalPrice += drink.Price;
                        }
                    }
                }
            }

        }

        private Student GetSelectedStudent()
        {

            List<Student> students = studService.GetStudents();
            string studentNumber = "";
            Student selectedStudent = new Student();

            for (int i = 0; i < listViewStudentsCO.Items.Count; i++)
            {
                studentNumber = listViewStudentsCO.Items[i].Text;

                if (listViewStudentsCO.Items[i].Checked == true)
                {
                    foreach (Student student in students)
                    {
                        if (studentNumber == student.Number.ToString())
                        {
                            selectedStudent = student;
                        }
                    }
                }

            }

            return selectedStudent;
        }

        private void Btn_ShowSales_Click(object sender, EventArgs e)
        {
            List<Order> orders = GetAllOrdersBetweenDates();

            //Berekenen van de totale omzet
            float totalPrice = 0;
            foreach (Order order in orders)
            {
                totalPrice += order.Price;
            }


            //Het aantal klanten die iets heeft besteld
            List<int> alreadySeen = new List<int>();

            int totalCustomers = 0;
            foreach (Order order in orders)
            { 
                if (!alreadySeen.Contains(order.StudentNumber))
                {
                    totalCustomers++;
                    alreadySeen.Add(order.StudentNumber);
                }
            }

            int customerAmount = totalCustomers; 
            float omzet = totalPrice;  
            int afzet = orders.Count(); 

            string[] sales = new string[3];
            sales[0] = afzet.ToString();
            sales[1] = omzet.ToString();
            sales[2] = customerAmount.ToString();

            listViewSales.Items.Add(new ListViewItem(sales));
        }

        private List<Order> GetAllOrdersBetweenDates()
        {

            List<Order> orders = new List<Order>();
            DateTime dateStart = monthCalendarStart.SelectionRange.Start;
            DateTime dateEnd = monthCalendarEnd.SelectionRange.End;

            //Checkt of er een goede datum is ingevoerd
            if (dateStart >= dateEnd)
            {
                MessageBox.Show("Please make sure the START date is before the END date!");
            }
            else if (dateEnd > DateTime.Today)
            {
                MessageBox.Show("Please make sure the END date is not in the future");
            }
            else
            {
                orders = orderService.GetOrders(dateStart, dateEnd);
            }

            return orders;
        }

        private void Btn_DeleteActivity_Click(object sender, EventArgs e)
        {
            List<Activity> activities = activityService.GetActivities();
            string activityID;

            if (MessageBox.Show("Are you sure you want to delete this activity/these activities?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {              
                for (int i = 0; i < listViewActivities.Items.Count; i++)
                {
                    if (listViewActivities.Items[i].Checked)
                    {
                        activityID = listViewActivities.Items[i].Text;

                        foreach (Activity act in activities)
                        {
                            if (activityID == act.ActivityID.ToString())
                            {
                                string query = "DELETE FROM activities WHERE activityID=" + act.ActivityID;

                                activityService.UpdateActivity(query);
                            }
                        }

                        listViewActivities.Items.Remove(listViewActivities.Items[i]);
                    }
                }
            }
        }

        private void Btn_AddActivity_Click(object sender, EventArgs e)
        {
            AddingActivities form = new AddingActivities();
            form.ShowDialog();

            showPanel("Activities");
        }
    }
}

