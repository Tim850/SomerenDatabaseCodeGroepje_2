using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Schedule_Service
    {
        Schedule_DAO schedule_db = new Schedule_DAO();

        public List<Schedule> GetSchedule()
        {
            //try
            //{
                List<Schedule> schedule = schedule_db.Db_Get_All_Schedule();
                return schedule;
            //}
            //catch (Exception)
            //{
            //    // something went wrong connecting to the database, so we will add a fake schedule to the list to make sure the rest of the application continues working!
            //    List<Schedule> schedule = new List<Schedule>();
            //    Schedule a = new Schedule();
            //    a.monday = "test";
            //    a.tuesday = "testt";
            //    schedule.Add(a);
            //    Schedule b = new Schedule();
            //    b.monday = "testing";
            //    b.tuesday = "testting";
            //    schedule.Add(b);
            //    return schedule;
            //    //throw new Exception("Someren couldn't connect to the database");
            //}

        }
    }
}
