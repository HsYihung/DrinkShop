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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            lblClient.Text = "姓名 : " +GlobalVar.ClientName;
            lblClientNum.Text = "電話 : "+GlobalVar.ClientNum;
            int orderNum = 1;
            foreach(Order myOrder in GlobalVar.OrderList)
            {
                string strItem = string.Format($"{orderNum}.{myOrder.shopName} {myOrder.drinkName} {myOrder.fdPrice}元 {myOrder.quantity}杯 {myOrder.orderPrice:C0}元");
                lboxDSList.Items.Add(strItem);                
                orderNum++;                
            }
            顯示總價();
        }
        private void btnShowList_Click(object sender, EventArgs e)
        {
            int orderNum = 1;
            string strItem = "";
            foreach (Order myOrder in GlobalVar.OrderList)
            {
                strItem += string.Format($"{orderNum}.{myOrder.shopName} {myOrder.drinkName} 甜度:{myOrder.sugar} 冰塊:{myOrder.ice} {myOrder.feedName}{myOrder.fdPrice}元 {myOrder.quantity}杯 {myOrder.orderPrice:C0}元\n");                
                orderNum++;
            }
            MessageBox.Show(strItem);
        }
        private void btnReClient_Click(object sender, EventArgs e)
        {
            GlobalVar.訂購人輸入.Show();
            this.Hide();
        }

        private void btnListOneClear_Click(object sender, EventArgs e)
        {
            int indexClear = -1;
            indexClear = lboxDSList.SelectedIndex;
            if (indexClear == -1)
            {
                MessageBox.Show("請選擇要刪除的訂單資料");
                return;
            }

            int reQuantity = GlobalVar.OrderList[indexClear].quantity;
            int rePrice = GlobalVar.OrderList[indexClear].fdPrice;
            GlobalVar.orderMath.reOrder(rePrice, reQuantity);
            GlobalVar.OrderList.RemoveAt(indexClear);
            lboxDSList.Items.RemoveAt(indexClear);
            顯示總價();
        }

        private void btnListAllClear_Click(object sender, EventArgs e)
        {
            GlobalVar.OrderList.Clear();
            GlobalVar.orderMath.clear();
            lboxDSList.Items.Clear();
            顯示總價();
        }

        private void btnNewList_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVar.訂購單.Show();
        }

        private void btnListtotxt_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(linksql.myDBConnectionString);
            con.Open();
            foreach (Order myOrder in GlobalVar.OrderList)
            {
                string strSQL = $"insert into [Order] (ShopID,UserID,DrinkID,FeedID,Quantity,ice,surgar) values({myOrder.shopID},{GlobalVar.UserID},{myOrder.drinkID},{myOrder.FeedID},{myOrder.quantity},'{myOrder.sugar}','{myOrder.ice}')";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                Console.WriteLine( cmd.ExecuteNonQuery());
            }
            con.Close();

            GlobalVar.OrderList.Clear();
            GlobalVar.orderMath.clear();
            lboxDSList.Items.Clear();
            顯示總價();
        }

        private void chkTex_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.orderMath.discountMath();
            顯示總價();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.訂購單.Close();
        }

        void 顯示總價()
        {
            lblTotal.Text = string.Format($"{GlobalVar.orderMath.totOrderPrice:C0}元");
        }
        public void showForm3()
        {
            lboxDSList.Items.Clear();
            lblClient.Text = "訂購人 : " + GlobalVar.ClientName;
            lblClientNum.Text = "訂購人電話 : " + GlobalVar.ClientNum;
            int orderNum = 1;
            foreach (Order myOrder in GlobalVar.OrderList)
            {
                string strItem = string.Format($"{orderNum}.{myOrder.drinkName} {myOrder.fdPrice}元 {myOrder.quantity}杯 共{myOrder.orderPrice:C0}元");
                lboxDSList.Items.Add(strItem);
                orderNum++;
            }
            GlobalVar.orderMath.discountMath();
            顯示總價();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
