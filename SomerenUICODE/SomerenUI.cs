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


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
        SomerenLogic.StockDrinks_Service stockDrinksService = new SomerenLogic.StockDrinks_Service();

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
                listViewStockDrinks.Columns.Add("Name of drink");
                listViewStockDrinks.Columns.Add("Stock");
                listViewStockDrinks.Columns.Add("Voucher price");

                //Plaatjes laten zien of er nog voorraad is
                foreach (SomerenModel.StockDrinks sd in stockList)
                {
                    if (sd.Stock <= 10)
                    {

                    }
                    else
                    {

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

                string[] students = new string[3];
                ListViewItem itm;

                foreach (SomerenModel.Student s in studentList)
                {
                    students[0] = s.Number.ToString();
                    students[1] = s.FirstName;
                    students[2] = s.LastName;

                    itm = new ListViewItem(students);
                    listViewStudentsCO.Items.Add(itm);
                }

                // listview drinks
                listViewDrinksCO.Clear();

                listViewDrinksCO.View = View.Details;
                listViewDrinksCO.GridLines = true;
                listViewDrinksCO.CheckBoxes = true;

                listViewDrinksCO.Columns.Add("Name", 80);
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

        private void CheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("CheckOut");
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            // geselecteerde student checken
            SelectedStudents();

            // geselecteerde drankjes
            SelectedDrinks();

            

            btn_Buy.Show();

        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            SelectedStudents();
        }

        private void SelectedStudents()
        {
            for (int i = 0; i < listViewStudentsCO.Items.Count; i++)
            {
                if (listViewStudentsCO.Items[i].Checked == true)
                {
                    //MessageBox.Show("Gelukt");
                }
            }
        }

        private void SelectedDrinks()
        {
            int totalPrice = 0;

            List<StockDrinks> drinks = stockDrinksService.GetStock();
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
    }
}
