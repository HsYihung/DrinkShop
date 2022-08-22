
namespace Store_management.Forms
{
    partial class FormDrink
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeveModify = new System.Windows.Forms.Button();
            this.btnReModify = new System.Windows.Forms.Button();
            this.cboxOptions = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "選項";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(241, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(307, 352);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(40, 175);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 29);
            this.txtPrice.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(40, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "價格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "商品名稱";
            // 
            // btnSeveModify
            // 
            this.btnSeveModify.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSeveModify.Location = new System.Drawing.Point(145, 317);
            this.btnSeveModify.Name = "btnSeveModify";
            this.btnSeveModify.Size = new System.Drawing.Size(63, 23);
            this.btnSeveModify.TabIndex = 21;
            this.btnSeveModify.Text = "確認";
            this.btnSeveModify.UseVisualStyleBackColor = true;
            this.btnSeveModify.Click += new System.EventHandler(this.btnSeveModify_Click);
            // 
            // btnReModify
            // 
            this.btnReModify.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReModify.Location = new System.Drawing.Point(40, 317);
            this.btnReModify.Name = "btnReModify";
            this.btnReModify.Size = new System.Drawing.Size(63, 23);
            this.btnReModify.TabIndex = 20;
            this.btnReModify.Text = "復原";
            this.btnReModify.UseVisualStyleBackColor = true;
            this.btnReModify.Click += new System.EventHandler(this.btnReModify_Click);
            // 
            // cboxOptions
            // 
            this.cboxOptions.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxOptions.FormattingEnabled = true;
            this.cboxOptions.Location = new System.Drawing.Point(40, 33);
            this.cboxOptions.Name = "cboxOptions";
            this.cboxOptions.Size = new System.Drawing.Size(164, 29);
            this.cboxOptions.TabIndex = 24;
            this.cboxOptions.SelectedIndexChanged += new System.EventHandler(this.cboxOptions_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(40, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 29);
            this.txtName.TabIndex = 25;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDel.Location = new System.Drawing.Point(55, 274);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(128, 37);
            this.btnDel.TabIndex = 26;
            this.btnDel.Text = "下架所選商品";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // FormDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 352);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboxOptions);
            this.Controls.Add(this.btnSeveModify);
            this.Controls.Add(this.btnReModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormDrink";
            this.Text = "FormDrink";
            this.Load += new System.EventHandler(this.FormDrink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeveModify;
        private System.Windows.Forms.Button btnReModify;
        private System.Windows.Forms.ComboBox cboxOptions;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDel;
    }
}