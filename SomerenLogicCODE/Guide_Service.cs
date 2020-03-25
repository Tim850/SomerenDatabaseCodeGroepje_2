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
    public class Guide_Service
    {
        Guide_DAO guide_db = new Guide_DAO();

        public List<Guide> GetGuides()
        {
            try
            {
                List<Guide> guides = guide_db.Db_Get_All_Guides();
                return guides;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Guide> guides = new List<Guide>();
                Guide a = new Guide();
                a.ActivityID = 1;
                a.StaffNumber = 2;
                guides.Add(a);

                Guide b = new Guide();
                b.ActivityID = 1;
                b.StaffNumber = 3;
                guides.Add(b);

                return guides;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}