
namespace drink_shop
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboxDSChoose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxDrink = new System.Windows.Forms.ListBox();
            this.lboxFeed = new System.Windows.Forms.ListBox();
            this.cboxSugar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxIce = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblClientNum = new System.Windows.Forms.Label();
            this.btnFeedClear = new System.Windows.Forms.Button();
            this.btnJoinOrder = new System.Windows.Forms.Button();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲店訂購單";
            // 
            // cboxDSChoose
            // 
            this.cboxDSChoose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxDSChoose.FormattingEnabled = true;
            this.cboxDSChoose.Location = new System.Drawing.Point(30, 92);
            this.cboxDSChoose.Name = "cboxDSChoose";
            this.cboxDSChoose.Size = new System.Drawing.Size(153, 28);
            this.cboxDSChoose.TabIndex = 1;
            this.cboxDSChoose.SelectedIndexChanged += new System.EventHandler(this.cboxDSChoose_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "冷飲店選擇";
            // 
            // lboxDrink
            // 
            this.lboxDrink.Enabled = false;
            this.lboxDrink.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxDrink.FormattingEnabled = true;
            this.lboxDrink.ItemHeight = 21;
            this.lboxDrink.Location = new System.Drawing.Point(21, 129);
            this.lboxDrink.Name = "lboxDrink";
            this.lboxDrink.Size = new System.Drawing.Size(368, 361);
            this.lboxDrink.TabIndex = 3;
            this.lboxDrink.SelectedIndexChanged += new System.EventHandler(this.lboxDrink_SelectedIndexChanged);
            // 
            // lboxFeed
            // 
            this.lboxFeed.Enabled = false;
            this.lboxFeed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxFeed.FormattingEnabled = true;
            this.lboxFeed.ItemHeight = 21;
            this.lboxFeed.Location = new System.Drawing.Point(436, 322);
            this.lboxFeed.Name = "lboxFeed";
            this.lboxFeed.Size = new System.Drawing.Size(153, 109);
            this.lboxFeed.TabIndex = 4;
            this.lboxFeed.SelectedIndexChanged += new System.EventHandler(this.lboxFeed_SelectedIndexChanged);
            // 
            // cboxSugar
            // 
            this.cboxSugar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxSugar.FormattingEnabled = true;
            this.cboxSugar.Location = new System.Drawing.Point(436, 163);
            this.cboxSugar.Name = "cboxSugar";
            this.cboxSugar.Size = new System.Drawing.Size(153, 28);
            this.cboxSugar.TabIndex = 5;
            this.cboxSugar.SelectedIndexChanged += new System.EventHandler(this.cboxSugar_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(442, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "甜度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(442, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "冰塊";
            // 
            // cboxIce
            // 
            this.cboxIce.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxIce.FormattingEnabled = true;
            this.cboxIce.Location = new System.Drawing.Point(436, 250);
            this.cboxIce.Name = "cboxIce";
            this.cboxIce.Size = new System.Drawing.Size(153, 28);
            this.cboxIce.TabIndex = 7;
            this.cboxIce.SelectedIndexChanged += new System.EventHandler(this.cboxIce_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(442, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "配料";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(412, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "姓名  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(412, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "電話  :";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClient.Location = new System.Drawing.Point(472, 54);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(20, 21);
            this.lblClient.TabIndex = 13;
            this.lblClient.Text = "2";
            // 
            // lblClientNum
            // 
            this.lblClientNum.AutoSize = true;
            this.lblClientNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClientNum.Location = new System.Drawing.Point(472, 91);
            this.lblClientNum.Name = "lblClientNum";
            this.lblClientNum.Size = new System.Drawing.Size(20, 21);
            this.lblClientNum.TabIndex = 14;
            this.lblClientNum.Text = "1";
            // 
            // btnFeedClear
            // 
            this.btnFeedClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFeedClear.Location = new System.Drawing.Point(436, 452);
            this.btnFeedClear.Name = "btnFeedClear";
            this.btnFeedClear.Size = new System.Drawing.Size(153, 38);
            this.btnFeedClear.TabIndex = 15;
            this.btnFeedClear.Text = "配料清除";
            this.btnFeedClear.UseVisualStyleBackColor = true;
            this.btnFeedClear.Click += new System.EventHandler(this.btnFeedClear_Click);
            // 
            // btnJoinOrder
            // 
            this.btnJoinOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnJoinOrder.Location = new System.Drawing.Point(21, 600);
            this.btnJoinOrder.Name = "btnJoinOrder";
            this.btnJoinOrder.Size = new System.Drawing.Size(130, 38);
            this.btnJoinOrder.TabIndex = 16;
            this.btnJoinOrder.Text = "加入訂購單";
            this.btnJoinOrder.UseVisualStyleBackColor = true;
            this.btnJoinOrder.Click += new System.EventHandler(this.btnJoinOrder_Click);
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckOrder.Location = new System.Drawing.Point(157, 600);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(130, 38);
            this.btnCheckOrder.TabIndex = 17;
            this.btnCheckOrder.Text = "查看訂購單";
            this.btnCheckOrder.UseVisualStyleBackColor = true;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClient.Location = new System.Drawing.Point(293, 600);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(130, 38);
            this.btnClient.TabIndex = 18;
            this.btnClient.Text = "切換使用者";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuit.Location = new System.Drawing.Point(551, 643);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(61, 30);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuantity.Location = new System.Drawing.Point(21, 549);
            this.txtQuantity.MaxLength = 2;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(61, 29);
            this.txtQuantity.TabIndex = 20;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(88, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "杯";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(148, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "單價 :";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(196, 549);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(77, 29);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(279, 553);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "元";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(487, 552);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 21);
            this.label14.TabIndex = 27;
            this.label14.Text = "元";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal.Location = new System.Drawing.Point(383, 549);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 29);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(335, 553);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 21);
            this.label16.TabIndex = 25;
            this.label16.Text = "總價 :";
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModifyUser.Location = new System.Drawing.Point(429, 599);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(130, 38);
            this.btnModifyUser.TabIndex = 28;
            this.btnModifyUser.Text = "修改帳號資訊";
            this.btnModifyUser.UseVisualStyleBackColor = true;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(614, 675);
            this.Controls.Add(this.btnModifyUser);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnCheckOrder);
            this.Controls.Add(this.btnJoinOrder);
            this.Controls.Add(this.btnFeedClear);
            this.Controls.Add(this.lblClientNum);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxIce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxSugar);
            this.Controls.Add(this.lboxFeed);
            this.Controls.Add(this.lboxDrink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxDSChoose);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "飲料店訂購單";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxDSChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxDrink;
        private System.Windows.Forms.ListBox lboxFeed;
        private System.Windows.Forms.ComboBox cboxSugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxIce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblClientNum;
        private System.Windows.Forms.Button btnFeedClear;
        private System.Windows.Forms.Button btnJoinOrder;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnModifyUser;
    }
}