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
    public class StockDrinks_Service
    {
        StockDrinks_DAO stock_db = new StockDrinks_DAO();

        public List<StockDrinks> GetStock()
        {
            try
            {
                List<StockDrinks> stock = stock_db.Db_Get_All_Stock();
                return stock;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<StockDrinks> stock = new List<StockDrinks>();
                StockDrinks a = new StockDrinks();
                a.DrinkID = 1;
                a.Name = "testDrank1";
                a.Price = 2;
                a.Stock = 13;
                stock.Add(a);

                StockDrinks b = new StockDrinks();
                b.DrinkID = 2;
                b.Name = "testDrank2";
                b.Price = 1;
                b.Stock = 7;
                stock.Add(b);

                return stock;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
