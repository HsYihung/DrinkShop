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
    public partial class Form1 : Form
    {
        linksql link;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            link = new linksql();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {            
            if(txtClient.Text != "" && txtClientNum.Text!="")
            {
                SqlConnection con = new SqlConnection(linksql.myDBConnectionString); ;
                con.Open();
                string strSQL = "select * from UserInfo Where Account = @account";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@account", txtClient.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    if ((string)reader["Password"] == txtClientNum.Text)
                    {
                        GlobalVar.ClientName = (string)reader["Name"];
                        GlobalVar.ClientNum = (string)reader["PhoneNumber"];
                        GlobalVar.UserID = (int)reader["UserID"];

                        if (GlobalVar.訂購單 == null)
                        {
                            Form2 訂購單 = new Form2();
                            GlobalVar.訂購單 = 訂購單;
                            GlobalVar.訂購人輸入 = this;
                        }
                        else
                        {
                            GlobalVar.訂購單.Form2show();
                        }
                        GlobalVar.訂購單.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密碼錯誤,請重新輸入");
                        txtClientNum.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("無此帳號,請重新輸入");
                    txtClient.Clear();
                    txtClientNum.Clear();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼未輸入");
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClient.Clear();
            txtClientNum.Clear();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newUser newUser = new newUser();
            newUser.ShowDialog();
        }
    }
}
