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
        public List<Order> Db_Get_All_Orders(DateTime dateStart, DateTime dateEnd)
        {
            string query = "SELECT orderNummer, [order].drinkID, amount, [order].[date], studentNumber, drink.purchasePrice FROM [order] JOIN drink ON drink.drinkID = [order].drinkID WHERE [date] >= '" + dateStart.ToString("yyyy/MM/dd") + "' AND [date] <= '" + dateEnd.ToString("yyyy/MM/dd") + "'";
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
                    OrderNumber = (int)dr["orderNummer"],
                    DrinkID = (Int16)dr["drinkID"],
                    Amount = (int)dr["amount"],
                    Date = (DateTime)dr["date"],
                    StudentNumber = (int)dr["studentnumber"],
                    Price = (float)dr["purchasePrice"]         
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
