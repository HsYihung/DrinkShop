
namespace drink_shop
{
    partial class Form3
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
            this.lblClient = new System.Windows.Forms.Label();
            this.lblClientNum = new System.Windows.Forms.Label();
            this.lboxDSList = new System.Windows.Forms.ListBox();
            this.btnReClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnListOneClear = new System.Windows.Forms.Button();
            this.btnNewList = new System.Windows.Forms.Button();
            this.btnListAllClear = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnListtotxt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂購清單";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClient.Location = new System.Drawing.Point(12, 45);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(50, 21);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "姓名 :";
            // 
            // lblClientNum
            // 
            this.lblClientNum.AutoSize = true;
            this.lblClientNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClientNum.Location = new System.Drawing.Point(12, 76);
            this.lblClientNum.Name = "lblClientNum";
            this.lblClientNum.Size = new System.Drawing.Size(50, 21);
            this.lblClientNum.TabIndex = 2;
            this.lblClientNum.Text = "電話 :";
            // 
            // lboxDSList
            // 
            this.lboxDSList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxDSList.FormattingEnabled = true;
            this.lboxDSList.ItemHeight = 21;
            this.lboxDSList.Location = new System.Drawing.Point(12, 110);
            this.lboxDSList.Name = "lboxDSList";
            this.lboxDSList.Size = new System.Drawing.Size(356, 403);
            this.lboxDSList.TabIndex = 3;
            // 
            // btnReClient
            // 
            this.btnReClient.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.btnReClient.Location = new System.Drawing.Point(228, 75);
            this.btnReClient.Name = "btnReClient";
            this.btnReClient.Size = new System.Drawing.Size(140, 27);
            this.btnReClient.TabIndex = 5;
            this.btnReClient.Text = "切換使用者";
            this.btnReClient.UseVisualStyleBackColor = true;
            this.btnReClient.Click += new System.EventHandler(this.btnReClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "總價 :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(288, 531);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 21);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "0元";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(324, 653);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(46, 23);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnListOneClear
            // 
            this.btnListOneClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListOneClear.Location = new System.Drawing.Point(103, 590);
            this.btnListOneClear.Name = "btnListOneClear";
            this.btnListOneClear.Size = new System.Drawing.Size(85, 50);
            this.btnListOneClear.TabIndex = 12;
            this.btnListOneClear.Text = "清除所選項目";
            this.btnListOneClear.UseVisualStyleBackColor = true;
            this.btnListOneClear.Click += new System.EventHandler(this.btnListOneClear_Click);
            // 
            // btnNewList
            // 
            this.btnNewList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewList.Location = new System.Drawing.Point(12, 590);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(85, 50);
            this.btnNewList.TabIndex = 13;
            this.btnNewList.Text = "新增訂單";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // btnListAllClear
            // 
            this.btnListAllClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListAllClear.Location = new System.Drawing.Point(194, 590);
            this.btnListAllClear.Name = "btnListAllClear";
            this.btnListAllClear.Size = new System.Drawing.Size(85, 50);
            this.btnListAllClear.TabIndex = 14;
            this.btnListAllClear.Text = "清除所有項目";
            this.btnListAllClear.UseVisualStyleBackColor = true;
            this.btnListAllClear.Click += new System.EventHandler(this.btnListAllClear_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(12, 519);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(114, 23);
            this.btnShowList.TabIndex = 16;
            this.btnShowList.Text = "訂單詳細資訊";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnListtotxt
            // 
            this.btnListtotxt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListtotxt.Location = new System.Drawing.Point(285, 590);
            this.btnListtotxt.Name = "btnListtotxt";
            this.btnListtotxt.Size = new System.Drawing.Size(85, 50);
            this.btnListtotxt.TabIndex = 17;
            this.btnListtotxt.Text = "送出";
            this.btnListtotxt.UseVisualStyleBackColor = true;
            this.btnListtotxt.Click += new System.EventHandler(this.btnListtotxt_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(12, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "查看訂單紀錄";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(380, 683);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnListtotxt);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnListAllClear);
            this.Controls.Add(this.btnNewList);
            this.Controls.Add(this.btnListOneClear);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReClient);
            this.Controls.Add(this.lboxDSList);
            this.Controls.Add(this.lblClientNum);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "訂購清單";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblClientNum;
        private System.Windows.Forms.ListBox lboxDSList;
        private System.Windows.Forms.Button btnReClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnListOneClear;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.Button btnListAllClear;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnListtotxt;
        private System.Windows.Forms.Button button2;
    }
}