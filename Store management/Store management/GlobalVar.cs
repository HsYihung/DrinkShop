using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Store_management
{
    class GlobalVar
    {
        public static int storeID;
        public static Form1 login;
    }

    class linkSql
    {
        public static string myDBConnectionString = "";
        public linkSql()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "drinkDB";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }
    }
}
