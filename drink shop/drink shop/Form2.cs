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

namespace drink_shop
{
    public partial class Form2 : Form
    {
        shop myShop;
        List<int> listShopID = new List<int>();
        List<string> listIce = new List<string>();
        List<string> listSuger = new List<string>();
        string feedName = "";
        int feedID = 0;
        string drinkName = "";
        string ice = "";
        string sugar = "";
        int dPrice = 0;
        int fPrice = 0;
        int dfPrice = 0;
        int quantity = 0;
        int drinkID = 0;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblClient.Text = GlobalVar.ClientName;
            lblClientNum.Text = GlobalVar.ClientNum;
            SqlConnection con = new SqlConnection(linksql.myDBConnectionString);
            con.Open();
            string strSQL = "select * from shop";
            SqlCommand cmd = new SqlCommand(strSQL,con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                cboxDSChoose.Items.Add((string)reader["ShopName"]);
                listShopID.Add((int)reader["ShopID"]);
            }

            listIce.Add("正常");
            listIce.Add("少冰");
            listIce.Add("微冰");
            listIce.Add("去冰");

            listSuger.Add("正常");
            listSuger.Add("半糖");
            listSuger.Add("微糖");
            listSuger.Add("無糖");

            foreach(string myItem in listIce)
            {
                cboxIce.Items.Add(myItem);
            }
            cboxIce.SelectedIndex = 0;
            ice = listIce[cboxIce.SelectedIndex];
            foreach(string myItem in listSuger)
            {
                cboxSugar.Items.Add(myItem);
            }
            cboxSugar.SelectedIndex = 0;
            sugar = listSuger[cboxSugar.SelectedIndex];
            quantity = 1;
            txtQuantity.Text = quantity.ToString();
            顯示價格();
        }

        private void cboxDSChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboxDSChoose.SelectedIndex;
            myShop = new shop(listShopID[index]);
            lboxDrink.Items.Clear();
            lboxFeed.Items.Clear();
            foreach (Drink item in myShop.listDrink)
            {
                string strItem = item.name;
                int L = strItem.Length;
                for (int i = 1; i <= 15 - L; i++)
                {
                    strItem += "--";
                }
                strItem += $"{item.price}元";
                lboxDrink.Items.Add(strItem);
            }
            foreach (Feed item in myShop.listFeed)
            {
                string strItem = item.name;
                int L = strItem.Length;
                for (int i = 1; i <= 7 - L; i++)
                {
                    strItem += "--";
                }
                strItem += $"{item.price}元";
                lboxFeed.Items.Add(strItem);
            }
            lboxDrink.Enabled = true;
            lboxFeed.Enabled = true;
        }
        private void lboxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lboxDrink.SelectedIndex;
            try
            {
                drinkName = myShop.listDrink[index].name;
                drinkID = myShop.listDrink[index].id;
                dPrice = myShop.listDrink[index].price;
                顯示價格();
            }
            catch
            {

            }

        }

        private void cboxSugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            sugar = listSuger[cboxSugar.SelectedIndex];
        }

        private void cboxIce_SelectedIndexChanged(object sender, EventArgs e)
        {
            ice = listIce[cboxIce.SelectedIndex];
        }

        private void lboxFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                
                fPrice = myShop.listFeed[lboxFeed.SelectedIndex].price;
                feedID = myShop.listFeed[lboxFeed.SelectedIndex].id;
                feedName = myShop.listFeed[lboxFeed.SelectedIndex].name;
                顯示價格();
            }
            catch
            {

            }
        }

        private void btnFeedClear_Click(object sender, EventArgs e)
        {
            fPrice = 0;
            feedName = "";
            lboxFeed.SelectedItems.Clear();
            顯示價格();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text != "")
            {
                if (Int32.TryParse(txtQuantity.Text, out quantity))
                {
                    if (quantity < 1)
                    {
                        quantity = 1;
                    }
                }
                else
                {
                    txtQuantity.Text = "1";
                }
            }
        }

        private void btnJoinOrder_Click(object sender, EventArgs e)
        {
            if(drinkName == "")
            {
                MessageBox.Show("未選擇飲料");
                return;
            }
            if(quantity > myShop.listDrink[lboxDrink.SelectedIndex].stock)
            {
                MessageBox.Show("所選飲料庫存不足");
                return;
            }
            if (fPrice!=0)
            {
                if (quantity > myShop.listFeed[lboxFeed.SelectedIndex].stock)
                {
                    MessageBox.Show("所選配料庫存不足");
                    myShop.listFeed[lboxFeed.SelectedIndex].stock -= quantity;
                    return;
                }
            }
            myShop.listDrink[lboxDrink.SelectedIndex].stock -= quantity;            
            Order order = new Order();
            order.shopName = cboxDSChoose.SelectedItem.ToString();
            order.shopID = listShopID[cboxDSChoose.SelectedIndex];            
            order.drinkName = drinkName;
            order.drinkID = drinkID;
            order.quantity = quantity;
            order.feedName = feedName;
            order.FeedID = feedID;
            order.fPrice = fPrice;
            order.dPrice = dPrice;
            order.sugar = sugar;
            order.ice = ice;
            order.orderPrice = GlobalVar.orderMath.orderPrice(order.fdPrice, order.quantity);            
            GlobalVar.OrderList.Add(order);
            orderReset();
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            if (GlobalVar.結帳單 == null)
            {
                Form3 結帳單 = new Form3();
                GlobalVar.結帳單 = 結帳單;                
            }
            else
            {
                GlobalVar.結帳單.showForm3();
            }
            GlobalVar.結帳單.Show();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVar.訂購人輸入.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.訂購人輸入.Close();
        }
        //
        void 顯示價格()
        {
            dfPrice = dPrice + fPrice;
            int thistotal = dfPrice * quantity;
            lblPrice.Text = dfPrice.ToString();
            lblTotal.Text = thistotal.ToString();
        }
        void orderReset()
        {
            drinkName = "";
            feedID = 0;
            feedName = "";           
            fPrice = 0;
            txtQuantity.Text = "1";
            quantity = 1;
            lboxDrink.SelectedIndices.Clear();
            lboxFeed.SelectedIndices.Clear();           
        }
        public void Form2show()
        {
            lblClient.Text = GlobalVar.ClientName;
            lblClientNum.Text = GlobalVar.ClientNum;
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            ModifyUser modifyUser = new ModifyUser();
            modifyUser.ShowDialog();
        }
    }
}
