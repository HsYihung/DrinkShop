using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_shop
{
    class GlobalVar
    {
        public static Form1 訂購人輸入;
        public static Form2 訂購單;
        public static Form3 結帳單;
        public static OrderMath orderMath = new OrderMath();
        public static int UserID = 0;
        public static string ClientName = "";
        public static string ClientNum = "";
        public static List<Order> OrderList = new List<Order>();
        public static string newShopName = "";
        public static int newShopNum = 0;
    }
}
