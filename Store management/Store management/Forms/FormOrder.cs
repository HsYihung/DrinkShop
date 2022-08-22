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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }
        model model;
        private void FormOrder_Load(object sender, EventArgs e)
        {
            model = new model();
            cboxOptions.Items.Add("查看新訂單");
            cboxOptions.Items.Add("查看所有訂單");
            model.actionFrom(cboxOptions, listView1);
            cboxOptions.SelectedIndex = 0;
            model.readOrder();
            
        }

        private void cboxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxOptions.SelectedIndex==0)
            {
                btnAccept.Enabled = true;
                btnCancel.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
                btnCancel.Enabled = false;
            }
            model.readOrder();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            model.acceptOrder();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            model.CancelOrder();
        }
    }
}
