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
    class model
    {
        SqlConnection con;
        ListView actionListView;
        ComboBox actionComboBox;
        public int actionIndex = -1;
        public model()
        {
            con = new SqlConnection(linkSql.myDBConnectionString);            
        }
        public bool login(string Account, string Password)
        {
            bool isLogin = false;            
            con.Open();
            string strSQL = "select Password,ShopID from shop where Account= @Account";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Account",Account);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                if(Password==(string)reader["Password"])
                {
                    isLogin = true;
                    GlobalVar.storeID = (int)reader["ShopID"];
                }
                else
                {
                    MessageBox.Show("密碼錯誤");
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("無此帳號");
            }
            con.Close();
            return isLogin;
        }
        public string readShop(TextBox txtName,TextBox txtPhone,TextBox txtAddress)
        {
            string strMessage = "登入成功";
            con.Open();
            string strSQL = $"select ShopName,ShopPhone,Address from shop where ShopID = {GlobalVar.storeID}";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                txtName.Text = (string)reader["ShopName"];
                txtPhone.Text = (string)reader["ShopPhone"];
                txtAddress.Text = (string)reader["Address"];
            }
            reader.Close();
            strSQL = $"select ShopID from [Order] where ShopID = {GlobalVar.storeID} and OrderConfirm = 0";
            cmd = new SqlCommand(strSQL, con);
            reader = cmd.ExecuteReader();
            int index = 0;
            while(reader.Read())
            {
                index ++;
            }
            strMessage += $"{Environment.NewLine}{Environment.NewLine}目前有 {index} 筆新訂單";
            con.Close();
            return strMessage;
        }

        public string reviseShop(TextBox txtName, TextBox txtPhone, TextBox txtAddress)
        {
            string strMessage = "";
            con.Open();
            string strSQL = $"update shop set ShopName = @name, ShopPhone = @phone , Address = @Add  where ShopID = {GlobalVar.storeID}";
            SqlCommand cmd = new SqlCommand(strSQL,con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
            cmd.Parameters.AddWithValue("@add", txtAddress.Text);
            int i = cmd.ExecuteNonQuery();
            if(i>=1)
            {
                strMessage = "修改成功";
            }
            else
            {
                strMessage = "修改失敗";
            }
            con.Close();
            return strMessage;
        }

        public void actionFrom(ComboBox cbox,ListView listview)
        {
            if(listview != null && cbox != null)
            {
                actionListView = listview;
                actionListView.Clear();
                actionComboBox = cbox;
            }
        }

        public void readStock()
        {
            actionListView.Clear();
            actionListView.SmallImageList = null;
            actionListView.View = View.Details;
            actionListView.Columns.Add("序號", 50);
            actionListView.Columns.Add("商品名稱", 160);
            actionListView.Columns.Add("庫存", 70);
            actionListView.FullRowSelect = true;
            int i = 0;
            if (actionComboBox.SelectedIndex == 0)
            {
                con.Open();
                string strSQL = $"select DrinkID , DrinkName , Stock from Drink where ShopID = {GlobalVar.storeID}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i++;
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                    item.Text = i.ToString();
                    item.SubItems.Add((string)reader["DrinkName"]);
                    item.SubItems.Add(reader["Stock"].ToString());
                    item.Tag = reader["DrinkID"];
                    actionListView.Items.Add(item);
                }
                reader.Close();
                con.Close();
            }
            else
            {
                con.Open();
                string strSQL = $"select FeedID , FeedName , Stock from Feed where ShopID = {GlobalVar.storeID}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i++;
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                    item.Text = i.ToString();
                    item.SubItems.Add((string)reader["FeedName"]);
                    item.SubItems.Add(reader["Stock"].ToString());
                    item.Tag = reader["FeedID"];
                    actionListView.Items.Add(item);
                }
                reader.Close();
                con.Close();
            }

            
        }

        public void addStock (Button curBtn,int addNum)
        {
            if (curBtn != null)
            {
                if(curBtn.Name == "btnAddStock")
                {
                    con.Open();
                    string strTable = "";
                    string strColumn = "";
                    if (actionComboBox.SelectedIndex == 0)
                    {
                        strTable = "Drink";
                        strColumn = "DrinkID";
                    }
                    else if(actionComboBox.SelectedIndex==1)
                    {
                        strTable = "Feed";
                        strColumn = "FeedID";
                    }
                    else
                    {
                        return;
                    }
                    for (int i=0 ;i < actionListView.SelectedItems.Count;i++)
                    {                        
                        int intAdd = 0;                        
                        intAdd += addNum;                        
                        string strSQL = $"select Stock from {strTable} where {strColumn} = {actionListView.SelectedItems[i].Tag}";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if(reader.Read())
                        {
                            intAdd += (int)reader["stock"];
                        }
                        reader.Close();
                        strSQL = $"update {strTable} set Stock = @addStock where {strColumn} = {actionListView.SelectedItems[i].Tag}";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@addStock", intAdd);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine(intAdd);
                    }
                    con.Close();
                    readStock();
                }
                else if(curBtn.Name == "btnReduceStock")
                {
                    con.Open();
                    string strTable = "";
                    string strColumn = "";
                    if (actionComboBox.SelectedIndex == 0)
                    {
                        strTable = "Drink";
                        strColumn = "DrinkID";
                    }
                    else if (actionComboBox.SelectedIndex == 1)
                    {
                        strTable = "Feed";
                        strColumn = "FeedID";
                    }
                    else
                    {
                        return;
                    }
                    for (int i = 0; i < actionListView.SelectedItems.Count; i++)
                    {
                        int intAdd = 0;                        
                        string strSQL = $"select Stock from {strTable} where {strColumn} = {actionListView.SelectedItems[i].Tag}";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            intAdd += (int)reader["stock"];
                        }                        
                        reader.Close();
                        if (intAdd < addNum)
                        {
                            MessageBox.Show("數量輸入錯誤");
                            con.Close();
                            return;
                        }
                        intAdd -= addNum;
                        strSQL = $"update {strTable} set Stock = @addStock where {strColumn} = {actionListView.SelectedItems[i].Tag}";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@addStock", intAdd);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine(intAdd);
                    }
                    con.Close();
                    readStock();
                }

            }
        }

        public void readDrink()
        {
            actionListView.Clear();
            actionListView.SmallImageList = null;
            actionListView.View = View.Details;
            actionListView.Columns.Add("序號", 50);
            actionListView.Columns.Add("商品名稱", 160);
            actionListView.Columns.Add("價格", 70);
            actionListView.FullRowSelect = true;
            int i = 0;
            if(actionComboBox.SelectedIndex == 0|| actionComboBox.SelectedIndex == 2 || actionComboBox.SelectedIndex == 4)
            {
                con.Open();
                string strSQL = $"select DrinkID, DrinkName , Price From Drink where ShopID = {GlobalVar.storeID}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    i++;
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                    item.Text = i.ToString();
                    item.SubItems.Add((string)reader["DrinkName"]);
                    item.SubItems.Add(reader["Price"].ToString());
                    item.Tag = reader["DrinkID"];
                    actionListView.Items.Add(item);
                }
                reader.Close();
                con.Close();

            }
            else if(actionComboBox.SelectedIndex == 1|| actionComboBox.SelectedIndex == 3 || actionComboBox.SelectedIndex == 5)
            {
                con.Open();
                string strSQL = $"select FeedID, FeedName , Price From Feed where ShopID = {GlobalVar.storeID}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i++;
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                    item.Text = i.ToString();
                    item.SubItems.Add((string)reader["FeedName"]);
                    item.SubItems.Add(reader["Price"].ToString());
                    item.Tag = reader["FeedID"];
                    actionListView.Items.Add(item);
                }
                reader.Close();
                con.Close();
            }         
        }
        public void selectDrink(TextBox txtName,TextBox txtPrice)
        {

            actionIndex = (int)actionListView.SelectedItems[0].Tag;
            if (actionComboBox.SelectedIndex == 0|| actionComboBox.SelectedIndex == 4)
            {
                con.Open();
                string strSQL = $"select DrinkName , Price From Drink where DrinkID = {actionListView.SelectedItems[0].Tag}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    txtName.Text = (string)reader["DrinkName"];
                    txtPrice.Text = reader["Price"].ToString();
                }
                reader.Close();
                con.Close();
            }
            else if (actionComboBox.SelectedIndex == 1 || actionComboBox.SelectedIndex == 5)
            {
                con.Open();
                string strSQL = $"select FeedName , Price From Feed where FeedID = {actionListView.SelectedItems[0].Tag}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = (string)reader["FeedName"];
                    txtPrice.Text = reader["Price"].ToString();
                }
                reader.Close();
                con.Close();
            }
            else
            {

            }
        }
        

        public void seveModify(TextBox txtName , TextBox txtPrice)
        {
            if (actionComboBox.SelectedIndex == 0)
            {
                if (actionIndex == -1)
                {
                    return;
                }
                con.Open();                
                string strSQL = $"update Drink set DrinkName = @newName , Price = @newPrice Where DrinkID = {actionIndex}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("newName",txtName.Text);
                cmd.Parameters.AddWithValue("newPrice",txtPrice.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                readDrink();
                actionIndex = -1;
            }
            else if (actionComboBox.SelectedIndex == 1)
            {
                if (actionIndex == -1)
                {
                    return;
                }
                con.Open();
                string strSQL = $"update Feed set FeedName = @newName , Price = @newPrice Where FeedID = {actionIndex}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("newName", txtName.Text);
                cmd.Parameters.AddWithValue("newPrice", txtPrice.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                readDrink();
                actionIndex = -1;
            }
            else if (actionComboBox.SelectedIndex == 2)
            {
                con.Open();
                string strSQL = $"select DrinkName From Drink where ShopID = {GlobalVar.storeID}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if ((string)reader["DrinkName"] !=txtName.Text)
                    {
                        reader.Close();
                        strSQL = $"insert into Drink values ({GlobalVar.storeID},@newName,@newPrice,0)";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@newName",txtName.Text);
                        cmd.Parameters.AddWithValue("@newPrice",txtPrice.Text);
                        cmd.ExecuteNonQuery();
                        txtName.Clear();
                        txtPrice.Clear();
                        con.Close();
                        readDrink();
                    }
                    else
                    {
                        reader.Close();
                        con.Close();
                        MessageBox.Show("已有此飲品");                        
                    }
                }
                else
                {
                    reader.Close();
                    strSQL = $"insert into Drink values ({GlobalVar.storeID},@newName,@newPrice,0)";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@newName", txtName.Text);
                    cmd.Parameters.AddWithValue("@newPrice", txtPrice.Text);
                    cmd.ExecuteNonQuery();
                    txtName.Clear();
                    txtPrice.Clear();
                    con.Close();
                    readDrink();
                    
                }
                
            }
            else
            {
                con.Open();
                string strSQL = $"select FeedName From Feed where ShopID = {GlobalVar.storeID}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if ((string)reader["FeedName"] != txtName.Text)
                    {
                        reader.Close();
                        strSQL = $"insert into Feed values ({GlobalVar.storeID},@newName,@newPrice,0)";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@newName", txtName.Text);
                        cmd.Parameters.AddWithValue("@newPrice", txtPrice.Text);
                        cmd.ExecuteNonQuery();
                        txtName.Clear();
                        txtPrice.Clear();
                        con.Close();
                        readDrink();
                    }
                    else
                    {
                        reader.Close();
                        con.Close();
                        MessageBox.Show("已有此配料");                        
                    }
                }
                else
                {
                    reader.Close();
                    strSQL = $"insert into Feed values ({GlobalVar.storeID},@newName,@newPrice,0)";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@newName", txtName.Text);
                    cmd.Parameters.AddWithValue("@newPrice", txtPrice.Text);
                    cmd.ExecuteNonQuery();
                    txtName.Clear();
                    txtPrice.Clear();
                    con.Close();
                    readDrink();
                }                
            }
        }

        public void delDrink(TextBox txtName, TextBox txtPrice)
        {
            if (actionIndex != -1)
            {
                if (actionComboBox.SelectedIndex == 4)
                {
                    con.Open();
                    string strSQL = $"delete Drink where drinkID = {actionListView.SelectedItems[0].Tag}";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    readDrink();
                    actionIndex = -1;
                }
                else
                {
                    con.Open();
                    string strSQL = $"delete Feed where FeedID = {actionListView.SelectedItems[0].Tag}";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    readDrink();
                    actionIndex = -1;
                }
            }
        }
        
        public void readOrder()
        {
            actionListView.Clear();
            actionListView.SmallImageList = null;
            actionListView.View = View.Details;
            actionListView.Columns.Add("", 35);
            actionListView.Columns.Add("訂購人",70);            
            actionListView.Columns.Add("飲料",80);
            actionListView.Columns.Add("加料", 50);
            actionListView.Columns.Add("甜度", 50);
            actionListView.Columns.Add("冰塊", 50);
            actionListView.Columns.Add("杯數", 50);
            actionListView.Columns.Add("總價", 80);
            actionListView.Columns.Add("訂購時間", 200);
            actionListView.FullRowSelect = true;
            int i = 0;
            if(actionComboBox.SelectedIndex == 0)
            {
                con.Open();
                string strSQL = $"select ID,(select Name from UserInfo where UserID = od.UserID) as Name,(select DrinkName from Drink where DrinkID = od.DrinkID)as DrinkName,isnull((select FeedName from Feed where FeedID = od.FeedID),'無') as FeedName,ice,surgar,Quantity,((select Price from Drink where DrinkID = od.DrinkID)+isnull((select Price from Feed where FeedID = od.FeedID),0)*Quantity) as totalPrice,OrderDate from [Order] as od where ShopID = {GlobalVar.storeID} and OrderConfirm =0";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    i++;
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 11, FontStyle.Regular);
                    item.Text = i.ToString();
                    item.SubItems.Add((string)reader["Name"]);
                    item.SubItems.Add((string)reader["DrinkName"]);
                    item.SubItems.Add((string)reader["FeedName"]);
                    item.SubItems.Add((string)reader["surgar"]);
                    item.SubItems.Add((string)reader["ice"]);
                    item.SubItems.Add(reader["Quantity"].ToString());
                    item.SubItems.Add(reader["totalPrice"].ToString());
                    item.SubItems.Add(string.Format($"{reader["OrderDate"]:yy/MM/dd H:mm:ss}"));
                    item.Tag = (int)reader["ID"];
                    actionListView.Items.Add(item);
                }
                reader.Close();
                con.Close();
            }
            else
            {
                con.Open();
                string strSQL = $"select ID,(select Name from UserInfo where UserID = od.UserID) as Name,(select DrinkName from Drink where DrinkID = od.DrinkID)as DrinkName,isnull((select FeedName from Feed where FeedID = od.FeedID),'無') as FeedName,ice,surgar,Quantity,((select Price from Drink where DrinkID = od.DrinkID)+isnull((select Price from Feed where FeedID = od.FeedID),0)*Quantity) as totalPrice,OrderDate from [Order] as od where ShopID = {GlobalVar.storeID}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i++;
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 11, FontStyle.Regular);
                    item.Text = i.ToString();
                    item.SubItems.Add((string)reader["Name"]);
                    item.SubItems.Add((string)reader["DrinkName"]);
                    item.SubItems.Add((string)reader["FeedName"]);
                    item.SubItems.Add((string)reader["surgar"]);
                    item.SubItems.Add((string)reader["ice"]);
                    item.SubItems.Add(reader["Quantity"].ToString());
                    item.SubItems.Add(reader["totalPrice"].ToString());
                    item.SubItems.Add(string.Format($"{reader["OrderDate"]:yy/MM/dd H:mm:ss}"));
                    item.Tag = (int)reader["ID"];
                    actionListView.Items.Add(item);
                }
                reader.Close();
                con.Close();
            }
        }
        public void acceptOrder()
        {           
            con.Open();
            for(int i = 0; i<actionListView.SelectedItems.Count;i++)
            {
                string strSQL = $"select DrinkID,FeedID,Quantity from [Order] where ID = {actionListView.SelectedItems[i].Tag}";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                int DrinkID = 0;
                int FeedID = 0;
                int Quantity = 0;
                int DrinkStock = 0;
                int FeedStock = 0;
                if (reader.Read())
                {
                    DrinkID = (int)reader["DrinkID"];
                    FeedID = (int)reader["FeedID"];
                    Quantity = (int)reader["Quantity"];
                }
                reader.Close();
                strSQL = $"declare @DrinkStock int; declare @FeedStock int;select @DrinkStock = Stock from Drink where DrinkID= {DrinkID};select @FeedStock = Stock from Feed where FeedID= {FeedID}; select @DrinkStock as DrinkStock , isnull(@FeedStock,0) as FeedStock;";
                cmd = new SqlCommand(strSQL, con);
                reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    if(Quantity>(int)reader["DrinkStock"])
                    {                        
                        reader.Close();
                        strSQL = $"update [Order] set OrderConfirm = 1, OrderMessage = '飲料庫存不足' where ID = {actionListView.SelectedItems[i].Tag}";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.ExecuteNonQuery();
                        break;
                    }
                    if (Quantity > (int)reader["FeedStock"])
                    {                        
                        reader.Close();
                        strSQL = $"update [Order] set OrderConfirm = 1 , OrderMessage = '配料庫存不足' where ID = {actionListView.SelectedItems[i].Tag}";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.ExecuteNonQuery();
                        break;
                    }
                    DrinkStock = (int)reader["DrinkStock"];
                    FeedStock = (int)reader["FeedStock"];
                }
                reader.Close();
                strSQL = $"update [Order] set OrderConfirm = 1 where ID = {actionListView.SelectedItems[i].Tag}";
                cmd = new SqlCommand(strSQL, con);
                cmd.ExecuteNonQuery();
                strSQL = $"update Drink set Stock = {DrinkStock - Quantity} where DrinkID = {DrinkID}";
                cmd = new SqlCommand(strSQL, con);
                cmd.ExecuteNonQuery();
                strSQL = $"update Feed set Stock = {FeedStock - Quantity} where FeedID = {FeedID}";
                cmd = new SqlCommand(strSQL, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            readOrder();
        }
        public void CancelOrder()
        {
            con.Open();
            for (int i = 0; i < actionListView.SelectedItems.Count; i++)
            {
                string strSQL = $"update [Order] set OrderConfirm = 1,OrderMessage = '此訂單被店家取消' where ID = {actionListView.SelectedItems[i].Tag}";                
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            readOrder();
        }
    }
}
