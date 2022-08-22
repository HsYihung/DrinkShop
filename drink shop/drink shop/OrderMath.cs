using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_shop
{
    class OrderMath
    {
        double _totOrderPrice = 0.0;
        public double _texPrice = 0.0;
        double _DisPrice = 0.0;
        public string DisName = "";
        public int DisNum = 0;
        int _OrderDPrice = 0;
        int _OrderQuantity = 0;
        public int shopNum = 0;
        List<int> discountTemp = new List<int>();
        List<int> discount = new List<int>();

        public double totOrderPrice
        {
            get
            {
                double outtotal = _totOrderPrice + _texPrice - _DisPrice;                
                return outtotal;
            }
            set
            {

            }
        }
        public double orderPrice(int myPrice,int myQuantity )
        {
            double mytotal = 0.0;
            mytotal = myPrice * myQuantity;
            _OrderQuantity = myQuantity;
            _OrderDPrice = myPrice;
            _totOrderPrice += mytotal;
            discountAdd();
            return mytotal;
        }
        void discountAdd()
        {
            for(int i= 0;i < _OrderQuantity;i++)
            {
                discountTemp.Add(_OrderDPrice);
            }
            discount.AddRange(discountTemp);
            discountTemp.Clear();
            discount.Sort();
            _OrderDPrice = 0;
            _OrderQuantity = 0;
        }
        public void texMath(bool tex)
        {
            if (tex)
            {                
                _texPrice = (_totOrderPrice - _DisPrice) * 0.05;
            }
            else
            {
                _texPrice = 0;
            }
        }

        public void reOrder(int myDPrice,int myQuantity)
        {
            _totOrderPrice -= (myDPrice * myQuantity);
            _OrderDPrice = myDPrice;
            _OrderQuantity = myQuantity;
            discountRemove();
        }
        void discountRemove()
        {
            for(int i = 0;i < _OrderQuantity ;i++)
            {
                discount.Remove(_OrderDPrice);
            }
            _OrderDPrice = 0;
            _OrderQuantity = 0;
        }

        public void discountMath()
        {
            switch(DisNum)
            {
                case 1://買二送一
                    if(discount.Count>=3)
                    {
                        _DisPrice = discount[0];
                        DisName = "買二送一";
                    }
                    else
                    {
                        _DisPrice = 0;
                        DisName = "";
                    }
                    break;
                case 2://第二杯半價
                    if(discount.Count >=2)
                    {
                        _DisPrice = discount[0] / 2;
                        DisName = "第二杯半價";
                    }
                    else
                    {
                        _DisPrice = 0;
                        DisName = "";
                    }
                    break;
                case 3://買三送一
                    if(discount.Count>=4)
                    {
                        _DisPrice = 0;
                        for(int i = 0; i<discount.Count/4; i++)
                        {
                            _DisPrice += discount[i];
                            
                        }

                        DisName = "買三送一";
                    }
                    else
                    {
                        _DisPrice = 0;
                        DisName = "";
                    }
                    break;
            }
        }
        
        public void clear()
        {
            _totOrderPrice = 0;
            discount.Clear();
            discountTemp.Clear();
        }


    }
}
