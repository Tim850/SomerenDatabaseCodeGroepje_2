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
    public partial class EditActivity : Form
    {
        public Activity selectedAct;
        SomerenLogic.Activity_Service activityService = new SomerenLogic.Activity_Service();

        public EditActivity(Activity selectedAct)
        {
            InitializeComponent();
            this.selectedAct = selectedAct;
        }

        private void Btn_EditAct_Click(object sender, EventArgs e)
        {
            string newDescription;
            Int16 newNumGuides;
            Int16 newNumPart;
            DateTime newDate;

            if (txt_description.Text == "")
            {
                newDescription = selectedAct.Description;
            }
            else
            {
                newDescription = txt_description.Text;
            }

            if (txt_NumGuides.Text == "")
            {
                newNumGuides = selectedAct.NumberOfGuides;
            }
            else
            {
                newNumGuides = Int16.Parse(txt_NumGuides.Text);
            }

            if (txt_NumPart.Text == "")
            {
                newNumPart = selectedAct.NumberOfParticipants;
            }
            else
            {
                newNumPart = Int16.Parse(txt_NumPart.Text);
            }

            if (txt_ActDate.Text == "")
            {
                newDate = selectedAct.ActivityDate;
            }
            else
            {
                newDate = DateTime.Parse(txt_ActDate.Text);
            }

            string query = "UPDATE activities SET [description]='" + newDescription + "', numberOfGuides=" + newNumGuides + ", numberOfParticipants=" + newNumPart + ", [date]='" + newDate.ToString("yyyy/MM/dd") + "' WHERE activityID=" + selectedAct.ActivityID;
            activityService.UpdateActivity(query);

            this.Close();
        }

        private void EditActivity_Load(object sender, EventArgs e)
        {
            lbl_OldActDate.Text = selectedAct.ActivityDate.ToString("yyyy/MM/dd");
            lbl_OldDescr.Text = selectedAct.Description;
            lbl_OldNumGuides.Text = selectedAct.NumberOfGuides.ToString();
            lbl_OldNumPart.Text = selectedAct.NumberOfParticipants.ToString();
        }
    }
}
