using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using SomerenUI.Properties;
using System.IO;
using System.Data.SqlTypes;

namespace SomerenUI
{
    public partial class EditGuide : Form
    {
        private Guide selectedGuide;
        SomerenLogic.Activity_Service activityService = new SomerenLogic.Activity_Service();
        SomerenLogic.Guide_Service guideService = new SomerenLogic.Guide_Service();

        public EditGuide(Guide selectedGuide)
        {
            InitializeComponent();
            this.selectedGuide = selectedGuide;
        }

        private void EditGuide_Load(object sender, EventArgs e)
        {
            List<Activity> activityList = activityService.GetActivities();

            cmb_NewActivity.Items.Clear();
            foreach (Activity act in activityList)
            {
                cmb_NewActivity.Items.Add(act);
            }

            cmb_NewActivity.SelectedIndex = 0;

            lbl_OldAct.Text = selectedGuide.ActivityID.ToString();
        }

        private void btn_EditGuide_Click(object sender, EventArgs e)
        {
            Activity newAct = (Activity)cmb_NewActivity.SelectedItem;

            if (newAct.ActivityID == selectedGuide.ActivityID)
            {
                MessageBox.Show("New activity can not be the same as old activity!");
                return;
            }

            string query = "UPDATE guides SET activityID=" + newAct.ActivityID + " WHERE staffNumber=" + selectedGuide.StaffNumber;
            guideService.UpdateGuide(query);

            this.Close();
        }
    }
}
