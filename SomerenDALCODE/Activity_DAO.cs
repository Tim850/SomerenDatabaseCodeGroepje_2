using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Activity_DAO : Base
    {
        public List<Activity> Db_Get_All_Activities()
        {
            string query = "SELECT activityID, [description], numberOfGuides, numberOfParticipants FROM activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityID = (Int16)dr["activityID"],
                    Description = (String)dr["description"],
                    NumberOfGuides = (Int16)dr["numberOfGuides"],
                    NumberOfParticipants = (Int16)dr["numberOfParticipants"]
                };
                activities.Add(activity);
            }
            return activities;
        }
        
        public void Db_Update_Activity(string query)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
