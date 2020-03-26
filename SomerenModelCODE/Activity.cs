using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public Int16 ActivityID { get; set; }
        public String Description { get; set; }
        public Int16 NumberOfGuides { get; set; }
        public Int16 NumberOfParticipants { get; set; }
        public DateTime ActivityDate { get; set; }
    }
}
