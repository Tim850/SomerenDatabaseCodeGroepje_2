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
    public class Order_Service
    {
        Order_DAO order_db = new Order_DAO();

        public List<Order> GetStock()
        {
            try
            {
                List<Order> order = order_db.Db_Get_All_Stock();
                return order;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Order> orders = new List<Order>();
                Order a = new Order();
                a.DrinkID = 1;
                a.OrderNumber = 6;
                a.StudentNumber = 1;
                a.Date = DateTime.Now;
                orders.Add(a);

                Order b = new Order();
                b.DrinkID = 4;
                b.OrderNumber = 7;
                b.StudentNumber = 2;
                b.Date = DateTime.Now;
                orders.Add(b);

                return orders;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
