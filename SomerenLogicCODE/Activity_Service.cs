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
    public class Activity_Service
    {
        Activity_DAO activity_db = new Activity_DAO();

        public List<Activity> GetActivities()
        {
            try
            {
                List<Activity> activities = activity_db.Db_Get_All_Activities();
                return activities;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Activity> activities = new List<Activity>();
                Activity a = new Activity();
                a.ActivityID = 1;
                a.Description = "A game of laser tag. Gather in front of the barn when it is time for this activity.";
                a.NumberOfGuides = 2;
                a.NumberOfParticipants = 20;
                activities.Add(a);

                Activity b = new Activity();
                b.ActivityID = 2;
                b.Description = "A food fight. This activity will be held in the cantine.";
                b.NumberOfGuides = 5;
                b.NumberOfParticipants = 6840;
                activities.Add(b);

                return activities;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}