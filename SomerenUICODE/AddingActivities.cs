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
    public partial class AddingActivities : Form
    {
        SomerenLogic.Activity_Service activityService = new SomerenLogic.Activity_Service();

        public AddingActivities()
        {
            InitializeComponent();
        }

        private void Btn_AddAct_Click(object sender, EventArgs e)
        {
            List<Activity> activities = activityService.GetActivities();

            if (txt_ActDate.Text == "" || txt_ActID.Text == "" || txt_description.Text == "" || txt_NumGuides.Text == "" || txt_NumPart.Text == "")
            {
                MessageBox.Show("Please fill in ALL the fields to succesfully add an activity");
                return;
            }

            foreach (Activity act in activities)
            {
                if (txt_description.Text.ToLower() == act.Description.ToLower() || txt_ActID.Text == act.ActivityID.ToString())
                {
                    MessageBox.Show("The description or ID of an activity can not be the same as another activity");

                    txt_ActDate.Clear();
                    txt_ActID.Clear();
                    txt_description.Clear();
                    txt_NumGuides.Clear();
                    txt_NumPart.Clear();

                    return;
                }
            }

            string query = "INSERT INTO activities VALUES (" + txt_ActID.Text + ", '" + @txt_description.Text + "', " + @txt_NumGuides.Text + ", " + @txt_NumPart.Text + ", '" + @txt_ActDate.Text + "')";
            activityService.UpdateActivity(query);

            this.Close();
        }
    }
}
