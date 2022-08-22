using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_management
{
    public partial class Form2 : Form
    {

        Button currentBtn;
        Form activeFrom;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            activeFrom = new Form();
            openChildForm(new Forms.FormStore(),btnStore);
        }

        void selectBtn(object btnSender)
        {
            
            if (btnSender != null)
            {
                if(currentBtn != (Button)btnSender)
                {
                    disBtn();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.White;
                }
            }            
        }

        void openChildForm(Form childForm,Object btnSender)
        {
            selectBtn(btnSender);
            if (activeFrom != null);
            {                
                activeFrom.Close();
            }
            selectBtn(btnSender);
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDeskTop.Controls.Add(childForm);
            this.panelDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void disBtn()
        {
            foreach(Control conBtn in panelMenu.Controls)
            {
                if (conBtn.GetType()==typeof(Button))
                {
                    conBtn.BackColor = Color.DarkGray;
                }
            }
        }
        
        private void btnStore_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormStore(), sender);
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormStock(), sender);
        }
        
        private void btnDrink_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormDrink(), sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormOrder(), sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelDeskTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.login.Close();
        }
    }
}
