using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class EditActivity : Form
    {
        public EditActivity()
        {
            InitializeComponent();
        }

        private void Btn_EditAct_Click(object sender, EventArgs e)
        {

            string query = "UPDATE activities SET description=@newDescription, numberOfGuides=@newNumGuides, numberOfParticipants=@newNumPart WHERE activityID=@actID";
        }
    }
}
