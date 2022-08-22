using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_management.Forms
{
    public partial class FormStore : Form
    {
        model model;
        //string strMessage = $"{Environment.NewLine}1{Environment.NewLine}2{Environment.NewLine}3";textbox換行
        string strMessage = "";
        public FormStore()
        {
            InitializeComponent();
        }

        private void FormStore_Load(object sender, EventArgs e)
        {
            model = new model();
            txtMessage.Text =  model.readShop(txtName,txtPhone,txtAddress);
            
        }

        private void btnReModify_Click(object sender, EventArgs e)
        {
            model.readShop(txtName, txtPhone, txtAddress);
            txtMessage.Text = "復原成功";
        }

        private void btnRePassWord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改密碼");
        }

        private void btnSeveModify_Click(object sender, EventArgs e)
        {
            txtMessage.Text = model.reviseShop(txtName, txtPhone, txtAddress);
        }
    }
}
