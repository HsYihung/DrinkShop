using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace drink_shop
{
    class linksql
    {
        public static string myDBConnectionString = "";        
        public linksql()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "drinkDB";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }
    }
}
