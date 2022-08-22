using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_shop
{
    class Order
    {
        public string shopName;
        public int shopID = 0;
        public int drinkID = 0;
        public int FeedID = 0;
        public string drinkName = "";
        public string ice = "";
        public string sugar = "";
        public string feedName = "";
        public int dPrice = 0;
        public int fPrice = 0;
        public int fdPrice
        {
            get { return dPrice + fPrice; }
            set { }
        }
        public double orderPrice = 0.0;
        public int quantity = 0;
    }
}
