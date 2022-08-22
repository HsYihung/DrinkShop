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
    public partial class newUser : Form
    {
        public newUser()
        {
            InitializeComponent();
        }

        private void newUser_Load(object sender, EventArgs e)
        {

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
                    SqlConnection con = new SqlConnection(linksql.myDBConnectionString);
                    con.Open();
                    string strSQL = "select Account,PhoneNumber from UserInfo where Account = @acc or PhoneNumber = @phone";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@acc",txtAccount.Text);
                    cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(!(reader.Read()))
                    {
                        reader.Close();
                        strSQL = "insert UserInfo (Account,Password,Name,PhoneNumber) values (@acc,@pass,@name,@phone)";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@acc",txtAccount.Text);
                        cmd.Parameters.AddWithValue("@pass",txtPassWord.Text);
                        cmd.Parameters.AddWithValue("@name",txtName.Text);
                        cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
                        int i = cmd.ExecuteNonQuery();
                        MessageBox.Show("新增使用者成功");
                        this.Close();
                    }
                    else
                    {
                        if((string)reader["Account"]==txtAccount.Text)
                        {
                            MessageBox.Show("帳號已存在,請重新輸入");
                            txtAccount.Clear();
                        }
                        else
                        {
                            MessageBox.Show("電話號碼重複,請重新輸入");
                            txtPhone.Clear();
                        }
                        reader.Close();
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
