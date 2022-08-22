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
    public partial class FormStock : Form
    {
        model model;
        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            model = new model();
            cboxOptions.Items.Add("查看飲品庫存");            
            cboxOptions.Items.Add("查看配料庫存");                       
            model.actionFrom(cboxOptions, listView1);
            cboxOptions.SelectedIndex = 0;
            model.readStock();
        }

        private void cboxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.readStock();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if(txtStock.Text != "")
            {
                int intNUM = 0;
                if (Int32.TryParse(txtStock.Text,out intNUM))
                {
                    model.addStock((Button)sender, intNUM);
                }
            }
        }

        private void btnReduceStock_Click(object sender, EventArgs e)
        {
            if (txtStock.Text != "")
            {
                int intNUM = 0;
                if (Int32.TryParse(txtStock.Text, out intNUM))
                {
                    model.addStock((Button)sender, intNUM);
                }
            }
        }
    }
}
