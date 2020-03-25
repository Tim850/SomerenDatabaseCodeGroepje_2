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
    public class Guide_DAO : Base
    {
        public List<Guide> Db_Get_All_Guides()
        {
            string query = "SELECT staffNumber, activityID FROM guides";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Guide> ReadTables(DataTable dataTable)
        {
            List<Guide> guides = new List<Guide>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Guide guide = new Guide()
                {
                    ActivityID = (Int16)dr["activityID"],
                    StaffNumber = (int)dr["staffNumber"]
                };
                guides.Add(guide);
            }
            return guides;
        }
    }
}
