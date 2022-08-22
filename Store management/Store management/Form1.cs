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
    public partial class Form1 : Form
    {

        SqlConnection con;
        model model;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkSql linkSql = new linkSql();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtAccount.Text != "" && txtPassword.Text != "")
            {
                model = new model();
                if(model.login(txtAccount.Text, txtPassword.Text))
                {
                    GlobalVar.login = this;                    
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("請輸入帳號或密碼");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccount.Clear();
            txtPassword.Clear();
        }

        private void btnNewStore_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
