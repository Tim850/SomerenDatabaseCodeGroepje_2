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
    public class Order_DAO : Base
    {
        public List<Order> Db_Get_All_Stock()
        {
            string query = "";  //HIER MOET NOG EEN SQL QUERYYYYYY
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    DrinkID = (Int16)dr["drinkID"],
                    OrderNumber = (int)dr["orderNumber"],
                    StudentNumber = (int)dr["studentnumber"],
                    Date = (DateTime)dr["date"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
