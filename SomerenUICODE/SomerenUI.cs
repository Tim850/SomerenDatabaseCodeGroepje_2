using SomerenLogic;
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
        SomerenLogic.Guide_Service guideService = new SomerenLogic.Guide_Service();
        SomerenLogic.Schedule_Service scheduleService = new SomerenLogic.Schedule_Service();
        SomerenLogic.Teacher_Service teachService = new SomerenLogic.Teacher_Service();

        //sorter
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        
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
                pnl_Guides.Hide();
                pnl_Schedule.Hide();

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
                pnl_Guides.Hide();
                pnl_Schedule.Hide();

                // show students
                pnl_Students.Show();

                // fill the students listview within the students panel with a list of students

                List<Student> studentList = studService.GetStudents();

                lvwColumnSorter = new ListViewColumnSorter();
                listViewStudents.ListViewItemSorter = lvwColumnSorter;

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
                pnl_Guides.Hide();
                pnl_Schedule.Hide();


                // show students
                pnl_Teachers.Show();

                // fill the students listview within the students panel with a list of students
                List<Teacher> teacherList = teachService.GetTeachers();

                //sorter
                lvwColumnSorter = new ListViewColumnSorter();
                listViewTeachers.ListViewItemSorter = lvwColumnSorter;

                // clear the listview before filling it again
                listViewTeachers.Clear();

                listViewTeachers.View = View.Details;
                listViewTeachers.GridLines = true;
                listViewTeachers.FullRowSelect = true;

                // Aanmaken van kollomen
                listViewTeachers.Columns.Add("Teacher Number", 100);
                listViewTeachers.Columns.Add("First Name", 100);
                listViewTeachers.Columns.Add("Last Name", 100);

                string[] teachers = new string[3];
                ListViewItem itm;

                foreach (SomerenModel.Teacher t in teacherList)
                {
                    // Items toevoegen aan een lijst
                    teachers[0] = t.Number.ToString();
                    teachers[1] = t.FirstName;
                    teachers[2] = t.LastName;

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
                pnl_Guides.Hide();
                pnl_Schedule.Hide();


                // show rooms
                pnl_Rooms.Show();

                // fill the rooms listview within the rooms panel with a list of rooms
                SomerenLogic.Room_Service roomService = new SomerenLogic.Room_Service();
                List<Room> roomList = roomService.GetRooms();

                //sorter
                lvwColumnSorter = new ListViewColumnSorter();
                listViewRooms.ListViewItemSorter = lvwColumnSorter;

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
                pnl_Guides.Hide();
                pnl_Schedule.Hide();


                // show stock
                pnl_StockDrinks.Show();

                // fill the listview with a list of the stock
                List<StockDrinks> stockList = stockDrinksService.GetStock();

                //sorter
                lvwColumnSorter = new ListViewColumnSorter();
                listViewStockDrinks.ListViewItemSorter = lvwColumnSorter;

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
                pnl_Guides.Hide();
                pnl_Schedule.Hide();

                // show checkout
                pnl_CheckOut.Show();

                // lijsten
                List<Student> studentList = studService.GetStudents();
                List<StockDrinks> drinkList = stockDrinksService.GetStock();

                //Sorter
                lvwColumnSorter = new ListViewColumnSorter();
                listViewStudentsCO.ListViewItemSorter = lvwColumnSorter;

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


                //Sorter
                lvwColumnSorter = new ListViewColumnSorter();
                listViewDrinksCO.ListViewItemSorter = lvwColumnSorter;

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
                pnl_Guides.Hide();
                pnl_Schedule.Hide();

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
                pnl_Guides.Hide();
                pnl_Schedule.Hide();

                //show panel
                pnl_Activities.Show();
                
                //sorter
                lvwColumnSorter = new ListViewColumnSorter();
                listViewActivities.ListViewItemSorter = lvwColumnSorter;

                //sorter
                lvwColumnSorter = new ListViewColumnSorter();
                listViewActivities.ListViewItemSorter = lvwColumnSorter;

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
            else if (panelName == "Schedule")
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
                pnl_Activities.Hide();
                btn_Buy.Hide();
                pnl_Guides.Hide();

                //show panel
                pnl_Schedule.Show();

                List<Schedule> scheduleList = scheduleService.GetSchedule();

                // clear the listview before filling it again
                listViewSchedule.Clear();

                listViewSchedule.View = View.Details;
                listViewSchedule.GridLines = true;
                listViewSchedule.FullRowSelect = true;

                // Aanmaken van kolommen
                listViewSchedule.Columns.Add("Time", 75);
                listViewSchedule.Columns.Add("Monday", 200);
                listViewSchedule.Columns.Add("Tuesday", 250);
                listViewSchedule.Columns.Add("Wednesday", 100);
                listViewSchedule.Columns.Add("Thursday", 100);
                listViewSchedule.Columns.Add("Friday", 100);

                string[] schedule = new string[6];
                ListViewItem itm;

                foreach (SomerenModel.Schedule s in scheduleList)
                {
                    schedule[0] = s.time;
                    schedule[1] = s.monday;
                    schedule[2] = s.tuesday;
                    schedule[3] = s.Wednesday;
                    schedule[4] = s.thursday;
                    schedule[5] = s.Friday;

                    itm = new ListViewItem(schedule);
                    listViewSchedule.Items.Add(itm);
                }

            } 
            else if (panelName == "Guides")
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
                pnl_Activities.Hide();
                btn_Buy.Hide();
                pnl_Schedule.Hide();

                //show panel
                pnl_Guides.Show();

                //sorter
                lvwColumnSorter = new ListViewColumnSorter();
                listViewGuides.ListViewItemSorter = lvwColumnSorter;

                //Vraag de activiteiten op uit de database
                List<Guide> guideList = guideService.GetGuides();
                List<Teacher> teacherList = teachService.GetTeachers();
                List<Activity> activityList = activityService.GetActivities();

                //vul de combobox met alle teachers waar je uit kunt kiezen om toe te voegen
                cmb_Teachers.Items.Clear();
                foreach (Teacher teacher in teacherList)
                {
                    cmb_Teachers.Items.Add(teacher);
                }

                cmb_Teachers.SelectedIndex = 0;

                //vul de combobox met activities
                cmb_Activities.Items.Clear();
                foreach (Activity act in activityList)
                {
                    cmb_Activities.Items.Add(act);
                }

                cmb_Activities.SelectedIndex = 0;

                // listview guides
                listViewGuides.Clear();

                listViewGuides.View = View.Details;
                listViewGuides.GridLines = true;
                listViewGuides.CheckBoxes = true;

                listViewGuides.Columns.Add("ActivityID", 70);
                listViewGuides.Columns.Add("StaffNumber", 70);

                string[] guide = new string[2];
                ListViewItem itm;

                foreach (SomerenModel.Guide d in guideList)
                {
                    guide[0] = d.ActivityID.ToString();
                    guide[1] = d.StaffNumber.ToString();

                    itm = new ListViewItem(guide);
                    listViewGuides.Items.Add(itm);
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
        private void ScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Schedule");
        }
        private void GuidesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Guides");
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

        private void btn_AddActivity_Click_1(object sender, EventArgs e)
        {
            AddingActivities form = new AddingActivities();
            form.ShowDialog();

            showPanel("Activities");
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
                                string query = "DELETE FROM guides WHERE activityID=" + act.ActivityID + "DELETE FROM activities WHERE activityID=" + act.ActivityID;

                                activityService.UpdateActivity(query);
                            }
                        }

                        listViewActivities.Items.Remove(listViewActivities.Items[i]);
                    }
                }
            }
        }

        private void Btn_EditActivity_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < listViewActivities.Items.Count; i++)
            {
                if (listViewActivities.Items[i].Checked)
                {
                    count++;

                    if (count > 1)
                    {
                        MessageBox.Show("Only select 1 activity!");
                    }
                }
            }

            if (count == 0)
            {
                MessageBox.Show("Select an activity to edit it");
                return;
            }

            Activity selectedAct = GetSelectedAct();
            EditActivity form = new EditActivity(selectedAct);
            form.ShowDialog();

            showPanel("Activities");
        }

        private Activity GetSelectedAct()
        {
            List<Activity> activities = activityService.GetActivities();
            string actID = "";
            Activity selectedAct = new Activity();

            for (int i = 0; i < listViewActivities.Items.Count; i++)
            {
                actID = listViewActivities.Items[i].Text;

                if (listViewActivities.Items[i].Checked == true)
                {
                    foreach (Activity act in activities)
                    {
                        if (actID == act.ActivityID.ToString())
                        {
                            selectedAct = act;
                        }
                    }
                }

            }

            return selectedAct;
        }

        private void btn_AddGuide_Click(object sender, EventArgs e)
        {
            // geselecteerde docent uit van de combobox guide maken
            Teacher teacher = (Teacher)cmb_Teachers.SelectedItem;

            // geselecteerde activity uit combobox
            Activity activity = (Activity)cmb_Activities.SelectedItem;

            string query = "INSERT INTO guides (staffNumber, activityID) VALUES (" + teacher.Number + ", " + activity.ActivityID + ")";
            guideService.UpdateGuide(query);

            showPanel("Guides");
        }

        private void btn_DeleteGuide_Click(object sender, EventArgs e)
        {
            List<Guide> guides = guideService.GetGuides();
            string guideID;

            if (MessageBox.Show("Are you sure you want to delete this guide/these guides?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < listViewGuides.Items.Count; i++)
                {
                    if (listViewGuides.Items[i].Checked)
                    {
                        guideID = listViewGuides.Items[i].SubItems[1].Text;

                        foreach (Guide guide in guides)
                        {
                            if (guideID == guide.StaffNumber.ToString())
                            {
                                // guide verwijderen uit guide tabel
                                string queryDel = "DELETE FROM guides WHERE staffnumber=" + guide.StaffNumber;
                                guideService.UpdateGuide(queryDel);
                            }
                        }

                        listViewGuides.Items.Remove(listViewGuides.Items[i]);
                    }
                }
            }
        }

        private void btn_EditGuide_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < listViewGuides.Items.Count; i++)
            {
                if (listViewGuides.Items[i].Checked)
                {
                    count++;

                    if (count > 1)
                    {
                        MessageBox.Show("Only select 1 guide!");
                    }
                }
            }

            if (count == 0)
            {
                MessageBox.Show("Select an guide to edit it");
                return;
            }

            Guide selectedGuide = GetSelectedGuide();
            EditGuide form = new EditGuide(selectedGuide);
            form.ShowDialog();

            showPanel("Guides");
        }

        private Guide GetSelectedGuide()
        {
            List<Guide> guides = guideService.GetGuides();
            string staffID = "";
            Guide selectedGuide = new Guide();

            for (int i = 0; i < listViewGuides.Items.Count; i++)
            {
                staffID = listViewGuides.Items[i].SubItems[1].Text;

                if (listViewGuides.Items[i].Checked == true)
                {
                    foreach (Guide guide in guides)
                    {
                        if (staffID == guide.StaffNumber.ToString())
                        {
                            selectedGuide = guide;
                        }
                    }
                }

            }

            return selectedGuide;
        }
        
        //OnClick events voor de column sorter
        private void ListViewActivities_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            OrderListView(e, listViewActivities);
        }
        private void ListViewGuides_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            OrderListView(e, listViewGuides);
        }

        private void ListViewDrinksCO_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            OrderListView(e, listViewDrinksCO);
        }

        private void ListViewStudentsCO_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            OrderListView(e, listViewStudentsCO);
        }

        private void ListViewRooms_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            OrderListView(e, listViewRooms);
        }

        private void ListViewStockDrinks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            OrderListView(e, listViewStockDrinks);
        }

        private void ListViewStudents_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            OrderListView(e, listViewStudents);
        }

        private void ListViewTeachers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            OrderListView(e, listViewTeachers);
        }


        private void OrderListView(ColumnClickEventArgs e, ListView lv)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                    lvwColumnSorter.Order = SortOrder.Descending;
                else
                    lvwColumnSorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            
            lv.Sort();
        }
    }
}

