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
    public class StockDrinks_DAO : Base
    {
        public List<StockDrinks> Db_Get_All_Stock()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<StockDrinks> ReadTables(DataTable dataTable)
        {
            List<StockDrinks> stock = new List<StockDrinks>();

            foreach (DataRow dr in dataTable.Rows)
            {
                StockDrinks drink = new StockDrinks()
                {
                    Name = (String)dr["name"],
                    Price = (int)dr["priceInVouchers"],
                    Stock = (int)dr["stock"]
                };
                stock.Add(drink);
            }
            return stock;
        }
    }
}
