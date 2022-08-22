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
    public partial class ModifyUser : Form
    {
        SqlConnection con;
        public ModifyUser()
        {
            InitializeComponent();
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(linksql.myDBConnectionString);
            con.Open();
            string strSQL = $"select * from UserInfo where UserID = '{GlobalVar.UserID}'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtAccount.Text = (string)reader["Account"];
                txtPassWord.Text = (string)reader["Password"];
                txtName.Text = (string)reader["Name"];
                txtPhone.Text = (string)reader["PhoneNumber"];
            }
            else
            {

            }
            con.Close();
        }

        private void btn退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn確認_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text != "" && txtName.Text != "" && txtPassWord.Text != "" && txtPassWordConfirn.Text != "" && txtPhone.Text != "")
            {
                if (txtPassWord.Text == txtPassWordConfirn.Text)
                {
                    con.Open();
                    string strSQL = "select UserID from UserInfo where PhoneNumber = @phone";
                    SqlCommand cmd = new SqlCommand(strSQL,con);
                    cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
                    SqlDataReader reader = cmd.ExecuteReader();                                        
                    if(!(reader.Read()) || (int)reader["UserID"]==GlobalVar.UserID)
                    {
                        reader.Close();
                        strSQL = $"update UserInfo set Password = @pass , Name = @name , PhoneNumber = @phone where UserID = '{GlobalVar.UserID}'";
                        cmd = new SqlCommand(strSQL , con);
                        cmd.Parameters.AddWithValue("@pass",txtPassWord.Text);
                        cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
                        cmd.Parameters.AddWithValue("@name",txtName.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改成功");
                        this.Close();
                    }
                    else
                    {
                        reader.Close();
                        txtPhone.Clear();
                        MessageBox.Show("電話號碼重複,請重新輸入");
                    }
                    con.Close();
                }
                else
                {
                    txtPassWordConfirn.Clear();
                    MessageBox.Show("密碼輸入不一致請重新輸入");
                }
            }
            else if (txtAccount.Text == "")
            {
                MessageBox.Show("請輸入帳號");
            }
            else if (txtPassWord.Text == "")
            {
                MessageBox.Show("請輸入密碼");
            }
            else if (txtPassWordConfirn.Text == "")
            {
                MessageBox.Show("請輸入密碼確認");
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("請輸入姓名");
            }
            else
            {
                MessageBox.Show("請輸入電話");
            }
        }
    }
}
