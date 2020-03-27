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
    public class Schedule_DAO : Base
    {

        public List<Schedule> Db_Get_All_Schedule()
        {
            string query = "SELECT [time], monday, tuesday, Wednesday, thursday, Friday From schedule ORDER BY [time]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Schedule> ReadTables(DataTable dataTable)
        {
            List<Schedule> schedule = new List<Schedule>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Schedule schedulee = new Schedule()
                {
                    time = (String)dr["time"],
                    monday = (String)dr["monday"],
                    tuesday = (String)dr["tuesday"],
                    Wednesday = (String)dr["Wednesday"],
                    thursday = (String)dr["thursday"],
                    Friday = (String)dr["Friday"]
                };
                schedule.Add(schedulee);
                if (dr == null);
            }
            return schedule;
        }
    }
}
