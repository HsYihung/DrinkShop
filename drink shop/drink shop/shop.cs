using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace drink_shop
{
    class shop
    {
        linksql link = new linksql();
        public List<Feed> listFeed = new List<Feed>();
        public List<Drink> listDrink = new List<Drink>();
        public shop(int shopID)
        {
            SqlConnection con = new SqlConnection(linksql.myDBConnectionString);
            con.Open();
            string strSQL = $"select DrinkID,DrinkName,Price,(select (d.Stock-isnull(sum(Quantity),0)) from [Order] where DrinkID = d.DrinkID) as Stock from Drink as d where ShopID = @shopID order by Price";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@shopID", shopID);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Drink drink = new Drink();
                drink.id = (int)reader["DrinkID"];
                drink.name = (string)reader["DrinkName"];
                drink.price = (int)reader["Price"];
                drink.stock = (int)reader["Stock"];
                Console.WriteLine((int)reader["Stock"]);
                listDrink.Add(drink);
            }
            reader.Close();
            strSQL = "select FeedID,FeedName,Price ,(select (f.Stock - isnull(sum(Quantity),0)) from [Order] where FeedID = f.FeedID ) as Stock from Feed as f where ShopID = @shopID order by Price";
            cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@shopID", shopID);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Feed feed = new Feed();
                feed.id = (int)reader["FeedID"];
                feed.name = (string)reader["FeedName"];
                feed.price = (int)reader["Price"];
                feed.stock = (int)reader["Stock"];
                Console.WriteLine((int)reader["Stock"]);
                listFeed.Add(feed);
            }
            reader.Close();
            con.Close();
        }
    }
}
